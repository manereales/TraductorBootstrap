using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traductor.Logic.Models
{
    public class Constants
    {
        public static Dictionary<string, string> SpanishEnglish = new Dictionary<string, string>() { { "hola", "hello" }, { "adios", "bye" }, { "dia", "day" } };
        public static Dictionary<string, string> SpanishFrench = new Dictionary<string, string>() { { "hola", "jelou" }, { "adios", "due" }, { "dia", "die" } };
    }
}
