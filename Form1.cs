using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Schedule;

namespace timerX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var Timer = new ScheduleTimer();
            Timer.Elapsed += new ScheduledEventHandler(timer_Elapsed);            
            Timer.AddEvent(new Schedule.ScheduledTime("BySecond", "5"));            
            Timer.Start();
        }

        private void timer_Elapsed(object sender, ScheduledEventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
        }

     
    }
}
