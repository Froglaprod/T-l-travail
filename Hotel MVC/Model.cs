using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Hotel_MVC
{
    public class Model
    {
        private Controller _controller;

        public Controller Controller { get => _controller; set => _controller = value; }

        // Gestion d'erreur de remplissage des champs
        public bool Process(Stockage Inscription)
        {
            if (Inscription.NumberNight < 5) 
            {
                return false;
            }
            else
            {
                File.WriteAllText("Insciption.txt", JsonSerializer.Serialize(Inscription));
                MessageBox.Show("Inscription réussi !");
                return true;
            }
           

           
        }
    }
}
