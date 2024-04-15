using WorkerRegistration.Model;
using WorkerRegistration.Presenter;

namespace WorkerRegistration
{
    public partial class WorkerView : Form
    {
        public WorkerPresenter presenter { get; set; }

        CityStreets streets = new CityStreets();
        public WorkerView(WorkerPresenter workerPresenter)
        {
            InitializeComponent();
            presenter = workerPresenter;
            FileInfo file = new FileInfo(presenter.path);
            if(file.Exists )
            {
                presenter.LoadData();
                UpdateList();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                presenter.AddWorker(new Worker
                {
                    Name = textBoxName.Text,
                    Surname = textBoxSurname.Text,
                    Position = comboBoxPosition.Text,
                    Salary = Convert.ToInt32(textBoxSalary.Text),
                    City = comboBoxCity.Text,
                    Street = comboBoxStreet.Text,
                    House = textBoxHouse.Text
                });
                ClearView();
                UpdateList();
            }
            catch (Exception)
            {
                MessageBox.Show("Incomplete information or incorrect salary format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void UpdateList()
        {
            listBoxWorkers.DataSource = null;
            listBoxWorkers.DataSource = presenter.workers;
        }

        void ClearView()
        {
            textBoxName.Text = string.Empty;
            textBoxSurname.Text = string.Empty;
            textBoxSalary.Text = string.Empty;
            textBoxHouse.Text = string.Empty;
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            Worker SelectedWorker = listBoxWorkers.SelectedItem as Worker;
            presenter.RemoveWorker(SelectedWorker);
            UpdateList();
        }

        private void comboBoxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCity.Text == "Baku") comboBoxStreet.DataSource = streets.Baku;
            else if (comboBoxCity.Text == "Moscow") comboBoxStreet.DataSource = streets.Moscow;
            else if (comboBoxCity.Text == "New-York") comboBoxStreet.DataSource = streets.NewYork;
            else if (comboBoxCity.Text == "London") comboBoxStreet.DataSource = streets.London;
        }

        private void listBoxWorkers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxWorkers.SelectedIndex >= 0)
            {
                labelName.Text = presenter.workers[listBoxWorkers.SelectedIndex].Name;
                labelSurname.Text = presenter.workers[listBoxWorkers.SelectedIndex].Surname;
                labelPosition.Text = presenter.workers[listBoxWorkers.SelectedIndex].Position;
                labelSalary.Text = presenter.workers[listBoxWorkers.SelectedIndex].Salary.ToString();
                labelCity.Text = presenter.workers[listBoxWorkers.SelectedIndex].City;
                labelStreet.Text = presenter.workers[listBoxWorkers.SelectedIndex].Street;
                labelHouse.Text = presenter.workers[listBoxWorkers.SelectedIndex].House;
            }
        }

        private void WorkerView_FormClosing(object sender, FormClosingEventArgs e)
        {
            presenter.SaveData();
            MessageBox.Show("Data was Saved", "Saving", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}