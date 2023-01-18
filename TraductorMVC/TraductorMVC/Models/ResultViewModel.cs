using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TraductorMVC.Models
{
    public class ResultViewModel
    {
        public string TranslateWord { get; set; }
        public string Message { get; set; }
        public bool IsError { get; set; }
    }
}