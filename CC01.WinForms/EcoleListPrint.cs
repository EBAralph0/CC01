using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.WinForms
{
    public class EcoleListPrint
    {
        public string Intitule { get; set; }
        public long Telephone { get; set; }
        public string Ecomail { get; set; }
        public byte[] Logo { get; set; }
        public EcoleListPrint(string intitule, long telephone,
               string ecomail, byte[] logo)
        {
            Intitule = intitule;
            Telephone = telephone;
            Ecomail = ecomail;
            Logo = logo;
        }
    }

}
