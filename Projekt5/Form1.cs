using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            operationBox.SelectedIndex = 0;
            comboBoxMoveTo.Enabled = false;
            comboBoxOperand1.SelectedIndex = 0;
            comboBoxOperand2.SelectedIndex = 0;

        }

        private void writeActiveToRegister(ref Label labelRegisterL, ref Label labelRegisterH, ref string registerActiveL, ref string registerDestinationL, ref string registerActiveH, ref string registerDestinationH)
        {
            registerDestinationL = registerActiveL;
            registerDestinationH = registerActiveH;
            labelRegisterL.Text = registerDestinationL;
            labelRegisterH.Text = registerDestinationH;

        }

        private void changeStateActive(ref RadioButton buttonActive, int index, ref Label labelActive, ref string register)
        {
            char[] ch = register.ToCharArray();
            
            if (buttonActive.Checked)
            {
                ch[index] = '0';
            }
            else
            {
                ch[index] = '1';
            }
            register = new string(ch);
            labelActive.Text = register;
           
        }
        public void checkInstant()
        {
            char[] chH = RegisterInH.ToCharArray();
            char[] chL = RegisterInL.ToCharArray();
            if (chH[0] == '1')
            {
                InstantbuttonNo15s1.Checked = true;
            }
            else
            {
                InstantbuttonNo15s0.Checked = true;
            }
            if (chH[1] == '1')
            {
                InstantbuttonNo14s1.Checked = true;
            }
            else
            {
                InstantbuttonNo14s0.Checked = true;
            }
            if (chH[2] == '1')
            {
                InstantbuttonNo13s1.Checked = true;
            }
            else
            {
                InstantbuttonNo13s0.Checked = true;
            }
            if (chH[3] == '1')
            {
                InstantbuttonNo12s1.Checked = true;
            }
            else
            {
                InstantbuttonNo12s0.Checked = true;
            }
            if (chH[4] == '1')
            {
                InstantbuttonNo11s1.Checked = true;
            }
            else
            {
                InstantbuttonNo11s0.Checked = true;
            }
            if (chH[5] == '1')
            {
                InstantbuttonNo10s1.Checked = true;
            }
            else
            {
                InstantbuttonNo10s0.Checked = true;
            }
            if (chH[6] == '1')
            {
                InstantbuttonNo9s1.Checked = true;
            }
            else
            {
                InstantbuttonNo9s0.Checked = true;
            }
            if (chH[7] == '1')
            {
                InstantbuttonNo8s1.Checked = true;
            }
            else
            {
                InstantbuttonNo8s0.Checked = true;
            }
            if (chL[0] == '1')
            {
                InstantbuttonNo7s1.Checked = true;
            }
            else
            {
                InstantbuttonNo7s0.Checked = true;
            }
            if (chL[1] == '1')
            {
                InstantbuttonNo6s1.Checked = true;
            }
            else
            {
                InstantbuttonNo6s0.Checked = true;
            }
            if (chL[2] == '1')
            {
                InstantbuttonNo5s1.Checked = true;
            }
            else
            {
                InstantbuttonNo5s0.Checked = true;
            }
            if (chL[3] == '1')
            {
                InstantbuttonNo4s1.Checked = true;
            }
            else
            {
                InstantbuttonNo4s0.Checked = true;
            }
            if (chL[4] == '1')
            {
                InstantbuttonNo3s1.Checked = true;
            }
            else
            {
                InstantbuttonNo3s0.Checked = true;
            }
            if (chL[5] == '1')
            {
                InstantbuttonNo2s1.Checked = true;
            }
            else
            {
                InstantbuttonNo2s0.Checked = true;
            }
            if (chL[6] == '1')
            {
                InstantbuttonNo1s1.Checked = true;
            }
            else
            {
                InstantbuttonNo1s0.Checked = true;
            }
            if (chL[7] == '1')
            {
                InstantbuttonNo0s1.Checked = true;
            }
            else
            {
                InstantbuttonNo0s0.Checked = true;
            }

        }


        private void AXbuttonNo15s0_CheckedChanged(object sender, EventArgs e)
        {
            changeStateActive(ref AXbuttonNo15s0, 0, ref AHActive, ref AH);
        }

        private void AXbuttonNo14s1_CheckedChanged(object sender, EventArgs e)
        {
            changeStateActive(ref AXbuttonNo14s0, 1, ref AHActive, ref AH);
        }

        private void AXbuttonNo13s1_CheckedChanged(object sender, EventArgs e)
        {
            changeStateActive(ref AXbuttonNo13s0, 2, ref AHActive, ref AH);
        }

        private void AXbuttonNo12s1_CheckedChanged(object sender, EventArgs e)
        {
            changeStateActive(ref AXbuttonNo12s0, 3, ref AHActive, ref AH);
        }

        private void AXbuttonNo11s1_CheckedChanged(object sender, EventArgs e)
        {
            changeStateActive(ref AXbuttonNo11s0, 4, ref AHActive, ref AH);
        }

        private void AXbuttonNo10s1_CheckedChanged(object sender, EventArgs e)
        {
            changeStateActive(ref AXbuttonNo10s0, 5, ref AHActive, ref AH);
        }

        private void AXbuttonNo9s1_CheckedChanged(object sender, EventArgs e)
        {
            changeStateActive(ref AXbuttonNo9s0, 6, ref AHActive, ref AH);
        }

        private void AXbuttonNo8s1_CheckedChanged(object sender, EventArgs e)
        {
            changeStateActive(ref AXbuttonNo8s0, 7, ref AHActive, ref AH);
        }

        private void AXbuttonNo7s1_CheckedChanged(object sender, EventArgs e)
        {
            changeStateActive(ref AXbuttonNo7s0, 0, ref ALActive, ref AL);
        }

        private void AXbuttonNo6s1_CheckedChanged(object sender, EventArgs e)
        {
            changeStateActive(ref AXbuttonNo6s0, 1, ref ALActive, ref AL);
        }

        private void AXbuttonNo5s1_CheckedChanged(object sender, EventArgs e)
        {
            changeStateActive(ref AXbuttonNo5s0, 2, ref ALActive, ref AL);
        }

        private void AXbuttonNo4s1_CheckedChanged(object sender, EventArgs e)
        {
            changeStateActive(ref AXbuttonNo4s0, 3, ref ALActive, ref AL);
        }

        private void AXbuttonNo3s1_CheckedChanged(object sender, EventArgs e)
        {
            changeStateActive(ref AXbuttonNo3s0, 4, ref ALActive, ref AL);
        }

        private void AXbuttonNo2s1_CheckedChanged(object sender, EventArgs e)
        {
            changeStateActive(ref AXbuttonNo2s0, 5, ref ALActive, ref AL);
        }

        private void AXbuttonNo1s1_CheckedChanged(object sender, EventArgs e)
        {
            changeStateActive(ref AXbuttonNo1s0, 6, ref ALActive, ref AL);
        }

        private void AXbuttonNo0s1_CheckedChanged(object sender, EventArgs e)
        {
            changeStateActive(ref AXbuttonNo0s0, 7, ref ALActive, ref AL);
        }

        private void BXbuttonNo15s1_CheckedChanged(object sender, EventArgs e)
        {
            changeStateActive(ref BXbuttonNo15s0, 0, ref BHActive, ref BH);
        }

        private void BXbuttonNo14s1_CheckedChanged(object sender, EventArgs e)
        {
            changeStateActive(ref BXbuttonNo14s0, 1, ref BHActive, ref BH);
        }

        private void BXbuttonNo13s1_CheckedChanged(object sender, EventArgs e)
        {
            changeStateActive(ref BXbuttonNo13s0, 2, ref BHActive, ref BH);
        }

        private void BXbuttonNo12s1_CheckedChanged(object sender, EventArgs e)
        {
            changeStateActive(ref BXbuttonNo12s0, 3, ref BHActive, ref BH);
        }

        private void BXbuttonNo11s1_CheckedChanged(object sender, EventArgs e)
        {
            changeStateActive(ref BXbuttonNo11s0, 4, ref BHActive, ref BH);
        }

        private void BXbuttonNo10s1_CheckedChanged(object sender, EventArgs e)
        {
            changeStateActive(ref BXbuttonNo10s0, 5, ref BHActive, ref BH);
        }

        private void BXbuttonNo9s1_CheckedChanged(object sender, EventArgs e)
        {
            changeStateActive(ref BXbuttonNo9s0, 6, ref BHActive, ref BH);
        }

        private void BXbuttonNo8s1_CheckedChanged(object sender, EventArgs e)
        {
            changeStateActive(ref BXbuttonNo8s0, 7, ref BHActive, ref BH);
        }

        private void BXbuttonNo7s1_CheckedChanged(object sender, EventArgs e)
        {
            changeStateActive(ref BXbuttonNo7s0, 0, ref BLActive, ref BL);
        }

        private void BXbuttonNo6s1_CheckedChanged(object sender, EventArgs e)
        {
            changeStateActive(ref BXbuttonNo6s0, 1, ref BLActive, ref BL);
        }

        private void BXbuttonNo5s1_CheckedChanged(object sender, EventArgs e)
        {
            changeStateActive(ref BXbuttonNo5s0, 2, ref BLActive, ref BL);
        }

        private void BXbuttonNo4s1_CheckedChanged(object sender, EventArgs e)
        {
            changeStateActive(ref BXbuttonNo4s0, 3, ref BLActive, ref BL);
        }

        private void BXbuttonNo3s1_CheckedChanged(object sender, EventArgs e)
        {
            changeStateActive(ref BXbuttonNo3s0, 4, ref BLActive, ref BL);
        }

        private void BXbuttonNo2s1_CheckedChanged(object sender, EventArgs e)
        {
            changeStateActive(ref BXbuttonNo2s0, 5, ref BLActive, ref BL);
        }

        private void BXbuttonNo1s1_CheckedChanged(object sender, EventArgs e)
        {
            changeStateActive(ref BXbuttonNo1s0, 6, ref BLActive, ref BL);
        }

        private void BXbuttonNo0s1_CheckedChanged(object sender, EventArgs e)
        {
            changeStateActive(ref BXbuttonNo0s0, 7, ref BLActive, ref BL);
        }

        private void CXbuttonNo15s1_CheckedChanged(object sender, EventArgs e)
        {
            changeStateActive(ref CXbuttonNo15s0, 0, ref CHActive, ref CH);
        }

        private void CXbuttonNo14s1_CheckedChanged(object sender, EventArgs e)
        {
            changeStateActive(ref CXbuttonNo14s0, 1, ref CHActive, ref CH);
        }

        private void CXbuttonNo13s1_CheckedChanged(object sender, EventArgs e)
        {
            changeStateActive(ref CXbuttonNo13s0, 2, ref CHActive, ref CH);
        }

        private void CXbuttonNo12s1_CheckedChanged(object sender, EventArgs e)
        {
            changeStateActive(ref CXbuttonNo12s0, 3, ref CHActive, ref CH);
        }

        private void CXbuttonNo11s1_CheckedChanged(object sender, EventArgs e)
        {
            changeStateActive(ref CXbuttonNo11s0, 4, ref CHActive, ref CH);
        }

        private void CXbuttonNo10s1_CheckedChanged(object sender, EventArgs e)
        {
            changeStateActive(ref CXbuttonNo10s0, 5, ref CHActive, ref CH);
        }

        private void CXbuttonNo9s1_CheckedChanged(object sender, EventArgs e)
        {
            changeStateActive(ref CXbuttonNo9s0, 6, ref CHActive, ref CH);
        }

        private void CXbuttonNo8s1_CheckedChanged(object sender, EventArgs e)
        {
            changeStateActive(ref CXbuttonNo8s0, 7, ref CHActive, ref CH);
        }

        private void CXbuttonNo7s1_CheckedChanged(object sender, EventArgs e)
        {
            changeStateActive(ref CXbuttonNo7s0, 0, ref CLActive, ref CL);
        }

        private void CXbuttonNo6s1_CheckedChanged(object sender, EventArgs e)
        {
            changeStateActive(ref CXbuttonNo6s0, 1, ref CLActive, ref CL);
        }

        private void CXbuttonNo5s1_CheckedChanged(object sender, EventArgs e)
        {
            changeStateActive(ref CXbuttonNo5s0, 2, ref CLActive, ref CL);
        }

        private void CXbuttonNo4s1_CheckedChanged(object sender, EventArgs e)
        {
            changeStateActive(ref CXbuttonNo4s0, 3, ref CLActive, ref CL);
        }

        private void CXbuttonNo3s1_CheckedChanged(object sender, EventArgs e)
        {
            changeStateActive(ref CXbuttonNo3s0, 4, ref CLActive, ref CL);
        }

        private void CXbuttonNo2s1_CheckedChanged(object sender, EventArgs e)
        {
            changeStateActive(ref CXbuttonNo2s0, 5, ref CLActive, ref CL);
        }

        private void CXbuttonNo1s1_CheckedChanged(object sender, EventArgs e)
        {
            changeStateActive(ref CXbuttonNo1s0, 6, ref CLActive, ref CL);
        }

        private void CXbuttonNo0s1_CheckedChanged(object sender, EventArgs e)
        {
            changeStateActive(ref CXbuttonNo0s0, 7, ref CLActive, ref CL);
        }

        private void DXbuttonNo15s1_CheckedChanged(object sender, EventArgs e)
        {
            changeStateActive(ref DXbuttonNo15s0, 0, ref DHActive, ref DH);
        }

        private void DXbuttonNo14s1_CheckedChanged(object sender, EventArgs e)
        {
            changeStateActive(ref DXbuttonNo14s0, 1, ref DHActive, ref DH);
        }

        private void DXbuttonNo13s1_CheckedChanged(object sender, EventArgs e)
        {
            changeStateActive(ref DXbuttonNo13s0, 2, ref DHActive, ref DH);
        }

        private void DXbuttonNo12s1_CheckedChanged(object sender, EventArgs e)
        {
            changeStateActive(ref DXbuttonNo12s0, 3, ref DHActive, ref DH);
        }

        private void DXbuttonNo11s1_CheckedChanged(object sender, EventArgs e)
        {
            changeStateActive(ref DXbuttonNo11s0, 4, ref DHActive, ref DH);
        }

        private void DXbuttonNo10s1_CheckedChanged(object sender, EventArgs e)
        {
            changeStateActive(ref DXbuttonNo10s0, 5, ref DHActive, ref DH);
        }

        private void DXbuttonNo9s1_CheckedChanged(object sender, EventArgs e)
        {
            changeStateActive(ref DXbuttonNo9s0, 6, ref DHActive, ref DH);
        }

        private void DXbuttonNo8s1_CheckedChanged(object sender, EventArgs e)
        {
            changeStateActive(ref DXbuttonNo8s0, 7, ref DHActive, ref DH);
        }

        private void DXbuttonNo7s1_CheckedChanged(object sender, EventArgs e)
        {
            changeStateActive(ref DXbuttonNo7s0, 0, ref DLActive, ref DL);
        }

        private void DXbuttonNo6s1_CheckedChanged(object sender, EventArgs e)
        {
            changeStateActive(ref DXbuttonNo6s0, 1, ref DLActive, ref DL);
        }

        private void DXbuttonNo5s1_CheckedChanged(object sender, EventArgs e)
        {
            changeStateActive(ref DXbuttonNo5s0, 2, ref DLActive, ref DL);
        }

        private void DXbuttonNo4s1_CheckedChanged(object sender, EventArgs e)
        {
            changeStateActive(ref DXbuttonNo4s0, 3, ref DLActive, ref DL);
        }

        private void DXbuttonNo3s1_CheckedChanged(object sender, EventArgs e)
        {
            changeStateActive(ref DXbuttonNo3s0, 4, ref DLActive, ref DL);
        }

        private void DXbuttonNo2s1_CheckedChanged(object sender, EventArgs e)
        {
            changeStateActive(ref DXbuttonNo2s0, 5, ref DLActive, ref DL);
        }

        private void DXbuttonNo1s1_CheckedChanged(object sender, EventArgs e)
        {
            changeStateActive(ref DXbuttonNo1s0, 6, ref DLActive, ref DL);
        }

        private void DXbuttonNo0s1_CheckedChanged(object sender, EventArgs e)
        {
            changeStateActive(ref DXbuttonNo0s0, 7, ref DLActive, ref DL);
        }


        private void buttonWriteAX_Click(object sender, EventArgs e)
        {
            writeActiveToRegister(ref labelAL, ref labelAH, ref AL, ref RegisterAL, ref AH, ref RegisterAH);
        }

        private void buttonWriteBX_Click(object sender, EventArgs e)
        {
            writeActiveToRegister(ref labelBL, ref labelBH, ref BL, ref RegisterBL, ref BH, ref RegisterBH);
        }

        private void buttonWriteCX_Click(object sender, EventArgs e)
        {
            writeActiveToRegister(ref labelCL, ref labelCH, ref CL, ref RegisterCL, ref CH, ref RegisterCH);
        }

        private void buttonWriteDX_Click(object sender, EventArgs e)
        {
            writeActiveToRegister(ref labelDL, ref labelDH, ref DL, ref RegisterDL, ref DH, ref RegisterDH);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void InstantbuttonNo15s1_CheckedChanged(object sender, EventArgs e)
        {
            changeStateActive(ref InstantbuttonNo15s0, 0, ref labelInH, ref RegisterInH);
        }

        private void InstantbuttonNo14s1_CheckedChanged(object sender, EventArgs e)
        {
            changeStateActive(ref InstantbuttonNo14s0, 1, ref labelInH, ref RegisterInH);
        }

        private void InstantbuttonNo13s1_CheckedChanged(object sender, EventArgs e)
        {
            changeStateActive(ref InstantbuttonNo13s0, 2, ref labelInH, ref RegisterInH);
        }

        private void InstantbuttonNo12s1_CheckedChanged(object sender, EventArgs e)
        {
            changeStateActive(ref InstantbuttonNo12s0, 3, ref labelInH, ref RegisterInH);
        }

        private void InstantbuttonNo11s1_CheckedChanged(object sender, EventArgs e)
        {
            changeStateActive(ref InstantbuttonNo11s0, 4, ref labelInH, ref RegisterInH);
        }

        private void InstantbuttonNo10s1_CheckedChanged(object sender, EventArgs e)
        {
            changeStateActive(ref InstantbuttonNo10s0, 5, ref labelInH, ref RegisterInH);
        }

        private void InstantbuttonNo9s1_CheckedChanged(object sender, EventArgs e)
        {
            changeStateActive(ref InstantbuttonNo9s0, 6, ref labelInH, ref RegisterInH);
        }

        private void InstantbuttonNo8s1_CheckedChanged(object sender, EventArgs e)
        {
            changeStateActive(ref InstantbuttonNo8s0, 7, ref labelInH, ref RegisterInH);
        }

        private void InstantbuttonNo7s1_CheckedChanged(object sender, EventArgs e)
        {
            changeStateActive(ref InstantbuttonNo7s0, 0, ref labelInL, ref RegisterInL);
        }

        private void InstantbuttonNo6s1_CheckedChanged(object sender, EventArgs e)
        {
            changeStateActive(ref InstantbuttonNo6s0, 1, ref labelInL, ref RegisterInL);
        }

        private void InstantbuttonNo5s1_CheckedChanged(object sender, EventArgs e)
        {
            changeStateActive(ref InstantbuttonNo5s0, 2, ref labelInL, ref RegisterInL);
        }

        private void InstantbuttonNo4s1_CheckedChanged(object sender, EventArgs e)
        {
            changeStateActive(ref InstantbuttonNo4s0, 3, ref labelInL, ref RegisterInL);
        }

        private void InstantbuttonNo3s1_CheckedChanged(object sender, EventArgs e)
        {
            changeStateActive(ref InstantbuttonNo3s0, 4, ref labelInL, ref RegisterInL);
        }

        private void InstantbuttonNo2s1_CheckedChanged(object sender, EventArgs e)
        {
            changeStateActive(ref InstantbuttonNo2s0, 5, ref labelInL, ref RegisterInL);
        }

        private void InstantbuttonNo1s1_CheckedChanged(object sender, EventArgs e)
        {
            changeStateActive(ref InstantbuttonNo1s0, 6, ref labelInL, ref RegisterInL);
        }

        private void InstantbuttonNo0s1_CheckedChanged(object sender, EventArgs e)
        {
            changeStateActive(ref InstantbuttonNo0s0, 7, ref labelInL, ref RegisterInL);
        }

        private void operationBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (operationBox.SelectedIndex == 0)
            {
                comboBoxMoveTo.SelectedItem = null;
                comboBoxMoveTo.Enabled = false;
                operation = "MOV";
            }
            else
            {
                comboBoxMoveTo.Enabled = true;
            }
            if (operationBox.SelectedIndex == 1)
            {
                operation = "ADD";
                comboBoxMoveTo.SelectedIndex = 0;
            }
            if (operationBox.SelectedIndex == 2)
            {
                operation = "SUB";
                comboBoxMoveTo.SelectedIndex = 0;
            }
        }
        public void operationMOV(ref string registerH, ref string registerL, ref Label labelH, ref Label labelL)
        {
            if (programWorking)
            {
                if (programOperand2 == "A")
                {
                    RegisterAH = registerH;
                    RegisterAL = registerL;
                    labelAH.Text = registerH;
                    labelAL.Text = registerL;
                }
                else if (programOperand2 == "B")
                {
                    RegisterBH = registerH;
                    RegisterBL = registerL;
                    labelBH.Text = registerH;
                    labelBL.Text = registerL;
                }
                else if (programOperand2 == "C")
                {
                    RegisterCH = registerH;
                    RegisterCL = registerL;
                    labelCH.Text = registerH;
                    labelCL.Text = registerL;
                }
                else if (programOperand2 == "D")
                {
                    RegisterDH = registerH;
                    RegisterDL = registerL;
                    labelDH.Text = registerH;
                    labelDL.Text = registerL;
                }
                else if (programOperand2 == "I")
                {
                    RegisterInH = registerH;
                    RegisterInL = registerL;
                    labelInH.Text = registerH;
                    labelInL.Text = registerL;
                }
            }
            else
            {
                if (operand2 == "A")
                {
                    RegisterAH = registerH;
                    RegisterAL = registerL;
                    labelAH.Text = registerH;
                    labelAL.Text = registerL;
                }
                else if (operand2 == "B")
                {
                    RegisterBH = registerH;
                    RegisterBL = registerL;
                    labelBH.Text = registerH;
                    labelBL.Text = registerL;
                }
                else if (operand2 == "C")
                {
                    RegisterCH = registerH;
                    RegisterCL = registerL;
                    labelCH.Text = registerH;
                    labelCL.Text = registerL;
                }
                else if (operand2 == "D")
                {
                    RegisterDH = registerH;
                    RegisterDL = registerL;
                    labelDH.Text = registerH;
                    labelDL.Text = registerL;
                }
                else if (operand2 == "I")
                {
                    RegisterInH = registerH;
                    RegisterInL = registerL;
                    labelInH.Text = registerH;
                    labelInL.Text = registerL;
                }
            }
            
            registerH = "00000000";
            registerL = "00000000";
            labelH.Text = registerH;
            labelL.Text = registerL;
        }
        public void operationSUB(ref string registerOperand1L, ref string registerOperand1H, ref Label labelL, ref Label labelH)
        {
            helpStringBinary = registerOperand1H + registerOperand1L;
            helpNumber1 = Convert.ToInt32(helpStringBinary, 2);


            if (programWorking)
            {
                if (programOperand2 == "A")
                {
                    helpStringBinary = RegisterAH + RegisterAL;
                    helpNumber2 = Convert.ToInt32(helpStringBinary, 2);
                    /*
                    RegisterAH = "00000000";
                    RegisterAL = "00000000"; //zerowanie operandów po dodaniu
                    labelAH.Text = RegisterAH;
                    labelAL.Text = RegisterAL;
                    */
                }
                else if (programOperand2 == "B")
                {
                    helpStringBinary = RegisterBH + RegisterBL;
                    helpNumber2 = Convert.ToInt32(helpStringBinary, 2);
                    /*
                    RegisterBH = "00000000";
                    RegisterBL = "00000000"; //zerowanie operandów po dodaniu
                    labelBH.Text = RegisterBH;
                    labelBL.Text = RegisterBL;
                    */
                }
                else if (programOperand2 == "C")
                {
                    helpStringBinary = RegisterCH + RegisterCL;
                    helpNumber2 = Convert.ToInt32(helpStringBinary, 2);
                    /*
                    RegisterCH = "00000000";
                    RegisterCL = "00000000"; //zerowanie operandów po dodaniu
                    labelCH.Text = RegisterCH;
                    labelCL.Text = RegisterCL;
                    */
                }
                else if (programOperand2 == "D")
                {
                    helpStringBinary = RegisterDH + RegisterDL;
                    helpNumber2 = Convert.ToInt32(helpStringBinary, 2);
                    /*
                    RegisterDH = "00000000";
                    RegisterDL = "00000000"; //zerowanie operandów po dodaniu
                    labelDH.Text = RegisterDH;
                    labelDL.Text = RegisterDL;
                    */
                }
                else if (programOperand2 == "I")
                {
                    helpStringBinary = RegisterInH + RegisterInL;
                    helpNumber2 = Convert.ToInt32(helpStringBinary, 2);
                    /*
                    RegisterInH = "00000000";
                    RegisterInL = "00000000"; //zerowanie operandów po dodaniu
                    labelInH.Text = RegisterInH;
                    labelInL.Text = RegisterInL;
                    */
                }
            }
            else
            {
                if (operand2 == "A")
                {
                    helpStringBinary = RegisterAH + RegisterAL;
                    helpNumber2 = Convert.ToInt32(helpStringBinary, 2);
                    /*
                    RegisterAH = "00000000";
                    RegisterAL = "00000000"; //zerowanie operandów po dodaniu
                    labelAH.Text = RegisterAH;
                    labelAL.Text = RegisterAL;
                    */
                }
                else if (operand2 == "B")
                {
                    helpStringBinary = RegisterBH + RegisterBL;
                    helpNumber2 = Convert.ToInt32(helpStringBinary, 2);
                    /*
                    RegisterBH = "00000000";
                    RegisterBL = "00000000"; //zerowanie operandów po dodaniu
                    labelBH.Text = RegisterBH;
                    labelBL.Text = RegisterBL;
                    */
                }
                else if (operand2 == "C")
                {
                    helpStringBinary = RegisterCH + RegisterCL;
                    helpNumber2 = Convert.ToInt32(helpStringBinary, 2);
                    /*
                    RegisterCH = "00000000";
                    RegisterCL = "00000000"; //zerowanie operandów po dodaniu
                    labelCH.Text = RegisterCH;
                    labelCL.Text = RegisterCL;
                    */
                }
                else if (operand2 == "D")
                {
                    helpStringBinary = RegisterDH + RegisterDL;
                    helpNumber2 = Convert.ToInt32(helpStringBinary, 2);
                    /*
                    RegisterDH = "00000000";
                    RegisterDL = "00000000"; //zerowanie operandów po dodaniu
                    labelDH.Text = RegisterDH;
                    labelDL.Text = RegisterDL;
                    */
                }
                else if (operand2 == "I")
                {
                    helpStringBinary = RegisterInH + RegisterInL;
                    helpNumber2 = Convert.ToInt32(helpStringBinary, 2);
                    /*
                    RegisterInH = "00000000";
                    RegisterInL = "00000000"; //zerowanie operandów po dodaniu
                    labelInH.Text = RegisterInH;
                    labelInL.Text = RegisterInL;
                    */
                }
            }
            helpNumber1 -= helpNumber2;
            if (helpNumber1 >= 0)
            {

                helpStringBinary = Convert.ToString(helpNumber1, 2);
                while (helpStringBinary.Length < 16)
                {
                    helpStringBinary = "0" + helpStringBinary;
                }
                while (helpStringBinary.Length > 16)
                {
                    helpStringBinary = helpStringBinary.Remove(0, 1);
                }
                for (int i = 0; i < 16; i++)
                {
                    if (i < 8)
                    {
                        helpStringH += helpStringBinary[i];
                    }
                    else
                    {
                        helpStringL += helpStringBinary[i];
                    }
                }
                moveToFunction();

                /*
                registerOperand1H = "0000000";
                registerOperand1L = "0000000";
                labelH.Text = registerOperand1H; //zerowanie operandów po dodaniu
                labelL.Text = registerOperand1L;
                */
            }
            else
            {
                helpStringH = "00000000";
                helpStringL = "00000000";
                moveToFunction();
            }
            helpStringH = null;
            helpStringL = null;
        }
        public void operationADD(ref string registerOperand1L, ref string registerOperand1H, ref Label labelL, ref Label labelH)
        {
            helpStringBinary = registerOperand1H + registerOperand1L;
            helpNumber1 = Convert.ToInt32(helpStringBinary, 2);

            if (programWorking)
            {
                if (programOperand2 == "A")
                {
                    helpStringBinary = RegisterAH + RegisterAL;
                    helpNumber2 = Convert.ToInt32(helpStringBinary, 2);
                    /*
                    RegisterAH = "00000000";
                    RegisterAL = "00000000"; //zerowanie operandów po dodaniu
                    labelAH.Text = RegisterAH;
                    labelAL.Text = RegisterAL;
                    */
                }
                else if (programOperand2 == "B")
                {
                    helpStringBinary = RegisterBH + RegisterBL;
                    helpNumber2 = Convert.ToInt32(helpStringBinary, 2);
                    /*
                    RegisterBH = "00000000";
                    RegisterBL = "00000000"; //zerowanie operandów po dodaniu
                    labelBH.Text = RegisterBH;
                    labelBL.Text = RegisterBL;
                    */
                }
                else if (programOperand2 == "C")
                {
                    helpStringBinary = RegisterCH + RegisterCL;
                    helpNumber2 = Convert.ToInt32(helpStringBinary, 2);
                    /*
                    RegisterCH = "00000000";
                    RegisterCL = "00000000"; //zerowanie operandów po dodaniu
                    labelCH.Text = RegisterCH;
                    labelCL.Text = RegisterCL;
                    */
                }
                else if (programOperand2 == "D")
                {
                    helpStringBinary = RegisterDH + RegisterDL;
                    helpNumber2 = Convert.ToInt32(helpStringBinary, 2);
                    /*
                    RegisterDH = "00000000";
                    RegisterDL = "00000000"; //zerowanie operandów po dodaniu
                    labelDH.Text = RegisterDH;
                    labelDL.Text = RegisterDL;
                    */
                }
                else if (programOperand2 == "I")
                {
                    helpStringBinary = RegisterInH + RegisterInL;
                    helpNumber2 = Convert.ToInt32(helpStringBinary, 2);
                    /*
                    RegisterInH = "00000000";
                    RegisterInL = "00000000"; //zerowanie operandów po dodaniu
                    labelInH.Text = RegisterInH;
                    labelInL.Text = RegisterInL;
                    */
                }
            }
            else
            {
                if (operand2 == "A")
                {
                    helpStringBinary = RegisterAH + RegisterAL;
                    helpNumber2 = Convert.ToInt32(helpStringBinary, 2);
                    /*
                    RegisterAH = "00000000";
                    RegisterAL = "00000000"; //zerowanie operandów po dodaniu
                    labelAH.Text = RegisterAH;
                    labelAL.Text = RegisterAL;
                    */
                }
                else if (operand2 == "B")
                {
                    helpStringBinary = RegisterBH + RegisterBL;
                    helpNumber2 = Convert.ToInt32(helpStringBinary, 2);
                    /*
                    RegisterBH = "00000000";
                    RegisterBL = "00000000"; //zerowanie operandów po dodaniu
                    labelBH.Text = RegisterBH;
                    labelBL.Text = RegisterBL;
                    */
                }
                else if (operand2 == "C")
                {
                    helpStringBinary = RegisterCH + RegisterCL;
                    helpNumber2 = Convert.ToInt32(helpStringBinary, 2);
                    /*
                    RegisterCH = "00000000";
                    RegisterCL = "00000000"; //zerowanie operandów po dodaniu
                    labelCH.Text = RegisterCH;
                    labelCL.Text = RegisterCL;
                    */
                }
                else if (operand2 == "D")
                {
                    helpStringBinary = RegisterDH + RegisterDL;
                    helpNumber2 = Convert.ToInt32(helpStringBinary, 2);
                    /*
                    RegisterDH = "00000000";
                    RegisterDL = "00000000"; //zerowanie operandów po dodaniu
                    labelDH.Text = RegisterDH;
                    labelDL.Text = RegisterDL;
                    */
                }
                else if (operand2 == "I")
                {
                    helpStringBinary = RegisterInH + RegisterInL;
                    helpNumber2 = Convert.ToInt32(helpStringBinary, 2);
                    /*
                    RegisterInH = "00000000";
                    RegisterInL = "00000000"; //zerowanie operandów po dodaniu
                    labelInH.Text = RegisterInH;
                    labelInL.Text = RegisterInL;
                    */
                }
            }
            helpNumber1 += helpNumber2;
            helpStringBinary = Convert.ToString(helpNumber1, 2);
            while (helpStringBinary.Length < 16)
            {
                helpStringBinary = "0" + helpStringBinary;
            }
            while (helpStringBinary.Length > 16)
            {
                helpStringBinary = helpStringBinary.Remove(0, 1);
            }
            for (int i = 0; i < 16; i++)
            {
                if (i < 8)
                {
                    helpStringH += helpStringBinary[i];
                }
                else
                {
                    helpStringL += helpStringBinary[i];
                }
            }
            moveToFunction();
            helpStringH = null;
            helpStringL = null;
            /*
            registerOperand1H = "0000000";
            registerOperand1L = "0000000";
            labelH.Text = registerOperand1H; //zerowanie operandów po dodaniu
            labelL.Text = registerOperand1L;
            */
        }
        private void moveToFunction()
        {
            if (moveTo == "A")
            {
                RegisterAH = helpStringH;
                RegisterAL = helpStringL;
                labelAH.Text = RegisterAH;
                labelAL.Text = RegisterAL;
            }
            else if (moveTo == "B")
            {
                RegisterBH = helpStringH;
                RegisterBL = helpStringL;
                labelBH.Text = RegisterBH;
                labelBL.Text = RegisterBL;
            }
            else if (moveTo == "C")
            {
                RegisterCH = helpStringH;
                RegisterCL = helpStringL;
                labelCH.Text = RegisterCH;
                labelCL.Text = RegisterCL;
            }
            else if (moveTo == "D")
            {
                RegisterDH = helpStringH;
                RegisterDL = helpStringL;
                labelDH.Text = RegisterDH;
                labelDL.Text = RegisterDL;
            }
            else if (moveTo == "I")
            {
                RegisterInH = helpStringH;
                RegisterInL = helpStringL;
                labelInH.Text = RegisterInH;
                labelInL.Text = RegisterInL;
            }
            checkInstant();
        }
        private void buttonExeOrder_Click(object sender, EventArgs e)
        {
            if (operation == "MOV")
            {
                if (operand1 == operand2) { }
                else if (operand1 == "A")
                {
                    operationMOV(ref RegisterAH, ref RegisterAL, ref labelAH, ref labelAL);
                }
                else if (operand1 == "B")
                {
                    operationMOV(ref RegisterBH, ref RegisterBL, ref labelBH, ref labelBL);
                }
                else if (operand1 == "C")
                {
                    operationMOV(ref RegisterCH, ref RegisterCL, ref labelCH, ref labelCL);
                }
                else if (operand1 == "D")
                {
                    operationMOV(ref RegisterDH, ref RegisterDL, ref labelDH, ref labelDL);
                }
                else if (operand1 == "I")
                {
                    operationMOV(ref RegisterInH, ref RegisterInL, ref labelInH, ref labelInL);
                }
                checkInstant();
            }
            else if (operation == "ADD")
            {
                if (operand1 == "A")
                {
                    operationADD(ref RegisterAL, ref RegisterAH, ref labelAL, ref labelAH);
                }
                else if (operand1 == "B")
                {
                    operationADD(ref RegisterBL, ref RegisterBH, ref labelBL, ref labelBH);
                }
                else if (operand1 == "C")
                {
                    operationADD(ref RegisterCL, ref RegisterCH, ref labelCL, ref labelCH);
                }
                else if (operand1 == "D")
                {
                    operationADD(ref RegisterDL, ref RegisterDH, ref labelDL, ref labelDH);
                }
                else if (operand1 == "I")
                {
                    operationADD(ref RegisterInL, ref RegisterInH, ref labelInL, ref labelInH);
                }
                checkInstant();
            }
            else if (operation == "SUB")
            {
                if (operand1 == "A")
                {
                    operationSUB(ref RegisterAL, ref RegisterAH, ref labelAL, ref labelAH);
                }
                else if (operand1 == "B")
                {
                    operationSUB(ref RegisterBL, ref RegisterBH, ref labelBL, ref labelBH);
                }
                else if (operand1 == "C")
                {
                    operationSUB(ref RegisterCL, ref RegisterCH, ref labelCL, ref labelCH);
                }
                else if (operand1 == "D")
                {
                    operationSUB(ref RegisterDL, ref RegisterDH, ref labelDL, ref labelDH);
                }
                else if (operand1 == "I")
                {
                    operationSUB(ref RegisterInL, ref RegisterInH, ref labelInL, ref labelInH);
                }
                checkInstant();
            }
        }

        private void comboBoxOperand1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxOperand1.SelectedIndex == 0)
            {
                operand1 = "A";
            }
            else if (comboBoxOperand1.SelectedIndex == 1)
            {
                operand1 = "B";
            }
            else if (comboBoxOperand1.SelectedIndex == 2)
            {
                operand1 = "C";
            }
            else if (comboBoxOperand1.SelectedIndex == 3)
            {
                operand1 = "D";
            }
            else if (comboBoxOperand1.SelectedIndex == 4)
            {
                operand1 = "I";
            }
        }

        private void comboBoxOperand2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxOperand2.SelectedIndex == 0)
            {
                operand2 = "A";
            }
            else if (comboBoxOperand2.SelectedIndex == 1)
            {
                operand2 = "B";
            }
            else if (comboBoxOperand2.SelectedIndex == 2)
            {
                operand2 = "C";
            }
            else if (comboBoxOperand2.SelectedIndex == 3)
            {
                operand2 = "D";
            }
            else if (comboBoxOperand2.SelectedIndex == 4)
            {
                operand2 = "I";
            }
        }

        private void comboBoxMoveTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxMoveTo.SelectedIndex == 0)
            {
                moveTo = "A";
            }
            else if (comboBoxMoveTo.SelectedIndex == 1)
            {
                moveTo = "B";
            }
            else if (comboBoxMoveTo.SelectedIndex == 2)
            {
                moveTo = "C";
            }
            else if (comboBoxMoveTo.SelectedIndex == 3)
            {
                moveTo = "D";
            }
            else if (comboBoxMoveTo.SelectedIndex == 4)
            {
                moveTo = "I";
            }
        }

        private void buttonAddOrderToProgram_Click(object sender, EventArgs e)
        {
            if (operationBox.SelectedIndex == 0)
            {
                activeCommand = comboBoxOperand1.SelectedItem.ToString() + operationBox.SelectedItem.ToString() + comboBoxOperand2.SelectedItem.ToString();
            }
            else
            {
                activeCommand = comboBoxOperand1.SelectedItem.ToString() + operationBox.SelectedItem.ToString() + comboBoxOperand2.SelectedItem.ToString() + ">" + comboBoxMoveTo.SelectedItem.ToString();
            }
            listProgram.Items.Add(activeCommand);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            using StreamWriter file = new("program.txt");
             foreach (string item in listProgram.Items)
            {
                file.WriteLine(item.ToString());
            }
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            listProgram.Items.Clear();
            foreach (string line in System.IO.File.ReadLines("program.txt"))
            {
                listProgram.Items.Add(line);
            }
        }

        private void buttonProgramReset_Click(object sender, EventArgs e)
        {
            listProgram.Items.Clear();
        }

        private void programStepFunction(string order)
        {
            programWorking = true;
            if (order.Length <= 5)
            {
                programOperand1 = order.Substring(0, 1);
                programOperation = order.Substring(1, 3);
                programOperand2 = order.Substring(4, 1);
            }
            else
            {
                programOperand1 = order.Substring(0, 1);
                programOperation = order.Substring(1, 3);
                programOperand2 = order.Substring(4, 1);
                programMoveTo = order.Substring(6, 1);
            }
            if (programOperation == "MOV")
            {
                if (programOperand1 == programOperand2) { }
                else if (programOperand1 == "A")
                {
                    operationMOV(ref RegisterAH, ref RegisterAL, ref labelAH, ref labelAL);
                }
                else if (programOperand1 == "B")
                {
                    operationMOV(ref RegisterBH, ref RegisterBL, ref labelBH, ref labelBL);
                }
                else if (programOperand1 == "C")
                {
                    operationMOV(ref RegisterCH, ref RegisterCL, ref labelCH, ref labelCL);
                }
                else if (programOperand1 == "D")
                {
                    operationMOV(ref RegisterDH, ref RegisterDL, ref labelDH, ref labelDL);
                }
                else if (programOperand1 == "I")
                {
                    operationMOV(ref RegisterInH, ref RegisterInL, ref labelInH, ref labelInL);
                }
                checkInstant();
            }
            else if (programOperation == "ADD")
            {
                if (programOperand1 == "A")
                {
                    operationADD(ref RegisterAL, ref RegisterAH, ref labelAL, ref labelAH);
                }
                else if (programOperand1 == "B")
                {
                    operationADD(ref RegisterBL, ref RegisterBH, ref labelBL, ref labelBH);
                }
                else if (programOperand1 == "C")
                {
                    operationADD(ref RegisterCL, ref RegisterCH, ref labelCL, ref labelCH);
                }
                else if (programOperand1 == "D")
                {
                    operationADD(ref RegisterDL, ref RegisterDH, ref labelDL, ref labelDH);
                }
                else if (programOperand1 == "I")
                {
                    operationADD(ref RegisterInL, ref RegisterInH, ref labelInL, ref labelInH);
                }
                checkInstant();
            }
            else if (programOperation == "SUB")
            {
                if (programOperand1 == "A")
                {
                    operationSUB(ref RegisterAL, ref RegisterAH, ref labelAL, ref labelAH);
                }
                else if (programOperand1 == "B")
                {
                    operationSUB(ref RegisterBL, ref RegisterBH, ref labelBL, ref labelBH);
                }
                else if (programOperand1 == "C")
                {
                    operationSUB(ref RegisterCL, ref RegisterCH, ref labelCL, ref labelCH);
                }
                else if (programOperand1 == "D")
                {
                    operationSUB(ref RegisterDL, ref RegisterDH, ref labelDL, ref labelDH);
                }
                else if (programOperand1 == "I")
                {
                    operationSUB(ref RegisterInL, ref RegisterInH, ref labelInL, ref labelInH);
                }
                checkInstant();
            }
            programWorking = false;
        }

        private void buttonProgramStep_Click(object sender, EventArgs e)
        {
            if (listProgram.SelectedIndex + 1 < listProgram.Items.Count)
            {
                listProgram.SelectedIndex += 1;
                programOrder = listProgram.Items[listProgram.SelectedIndex].ToString();
                programOrder.Trim();
                programStepFunction(programOrder);
            }
        }

        private void buttonProgram_Click(object sender, EventArgs e)
        {
            while (listProgram.SelectedIndex + 1 < listProgram.Items.Count)
            {
                buttonProgramStep.PerformClick();
            }
        }
    }
}
