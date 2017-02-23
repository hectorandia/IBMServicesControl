using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.ServiceProcess;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using System.Management;
using Microsoft.Win32;
using System.Threading.Tasks;

namespace ServiceQuery
{
    public class QueryServices : Query
    {
        private ImportInfo info;
        private string selectedServer;
        private string place1, place2;
        private DataTable csvServer;
        private DataTable csvService;
        private ManagementObject manager;
        private ManagementScope conection;


        public QueryServices()
        {
            info = new ImportInfo();
            place1 = info.Place1;
            place2 = info.Place2;
        }

        #region Set ComboBox
        /*
         * Metodo encargado de proporcionar informacion para
         * los combobox de la clase WindowMain.
         * Recibe desde la clase WindowMain un parametro de tipo
         * string con la informacion del elemento seleccionado.
         * 
         * @selectedItem = parametro selecionado en el comboBox de la clase
         * windowMain
         * */
        public void SetComboBoxServer(string selectedServer)
        {
            this.selectedServer = selectedServer;
            //
            //se evalua si el parametro coindice con el tipo de servidor 1
            if (selectedServer == info.ServerTyp1) 
            {
                SetComboServer(info.PathServers1);
                SetComboService(info.PathServices1);
            }
            else if (selectedServer == info.ServerTyp2)
            {
                SetComboServer(info.PathServers2);
                SetComboService(info.PathServices2);
            }
            //
            //si se selecciona All, la primera tabla sera agregada como parametro a la segunda tabla
            else
            {
                DataTable scv2 = info.GetDataTableFromScV(info.PathServers1);
                DataTable csvServ2 = info.GetDataTableFromScV(info.PathServices1);
                SetComboServer(info.PathServers2);
                SetComboService(info.PathServices2);
                csvServer.Merge(scv2);
                csvService.Merge(csvServ2);
            } 
            this.NotifyObs();
        }

        public void SetComboServer(string path)
        {
            //
            //se asigna la ubicacion del archivo csv con la 
            //informacion de los servidores de tipo 1
            //
            string csv_file = path;
            //
            //se invoca el metodo GetDataTableFromSvc entregandole 
            //como parametro la ubicacion del archivo csv con la
            //informacion de los servidores de tipo 1
            //
            csvServer = info.GetDataTableFromScV(csv_file);
        }


        public void SetComboService(string path)
        {
            string csv_file = path;
            csvService = info.GetDataTableFromScV(csv_file);     
        }

        #endregion Set ComboBox

        #region Geters
        //Metodos set y get de la variable csvData
        public DataTable CsvServer
        {
            get
            {
                return csvServer;
            }
            set
            {
                this.csvServer = value;                
            }
        }

        public DataTable CsvService
        {
            get
            {
                return csvService;
            }
            set
            {
                this.csvService = value;               
            }
        }

        public string Place1
        { 
            get
            {
                return place1;
            }
        }
        
        public string Place2
        {
            get
            {
                return place2;
            }
        }

        public string ServerTyp1()
        { 
            return info.ServerTyp1;
        }

        public string ServerTyp2()
        {
            return info.ServerTyp2;
        }

        #endregion Geters



        public String PingToServer(string server)
        {
            Ping ping = new Ping();
            int timeout = 20;
            try
            {
                if (ping.Send(server, timeout).Status == IPStatus.Success)
                {
                    return "The Server " + server + " Responded Successfully ";
                }
                else
                {
                    return "Server " + server + " Not Responding";
                }
            }
            catch(Exception ex)
            {
                return "Server " + server + " Not Found, " + ex.Message;
            }
        }

        /**
         * 
         * */
        public ServiceController GetServiceQuery(string serviceName, string serverName)
        {
            ServiceController scServices;
            try
            {
                scServices = new ServiceController(serviceName, serverName);
                return scServices;
            }
            catch(NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            catch(InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }


        public string StartModeService(string serverName, string serviceName)
        {
            string mode = "";
            try
            {
                conection = ConectToServer(serverName);

                SelectQuery wmiQuery = new SelectQuery("SELECT * FROM Win32_Service WHERE Name='" + serviceName + "'");
                var searcher = new ManagementObjectSearcher(conection, wmiQuery);
                var results = searcher.Get();

                foreach (ManagementObject service in results)
                {
                    mode = service["StartMode"].ToString();
                }
            }
            catch(Exception ex)
            {
                mode = " ";
            }
            
            return mode;
        }



        public void StopService(string nameService, string nameServer)
        {
            ServiceController sc = new ServiceController(nameService, nameServer);

            try
            {
                //determina el tiempo de espera para status
                TimeSpan timeout = TimeSpan.FromMilliseconds(timeoutMilliseconds);

                if (sc != null && sc.Status == ServiceControllerStatus.Running)
                {
                    sc.Stop();
                }
                sc.WaitForStatus(ServiceControllerStatus.Stopped, timeout);
                sc.Close();
            }
            catch(Exception ex)
            {
                sc.Close();
            }
        }


        public void StartService(string nameService, string nameServer)
        {
            ServiceController sc = new ServiceController(nameService, nameServer);
            
            try
            {
                TimeSpan timeout = TimeSpan.FromMilliseconds(timeoutMilliseconds);

                if (sc != null && sc.Status == ServiceControllerStatus.Stopped)
                {
                    sc.Start();
                }
                else { }
                sc.WaitForStatus(ServiceControllerStatus.Running, timeout);
                sc.Close();
            }
            catch (Exception ex)
            {
                sc.Close();
            }
        }


        public void RestartService(string nameService, string nameServer)
        {
            ServiceController sc = new ServiceController(nameService, nameServer);

            try
            {
                TimeSpan timeout = TimeSpan.FromMilliseconds(timeoutMilliseconds);

                if (sc != null && sc.Status == ServiceControllerStatus.Running)
                {
                    sc.Stop();
                    sc.WaitForStatus(ServiceControllerStatus.Stopped, timeout);
                    sc.Start();
                    sc.WaitForStatus(ServiceControllerStatus.Running, timeout);
                }
                else if (sc != null && sc.Status == ServiceControllerStatus.Stopped)
                { }

                sc.Close();
            }
            catch (Exception ex)
            {
                sc.Close();
            }
        }

        /**
         * Recive un valor de tipo int desde los
         * botones de la clase WindowMain y
         * decide que tarea va a realizar.
         * */
        public void DetectingTask(string nameService, string nameServer, int task)
        {
            int value = task;
            switch (value)
            {
                case 0:
                    StartService(nameService, nameServer);
                    break;
                case 1:
                    StopService(nameService, nameServer);
                    break;
                case 2:
                    RestartService(nameService, nameServer);
                    break;
            }
        }

        /**
         * metodo utilizado para cambiar el Start-Mode de los servicios
         * de windows
         * @param task : tarea a realizar(Enable, Disabled)
         * */
        public void HandlingService(string nameService, string nameServer, string task)
        {
            
                conection = ConectToServer(nameServer);

                SelectQuery wmiQuery = new SelectQuery("SELECT * FROM Win32_Service WHERE Name='" + nameService + "'");
                var searcher = new ManagementObjectSearcher(conection, wmiQuery);
                var results = searcher.Get();

                foreach (ManagementObject mo in results)
                {
                    ManagementBaseObject inParams = mo.GetMethodParameters("ChangeStartMode");
                    inParams["startmode"] = task;
                    ManagementBaseObject outParams = mo.InvokeMethod("ChangeStartMode", inParams, null);
                    task = mo.Properties["StartMode"].Value.ToString().Trim();
                }
           
        }

 

              
    }
}
