using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timer
{
   
        public class ThrdTime
        {
            static int countdown = 10;
            static System.Threading.Timer timer;
            static public void Main()
            {
                // Create the timer callback delegate.
                System.Threading.TimerCallback cb = new System.Threading.
                TimerCallback(ProcessTimerEvent);
                // Create the object for the timer.
                clsTime time = new clsTime();
                // Create the timer. It is autostart, so creating the timer will start it.
                timer = new System.Threading.Timer(cb, time, 4000, 1000);
                // Blessed are those who wait.
                MessageBox.Show("Waiting for countdown", "Text");
            }
            // Callback method for the timer. The only parameter is the object you
            // ed when you created the timer object.
            private static void ProcessTimerEvent(object obj)
            {
                --countdown;
                // If countdown is complete, exit the program.
                if (countdown == 0)
                {
                    timer.Dispose();
                    Environment.Exit(0);
                }
                string str = "";
                // Cast the obj argument to clsTime.
                if (obj is clsTime)
                {
                    clsTime time = (clsTime)obj;
                    str = time.GetTimeString();
                }
                str += "\r\nCountdown = " + countdown;
                MessageBox.Show(str, "Timer Thread");
            }
        }
        // Define a class to use as the object argument for the timer.
        class clsTime
        {
            public string GetTimeString()
            {
                string str = DateTime.Now.ToString();
                int index = str.IndexOf(" ");
                return (str.Substring(index + 1));
            }
        }
    }

