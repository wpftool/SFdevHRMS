﻿using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface.PerformanceManage
{
    public partial class CheckAllPerformance : Form
    {
        public CheckAllPerformance()
        {
            InitializeComponent();
        }
        public CheckAllPerformance(List<Performance> eja)
        {
            InitializeComponent();
            dataGridView1.DataSource = eja;
        }
    }
}
