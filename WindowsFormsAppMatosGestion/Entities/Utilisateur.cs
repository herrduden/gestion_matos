﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppMatosGestion.Entities
{
    internal class Utilisateur
    {
        public int IdUser { get; set; }
        public string Login { get; set; }
        public string Mdp { get; set; }
    }
}
