namespace DataSetProcess
{
    class csvWriter
    {
        #region Properties
        public string Path;
        private string Separador_Linea;
        private string Separador_Campos;
        public string[] Headers; 
        private StreamWriter Writer;
        #endregion
        public csvWriter(string path)
        {
            Path = path;
            Separador_Linea = System.Environment.NewLine;
            Separador_Campos = ",";
        }
        public void Open()
        {
            try
            {
                Writer = new StreamWriter(Path, true);
            }
            catch
            {
                throw (new Exception("Error, No es posible acceder al fichero."));
            }
        }
        public void Close()
        {
            try
            {
                Writer.Close();
            }
            catch
            {
                throw (new Exception("Error al cerrar el fichero."));
            }
        }
        private void write(string[] paramaters)
        {
            for (int i = 0; i < paramaters.Length; i++)
            {
                Writer.Write(paramaters[i]);
                if (i != paramaters.Length - 1)
                {
                    Writer.Write(Separador_Campos);
                }
                else
                {
                    break;
                }
            }
            Writer.Write('\n');
        }
        public void Write(string[] paramaters)
        {
            try
            {
                write(paramaters);
            }
            catch
            {
                throw (new Exception("Error writing to file"));
            }
        }
        public void WriteHeader()
        {
            Headers = new string[2];
            Headers[0] = "review";
            Headers[1] = "sentiment";
            write(Headers);
        }
        static void csvWriter_Example(string path)
        {
            csvWriter csv = new csvWriter(path);
            string[] header = new string[3];
            header[0] = "Name";
            header[1] = "Age";
            header[2] = "Street";
            string[] param = new string[3];
            param[0] = "Jhon";
            param[1] = "23";
            param[2] = "Aldgate";
            csv.Open();
            csv.WriteHeader();
            csv.Write(param);
            csv.Close();
        }
    }
}
