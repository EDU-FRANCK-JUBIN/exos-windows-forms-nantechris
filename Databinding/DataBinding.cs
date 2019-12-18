using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Databinding
{
    public partial class Databinding : Form
    {
        
        public Databinding()
        {
            InitializeComponent();
            List<Chanson> listeChansons = new List<Chanson>()
            {
                new Chanson("Johnny", "Oh Marie"),
                new Chanson("Johnny", "Laura"),
                new Chanson("Johnny", "Le penitencier"),
                new Chanson("Johnny", "Allumer le feu"),
                new Chanson("Cabrel", "Petite Marie"),
                new Chanson("Cabrel", "Octobre"),
                new Chanson("Cabrel", "La corrida"),
                new Chanson("Cabrel", "C'est écrit")
            };

            dgvArtiste.DataSource = listeChansons;
            dgvChanson.DataSource = listeChansons;
        }
    }
}
