﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Umbraco.UnitTestExample.Web.Controllers
{
    public class SubtrationModel
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Result
        {
            get
            {
                return X - Y;
            }
        }
    }
}