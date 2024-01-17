using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.concerete
{
    public class Destination
    {
        [Key] public int DestinationID { get; set; }

        public string City { get; set; }
        public string DayNight { get; set; } //konaklama süresi
        public double Price { get; set; } //fiyat 

        public string image {  get; set; } //resim dosyası için

        public string Description { get; set; }
        public int Capacity { get; set; } //kaç kişi bunun için azalıp arttığında 

        public bool Status { get; set; } //aktif mi pasif mi
        

        
    }
}
