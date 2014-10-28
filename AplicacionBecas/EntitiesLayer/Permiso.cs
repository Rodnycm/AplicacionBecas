﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Permiso : IEntity
    {
        private int idPermiso;
        public int Id
        {
            get { return idPermiso; }
            set { idPermiso = value; }
        }
        public String Nombre { get; set; }
        public String Descripción { get; set; }

        public Permiso()
        {
            Id = 0;
            Nombre = "";
            Descripción = "";
        }

        public Permiso(String pnombre, String pDescripción)
        {
            Id = 0;
            Nombre = pnombre;
            Descripción = pDescripción;
        }
    }
}




