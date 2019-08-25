// This implements a console application that can be used to test an ASCOM driver
//

// This is used to define code in the template that is specific to one class implementation
// unused code can be deleted and this definition removed.

// remove this to bypass the code that uses the chooser to select the driver
#define UseChooser

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ASCOM
{
    class Program
    {
        static void Main(string[] args)
        {
            // Uncomment the code that's required
            string id = string.Empty;
            // choose the device
            using (ASCOM.Utilities.Chooser chooser = new Utilities.Chooser())
            {
                chooser.DeviceType = "Focuser";
                id = chooser.Choose(string.Empty);
            }

            if (string.IsNullOrEmpty(id))
                return;
            // create this device
            ASCOM.DriverAccess.Focuser device = new ASCOM.DriverAccess.Focuser(id);

            // now run some tests, adding code to your driver so that the tests will pass.
            // these first tests are common to all drivers.
            Console.WriteLine("name " + device.Name);
            Console.WriteLine("description " + device.Description);
            Console.WriteLine("DriverInfo " + device.DriverInfo);
            Console.WriteLine("driverVersion " + device.DriverVersion);
            device.SetupDialog();
            // TODO add more code to test the driver.
            device.Connected = true;


            device.Connected = false;
            Console.WriteLine("Press Enter to finish");
            Console.ReadLine();
        }
    }
}
