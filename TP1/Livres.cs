using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    internal class Livres : Media
    {
        public string titre { get; set; }
        public string auteur { get; set; }

        public override void AfficherInfos()
        {
            base.AfficherInfos();
            Console.WriteLine("Titre du livre = ", titre);
            Console.WriteLine("Auteur de l'auteur = ", auteur);
        }
    }
}
