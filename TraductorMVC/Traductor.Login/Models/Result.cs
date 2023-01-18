using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traductor.Logic.Models
{
    public class Result
    {
        public string TranslateWord { get; set; }
        public string Message { get; set; }
        public bool IsError { get; set; }

    }
}
