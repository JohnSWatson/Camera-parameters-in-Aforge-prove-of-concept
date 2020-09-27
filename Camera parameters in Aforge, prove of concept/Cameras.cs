using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using AForge;
using AForge.Video.DirectShow;

namespace Camera_parameters_in_Aforge__prove_of_concept
{
    public static class Cameras
    {
        static FilterInfoCollection videoDevices;

        public static void Enumeratevideodevices(ComboBox cameraList)
            {
            // enumerate video devices
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            foreach (FilterInfo fi in videoDevices)
            {
                cameraList.Items.Add(fi.Name);
            }

            
        }

    }
}
