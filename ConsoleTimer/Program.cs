using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Digital_Void;
using System.Threading;

namespace ConsoleTimer
{
    class Program
    {
        static void Main(string[] args)
        {
            MainForm MainForm = new MainForm();
            PlayControl PC = new PlayControl(MainForm);
            PC.PlayPress();
            Thread.Sleep(1000);
            PC.PlayPress();
            Thread.Sleep(1000);
            PC.StopPress();
        }
    }
}
