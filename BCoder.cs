using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HW_7
{
    class BCoder : IСoder
    {
        public BCoder()
        {
            Abc();
        }
        List<char> abc = new();
        void Abc()
        {
            for (int i = 1072; i < 1104; i++)
            {
                abc.Add((char)i);
                if (i == 1077)
                abc.Add((char)1105);
            }
        }
        public string Encoder(string text)
        {
            text = text.ToLower();
            
            var txt = "";
            for(int i = 0; i < text.Length; i++)
            {
                var index = abc.IndexOf((char)(text[i]))+1;
                txt = txt + abc[abc.Count - index];
            }
            return txt;
        }
        /*public string Decode(string text)
        { 
            var txt = "";
            for (int i = 0; i < text.Length; i++)
            {
                var index = abc.IndexOf((char)(text[i]))+1;
                txt = txt + abc[abc.Count - index];
            }
            return txt;
        }*/
        public string Decode(string text)
        {
            return Encoder(text);
        }
    }
}
