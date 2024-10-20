using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProfitFurniture
{
    public partial class ClientForm : Form
    {
        public string SelectedClient { get; private set; }

        public ClientForm()
        {
            StartPosition = FormStartPosition.CenterScreen;
            var comboBox = new ComboBox
            {
                Dock = DockStyle.Fill,
                DropDownStyle = ComboBoxStyle.DropDown // Позволяет вводить текст вручную
            };
            comboBox.Items.AddRange(LoadClientsFromFile("D:\\Profitability\\Customers\\customerStorage.txt"));
            Controls.Add(comboBox);

            var okButton = new Button { Text = "OK", Dock = DockStyle.Bottom };
            okButton.Click += (sender, e) =>
            {
                SelectedClient = comboBox.Text; // Используем Text вместо SelectedItem
                if (!string.IsNullOrEmpty(SelectedClient))
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Пожалуйста, выберите или введите значение.");
                }
            };
            Controls.Add(okButton);
        }

        private string[] LoadClientsFromFile(string filePath)
        {
            return System.IO.File.ReadAllLines(filePath);
        }
    }
}
