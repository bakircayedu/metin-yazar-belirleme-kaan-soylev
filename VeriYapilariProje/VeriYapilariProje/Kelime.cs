using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace VeriYapilariProje
{
    public class Kelime
    {
        public int Frequency { get; set; }


         public string Word;

       

        public Kelime(string Word, int usage)
        {
            this.Word = Word;
            this.Frequency = usage
                ;
        }


    }
}
