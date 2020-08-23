using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Management.Instrumentation;
using System.Threading;

namespace ArduArm_Controller
{
    // 2013 - https://www.youtube.com/makenitso 

    public partial class Form1 : Form
    {
        public bool PenIsDown = false;
        public int[] Xarr = new int[10000];
        public int[] Yarr = new int[10000];
        public int[] Zarr = new int[10000];
        public int CountArr = 0;


        double c2 = 0.0; // is btwn -1 and 1
        double s2 = 0.0;
        bool elbowup = true; // true=elbow up, false=elbow down

        double theta1 = 0.0;  // target angles as determined through IK
        double theta2 = 0.0;

        double l1 = 100; //67.5; //length of links in mm
        double l2 = 100; //65.8;

        double computedX = 0.0; //results of forward kinematics
        double computedY = 0.0;



        public int scale = 315;
        private int s3PenDown = 35;
        private int s3PenUp = 70;
        private int currentX = 150, currentY = 50;

        public Bitmap armBmp;
        public Bitmap drawBmp;
        public Graphics g;
        public Graphics g1;

        public Graphics gg;

        public bool mouseIsDown = false;
        public bool PleaseStop = false;

        public int angleDangle = 0;

        public int J1_Offset = 0;    // -120
        public int J2_Offset = 180;      //220 

        public string RxString = "";

        private bool PenDown;

        public Form1()
        {
            InitializeComponent();
            toolStripLabel1.Text = "ArduArm - Controller v" + Application.ProductVersion;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int zz = 0; zz < 100; zz++)
            {
                for (int ww = 0; ww < 200; ww++)
                {
                    drawLine(0, 0, 200, ww);
                    Application.DoEvents();
                }
                
            }
        }

        public double resolveJ1(double inAngle)
        {
            double retVal = inAngle + J1_Offset;
            if (retVal < 0)
            {
                retVal = 360.0 + retVal;
            }
            if (retVal > 360)
            {
                retVal = 360.0 - retVal;
            }
            return retVal;
        }

        public double resolveJ2(double inAngle)
        {
            double retVal = inAngle + J2_Offset;
            if (retVal < 0)
            {
                retVal = 360 + retVal;
            } 
            if (retVal > 360)
            {
                retVal = 360 + retVal;
            }
            return retVal;
        }

        public void drawLine(int x1,  int x2, int y1, int y2)
        {
            
            System.Drawing.Pen myPen;
            myPen = new System.Drawing.Pen(System.Drawing.Color.Red);
            System.Drawing.Graphics formGraphics = this.CreateGraphics();
            formGraphics.Clear(System.Drawing.Color.White);
            formGraphics.DrawLine(myPen, x1, x2, y1, y2);
            myPen.Dispose();
            formGraphics.Dispose();
        }

        public void drawPreview(int x, int y)
        {
            x = x - 150; //310
            y = y - 0; //105

            if (checkYaxisFlip.Checked)
            {
                y = pictureBox1.Height - y;
            }

            System.Drawing.Pen myPen;
            myPen = new System.Drawing.Pen(System.Drawing.Color.Black);
            myPen.Width = 2;
            System.Drawing.Graphics formGraphics2 = pictureBox1.CreateGraphics();
            formGraphics2.DrawLine(myPen, x, y, x-1, y);
            
            myPen.Dispose();
            formGraphics2.Dispose();
        }


