﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_gellary.Models
{
    public class ViewModel
    {
        public Users User { get; set; }
        public IEnumerable<Users> UsersList { get; set; }
        public IEnumerable<Images> ImagesList { get; set; }
    }
}