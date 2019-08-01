namespace ServicioWeb.Modelo
{
    public sealed class Log
    {
        private static Log _instance = new Log();
        private static readonly object Lock = new object();
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);


        public static Log Instance()
        {
            if(_instance == null)
            {
                lock (Lock)
                {
                    if (_instance == null)  _instance = new Log();
                }
            }

            return _instance;
        }

        public void Error(object message)
        {
            Logger.Error(message);
        }

        public void Info(object message)
        {
            Logger.Info(message);
        }

    }
}