        public void drawARM(double J1, double J2, bool penDown)
        {
            Font drawFont = new Font("Arial", 8);
            

            double startX = 150;
            double startY = 220;
            int aLength = 150;

            J1 = Math.Abs(J1 - 360);
            J2 = Math.Abs(J2 - 360);

            SolidBrush drawBrush = new SolidBrush(Color.Black);
            

            double JR1 = resolveJ1(J1);
            double JR2 = resolveJ2(J2);

            double angleRadians = (Math.PI / 180.0) * JR1;
            double angleRadians2 = (Math.PI / 180.0) * JR2;

            System.Drawing.Pen myPen;
            myPen = new System.Drawing.Pen(System.Drawing.Color.Red);
            myPen.Width = 4;
            System.Drawing.Pen myPenBlack;
            myPenBlack = new System.Drawing.Pen(System.Drawing.Color.Gray);
            myPenBlack.Width = 1;

            System.Drawing.Graphics formGraphics = pictureBox2.CreateGraphics();
            formGraphics.Clear(System.Drawing.Color.White);

            //Draw canvas area
            formGraphics.DrawRectangle(myPenBlack, (float)startX+5, (float)10, (float)(205), (float)(startY-18));

            myPenBlack = new System.Drawing.Pen(System.Drawing.Color.Black);
            myPenBlack.Width = 3;

            //draw center
            formGraphics.DrawEllipse(myPenBlack, (float)startX - 5, (float)startY - 5, 10, 10);
            

            //draw Arm-1
            double x2 = (startX + Math.Cos(angleRadians) * aLength);
            double y2 = (startY + Math.Sin(angleRadians) * aLength);
            formGraphics.DrawLine(myPen, (int)startX, (int)startY, (int)x2, (int)y2);
            
            //draw elbow joint
            formGraphics.DrawEllipse(myPenBlack, (int)x2 - 5, (int)y2 - 5, 10, 10);
            myPen.Width = 2;
            //Draw Arm-2
            double x22 = (x2 + Math.Cos(angleRadians + angleRadians2) * aLength);
            double y22 = (y2 + Math.Sin(angleRadians + angleRadians2) * aLength);
            formGraphics.DrawLine(myPen, (int)x2, (int)y2, (int)x22, (int)y22);
            
            //draw pen
            formGraphics.DrawEllipse(myPenBlack, (int)x22 - 5, (int)y22 - 5, 10, 10);

            valShoulder.Text = (Math.Abs(J1-360)).ToString();
            valElbow.Text = (Math.Abs(J2 - 360)).ToString();

            valX.Text = x22.ToString();
            valY.Text = y22.ToString();

            //Draw shoulder angle
            string th1 = ((double)theta1).ToString("#.##");
            RectangleF drawRect = new RectangleF((float)startX + 10, (float)startY , 80, 40);
            formGraphics.DrawString(th1, drawFont, drawBrush, drawRect);

            //Draw elbow angle
            string th2 = (180 + ((double)theta2)).ToString("#.##");
            drawRect = new RectangleF((float)x2, (float)y2-20, 80, 40);
            formGraphics.DrawString(th2, drawFont, drawBrush, drawRect);


            myPen.Dispose();
            formGraphics.Dispose();

            //updatePreview
            drawPreview((int)x22, (int)y22);

            //output to commport
            if (checkBox1.Checked)
            {
                byte[] yy = intToByte(x22);
                byte[] xy = intToByte(y22);
                byte[] zy = intToByte(0);


                if (useGCode.Checked)
                {
                    string outPacket = "G01 X" + (int)theta1 + " Y" + (int)(180+theta2) + (char)10;
                    serialPort1.WriteLine(outPacket);
                }
                else
                {
                    SerialWrite(intToByte(3));    // theta1
                    SerialWrite(intToByte(2));    // theta2
                    SerialWrite(intToByte(1));      // pen is down
                    SerialWrite(intToByte(0));      // end packet
                }
            }
            Application.DoEvents();
            Thread.Sleep(int.Parse(speedAmount.Text)*10);
        }


        public byte[] intToByte(double intValueDBL)
        {
            int intValue = (int)intValueDBL;
            byte[] intBytes = BitConverter.GetBytes(intValue);
            Array.Reverse(intBytes);
            byte[] result = intBytes;
            return result;
        }

