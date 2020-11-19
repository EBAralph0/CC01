using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.BO
{
    public class Ecole
    {
        public string Intitulé { get; set; }
        public long Téléphone { get; set; }
        public string Email { get; set; }
        public byte[] Logo { get; set; }

        public Ecole()
        {
        }

        public Ecole(string intitulé, byte[] logo, long téléphone, string email)
        {
            Intitulé = intitulé;
            Logo = logo;
            Téléphone = téléphone;
            Email = email;
        }
    }
}
