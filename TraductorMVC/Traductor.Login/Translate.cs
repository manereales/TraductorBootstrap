using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traductor.Logic.Models;

namespace Traductor.Logic
{
    public  class Translate
    {
        public Result TranslateWord (ActionTypeEnum idioma, string word)
        {
            var TraduccionResult = new Result();
            try
            {
                
                switch (idioma)
                {
                    case ActionTypeEnum.Ingles:
                        TraduccionResult.TranslateWord = Tradutor(word, Constants.SpanishEnglish);
                        break;
                    case ActionTypeEnum.Frances:
                        TraduccionResult.TranslateWord = Tradutor(word, Constants.SpanishFrench);
                        break;
                    default:
                        TraduccionResult.Message = "no se encontró el idioma";
                        TraduccionResult.IsError = true;
                        return TraduccionResult;       
                       
                }

                if (TraduccionResult.TranslateWord == null)
                {
                    TraduccionResult.Message = "no se pudo traducir";
                    TraduccionResult.IsError = true;
                }
                else
                {
                    TraduccionResult.Message = "traducción exitosa";
                    TraduccionResult.IsError = false;
                }
                
            }
            catch (Exception Ex)
            {
                TraduccionResult.Message = "error desconocido";
                TraduccionResult.IsError = true;
            }
            return TraduccionResult;
        }

        public static string Tradutor(string word, Dictionary<string, string> dic)
        {
            string result = null;
            dic.TryGetValue(word, out result);
            return result;
        }
    }

}

