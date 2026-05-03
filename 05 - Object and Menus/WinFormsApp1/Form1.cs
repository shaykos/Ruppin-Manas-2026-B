using WinFormsApp1.Classes;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Person[] people = new Person[5];
        int pointer = 0;

        public Form1()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (pointer < people.Length)
            {
                switch (cboRole.SelectedItem.ToString())
                {
                    case "Person":
                        if (txtName.Text != "")
                            people[pointer++] = new Person(txtName.Text);
                        else
                            MessageBox.Show("name is empty", "invalid info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case "Employee":
                        EmpForm empForm = new EmpForm();
                        empForm.MdiParent = this;
                        empForm.Show();
                        break;
                    case "Manager":
                        break;
                }
            }

        }
    }
}
