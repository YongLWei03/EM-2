﻿using EM.Common;
using EM.Utils;
using EM.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;

namespace EM.Model.DTOs
{

    public class CompanyCateLimitDTO
    {
        public int TotalCost { get; set; }
        public int TotalLimit { get; set; }

        public string CateName { get;set; }
        
    }
}
