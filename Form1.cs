using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Using System.Windos.Forms Contains classes for creating Windows-based applications that use
 * UI features available in the Windows OS.
 * Resources used for this project include the following:
 * https://www.youtube.com/watch?v=tVlYojL7iCI
 * https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control.hide?view=netframework-4.8#System_Windows_Forms_Control_Hide
 * https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.timer?view=netframework-4.8#methods
 * https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control?view=netframework-4.8
 * https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.button?view=netframework-4.8#methods
 * https://www.researchgate.net/profile/Paulo_Rosa/publication/299395183/figure/fig41/AS:614089671847957@1523421795329/17-Illustration-of-a-simple-two-frame-animation-animation-flows-from-right-to-left.png
 * */
using System.Windows.Forms;

namespace MidtermNS2._1
{
    public partial class mainWindow : Form
    {
        public mainWindow()
        {
            InitializeComponent();
        }
        
        //When the hide button is clicked...
        private void hideBtn_Click(object sender, EventArgs e)
        {
            /*FUNCTION 1: Hide()
             *  Hide() is a method in the Control Class in System.Windows.Forms.
             *  Controls are components with visual representation.
             *  Hide() Conceals the control from the user*/

            //Hide all the controls except show
            walkBtn.Hide();
            jumpBtn.Hide();
            walkimg.Hide();
            jumpimg.Hide();
            repeatBox.Hide();
        }

        //When the show button is clicked...
        private void showBtn_Click(object sender, EventArgs e)
        {
            /*FUNCTION 2: Show()
             *  Show() is a method in the Control Class.
             *  Show() displays the control to the user*/

            //Show all the controls except hide
            walkBtn.Show();
            jumpBtn.Show();
            walkimg.Show(); 
            jumpimg.Show();
            repeatBox.Show();
        }

        //When the walk button is clicked...
        private void walkBtn_Click(object sender, EventArgs e)
        {
            /*FUNCTION 3: BringToFront()
             * BringToFront() is a method in the Control Class
             * BringToFront() brings the control to the front of the z-order*/

            //Bring the walking image to the front
            walkimg.BringToFront();
        }

        //When the jump button is clicked...
        private void jumpBtn_Click(object sender, EventArgs e)
        {
            /*FUNCTION 4: SendToBack()
             * SendToBack() is a method in the Control Class
             * SendToBack() sends the control to the back of the z-order*/
            
            //Send the walking image to the back
            walkimg.SendToBack();
        }

        //When the run box is checked...
        private void repeatBox_CheckedChanged(object sender, EventArgs e)
        {     
            //If the box is check...
            if (repeatBox.Checked)
            {
                /*FUNCTION 5: Start()
                 * Start() is part of the Timer class in System.Windows.Forms
                 * The Timer class implements a timer that raises an event at user-defined intervals.
                 * Start() starts the timer, the timer will continue unless a Stop() is called
                 */
                
                //Start the timer
                timer1.Start();  
            }
            //If it is unchecked
            else
            {
                /*FUNCTION 6: Stop()
                 * Stop() is part of the Timer class in System.Windows.Forms
                 * Stop() stops the timer
                 */
                
                //Stop the timers
                timer1.Stop();
                timer2.Stop();
            }
        }

        //When timer1 starts it will wait for 200ms and execute the block
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Bring the walking image to the front
            walkimg.BringToFront();

            //Start timer2
            timer2.Start();
            
        }

        //When timer2 is called it will wait for 100ms and execute the block
        private void timer2_Tick(object sender, EventArgs e)
        {
            //Stop timer2
            timer2.Stop();
            //Send the walking image to the back
            walkimg.SendToBack();
        }
    }
}