        public void ConvertAndDraw(double X, double Y)
        {
            double vG = Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));
            double vD = Math.Asin(Y / vG) * 180.0 / 3.1415926535897932384626433832795;
            double vA = Math.Acos(vG / 200.0) * 180.0 / 3.1415926535897932384626433832795;
            double vB = 180 - (2 * vA);
            double vH = 90 - (vD + vA);
            //DrawPixel((int)vH, (int)vB);
            drawARM(vH, vB,true);
        }

       
        // Given theta1, theta2 solve for target(Px, Py) (forward kinematics)
        void get_xy()
        {
            computedX = l1 * Math.Cos(radians(theta1)) + l2 * Math.Cos(radians(theta1 + theta2));
            computedY = l1 * Math.Sin(radians(theta1)) + l2 * Math.Sin(radians(theta1 + theta2));
        }

        // Given target(Px, Py) solve for theta1, theta2 (inverse kinematics)
        void get_angles(double Px, double Py)
        {
            // first find theta2 where c2 = cos(theta2) and s2 = sin(theta2)
            c2 = (Math.Pow(Px, 2) + Math.Pow(Py, 2) - Math.Pow(l1, 2) - Math.Pow(l2, 2)) / (2 * l1 * l2); // is btwn -1 and 1
            //Serial.print("c2 "); Serial.print(c2);

            if (elbowup == false)
            {
                s2 = Math.Sqrt(1 - Math.Pow(c2, 2));  // sqrt can be + or -, and each corresponds to a different orientation
            }
            else if (elbowup == true)
            {
                s2 = - Math.Sqrt(1 - Math.Pow(c2, 2));
            }
            theta2 =  degrees(Math.Atan2(s2, c2));  // solves for the angle in degrees and places in correct quadrant
            //theta2 = map(theta2, 0,180,180,0); // the servo is flipped. 0 deg is on the left physically
            // now find theta1 where c1 = cos(theta1) and s1 = sin(theta1)
            theta1 = degrees(Math.Atan2(-l2 * s2 * Px + (l1 + l2 * c2) * Py, (l1 + l2 * c2) * Px + l2 * s2 * Py));

            //theta2 = 180 - Math.Abs(theta2);
            //theta1 = theta1;
            //Serial.println();
        }



        public double degrees(double radians)
        {
            return radians *180 / Math.PI;
        }

        public double radians(double degrees)
        {
            return Math.PI * degrees / 180; ;
        }

   


        private void button2_Click(object sender, EventArgs e)
        {
            angleDangle = angleDangle+5;
            if (angleDangle > 359) { angleDangle = 1; }
            

            label1.Text = angleDangle.ToString();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
           // drawARM(trackBar1.Value / 100.0, trackBar2.Value / 100.0);
        }

        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            //drawARM(trackBar1.Value / 100.0, trackBar2.Value / 100.0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClearDrawSpace();
        }

        public void ClearDrawSpace()
        {
            System.Drawing.Graphics formGraphics3 = pictureBox1.CreateGraphics();
            formGraphics3.Clear(System.Drawing.Color.White);
            formGraphics3.Dispose();
            ClearArrays();
        }
  
   

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Xarr[CountArr] = 0;
            Yarr[CountArr] = 0;
            Zarr[CountArr] = 1;
            CountArr++;
            mouseIsDown = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            Xarr[CountArr] = 0;
            Yarr[CountArr] = 0;
            Zarr[CountArr] = 0;
            CountArr++;
            mouseIsDown = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseIsDown)
            {
                double EX = e.X / 2 ; // EX range 0 - 360
                double EY = e.Y / 2 ;
                int x = e.X;
                int y = e.Y;

                if ((EX > 4) && (EX < 140))
                {
                    if ((EY > 4) && (EY < 140))
                    {
                        label6.Text = "";
                        label7.Text = "";
                        get_angles(EX, EY);
                        get_xy();
                        label6.Text = theta1.ToString();
                        label7.Text = theta2.ToString();
                        label13.Text = computedX.ToString();
                        label14.Text = computedY.ToString(); 

                        label6.Update();
                        label7.Update();
                        trackBar1.Value = (int)(theta1 * 100.0);
                        trackBar2.Value = (int)((180 - Math.Abs(theta2)) * 100.0);
                        drawARM(trackBar1.Value / 100.0, trackBar2.Value / 100.0,true);

                        if (CountArr < 10000)
                        {
                            Xarr[CountArr] = x;
                            Yarr[CountArr] = y;
                            Zarr[CountArr] = 1;
                            CountArr++;
                            label18.Text = CountArr.ToString() + " of 10,000";
                        }
                    }
                }
            }
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            mouseIsDown = false;
        }

       

        


        public void DrawCircle()
        {
            int x0 = 50;
            int y0 = 0;
            int radius = 40;
            for (int j = 1; j <= 7; j++)
            {
                radius = (j + 1) * 5;
                for (double i = 0.0; i < 360.0; i += 2)
                {
                    double angle = i * Math.PI / 180;
                    double x = (90.0 + radius * Math.Cos(angle));
                    double y = (65.0 + radius * Math.Sin(angle));
                    get_angles(x, y);
                    get_xy();
                    label6.Text = theta1.ToString();
                    label7.Text = theta2.ToString();
                    label13.Text = computedX.ToString();
                    label14.Text = computedY.ToString(); 

                    trackBar1.Value = (int)(theta1 * 100.0);
                    trackBar2.Value = (int)((180 - Math.Abs(theta2)) * 100.0);
                    drawARM(trackBar1.Value / 100.0, trackBar2.Value / 100.0,true);
                    if (PleaseStop) { PleaseStop = false;  break; }
                }
            }
            ReturnHome();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ClearDrawSpace();
            DrawCircle();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            doRead();
        }

        public void doRead(){
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                ClearDrawSpace();
                string[] lines = System.IO.File.ReadAllLines(openFileDialog1.FileName);
                foreach (string line in lines)
                {
                    string[] Coord = line.Split(' ');
                    
                    if (Coord[0] == "G01")
                    {
                        double x = int.Parse(Coord[1].Substring(1));
                        double y = int.Parse(Coord[2].Substring(1));

                        if(((x>10)&&(y>10)) && ( (x<140)&&(y<140) )){

                            get_angles(x, y);
                            get_xy();
                            label6.Text = theta1.ToString();
                            label7.Text = theta2.ToString();
                            label13.Text = computedX.ToString();
                            label14.Text = computedY.ToString();
                            trackBar1.Value = (int)(theta1 * 100.0);
                            trackBar2.Value = (int)((180 - Math.Abs(theta2)) * 100.0);
                            drawARM(trackBar1.Value / 100.0, trackBar2.Value / 100.0, true);
                            
                            if (PleaseStop) { PleaseStop = false; break; }
                        }
                    }
                }
                ReturnHome();
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            ClearDrawSpace();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ClearDrawSpace();
            DrawCircle();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            doRead();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                PleaseStop = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://makenweb.com");
            Process.Start(sInfo);
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            string[] theSerialPortNames = System.IO.Ports.SerialPort.GetPortNames();
            foreach(string SerItem in theSerialPortNames){
                comboBox1.Items.Add(SerItem);
            }
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string theSelectedPort = comboBox1.SelectedItem.ToString();
            serialPort1.PortName = theSelectedPort;
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox1.Text  = "";
                serialPort1.Open();
                //this.Width = 1388;
            }else{
                serialPort1.Close();
                //this.Width = 1038;
            }
        }

        public void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
             RxString = serialPort1.ReadLine();
             SetText(RxString);
        }

        public void updateText1(){
            textBox1.Text = RxString + "/n" + textBox1.Text;
        }

        public void SerialWrite(byte[] outData)
        {
            byte[] outDataByte = new byte[1];
            outDataByte[0] = outData[3];
            serialPort1.Write(outData, 0, 1);
        }

        delegate void SetTextCallback(string text);

        private void SetText(string text)
        {
            if (this.textBox1.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            } else{
                this.textBox1.Text = text + textBox1.Text;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton5_Click(object sender, EventArgs e)         //Callibrate
        {
            double x = 0;
            double y = 0;
            double z = 0;

            //home pos (10,10)
            x = 10;
            y = 10;

            //Draw Square
            for ( x = 10; x < 140; x++)
            {
                get_angles(x, y);
                get_xy();
                label6.Text = theta1.ToString();
                label7.Text = theta2.ToString();
                label13.Text = computedX.ToString();
                label14.Text = computedY.ToString();
                trackBar1.Value = (int)(theta1 * 100.0);
                trackBar2.Value = (int)((180 - Math.Abs(theta2)) * 100.0);
                drawARM(trackBar1.Value / 100.0, trackBar2.Value / 100.0, true);
            }
            for (y = 10; y < 140; y++)
            {
                get_angles(x, y);
                get_xy();
                label6.Text = theta1.ToString();
                label7.Text = theta2.ToString();
                label13.Text = computedX.ToString();
                label14.Text = computedY.ToString();
                trackBar1.Value = (int)(theta1 * 100.0);
                trackBar2.Value = (int)((180 - Math.Abs(theta2)) * 100.0);
                drawARM(trackBar1.Value / 100.0, trackBar2.Value / 100.0, true);
            }
            for (x = 140; x > 10; x--)
            {
                get_angles(x, y);
                get_xy();
                label6.Text = theta1.ToString();
                label7.Text = theta2.ToString();
                label13.Text = computedX.ToString();
                label14.Text = computedY.ToString();
                trackBar1.Value = (int)(theta1 * 100.0);
                trackBar2.Value = (int)((180 - Math.Abs(theta2)) * 100.0);
                drawARM(trackBar1.Value / 100.0, trackBar2.Value / 100.0, true);
            }
            for (y = 140; y > 10; y--)
            {
                get_angles(x, y);
                get_xy();
                label6.Text = theta1.ToString();
                label7.Text = theta2.ToString();
                label13.Text = computedX.ToString();
                label14.Text = computedY.ToString();
                trackBar1.Value = (int)(theta1 * 100.0);
                trackBar2.Value = (int)((180 - Math.Abs(theta2)) * 100.0);
                drawARM(trackBar1.Value / 100.0, trackBar2.Value / 100.0, true);
            }

            //pen is back at home (10,10)

            //Draw cross
            for (x = 10; x < 140; x++)
            {
                y = x;
                get_angles(x, y);
                get_xy();
                label6.Text = theta1.ToString();
                label7.Text = theta2.ToString();
                label13.Text = computedX.ToString();
                label14.Text = computedY.ToString();
                trackBar1.Value = (int)(theta1 * 100.0);
                trackBar2.Value = (int)((180 - Math.Abs(theta2)) * 100.0);
                drawARM(trackBar1.Value / 100.0, trackBar2.Value / 100.0, true);
            }

            ReturnHome();
        }

        public void ReturnHome()
        {
            double x = 10;
            double y = 10;
            get_angles(x, y);
            get_xy();
            label6.Text = theta1.ToString();
            label7.Text = theta2.ToString();
            label13.Text = computedX.ToString();
            label14.Text = computedY.ToString();
            trackBar1.Value = (int)(theta1 * 100.0);
            trackBar2.Value = (int)((180 - Math.Abs(theta2)) * 100.0);
            drawARM(trackBar1.Value / 100.0, trackBar2.Value / 100.0, false);
        }


        private void button5_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string mFile = saveFileDialog1.FileName;
                System.IO.StreamWriter file = new System.IO.StreamWriter(mFile);

                file.WriteLine("G90");      //Absolute programming
                file.WriteLine("G21");      //Programming in (mm)
                file.WriteLine("G0 X" + Xarr[0] + " Y" + Yarr[0]);  //Start position

                for (int t = 0; t < CountArr; t++)
                {
                    if ((Xarr[t] == 0) && (Yarr[t] == 0))
                    {
                        if (Zarr[t] == 1)                               //Spindle Start
                        {
                            file.WriteLine("G0 X" + Xarr[t + 1] + " Y" + Yarr[t + 1]);
                            file.WriteLine("M03");
                        }
                        if (Zarr[t] == 0) { file.WriteLine("M05"); }   //Spindle Stop
                    }
                    else
                    {
                        file.WriteLine("G01 X" + Xarr[t] + " Y" + Yarr[t]);
                    }
                }
                file.WriteLine("M02"); //End of Program
                file.Close();
            }
        }

        public void ClearArrays()
        {
            for (int t = 0; t < 10000; t++)
            {
                Xarr[t] = 0;
                Yarr[t] = 0;
                Zarr[t] = 0;
            }
            CountArr = 0;
            label18.Text = "0 of 10,000";
        }

    }
}
