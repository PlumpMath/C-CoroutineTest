using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SafeCoroutine
{
    public partial class CoroutineTestForm : Form
    {
        public CoroutineTestForm()
        {
            InitializeComponent();
        }

        private void coroutineTimer_Tick(object sender, EventArgs e)
        {
            var timer = sender as Timer;
            CoroutineManager.Update(timer.Interval / 1000.0f);
        }

        private Coroutine mOuterRoutine;
        private Coroutine mInnerRoutine;

        private void btnStartCoroutine_Click(object sender, EventArgs e)
        {
            mOuterRoutine = CoroutineManager.StartCoroutine(outerSample());
        }

        IEnumerator outerSample()
        {
            tbDisplay.Text += "enter outerSample\r\n";
            yield return new WaitForSeconds(2);
            tbDisplay.Text += "outerSample WaitForSeconds(2)\r\n";
            mInnerRoutine = CoroutineManager.StartCoroutine(innerSample());
            yield return mInnerRoutine;
            tbDisplay.Text += "waiting for button click!\r\n";
            var routine1 = new WaitForButtonClick(btnWaitForMe);
            var routine2 = new WaitForButtonClick(btnWaitForMe2);
            yield return new WaitForAll(routine1, routine2);
            tbDisplay.Text += "exit outerSample\r\n";
        }

        IEnumerator innerSample()
        {
            int timer = 0;
            while (true)
            {
                tbDisplay.Text += "timer = " + timer++ + "\r\n";
                yield return new WaitForSeconds(0.5f);
            }
        }

        private void btnStopCoroutine_Click(object sender, EventArgs e)
        {
            //if (mOuterRoutine.IsSelfPaused)
            //    mOuterRoutine.Resume();
            //else
            //    mOuterRoutine.Pause();

            mInnerRoutine.Stop();
        }
    }
}
