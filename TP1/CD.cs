using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    internal class CD : Media
    {
        public string artiste { get; set; }
        public string titre { get; set; }
        public string nb_chanson { get; set; }

        public override void AfficherInfos()
        {
            base.AfficherInfos();
            Console.WriteLine("Titre du CD = ", titre);
            Console.WriteLine("Durée du CD = ", artiste);
            Console.WriteLine("Nombre de chanson = ", nb_chanson);
        }
    }
}
