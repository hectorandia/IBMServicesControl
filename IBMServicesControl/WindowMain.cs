﻿using System;
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
using System.IO;


namespace IBMServicesControl
{
    public partial class WindowMain : MetroFramework.Forms.MetroForm, IMainObserver
    {
        private QueryServices query; 
        private string selectAll = "All";
        private string selectedServices;
        private string selectedServer;
        private int indexServicesProgressBar;
        private int indexServerProgressBar;
        private Thread thread;

        public WindowMain()
        {
            InitializeComponent(); 
        }

        #region WindowsForm Components
        private void WindowMain_Load(object sender, EventArgs e)
        {
            query = new QueryServices();
            query.RegisterObs(this);

            SetStarComboBoxServerTypValue();
            selectServiceComBox.SelectedItem = 0;            
            selectServerTypComBox.SelectedIndex = 0;
            cancelBtn.Enabled = false;
            startBtn.Enabled = false;
            stopBtn.Enabled = false;
            EnableBtn.Enabled = false;
            DisableBtn.Enabled = false;
        }
        public void MetodoBasura()
        {

        }

        public void UpdateElement()
        {
            UpdateServerComboBox();
            UpdateServiceComboBox();
        }

        public void SetStarComboBoxServerTypValue()
        {
            foreach (string typ in query.GetServersTyp)
            {
                selectServerTypComBox.Items.Add(typ);
            }
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

        private void LoadProgressBar()
        {
            this.progressBar.Maximum = indexServerProgressBar * indexServicesProgressBar;
            this.progressBar.Increment(1);
            if (progressBar.Value == progressBar.Maximum)
            {
                progressBar.Visible = false;
                EnableAllButton();
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

            foreach(string typ in query.GetServicesTyp)
            {
                selectServiceComBox.Items.Add(typ);
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

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            thread.Abort();
            dataGridView1.Rows.Clear();
            progressBar.Visible = false;
            EnableAllButton();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            selectedServices = selectServiceComBox.SelectedItem.ToString();
            selectedServer = selectServerComBox.SelectedItem.ToString();
            DisableAllButton();
            StartThreadGridView();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            DisableAllButton();
            StartStopBtnTask(0);
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            DisableAllButton();
            StartStopBtnTask(1);                      
        }

        private void restartBtn_Click(object sender, EventArgs e)
        {
            DisableAllButton();
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
            DisableAllButton();
            HandlingServiceButton("Automatic");
        }

        private void DisableBtn_Click(object sender, EventArgs e)
        {
            DisableAllButton();
            HandlingServiceButton("Disabled");
        }

        /**
         * proporciona una funcion para los botones enable y disable
         * recibiendo como parametro la tarea a realizar
         * @param task : tipo de tarea a realizar
         * */
        private void HandlingServiceButton(string task)
        {
            DialogResult result = MessageBox.Show("The service will be set to start type " + task + " Are you sure? ", "Service " + task, MessageBoxButtons.YesNo);
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
                        result = MessageBox.Show("Do you want to start the service?", "Service " + task, MessageBoxButtons.YesNo);
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
            else
            {
                StartThreadGridView();
            }

        }

        private void DisableAllButton()
        {
            cancelBtn.Enabled = true;
            searchBtn.Enabled = false;
            stopBtn.Enabled = false;
            startBtn.Enabled = false;
            //restartBtn.Enabled = false;
            EnableBtn.Enabled = false;
            DisableBtn.Enabled = false;
            saveBtn.Enabled = false;
        }

        private void EnableAllButton()
        {
            cancelBtn.Enabled = false;
            searchBtn.Enabled = true;
            stopBtn.Enabled = true;
            startBtn.Enabled = true;
            //restartBtn.Enabled = true;
            EnableBtn.Enabled = true;
            DisableBtn.Enabled = true;
            saveBtn.Enabled = true;
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
                dataGridView1.Rows[0].Cells[0].Selected = false;
                LoadProgressBar();
            }
        }

        private void StartThreadGridView()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.Rows.Clear();
            this.progressBar.Visible = true;
            this.progressBar.Value = 0;

            thread = new Thread(new ThreadStart(SearchFunction));
            thread.Start();
        }



        /*
         * Prepara los Objectos que seran cargado en forma de Row en el Data grid view
         * */
        private void LoadedDataGridView(List<string> selectListServices, int index)
        {
            indexServicesProgressBar = selectListServices.Count;
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
                catch (ThreadAbortException ex)
                {
                    if (MessageBox.Show("Die Abfrage der Diente wurde abgebrochen", "Services Control", MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        indexServicesProgressBar = 0;
                        break;
                    }
                    else
                    {
                        Environment.Exit(0);
                        break;                        
                    }
                    
                }
                catch(Exception ex)
                {
                    if (MessageBox.Show(ex.Message + " . Continue?", "Services Control", MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        indexServicesProgressBar -= 1;
                        continue;
                    }
                    else
                    {
                        Environment.Exit(0);
                        break;
                    }
                }
            }

        }

        private void dataGridView1_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToBoolean(row.Cells["Select"].Value) == true)
                {
                    row.Cells["Select"].Value = false;
                }
                else
                {
                    row.Cells["Select"].Value = true;
                }
            }
            dataGridView1.RefreshEdit();
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
            indexServerProgressBar = 0;
            for (int i = 0; i < query.CsvServer.Rows.Count; i++)
            {
                try
                {
                    if (query.CsvServer.Rows[i]["ServerName"].ToString() == selectedServer)
                    {
                        indexServerProgressBar += 1;
                        LoadedDataGridView(selectListServices, i);

                    }
                    else if (selectedServer == selectAll )
                    {
                        indexServerProgressBar = query.CsvServer.Rows.Count;
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


        private void WindowMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
            Application.Exit();
            Environment.Exit(0);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            var sb = new StringBuilder();

            var headers = dataGridView1.Columns.Cast<DataGridViewColumn>();
            sb.AppendLine(string.Join(";", headers.Select(column => "\"" + column.HeaderText + "\"").ToArray()));

            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                var cells = row.Cells.Cast<DataGridViewCell>();
                sb.AppendLine(string.Join(";", cells.Select(cell => "\"" + cell.Value + "\"").ToArray()));

            }
            saveFileDialog1.Filter = "CSV File|*.csv|Text File|*.txt";
            if(saveFileDialog1.ShowDialog() ==DialogResult.OK && saveFileDialog1.FileName != "")
            {
                try
                {
                    File.WriteAllText(saveFileDialog1.FileName, sb.ToString());
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        #region ToolStripMenu
        private void aboutServicesControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowMain_FormClosed(sender, null);
        }
        #endregion

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveBtn_Click(sender, null);
        }
    }
}
