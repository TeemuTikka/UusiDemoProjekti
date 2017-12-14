using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demoa
{
    class demoClass
    {
        private string teksti;
        public demoClass(string test)
        {
            teksti = test;
        }

        public string Teksti { get => teksti; set => teksti = value; }

        public void metodi ()
        { }

    }
}
