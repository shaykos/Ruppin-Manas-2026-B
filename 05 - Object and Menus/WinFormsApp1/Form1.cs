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
            pnlEmployee.Visible = false;
            pnlManager.Visible = false;
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
                        if (txtName.Text != "" && txtSalary.Text != "")
                            people[pointer++] = new Employee(txtName.Text, double.Parse(txtSalary.Text));
                        break;
                    case "Manager":
                        if (txtName.Text != "" && txtBonus.Text != "")
                            people[pointer++] = new Employee(txtName.Text, double.Parse(txtSalary.Text));
                        break;
                }
            }

            foreach (Person person in people)
            {
                lblAllPeople.Text += person.Print() + "\n";
            }
        }

        private void cboRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboRole.SelectedItem.ToString())
            {
                case "Person":
                    pnlEmployee.Visible = false;
                    pnlManager.Visible = false;
                    break;
                case "Employee":
                    pnlEmployee.Visible = true;
                    pnlManager.Visible = false;
                    break;
                case "Manager":
                    pnlManager.Visible = true;
                    pnlEmployee.Visible = true;
                    break;
            }
        }
    }
}
