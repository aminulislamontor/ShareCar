using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using ShareCar.Repository;

namespace ShareCar_v2
{
    public partial class UserDash : MetroForm
    {
        CarRequestRepo RequestRepo = new CarRequestRepo();
        public UserDash()
        {
            InitializeComponent();
        }

        private void PopulatedGridView()
        {
            this.userGrid.AutoGenerateColumns = false;
            this.userGrid.DataSource = RequestRepo.GetAll().ToList();
            this.userGrid.ClearSelection();
            this.userGrid.Refresh();
        }

        private void UserDash_Load(object sender, EventArgs e)
        {
            this.PopulatedGridView();
        }
    }
}
