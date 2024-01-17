using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.concerete
{
    public class feature
    {
        [Key] public int FeatureID {  get; set; }
        
        public string Post1Name {  get; set; }
        public string Post1Description { get; set; }
        public string Post1Image { get; set; }

        public bool status { get; set; }





    }
}
