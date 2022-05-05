using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using CRUD_System.Entities;
using System.Data.Entity;

namespace CRUD_System
{
    public partial class Form1 : Form
    {

        Detail MyDetail = new Detail();

        public Form1()
        {
            InitializeComponent();
        }

        private void PopGridView()
        {
            using (var MyModelEntities = new MyModel())
            {
                grvDetailsData.DataSource = MyModelEntities.Details.ToList<Detail>();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopGridView();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            MyDetail.Name = ctrlName.Text;
            MyDetail.Lastname = ctrlLastname.Text;
            MyDetail.Age = Convert.ToInt32(ctrlAge.Text);
            MyDetail.Address = ctrlAddress.Text;
            MyDetail.Birthday = Convert.ToDateTime(ctrlBirthday.Text);

            using (var MyDbEntities = new MyModel())
            {
                if (MyDetail.ID == 0)
                {
                    MyDbEntities.Details.Add(MyDetail);
                    MyDbEntities.SaveChanges();

                    MessageBox.Show("Data Saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MyDbEntities.Entry(MyDetail).State = EntityState.Modified;
                    MyDbEntities.SaveChanges();

                    btSave.Text = "Save";
                    MyDetail.ID = 0;
                    MessageBox.Show("Data Updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            PopGridView();

        }

        private void grvDetailsData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grvDetailsData.CurrentRow.Index != -1)
            {
                MyDetail.ID = Convert.ToInt32(grvDetailsData.CurrentRow.Cells[0].Value);
                using (var MyDbEntities = new MyModel())
                {
                    MyDetail = MyDbEntities.Details.Where(x => x.ID == MyDetail.ID).FirstOrDefault();
                    ctrlName.Text = MyDetail.Name;
                    ctrlLastname.Text = MyDetail.Lastname;
                    ctrlAge.Text = MyDetail.Age.ToString();
                    ctrlAddress.Text = MyDetail.Address;
                    ctrlBirthday.Text = MyDetail.Birthday.ToString();

                    btSave.Text = "Update";
                }
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (var MyDbEntities = new MyModel())
                {
                    var entry = MyDbEntities.Entry(MyDetail);
                    if (entry.State == EntityState.Detached)
                    {
                        MyDbEntities.Details.Attach(MyDetail);
                        MyDbEntities.Details.Remove(MyDetail);
                        MyDbEntities.SaveChanges();
                        PopGridView();
                        ClearFields();
                    }
                }
            }
        }

        private void ClearFields()
        {
            ctrlName.Text = "";
            ctrlLastname.Text = "";
            ctrlAge.Text = "";
            ctrlAddress.Text = "";
            ctrlBirthday.Text = DateTime.Now.ToString();
        }

    }
}
