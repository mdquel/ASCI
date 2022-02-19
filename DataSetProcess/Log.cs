namespace DataSetProcess
{
    public class Log
    {
        public void WriteLog(string Message)
        {
            using (StreamWriter file = File.AppendText("log.txt"))
            {
                file.WriteLine(Message);
            }
        }

        public void InitLog()
        {
            using (StreamWriter file = File.AppendText("log.txt"))
            {
                file.Write("\r\nLog: ");
                file.WriteLine($"{DateTime.Now.ToLongTimeString()} {DateTime.Now.ToLongDateString()}");
                file.WriteLine("-------------------------------");
            }

        }
    }

}
