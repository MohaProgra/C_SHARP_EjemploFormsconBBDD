﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploForms
{
    public partial class Ventana2 : Form
    {

        
        public Ventana2()
        {
            InitializeComponent();
            
        }
        public void cambiaNombrePokemon(String nombrePokemon)
        {
            label1.Text = nombrePokemon;

        }
    }
}
