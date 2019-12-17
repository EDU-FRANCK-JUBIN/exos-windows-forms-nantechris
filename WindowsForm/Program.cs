using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Calculatrice
            /*try
            {
                Application.Run(new Calculatrice());
            }
            catch(DivideByZeroException exception)
            {
                MessageBox.Show(exception.Message);
            }*/

            Application.Run(new JeuTaquin());

        }
    }
}
