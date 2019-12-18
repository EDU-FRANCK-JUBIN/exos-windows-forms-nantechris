using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBindingWSrc
{
    public partial class DatabindingSrc : Form
    {
        public DatabindingSrc()
        {
            InitializeComponent();
        }

        private void DatabindingSrc_Load(object sender, EventArgs e)
        {
            List<Personne> mesPersonnes = new List<Personne>();

            // Je crée une instance avec le constructeur par défaut, et j'ajoute cette instance
            Personne quelquel = new Personne();
            mesPersonnes.Add(quelquel);

            mesPersonnes.Add(new Personne("LeBienNommé"));

            mesPersonnes.Add(new Personne("Sors", "Jean", Convert.ToDateTime("01/01/2012")));

            /*Personne quelquedAutre = "Marc, Assin (02/01/2012)";
            mesPersonnes.Add(quelquedAutre);*/

            personneBindingSource.DataSource = mesPersonnes;
        }
    }
}
