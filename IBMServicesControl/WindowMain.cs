using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ServiceQuery;
using System.ServiceProcess;
using System.Management;
using MetroFramework;





namespace IBMServicesControl
{
    public partial class WindowMain : MetroFramework.Forms.MetroForm, IMainObserver
    {
        private QueryServices query; 
        private string selectAll = "All";
        private string selectedServices;
        private string selectedServer;
        private DataTable tableForGridView;

        public WindowMain()
        {
            InitializeComponent(); 
        }

        #region WindowsForm Components
        private void WindowMain_Load(object sender, EventArgs e)
        {
            query = new QueryServices();
            query.RegisterObs(this);

            selectServerTypComBox.Items.Add(selectAll);
            selectServerTypComBox.Items.Add(query.ServerTyp1());
            selectServerTypComBox.Items.Add(query.ServerTyp2());
            selectServiceComBox.SelectedItem = 0;
            
            selectServerTypComBox.SelectedIndex = 0;
            tableForGridView = new DataTable();

            tableForGridView.Columns.Add("Select", typeof(bool));
            tableForGridView.Columns.Add("Place", typeof(string));
            tableForGridView.Columns.Add("ServerName", typeof(string));
            tableForGridView.Columns.Add("ServiceName", typeof(string));
            tableForGridView.Columns.Add("StarType", typeof(string));
            tableForGridView.Columns.Add("State", typeof(string));

        }


        public void UpdateElement()
        {
            UpdateServerComboBox();
            UpdateServiceComboBox();
        }

        /**
         * Actualiza la informacion del ServerComboBox
         * dependiendo del tipo de servidor seleccionado
         * */
        private void UpdateServerComboBox()
        {
            selectServerComBox.Items.Clear();
            selectServerComBox.Items.Add(selectAll);
            selectServerComBox.SelectedIndex = 0;

            for (int i = 0; i < query.CsvServer.Rows.Count; i++)
            {
                selectServerComBox.Items.Add(query.CsvServer.Rows[i]["ServerName"]);
            }
        }



        #endregion WindowsFroms Components


        #region ComboBox
        private void SelectTypComBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectServerComBox.Items.Clear();
            query.SetComboBoxServer(selectServerTypComBox.SelectedItem.ToString());
            selectServiceComBox.SelectedIndex = 0;            
        }

        private void selectServerComBox_SelectedIndexChanged(object sender, EventArgs e)
        { }

        private void selectServiceComBox_SelectedIndexChanged(object sender, EventArgs e)
        { }


        private void pinTextBox_TextChanged(object sender, EventArgs e)
        { }
        #endregion ComboBox


        #region ComboBox Functions


        private void UpdateServiceComboBox()
        {
            selectServiceComBox.Items.Clear();
            selectServiceComBox.Items.Add(selectAll);
            selectServiceComBox.SelectedIndex = 0;
                     
            string last = "";

            for (int i = 0; i < query.CsvService.Rows.Count; i++)
            {
                //se compara la similitud con el elemento anterior
                if (query.CsvService.Rows[i]["serviceTyp"].ToString() != last)
                {
                    //si no son iguales se agrega el registro
                    selectServiceComBox.Items.Add(query.CsvService.Rows[i]["serviceTyp"]); 
                }
                else
                { }
                //se guarda el valor del ultimo registro analizado
                last = query.CsvService.Rows[i]["serviceTyp"].ToString();           
            }
        }


        private void AddAllServerToTheComboBox()
        {
            for (int i = 0; i < query.CsvServer.Rows.Count; i++)
            {
                selectServerComBox.Items.Add(query.CsvServer.Rows[i]["serverName"]);
            }
        }
        #endregion ComboBox Function


