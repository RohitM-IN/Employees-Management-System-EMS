﻿using Employees_Management_System.Class;
using Employees_Management_System.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employees_Management_System.User_Controls
{
    public partial class Employees_Visits : UserControl
    {
        private static Employees_Visits _instance;

        public static Employees_Visits Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Employees_Visits();
                return _instance;
            }
        }
        public Employees_Visits()
        {
            InitializeComponent();
        }

        private void Employees_Visits_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eMSDataSet.BlacklistInfo' table. You can move, or remove it, as needed.
            this.employeeVisitsInfoTableAdapter.Fill(this.eMSDataSet.EmployeeVisitsInfo);

            lblEmployeeCount.Text = EmployeeGlobalInformation.EmployeeCount().ToString();

            lblCameEmployees.Text = EmployeeGlobalInformation.EmployeeCame().ToString();

            lblNotCameEmployees.Text = EmployeeGlobalInformation.NotCameEmployees().ToString();

            lblAverage.Text = EmployeeGlobalInformation.AverageCount().ToString();
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            SendEmail sendEmail = new SendEmail();
            sendEmail.Show();
        }

        private void btnEmployeeVisitsFullInfo_Click(object sender, EventArgs e)
        {
            EmployeeVisitsFullInfoFiltering employeeVisitsFullInfoFiltering = new EmployeeVisitsFullInfoFiltering();
            employeeVisitsFullInfoFiltering.Show();
        }

        private void btnEMSBot_Click(object sender, EventArgs e)
        {
            TelegramBot telegramBot = new TelegramBot();
            telegramBot.Show();
        }
    }
}
