﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapLesson3 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Create a new DataSet
            System.Data.DataSet xmlDataSet = new System.Data.DataSet("XML DataSet");
            // Load the XML document to the DataSet
            xmlDataSet.ReadXml(@"..\..\Data\rio2016.xml");
            // This line of code is generated by Data Source Configuration Wizard
            pieChartDataAdapter1.DataSource = xmlDataSet.Tables["Table1"];
        }

        private void OnDataLoaded(object sender, DevExpress.XtraMap.DataLoadedEventArgs e) {
            mapControl1.ZoomToFitLayerItems();
        }
    }
}
