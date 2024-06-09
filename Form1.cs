using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR_7_2
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Закрити застосунок", "Вихід з програми",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Очистити таблицю?\n\nВсі дані будуть втрачені", "Очищення даних",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                bindSrcTowns.Clear();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Видалити поточний запис ?", "Видалення запису",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                bindSrcTowns.RemoveCurrent();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            hard_drive hard_drive_ = new hard_drive();

            fTown ft = new fTown(ref hard_drive_);
             if (ft.ShowDialog() == DialogResult.OK)
             {
                 bindSrcTowns.Add(hard_drive_);
             }



            gvTowns.AutoGenerateColumns = false;

            DataGridViewColumn column = new DataGridViewTextBoxColumn();

            column = new DataGridViewTextBoxColumn(); column.DataPropertyName =
            "Manufacturer"; column.Name = "Виробник"; gvTowns.Columns.Add(column);

            column = new DataGridViewTextBoxColumn(); column.DataPropertyName =
            "Model"; column.Name = "Модель"; gvTowns.Columns.Add(column);

            column = new DataGridViewTextBoxColumn(); column.DataPropertyName =
            "CapacityGB"; column.Name = "Обсяг"; gvTowns.Columns.Add(column);

            column = new DataGridViewTextBoxColumn(); column.DataPropertyName =
            "Interfacetype"; column.Name = "Тип інтерфейсу"; gvTowns.Columns.Add(column);

            column = new DataGridViewTextBoxColumn(); column.DataPropertyName =
            "Rpm"; column.Name = "Кіл.оберт.за хв.";
            column.Width = 80; gvTowns.Columns.Add(column);

            column = new DataGridViewCheckBoxColumn(); column.DataPropertyName
            = "Price"; column.Name = "Ціна";
            column.Width = 60; gvTowns.Columns.Add(column);

            column = new DataGridViewCheckBoxColumn(); column.DataPropertyName
            = "IsSSD"; column.Name = "Має жорсткий диск";

            column.Width = 60; gvTowns.Columns.Add(column);

            bindSrcTowns.Add(new hard_drive("Seagate", "Barracuda", 2000, "SATA 3", 7200, 89.99, true));
            EventArgs args = new EventArgs(); OnResize(args);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            hard_drive hard_drive_ = (hard_drive)bindSrcTowns.List[bindSrcTowns.Position];

            fTown ft = new fTown(ref hard_drive);
            if (ft.ShowDialog() == DialogResult.OK)

            {
                bindSrcTowns.List[bindSrcTowns.Position] = hard_drive;
            }
        }
    }
    
}
