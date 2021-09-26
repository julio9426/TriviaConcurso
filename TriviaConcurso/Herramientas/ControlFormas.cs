using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TriviaConcurso.Herramientas
{
    public static class ControlFormas
    {
        private static List<Form> stackFormas = new List<Form>();
        public static Form VerificaForma(Type forma) 
        {
            var formaVerificada = stackFormas.Where(f => f.GetType() == forma).FirstOrDefault();
            
            return formaVerificada; 
        }
        public static void EnlistaForma(Form forma)
        {
            if (forma==null || (forma.Tag!=null && forma.Tag == "Enlistada"))
            {
                return;
            }
            forma.Tag = "Enlistada";
            stackFormas.Add(forma);
        }

        public static void RemueveForma(Form forma)
        {
            stackFormas.Remove(forma);
        }


    }
}
