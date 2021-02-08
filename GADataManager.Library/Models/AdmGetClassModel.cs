﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADataManager.Library.Models
{
    public class AdmGetClassModel
    {
        public int class_ID { get; set; }
        public string class_name { get; set; }
        public string promo_year { get; set; }
        public string specialty_name { get; set; }
        
        public string fullName { get; set; }
    }
    
}
