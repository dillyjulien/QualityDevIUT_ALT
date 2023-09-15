using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    public class Media
    {
        public string titre { get; set; }
        public int numero_référence { get; set; }
        public int nb_exemplaire_dispo { get; set; }

        public virtual void AfficherInfos()
        {
            Console.WriteLine("Titre = ", titre);
            Console.WriteLine("Numéro de référence = ", numero_référence);
            Console.WriteLine("Nombre d'exemplaire disponible = ", nb_exemplaire_dispo);

        }



    }

    
}
