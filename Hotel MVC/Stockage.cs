using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_MVC
{
    public class Stockage
    {
        // Variables de stockage des données rentrées
        private DateTime arrivate;
        private int numberNight;
        private string info;

        public DateTime Arrivate { get => arrivate; set => arrivate = value; }
        public int NumberNight { get => numberNight; set => numberNight = value; }
        public string Info { get => info; set => info = value; }
    }
}
