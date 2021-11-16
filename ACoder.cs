using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HW_7
{
    class ACoder : IСoder
    {
        public string Encoder(string text)
        {
            var txt = "";
            for (int i = 0; i < text.Length; i++)
            {
                txt = txt + (char)(text[i]+1);
            }
            return txt;
        }

        public string Decode(string text)
        {
            var txt = "";
            for (int i = 0; i < text.Length; i++)
            {
                txt = txt + (char)(text[i]-1);
            }
            return txt;
        }
    }
}
