using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    internal class DVD : Media
    {
        public string duree { get; set; }
        public string titre { get; set; }

        public override void AfficherInfos()
        {
            base.AfficherInfos();
            Console.WriteLine("Titre du DVD = ", titre);
            Console.WriteLine("Durée du DVD = ", duree);
        }
    }
}
