using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Categorisation_Game
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Add correct entry point form here

            //Application.Run(new LoginPage());

            //Application.Run(new MenuPage());

            string name = "MusicDetails.csv";         
            string path = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, @"..\..\"));
            string fullpath = Path.Combine(path, name);
            string[] data = File.ReadAllLines(fullpath);
            int rowlength = data[0].Split(';').Length;
            string[,] table  = new string[data.Length,rowlength];

            for (int i = 0; i < data.Length; i++)
            {
                var temp = data[i].Split(';');
                for (int j = 0; j < rowlength; j++)            
                    table[i, j] = temp[j];                   
            }
            for (int i = 0; i < rowlength; i++)
            {
                MessageBox.Show(table[0, i]);
            }
        }
    }
}