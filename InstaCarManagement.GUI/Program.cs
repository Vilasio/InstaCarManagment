using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace InstaCarManagement.GUI
{
    static class Program
    {
        

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            NpgsqlConnection connection = new NpgsqlConnection(ConfigurationManager.AppSettings["Connection"]);


            try
            {
                connection.Open();

                FormLogin login = null;
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                
                login = new FormLogin(connection);
                if (login.ShowDialog() == DialogResult.OK)
                {
                    FormMain main = new FormMain(connection, login.actualUser);
                    Application.Run(main);
                    
                }
                



            }
            catch (NpgsqlException dbEx)
            {
                MessageBox.Show($"Leider ist eine Datenbankfehler aufgetreten.\n{dbEx.Message}", "Datenbankfehler!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Leider ist ein algemeiner Fehler aufgetreten.\n{ex.Message}", "Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                connection.Close();    
            }
        }



    } 
}
