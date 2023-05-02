using Evaluation_Manager.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluation_Manager
{
    public partial class FrmStudents : Form {
        public FrmStudents() {
            InitializeComponent();
        }

        private void FrmStudents_Load(object sender, EventArgs e) {
            ShowStudents();
        }

        private void ShowStudents() {
            var students = StudentRepository.GetStudents();
            dgvStudents1.DataSource = students;

            dgvStudents1.Columns["Id"].DisplayIndex = 0;
            dgvStudents1.Columns["FirstName"].DisplayIndex = 1;
            dgvStudents1.Columns["LastName"].DisplayIndex = 2;
            dgvStudents1.Columns["Grade"].DisplayIndex = 3;
        }

        private void FrmStudents_Load_1(object sender, EventArgs e) {

        }
    }
}
