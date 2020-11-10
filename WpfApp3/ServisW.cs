using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp3.DB;

namespace WpfApp3
{
    public class ServisW
    {
        public  String Name { get; set; }
        public String Cost1 { get; set; }
        public String Cost2 { get; set; }
        public String Time { get; set; }
        public String CostString { get; set; }
        public string ImagePath { get; set; }

        public string btChange { get; set; }
        public string btDell { get; set; }
        public string btWrite { get; set; }

        public ServisW (DB.Service service)
        {
            Name = service.Title;

            Cost1 = GetCost1(service);
            Cost2 = GetCost2(service);
            Time = GetTime(service);
            CostString = GetCostString(service);
            ImagePath = GetImagePath(service);

            btChange = "Visible";
            btDell = "Visible";
            btWrite = "Visible";
        }

        private string GetImagePath(Service service)
        {
            if(service.MainImagePath !=  null)
            {
                return service.MainImagePath;
            }
            else
            {
                return "NoImage.png";
            }
        }

        private string GetCostString(Service service)
        {
            if (service.Discount != null && service.Discount > 0)
            {
                return service.Discount * 100 + "%";
            }
            else
            {
                return string.Empty;
            }
        }

        private string GetTime(Service service)
        {
            return " руб. за " +  service.DurationInSeconds  / 60 + " мин.";
        }

        private string GetCost2(Service service)
        {
            if (service.Discount != null && service.Discount > 0)
            {
                decimal realcost =  service.Cost *  ( Convert.ToDecimal(1) - 
                    Convert.ToDecimal(service.Discount));

                return Math.Round(realcost, 2).ToString();
            }
            else
            {
                return service.Cost.ToString();
            }



        }

        /// <summary>
        /// метод  выводит  цену  без скидки  если  скидка есть, если нет то null
        /// </summary>
        /// <param name="service"></param>
        /// <returns></returns>
        private string GetCost1(Service service)
        {
           if ( service.Discount!=null &&  service.Discount >0 )
            {
                return service.Cost.ToString();
            }
           else
            {
                return string.Empty;
            }
        }
    }
}
