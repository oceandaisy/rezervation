﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.concerete
{
    public class SubAbout
    {
        [Key] public string SubAboutId { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }




    }
}