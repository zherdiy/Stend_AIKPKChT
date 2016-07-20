using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace StendAIKPKChT
{
    public partial class Form1 : Form
    {
        /* variables */
        static bool isConnected, isStartSost, isStartCoord;
        int port = 1234;
        public Form1()
        {
            InitializeComponent();
            String[] mySostList = new String[] { "запрос т.зап. АЦП", "запрос т. остановки", "запрос т. мал.хода ", "мл.бит датчика коорд.", " ст.бит датчика коорд.", "разреш. автообнуления",
                     "ЭВМ/Местное", "готовность ATV", "авария ATV", "блокировка ", "упор справа", "упор слева/конц.нуля", "перемещение вправо", "перемещение влево",
                     "малый ход", "дв.каретка", "дв.угла-места", "дв.перемещения", "дв.азимута", "дв.фокал", "дв.подъем", "дв.колонна", "дв.каретка"};
            chLBSost.Items.AddRange(mySostList); // add list to checkedListBox1
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            isConnected = true;
            tboxIP.Text = "10.0.86.202";

        }

        private void labelSensor1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxDrive_Enter(object sender, EventArgs e)
        {

        }



        private void radioButtonMotorColonna_CheckedChanged(object sender, EventArgs e)
        {
   
        }

        private void radioButtonMotorKaretka_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonTopLeft_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonBottomRight_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonColonna_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonKaretka_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonIP_Click(object sender, EventArgs e)
        {
            try
            {
                TcpClient client = new TcpClient();
                client.Connect(tboxIP.Text, port);
                NetworkStream stream = client.GetStream(); ;
                isConnected = true;
                btnIP.Text = "Disconnect";
                MessageBox.Show("Success connection to " + tboxIP.Text);
            }
            catch
            {
                MessageBox.Show("No connection to " + tboxIP.Text);
                isConnected = false;
            }
    
        }

        private void btnSost_Click(object sender, EventArgs e)
        {
            if (!isStartSost)
            {
                isStartSost = true;
                btnSost.Text = "STOP";
                timerSost.Start();
            }
            else
            {
                isStartSost = false;
                btnSost.Text = "START";
                timerSost.Stop();
                foreach (Int32 i in chLBSost.CheckedIndices)
                {
                    chLBSost.SetItemChecked(i, false);
                }
            }
        }
        
        private void timerSost_Tick(object sender, EventArgs e)
        {
            /*if (checkBox1.Checked)
            {
                chLBSost.SetItemChecked(0, true);
            }*/

            //MessageBox.Show("Refresh PLIS&ATV condition");

        }

        

        private void btnStartCoord_Click(object sender, EventArgs e)
        {
            if (!isStartCoord)
            {
                isStartCoord = true;
                btnStartCoord.Text = "STOP";
                /* code */    // new query to get the coordinate in circle
                
                /*timerCoord.Start(); 
                //wdCoord = 0;
                isGotCoord = false; */
            }
            else
            {
                isStartCoord = false;
                btnStartCoord.Text = "START";
                /* code */   // new query to stop getting coordinate in circle

                //timerCoord.Stop();   
            }
        }

        private void btnCleareCoord_Click(object sender, EventArgs e)
        {
            tboxCoord.Clear();
        }

        private void btnCoordSost_Click(object sender, EventArgs e)
        {
            int data = 0;
            if (rbtnColonna.Checked)      
                data &= 0x0C;
            if (rbtnKaretka.Checked)      
                data |= 0x01;
            if (chBoxPermitClear.Checked) 
            {
                data |= 0x04;
            } 
            else 
            {
                data &= 0xFB;
            }
            if (chBoxCoordClear.Checked) 
            {
                data |= 0x08;
            } 
            else 
            {
                data &= 0xF7;
            }
            /* code */ // send data byte 
            label8.Text = data.ToString("D");
            //label8.Text = Convert.ToString(data);

        }


    }
}