        #region Buttons
        private void pingBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(query.PingToServer(pinTextBox.Text));
        }
       

        private void searchBtn_Click(object sender, EventArgs e)
        {
            selectedServices = selectServiceComBox.SelectedItem.ToString();
            selectedServer = selectServerComBox.SelectedItem.ToString();

            StartThreadGridView();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            StartStopBtnTask(0);
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            StartStopBtnTask(1);                      
        }

        private void restartBtn_Click(object sender, EventArgs e)
        {
            StartStopBtnTask(2);
        }
        #endregion Buttons


        #region Buttons Functions
        /**
         * proporciona una accion a los botones
         * start, stop y restart, recibiendo como parametro
         * el tipo de tarea a realizar
         * @param task : tipo de tarea a realizar
         * */
        private void StartStopBtnTask(int task)
        {
            if (!(dataGridView1.Rows.Count == 0))
            {
                try
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells["Select"].Value) == true)
                        {
                            query.DetectingTask(Convert.ToString(row.Cells["ServiceName"].Value), Convert.ToString(row.Cells["ServerName"].Value), task);
                        }
                        else { }
                    }
                    StartThreadGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to start the service: " + ex.Message);
                }
            }
        }

        private void EnableBtn_Click(object sender, EventArgs e)
        {
            HandlingServiceButton("Automatic");
        }

        private void DisableBtn_Click(object sender, EventArgs e)
        {
            HandlingServiceButton("Disabled");
        }

        /**
         * proporciona una funcion para los botones enable y disable
         * recibiendo como parametro la tarea a realizar
         * @param task : tipo de tarea a realizar
         * */
        private void HandlingServiceButton(string task)
        {
            DialogResult result = MessageBox.Show("Die Dienste werden ihre Startype als " + task + " ändern . Möchten Sie die Ausgabe ausführen?", "Dienste " + task, MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells["Select"].Value) == true)
                        {
                            query.HandlingService(Convert.ToString(row.Cells["ServiceName"].Value), Convert.ToString(row.Cells["ServerName"].Value), task);
                        }
                        else { }
                    }

                    if(task == "Disabled")
                    {
                        StartStopBtnTask(1);
                    }
                    else
                    {
                        result = MessageBox.Show("Möchten Sie die Dienste Starten?", "Dienste " + task, MessageBoxButtons.YesNo);
                        if(result == DialogResult.Yes)
                        {
                            StartStopBtnTask(0);
                        }
                        else
                        {
                            StartThreadGridView();
                        }
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
        #endregion Buttons Functions


        #region DataGridView Functions


        internal delegate void SetDataSourceDelegate(ServerInfo info);

        private void SetDataSource(ServerInfo info)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new SetDataSourceDelegate(SetDataSource), info);
            }
            else
            {
                dataGridView1.Rows.Add(info.Select, info.Place, info.ServerName, info.ServiceName, info.StartType, info.State);               
            }
        }

        private void StartThreadGridView()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.Rows.Clear();

            Thread thread = new Thread(new ThreadStart(SearchFunction));
            thread.Start();
        }


        private void LoadedDataGridView(List<string> selectListServices, int index)
        {
            foreach (String sl in selectListServices)
            {
                string server = query.CsvServer.Rows[index]["ServerName"].ToString();

                ServiceController sc = query.GetServiceQuery(sl, server);
                try
                {
                    string estado = query.StartModeService(server, sl);
                    ServerInfo Info = new ServerInfo
                    {
                        Select = query.Estado,
                        Place = query.CsvServer.Rows[index]["PlaceName"].ToString(),
                        ServerName = query.CsvServer.Rows[index]["ServerName"].ToString(),
                        ServiceName = Convert.ToString(sc.ServiceName),
                        StartType = estado,
                        State = Convert.ToString(sc.Status)
                    };

                    SetDataSource(Info);
                    CellColorDataGridView();                    
                }
                catch (Exception ex)
                {
                    if (MessageBox.Show(ex.Message + " . Continue?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
            }

        }


        /**
         * dependiendo del estado de cada servicio, proporciona 
         * un color para la celda "State". Rojo para "Stopped",
         * verde para "Running" y naranja para "Pendind"
         * */
        private void CellColorDataGridView()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["State"].Value.ToString() == "Running")
                {
                    row.Cells["State"].Style.BackColor = Color.SeaGreen;
                    row.Cells["State"].Style.ForeColor = Color.White;
                }
                else if (row.Cells["State"].Value.ToString() == "Stopped")
                {
                    row.Cells["State"].Style.BackColor = Color.OrangeRed;
                    row.Cells["State"].Style.ForeColor = Color.White;
                }                   
                else 
                {
                    row.Cells["State"].Style.BackColor = Color.Orange;
                    row.Cells["State"].Style.ForeColor = Color.Black;
                }
            }
        }

        /*
         * Realiza una busqueda con los
         * valores seleccionado en cada ComboBox
         * */
        private void SearchFunction()
        {
            //dataGridView1.Rows.Clear();
            
            //string selectedServices = selectServiceComBox.SelectedItem.ToString();
            //string selectedServer = selectServerComBox.SelectedItem.ToString();

            List<string> selectListServices = new List<string>();
            List<string> selectListServers = new List<string>();

            //compara elementos de la tabla CSvService con los Servicios seleccionados
            for (int i = 0; i < query.CsvService.Rows.Count; i++)
            {
                try
                {
                    //solo un tipo de servicio seleccionado
                    if (query.CsvService.Rows[i]["serviceTyp"].ToString() == selectedServices)
                    {
                        selectListServices.Add(query.CsvService.Rows[i]["ServiceName"].ToString());
                    }

                    //todos los servicios han sido seleccionados
                    else if (selectedServices == selectAll)
                    {
                        selectListServices.Add(query.CsvService.Rows[i]["ServiceName"].ToString());
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    continue;
                }
            }

            SelectedCheck(selectedServer, selectListServices);            
         }


        /**
         * caraga en el datagridview la informacion que ha sido seleccionada en
         * los comboBox, recibiendo como parametros el servidor seleccionado 
         * y la lista de servicios relacionada con ese servidor.
         * 
         * @param selectedServer : servidor seleccionado
         * @param seleclListServices : lista de servicios relacionada al servidor
         *        seleccionado
         * */
        private void SelectedCheck(string selectedServer, List<string> selectListServices)
        {
            for (int i = 0; i < query.CsvServer.Rows.Count; i++)
            {
                try
                {
                    if (query.CsvServer.Rows[i]["ServerName"].ToString() == selectedServer)
                    {
                        LoadedDataGridView(selectListServices, i);
                    }
                    else if (selectedServer == selectAll )
                    {
                        LoadedDataGridView(selectListServices, i);
                    }
                    
                }
                catch (Exception ex)
                {
                    continue;
                }
            }            
        }





        #endregion


    }
}
