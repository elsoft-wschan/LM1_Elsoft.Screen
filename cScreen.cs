using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Elsoft.Screen
{
    public class cScreen
    {
        public static string ErrorMessage = "";

        //get the actual percentage of brightness
        public static bool GetBrightness(out int brightness)
        {
            try
            {
                ErrorMessage = "";
                brightness = 0;

                //define scope (namespace)
                System.Management.ManagementScope s = new System.Management.ManagementScope("root\\WMI");

                //define query
                System.Management.SelectQuery q = new System.Management.SelectQuery("WmiMonitorBrightness");

                //output current brightness
                System.Management.ManagementObjectSearcher mos = new System.Management.ManagementObjectSearcher(s, q);

                System.Management.ManagementObjectCollection moc = mos.Get();

                //store result
                foreach (System.Management.ManagementObject o in moc)
                {
                    brightness = (byte)o.GetPropertyValue("CurrentBrightness");
                    break; //only work on the first object
                }

                moc.Dispose();
                mos.Dispose();

                return true;
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
                brightness = 0;
                return false;
            }
        }

        //array of valid brightness values in percent
        public static bool GetBrightnessLevels(out byte[] levels)
        {
            levels = new byte[0];

            try
            {
                ErrorMessage = "";

                //define scope (namespace)
                System.Management.ManagementScope s = new System.Management.ManagementScope("root\\WMI");

                //define query
                System.Management.SelectQuery q = new System.Management.SelectQuery("WmiMonitorBrightness");

                //output current brightness
                System.Management.ManagementObjectSearcher mos = new System.Management.ManagementObjectSearcher(s, q);

                System.Management.ManagementObjectCollection moc = mos.Get();

                //store result


                foreach (System.Management.ManagementObject o in moc)
                {
                    levels = (byte[])o.GetPropertyValue("Level");
                    break; //only work on the first object
                }

                moc.Dispose();
                mos.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
                levels = new byte[0];
                return false;
            }
        }

        public static bool SetBrightness(byte targetBrightness)
        {
            try
            {
                ErrorMessage = "";
                //define scope (namespace)
                System.Management.ManagementScope s = new System.Management.ManagementScope("root\\WMI");

                //define query
                System.Management.SelectQuery q = new System.Management.SelectQuery("WmiMonitorBrightnessMethods");

                //output current brightness
                System.Management.ManagementObjectSearcher mos = new System.Management.ManagementObjectSearcher(s, q);

                System.Management.ManagementObjectCollection moc = mos.Get();

                foreach (System.Management.ManagementObject o in moc)
                {
                    o.InvokeMethod("WmiSetBrightness", new Object[] { UInt32.MaxValue, targetBrightness }); //note the reversed order - won't work otherwise!
                    break; //only work on the first object
                }

                moc.Dispose();
                mos.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
                return false;
            }
        }

    }
}
