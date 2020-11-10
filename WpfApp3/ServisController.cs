using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3
{
    public class ServisController
    {
        /// <summary>
        /// Это будет  выводится  в  форму
        /// </summary>
        public List<ServisW> ServisWs { get; set; }



        public ServisController()
        {

            ServisWs = new List<ServisW>();

            DB.DETLT2020Entities entities = new DB.DETLT2020Entities(); // подключение  к бд

            List<DB.Service> services;

            try
            {
                services = entities.Service.ToList(); // список  из  бд
            }
            catch
            {
                return;
            }


            if (services.Count != 0)
            {
                foreach (var item in services) // перебираем  объекты бд
                {
                    try
                    {
                        ServisW servisW = new ServisW(item); // создаем новый  объект  
                        ServisWs.Add(servisW); // записывам в список  
                    }
                    catch
                    {
                        continue;
                    }
                }
            }
        }
    }
}
