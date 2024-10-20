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
    public partial class FurnitureForm : Form
    {
        public string SelectedFurniture { get; private set; }

        public FurnitureForm()
        {
            StartPosition = FormStartPosition.CenterScreen;
            var comboBox = new ComboBox
            {
                Dock = DockStyle.Fill,
                DropDownStyle = ComboBoxStyle.DropDown // Позволяет вводить текст вручную
            };
            comboBox.Items.AddRange(LoadFurnitureFromFile("D:\\Profitability\\Furniture\\furnitureStorage.txt"));
            Controls.Add(comboBox);

            var okButton = new Button { Text = "OK", Dock = DockStyle.Bottom };
            okButton.Click += (sender, e) =>
            {
                SelectedFurniture = comboBox.Text; // Используем Text вместо SelectedItem
                if (!string.IsNullOrEmpty(SelectedFurniture))
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

        private string[] LoadFurnitureFromFile(string filePath)
        {
            return System.IO.File.ReadAllLines(filePath);
        }
    }
}
