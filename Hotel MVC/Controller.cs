﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_MVC
{
    public class Controller
    {
        private Model model;
        private Form1 view;

        public Model Model { get => model; set => model = value; }
        public Form1 View { get => view; set => view = value; }

        // Message lors de la validation
        public void Process(Stockage Inscription)
        {
            if(Model.Process(Inscription))
            {
                View.Success(" Opération Réussi");
            }
            else
            {
                View.Error(" Opération échoué");
            }
        }
    }
}
