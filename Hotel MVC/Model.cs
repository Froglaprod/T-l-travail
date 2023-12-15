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

        public bool Process(Stockage Inscription)
        {
            File.WriteAllText("Insciption.txt", JsonSerializer.Serialize(Inscription));
            MessageBox.Show("Inscription réussi !");

            return true;
        }
    }
}
