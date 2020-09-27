using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Camera_parameters_in_Aforge__prove_of_concept
{
    public partial class Form1 : Form
    {
        Cameras cameras = new Cameras();

        public Form1()
        {
            InitializeComponent();
            cameras.loadCameraNames(comboBoxCameras);
        }

        private void comboBoxCameras_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelMoniker.Text = cameras.moniker(comboBoxCameras.SelectedIndex);
        }
    }
}
