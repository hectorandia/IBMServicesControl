using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Microsoft.VisualBasic.FileIO;
using System.Configuration;
using System.Windows.Forms;

namespace ServiceQuery
{
    class ImportInfo
    {
        //variable donde se guarda el archivo csv en formato de tabla
        private DataTable csvData;

        private string serverTyp1;
        private string serverTyp2;

        private string pathServers1;
        private string pathServers2;

        private string pathServices1;
        private string pathServices2;

        private string place1;
        private string place2;

        private bool checkBoxDefaultValue;

        public ImportInfo()
        {
            LoadCsvFiles();
            checkBoxDefaultValue = Convert.ToBoolean(ConfigurationManager.AppSettings["checkBoxDefaultValue"]);
        }
        
        /*
         * Metodo encargado de convertir un archivo csv en un DataTable.
         * El parametro csv_file_path recibe la ubicacion del documento.
         * */
        public DataTable GetDataTableFromScV(string csv_file_path)
        {
            csvData = new DataTable();
            try
            {
                using (TextFieldParser csvReader = new TextFieldParser(csv_file_path))
                {
                    csvReader.SetDelimiters(new string[] { ";" });
                    csvReader.HasFieldsEnclosedInQuotes = true;
                    //Read column names
                    string[] colFields = csvReader.ReadFields();
                    foreach (string column in colFields)
                    {
                        DataColumn datecolumn = new DataColumn(column);
                        datecolumn.AllowDBNull = true;
                        csvData.Columns.Add(datecolumn);
                    }
                    while (!csvReader.EndOfData)
                    {
                        string[] fieldData = csvReader.ReadFields();
                        //Making empty value as null
                        for (int i = 0; i < fieldData.Length; i++)
                        {
                            if (fieldData[i] == "")
                            {
                                fieldData[i] = null;
                            }
                        }
                        csvData.Rows.Add(fieldData);
                    }
                }
            }
            catch (Exception ex)
            {


            }
            return csvData;
        }

        public void LoadCsvFiles()
        {
            try
            {
                serverTyp1 = ConfigurationManager.AppSettings["ServerTyp1"];
                serverTyp2 = ConfigurationManager.AppSettings["ServerTyp2"];

                place1 = ConfigurationManager.AppSettings["place1"];
                place2 = ConfigurationManager.AppSettings["place2"];

                //
                //Variables de tipo string, donde se guarda la hubicacion de cada archivo 
                //csv especificada en el archivo App.config
                //
                pathServers1 = ConfigurationManager.AppSettings["pathServers1"];
                pathServers2 = ConfigurationManager.AppSettings["pathServers2"];
                pathServices1 = ConfigurationManager.AppSettings["pathServices1"];
                pathServices2 = ConfigurationManager.AppSettings["pathServices2"];
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //
        //metodo get para las variables de tipos string donde se almacena
        //el tipo de servidor
        //
        public string ServerTyp1
        {
            get
            {
                return serverTyp1;
            }
        }

        public string ServerTyp2
        {
            get
            {
                return serverTyp2;
            }
        }


        //
        //Metodos get para las variables de tipo string donde se almacena la ubicacion
        //de cada archivo CSV
        //
        public string PathServers1
        {
            get
            {
                return pathServers1; //Retorna una lista con los nombres de los servicios
            }
        }
        public string PathServers2
        {
            get
            {
                return pathServers2; //Retorna una lista con los nombres de los servicios
            }
        }
        public string PathServices1
        {
            get
            {
                return pathServices1; //Retorna una lista con los nombres de los servicios
            }
        }
        public string PathServices2
        {
            get
            {
                return pathServices2; //Retorna una lista con los nombres de los servicios
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

        public bool CheckBoxDefaultValue
        {
            get
            {
                return checkBoxDefaultValue;
            }
        }

    }
}
