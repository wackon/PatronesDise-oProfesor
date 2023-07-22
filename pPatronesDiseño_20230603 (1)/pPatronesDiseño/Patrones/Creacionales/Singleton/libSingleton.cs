using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pPatronesDiseño.Patrones.Creacionales.Singleton
{
    public class BalanceadorCarga
    {
        static BalanceadorCarga instancia;
        List<string> Servidores = new List<string>();
        Random random= new Random();
        //Bloqueo de sincronización del objeto
        private static object locker = new object();
        protected BalanceadorCarga()
        {
            Servidores.Add("Servidor I");
            Servidores.Add("Servidor II");
            Servidores.Add("Servidor III");
            Servidores.Add("Servidor IV");
            Servidores.Add("Servidor V");
        }
        public static BalanceadorCarga GetBalanceador()
        {
            if (instancia == null)
            {
                lock(locker)
                {
                    if (instancia == null)
                    {
                        instancia = new BalanceadorCarga();
                    }
                }
            }
            return instancia;   
        }
        public string Servidor
        {
            get { 
                int r = random.Next(Servidores.Count);
                return Servidores[r].ToString();
            }
        }
    }
}
