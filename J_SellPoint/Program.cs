using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace J_SellPoint
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
            Application.Run(new FrmDashboard());
        }

        public static void DisplayInfoMessage(string message)
        {
            MessageBox.Show(message, @"Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void DisplayErrorMessage(string message)
        {
            MessageBox.Show(message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void DisplayAlertMessage(string message)
        {
            MessageBox.Show(message, @"Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static bool Ask(string Question)
        {
            var answer = MessageBox.Show(Question, @"Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return answer == DialogResult.Yes?true:false;
        }

        // Restaura los valores de los tex, checkbox, combobox
        public static void CleanFormText(Control.ControlCollection controls)
        {
            foreach (var control in controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Text = string.Empty;
                }
                else if (control is CheckBox)
                {
                    ((CheckBox)control).Checked = false;
                }
                else if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = 0;
                }
            }
        }
    }
}
