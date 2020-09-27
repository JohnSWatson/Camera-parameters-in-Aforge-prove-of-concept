using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using AForge;
using AForge.Video.DirectShow;

namespace Camera_parameters_in_Aforge__prove_of_concept
{
    public class Cameras
    {
        static FilterInfoCollection videoDevices;

        public Cameras() 
            {
            // Enumerate video devices
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            }



                public void loadCameraNames(ComboBox nameList)
            {

            foreach (FilterInfo fi in videoDevices)
            {
                nameList.Items.Add(fi.Name);
            }

        }

        public string moniker(int cameraIndex)
        {
            return videoDevices[cameraIndex].MonikerString;
        }
    }
}
