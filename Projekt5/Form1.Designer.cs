
namespace Projekt5
{
    partial class Form1
    {
        public bool programWorking = false;
        
        public string operation = "MOV";
        public string operand1 = "A";
        public string operand2 = "A";
        public string moveTo = "";

        public string activeCommand;

        public int helpNumber1;
        public int helpNumber2;
        public string helpStringBinary;
        public string helpStringH;
        public string helpStringL;

        public string programOperation;
        public string programOperand1;
        public string programOperand2;
        public string programMoveTo;

        public string programOrder;

        public string AH = "00000000";
        public string AL = "00000000";

        public string BH = "00000000";
        public string BL = "00000000";

        public string CH = "00000000";
        public string CL = "00000000";

        public string DH = "00000000";
        public string DL = "00000000";

        public string RegisterAH = "00000000";
        public string RegisterAL = "00000000";

        public string RegisterBH = "00000000";
        public string RegisterBL = "00000000";

        public string RegisterCH = "00000000";
        public string RegisterCL = "00000000";

        public string RegisterDH = "00000000";
        public string RegisterDL = "00000000";

        public string RegisterInH = "00000000";
        public string RegisterInL = "00000000";
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxMoveTo = new System.Windows.Forms.ComboBox();
            this.comboBoxOperand2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxOperand1 = new System.Windows.Forms.ComboBox();
            this.buttonAddOrderToProgram = new System.Windows.Forms.Button();
            this.buttonExeOrder = new System.Windows.Forms.Button();
            this.operationBox = new System.Windows.Forms.ComboBox();
            this.groupBoxInstant = new System.Windows.Forms.GroupBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelInL = new System.Windows.Forms.Label();
            this.labelInH = new System.Windows.Forms.Label();
            this.groupInstant0 = new System.Windows.Forms.GroupBox();
            this.InstantbuttonNo0s1 = new System.Windows.Forms.RadioButton();
            this.InstantbuttonNo0s0 = new System.Windows.Forms.RadioButton();
            this.groupInstant1 = new System.Windows.Forms.GroupBox();
            this.InstantbuttonNo1s1 = new System.Windows.Forms.RadioButton();
            this.InstantbuttonNo1s0 = new System.Windows.Forms.RadioButton();
            this.groupInstant8 = new System.Windows.Forms.GroupBox();
            this.InstantbuttonNo8s1 = new System.Windows.Forms.RadioButton();
            this.InstantbuttonNo8s0 = new System.Windows.Forms.RadioButton();
            this.groupInstant4 = new System.Windows.Forms.GroupBox();
            this.InstantbuttonNo4s1 = new System.Windows.Forms.RadioButton();
            this.InstantbuttonNo4s0 = new System.Windows.Forms.RadioButton();
            this.groupInstant9 = new System.Windows.Forms.GroupBox();
            this.InstantbuttonNo9s1 = new System.Windows.Forms.RadioButton();
            this.InstantbuttonNo9s0 = new System.Windows.Forms.RadioButton();
            this.groupInstant2 = new System.Windows.Forms.GroupBox();
            this.InstantbuttonNo2s1 = new System.Windows.Forms.RadioButton();
            this.InstantbuttonNo2s0 = new System.Windows.Forms.RadioButton();
            this.groupInstant12 = new System.Windows.Forms.GroupBox();
            this.InstantbuttonNo12s1 = new System.Windows.Forms.RadioButton();
            this.InstantbuttonNo12s0 = new System.Windows.Forms.RadioButton();
            this.groupInstant5 = new System.Windows.Forms.GroupBox();
            this.InstantbuttonNo5s1 = new System.Windows.Forms.RadioButton();
            this.InstantbuttonNo5s0 = new System.Windows.Forms.RadioButton();
            this.groupInstant10 = new System.Windows.Forms.GroupBox();
            this.InstantbuttonNo10s1 = new System.Windows.Forms.RadioButton();
            this.InstantbuttonNo10s0 = new System.Windows.Forms.RadioButton();
            this.groupInstant3 = new System.Windows.Forms.GroupBox();
            this.InstantbuttonNo3s1 = new System.Windows.Forms.RadioButton();
            this.InstantbuttonNo3s0 = new System.Windows.Forms.RadioButton();
            this.groupInstant13 = new System.Windows.Forms.GroupBox();
            this.InstantbuttonNo13s1 = new System.Windows.Forms.RadioButton();
            this.InstantbuttonNo13s0 = new System.Windows.Forms.RadioButton();
            this.groupInstant6 = new System.Windows.Forms.GroupBox();
            this.InstantbuttonNo6s1 = new System.Windows.Forms.RadioButton();
            this.InstantbuttonNo6s0 = new System.Windows.Forms.RadioButton();
            this.groupInstant11 = new System.Windows.Forms.GroupBox();
            this.InstantbuttonNo11s1 = new System.Windows.Forms.RadioButton();
            this.InstantbuttonNo11s0 = new System.Windows.Forms.RadioButton();
            this.groupInstant7 = new System.Windows.Forms.GroupBox();
            this.InstantbuttonNo7s1 = new System.Windows.Forms.RadioButton();
            this.InstantbuttonNo7s0 = new System.Windows.Forms.RadioButton();
            this.groupInstant14 = new System.Windows.Forms.GroupBox();
            this.InstantbuttonNo14s1 = new System.Windows.Forms.RadioButton();
            this.InstantbuttonNo14s0 = new System.Windows.Forms.RadioButton();
            this.groupInstant15 = new System.Windows.Forms.GroupBox();
            this.InstantbuttonNo15s1 = new System.Windows.Forms.RadioButton();
            this.InstantbuttonNo15s0 = new System.Windows.Forms.RadioButton();
            this.groupBoxDX = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelDL = new System.Windows.Forms.Label();
            this.labelDH = new System.Windows.Forms.Label();
            this.buttonWriteDX = new System.Windows.Forms.Button();
            this.DHActive = new System.Windows.Forms.Label();
            this.DLActive = new System.Windows.Forms.Label();
            this.gruopDX0 = new System.Windows.Forms.GroupBox();
            this.DXbuttonNo0s1 = new System.Windows.Forms.RadioButton();
            this.DXbuttonNo0s0 = new System.Windows.Forms.RadioButton();
            this.gruopDX1 = new System.Windows.Forms.GroupBox();
            this.DXbuttonNo1s1 = new System.Windows.Forms.RadioButton();
            this.DXbuttonNo1s0 = new System.Windows.Forms.RadioButton();
            this.gruopDX8 = new System.Windows.Forms.GroupBox();
            this.DXbuttonNo8s1 = new System.Windows.Forms.RadioButton();
            this.DXbuttonNo8s0 = new System.Windows.Forms.RadioButton();
            this.gruopDX4 = new System.Windows.Forms.GroupBox();
            this.DXbuttonNo4s1 = new System.Windows.Forms.RadioButton();
            this.DXbuttonNo4s0 = new System.Windows.Forms.RadioButton();
            this.gruopDX9 = new System.Windows.Forms.GroupBox();
            this.DXbuttonNo9s1 = new System.Windows.Forms.RadioButton();
            this.DXbuttonNo9s0 = new System.Windows.Forms.RadioButton();
            this.gruopDX2 = new System.Windows.Forms.GroupBox();
            this.DXbuttonNo2s1 = new System.Windows.Forms.RadioButton();
            this.DXbuttonNo2s0 = new System.Windows.Forms.RadioButton();
            this.gruopDX12 = new System.Windows.Forms.GroupBox();
            this.DXbuttonNo12s1 = new System.Windows.Forms.RadioButton();
            this.DXbuttonNo12s0 = new System.Windows.Forms.RadioButton();
            this.gruopDX5 = new System.Windows.Forms.GroupBox();
            this.DXbuttonNo5s1 = new System.Windows.Forms.RadioButton();
            this.DXbuttonNo5s0 = new System.Windows.Forms.RadioButton();
            this.gruopDX10 = new System.Windows.Forms.GroupBox();
            this.DXbuttonNo10s1 = new System.Windows.Forms.RadioButton();
            this.DXbuttonNo10s0 = new System.Windows.Forms.RadioButton();
            this.gruopDX3 = new System.Windows.Forms.GroupBox();
            this.DXbuttonNo3s1 = new System.Windows.Forms.RadioButton();
            this.DXbuttonNo3s0 = new System.Windows.Forms.RadioButton();
            this.gruopDX13 = new System.Windows.Forms.GroupBox();
            this.DXbuttonNo13s1 = new System.Windows.Forms.RadioButton();
            this.DXbuttonNo13s0 = new System.Windows.Forms.RadioButton();
            this.gruopDX6 = new System.Windows.Forms.GroupBox();
            this.DXbuttonNo6s1 = new System.Windows.Forms.RadioButton();
            this.DXbuttonNo6s0 = new System.Windows.Forms.RadioButton();
            this.gruopDX11 = new System.Windows.Forms.GroupBox();
            this.DXbuttonNo11s1 = new System.Windows.Forms.RadioButton();
            this.DXbuttonNo11s0 = new System.Windows.Forms.RadioButton();
            this.gruopDX7 = new System.Windows.Forms.GroupBox();
            this.DXbuttonNo7s1 = new System.Windows.Forms.RadioButton();
            this.DXbuttonNo7s0 = new System.Windows.Forms.RadioButton();
            this.gruopDX14 = new System.Windows.Forms.GroupBox();
            this.DXbuttonNo14s1 = new System.Windows.Forms.RadioButton();
            this.DXbuttonNo14s0 = new System.Windows.Forms.RadioButton();
            this.gruopDX15 = new System.Windows.Forms.GroupBox();
            this.DXbuttonNo15s1 = new System.Windows.Forms.RadioButton();
            this.DXbuttonNo15s0 = new System.Windows.Forms.RadioButton();
            this.groupBoxCX = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelCL = new System.Windows.Forms.Label();
            this.labelCH = new System.Windows.Forms.Label();
            this.buttonWriteCX = new System.Windows.Forms.Button();
            this.CHActive = new System.Windows.Forms.Label();
            this.CLActive = new System.Windows.Forms.Label();
            this.gruopCX0 = new System.Windows.Forms.GroupBox();
            this.CXbuttonNo0s1 = new System.Windows.Forms.RadioButton();
            this.CXbuttonNo0s0 = new System.Windows.Forms.RadioButton();
            this.gruopCX1 = new System.Windows.Forms.GroupBox();
            this.CXbuttonNo1s1 = new System.Windows.Forms.RadioButton();
            this.CXbuttonNo1s0 = new System.Windows.Forms.RadioButton();
            this.gruopCX8 = new System.Windows.Forms.GroupBox();
            this.CXbuttonNo8s1 = new System.Windows.Forms.RadioButton();
            this.CXbuttonNo8s0 = new System.Windows.Forms.RadioButton();
            this.gruopCX4 = new System.Windows.Forms.GroupBox();
            this.CXbuttonNo4s1 = new System.Windows.Forms.RadioButton();
            this.CXbuttonNo4s0 = new System.Windows.Forms.RadioButton();
            this.gruopCX9 = new System.Windows.Forms.GroupBox();
            this.CXbuttonNo9s1 = new System.Windows.Forms.RadioButton();
            this.CXbuttonNo9s0 = new System.Windows.Forms.RadioButton();
            this.gruopCX2 = new System.Windows.Forms.GroupBox();
            this.CXbuttonNo2s1 = new System.Windows.Forms.RadioButton();
            this.CXbuttonNo2s0 = new System.Windows.Forms.RadioButton();
            this.gruopCX12 = new System.Windows.Forms.GroupBox();
            this.CXbuttonNo12s1 = new System.Windows.Forms.RadioButton();
            this.CXbuttonNo12s0 = new System.Windows.Forms.RadioButton();
            this.gruopCX5 = new System.Windows.Forms.GroupBox();
            this.CXbuttonNo5s1 = new System.Windows.Forms.RadioButton();
            this.CXbuttonNo5s0 = new System.Windows.Forms.RadioButton();
            this.gruopCX10 = new System.Windows.Forms.GroupBox();
            this.CXbuttonNo10s1 = new System.Windows.Forms.RadioButton();
            this.CXbuttonNo10s0 = new System.Windows.Forms.RadioButton();
            this.gruopCX3 = new System.Windows.Forms.GroupBox();
            this.CXbuttonNo3s1 = new System.Windows.Forms.RadioButton();
            this.CXbuttonNo3s0 = new System.Windows.Forms.RadioButton();
            this.gruopCX13 = new System.Windows.Forms.GroupBox();
            this.CXbuttonNo13s1 = new System.Windows.Forms.RadioButton();
            this.CXbuttonNo13s0 = new System.Windows.Forms.RadioButton();
            this.gruopCX6 = new System.Windows.Forms.GroupBox();
            this.CXbuttonNo6s1 = new System.Windows.Forms.RadioButton();
            this.CXbuttonNo6s0 = new System.Windows.Forms.RadioButton();
            this.gruopCX11 = new System.Windows.Forms.GroupBox();
            this.CXbuttonNo11s1 = new System.Windows.Forms.RadioButton();
            this.CXbuttonNo11s0 = new System.Windows.Forms.RadioButton();
            this.gruopCX7 = new System.Windows.Forms.GroupBox();
            this.CXbuttonNo7s1 = new System.Windows.Forms.RadioButton();
            this.CXbuttonNo7s0 = new System.Windows.Forms.RadioButton();
            this.gruopCX14 = new System.Windows.Forms.GroupBox();
            this.CXbuttonNo14s1 = new System.Windows.Forms.RadioButton();
            this.CXbuttonNo14s0 = new System.Windows.Forms.RadioButton();
            this.gruopCX15 = new System.Windows.Forms.GroupBox();
            this.CXbuttonNo15s1 = new System.Windows.Forms.RadioButton();
            this.CXbuttonNo15s0 = new System.Windows.Forms.RadioButton();
            this.groupBoxBX = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelBL = new System.Windows.Forms.Label();
            this.labelBH = new System.Windows.Forms.Label();
            this.buttonWriteBX = new System.Windows.Forms.Button();
            this.BLActive = new System.Windows.Forms.Label();
            this.BHActive = new System.Windows.Forms.Label();
            this.gruopBX0 = new System.Windows.Forms.GroupBox();
            this.BXbuttonNo0s1 = new System.Windows.Forms.RadioButton();
            this.BXbuttonNo0s0 = new System.Windows.Forms.RadioButton();
            this.gruopBX1 = new System.Windows.Forms.GroupBox();
            this.BXbuttonNo1s1 = new System.Windows.Forms.RadioButton();
            this.BXbuttonNo1s0 = new System.Windows.Forms.RadioButton();
            this.gruopBX15 = new System.Windows.Forms.GroupBox();
            this.BXbuttonNo15s1 = new System.Windows.Forms.RadioButton();
            this.BXbuttonNo15s0 = new System.Windows.Forms.RadioButton();
            this.gruopBX8 = new System.Windows.Forms.GroupBox();
            this.BXbuttonNo8s1 = new System.Windows.Forms.RadioButton();
            this.BXbuttonNo8s0 = new System.Windows.Forms.RadioButton();
            this.gruopBX14 = new System.Windows.Forms.GroupBox();
            this.BXbuttonNo14s1 = new System.Windows.Forms.RadioButton();
            this.BXbuttonNo14s0 = new System.Windows.Forms.RadioButton();
            this.gruopBX4 = new System.Windows.Forms.GroupBox();
            this.BXbuttonNo4s1 = new System.Windows.Forms.RadioButton();
            this.BXbuttonNo4s0 = new System.Windows.Forms.RadioButton();
            this.gruopBX7 = new System.Windows.Forms.GroupBox();
            this.BXbuttonNo7s1 = new System.Windows.Forms.RadioButton();
            this.BXbuttonNo7s0 = new System.Windows.Forms.RadioButton();
            this.gruopBX9 = new System.Windows.Forms.GroupBox();
            this.BXbuttonNo9s1 = new System.Windows.Forms.RadioButton();
            this.BXbuttonNo9s0 = new System.Windows.Forms.RadioButton();
            this.gruopBX11 = new System.Windows.Forms.GroupBox();
            this.BXbuttonNo11s1 = new System.Windows.Forms.RadioButton();
            this.BXbuttonNo11s0 = new System.Windows.Forms.RadioButton();
            this.gruopBX2 = new System.Windows.Forms.GroupBox();
            this.BXbuttonNo2s1 = new System.Windows.Forms.RadioButton();
            this.BXbuttonNo2s0 = new System.Windows.Forms.RadioButton();
            this.gruopBX6 = new System.Windows.Forms.GroupBox();
            this.BXbuttonNo6s1 = new System.Windows.Forms.RadioButton();
            this.BXbuttonNo6s0 = new System.Windows.Forms.RadioButton();
            this.gruopBX12 = new System.Windows.Forms.GroupBox();
            this.BXbuttonNo12s1 = new System.Windows.Forms.RadioButton();
            this.BXbuttonNo12s0 = new System.Windows.Forms.RadioButton();
            this.gruopBX13 = new System.Windows.Forms.GroupBox();
            this.BXbuttonNo13s1 = new System.Windows.Forms.RadioButton();
            this.BXbuttonNo13s0 = new System.Windows.Forms.RadioButton();
            this.gruopBX5 = new System.Windows.Forms.GroupBox();
            this.BXbuttonNo5s1 = new System.Windows.Forms.RadioButton();
            this.BXbuttonNo5s0 = new System.Windows.Forms.RadioButton();
            this.gruopBX3 = new System.Windows.Forms.GroupBox();
            this.BXbuttonNo3s1 = new System.Windows.Forms.RadioButton();
            this.BXbuttonNo3s0 = new System.Windows.Forms.RadioButton();
            this.gruopBX10 = new System.Windows.Forms.GroupBox();
            this.BXbuttonNo10s1 = new System.Windows.Forms.RadioButton();
            this.BXbuttonNo10s0 = new System.Windows.Forms.RadioButton();
            this.groupBoxAX = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelAL = new System.Windows.Forms.Label();
            this.labelAH = new System.Windows.Forms.Label();
            this.buttonWriteAX = new System.Windows.Forms.Button();
            this.ALActive = new System.Windows.Forms.Label();
            this.AHActive = new System.Windows.Forms.Label();
            this.gruopAX0 = new System.Windows.Forms.GroupBox();
            this.AXbuttonNo0s1 = new System.Windows.Forms.RadioButton();
            this.AXbuttonNo0s0 = new System.Windows.Forms.RadioButton();
            this.gruopAX8 = new System.Windows.Forms.GroupBox();
            this.AXbuttonNo8s1 = new System.Windows.Forms.RadioButton();
            this.AXbuttonNo8s0 = new System.Windows.Forms.RadioButton();
            this.gruopAX1 = new System.Windows.Forms.GroupBox();
            this.AXbuttonNo1s1 = new System.Windows.Forms.RadioButton();
            this.AXbuttonNo1s0 = new System.Windows.Forms.RadioButton();
            this.gruopAX15 = new System.Windows.Forms.GroupBox();
            this.AXbuttonNo15s1 = new System.Windows.Forms.RadioButton();
            this.AXbuttonNo15s0 = new System.Windows.Forms.RadioButton();
            this.gruopAX14 = new System.Windows.Forms.GroupBox();
            this.AXbuttonNo14s1 = new System.Windows.Forms.RadioButton();
            this.AXbuttonNo14s0 = new System.Windows.Forms.RadioButton();
            this.gruopAX4 = new System.Windows.Forms.GroupBox();
            this.AXbuttonNo4s1 = new System.Windows.Forms.RadioButton();
            this.AXbuttonNo4s0 = new System.Windows.Forms.RadioButton();
            this.gruopAX7 = new System.Windows.Forms.GroupBox();
            this.AXbuttonNo7s1 = new System.Windows.Forms.RadioButton();
            this.AXbuttonNo7s0 = new System.Windows.Forms.RadioButton();
            this.gruopAX9 = new System.Windows.Forms.GroupBox();
            this.AXbuttonNo9s1 = new System.Windows.Forms.RadioButton();
            this.AXbuttonNo9s0 = new System.Windows.Forms.RadioButton();
            this.gruopAX11 = new System.Windows.Forms.GroupBox();
            this.AXbuttonNo11s1 = new System.Windows.Forms.RadioButton();
            this.AXbuttonNo11s0 = new System.Windows.Forms.RadioButton();
            this.gruopAX2 = new System.Windows.Forms.GroupBox();
            this.AXbuttonNo2s1 = new System.Windows.Forms.RadioButton();
            this.AXbuttonNo2s0 = new System.Windows.Forms.RadioButton();
            this.gruopAX6 = new System.Windows.Forms.GroupBox();
            this.AXbuttonNo6s1 = new System.Windows.Forms.RadioButton();
            this.AXbuttonNo6s0 = new System.Windows.Forms.RadioButton();
            this.gruopAX12 = new System.Windows.Forms.GroupBox();
            this.AXbuttonNo12s1 = new System.Windows.Forms.RadioButton();
            this.AXbuttonNo12s0 = new System.Windows.Forms.RadioButton();
            this.gruopAX13 = new System.Windows.Forms.GroupBox();
            this.AXbuttonNo13s1 = new System.Windows.Forms.RadioButton();
            this.AXbuttonNo13s0 = new System.Windows.Forms.RadioButton();
            this.gruopAX5 = new System.Windows.Forms.GroupBox();
            this.AXbuttonNo5s1 = new System.Windows.Forms.RadioButton();
            this.AXbuttonNo5s0 = new System.Windows.Forms.RadioButton();
            this.gruopAX3 = new System.Windows.Forms.GroupBox();
            this.AXbuttonNo3s1 = new System.Windows.Forms.RadioButton();
            this.AXbuttonNo3s0 = new System.Windows.Forms.RadioButton();
            this.gruopAX10 = new System.Windows.Forms.GroupBox();
            this.AXbuttonNo10s1 = new System.Windows.Forms.RadioButton();
            this.AXbuttonNo10s0 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonProgramReset = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonRead = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonProgram = new System.Windows.Forms.Button();
            this.buttonProgramStep = new System.Windows.Forms.Button();
            this.listProgram = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBoxInstant.SuspendLayout();
            this.groupInstant0.SuspendLayout();
            this.groupInstant1.SuspendLayout();
            this.groupInstant8.SuspendLayout();
            this.groupInstant4.SuspendLayout();
            this.groupInstant9.SuspendLayout();
            this.groupInstant2.SuspendLayout();
            this.groupInstant12.SuspendLayout();
            this.groupInstant5.SuspendLayout();
            this.groupInstant10.SuspendLayout();
            this.groupInstant3.SuspendLayout();
            this.groupInstant13.SuspendLayout();
            this.groupInstant6.SuspendLayout();
            this.groupInstant11.SuspendLayout();
            this.groupInstant7.SuspendLayout();
            this.groupInstant14.SuspendLayout();
            this.groupInstant15.SuspendLayout();
            this.groupBoxDX.SuspendLayout();
            this.gruopDX0.SuspendLayout();
            this.gruopDX1.SuspendLayout();
            this.gruopDX8.SuspendLayout();
            this.gruopDX4.SuspendLayout();
            this.gruopDX9.SuspendLayout();
            this.gruopDX2.SuspendLayout();
            this.gruopDX12.SuspendLayout();
            this.gruopDX5.SuspendLayout();
            this.gruopDX10.SuspendLayout();
            this.gruopDX3.SuspendLayout();
            this.gruopDX13.SuspendLayout();
            this.gruopDX6.SuspendLayout();
            this.gruopDX11.SuspendLayout();
            this.gruopDX7.SuspendLayout();
            this.gruopDX14.SuspendLayout();
            this.gruopDX15.SuspendLayout();
            this.groupBoxCX.SuspendLayout();
            this.gruopCX0.SuspendLayout();
            this.gruopCX1.SuspendLayout();
            this.gruopCX8.SuspendLayout();
            this.gruopCX4.SuspendLayout();
            this.gruopCX9.SuspendLayout();
            this.gruopCX2.SuspendLayout();
            this.gruopCX12.SuspendLayout();
            this.gruopCX5.SuspendLayout();
            this.gruopCX10.SuspendLayout();
            this.gruopCX3.SuspendLayout();
            this.gruopCX13.SuspendLayout();
            this.gruopCX6.SuspendLayout();
            this.gruopCX11.SuspendLayout();
            this.gruopCX7.SuspendLayout();
            this.gruopCX14.SuspendLayout();
            this.gruopCX15.SuspendLayout();
            this.groupBoxBX.SuspendLayout();
            this.gruopBX0.SuspendLayout();
            this.gruopBX1.SuspendLayout();
            this.gruopBX15.SuspendLayout();
            this.gruopBX8.SuspendLayout();
            this.gruopBX14.SuspendLayout();
            this.gruopBX4.SuspendLayout();
            this.gruopBX7.SuspendLayout();
            this.gruopBX9.SuspendLayout();
            this.gruopBX11.SuspendLayout();
            this.gruopBX2.SuspendLayout();
            this.gruopBX6.SuspendLayout();
            this.gruopBX12.SuspendLayout();
            this.gruopBX13.SuspendLayout();
            this.gruopBX5.SuspendLayout();
            this.gruopBX3.SuspendLayout();
            this.gruopBX10.SuspendLayout();
            this.groupBoxAX.SuspendLayout();
            this.gruopAX0.SuspendLayout();
            this.gruopAX8.SuspendLayout();
            this.gruopAX1.SuspendLayout();
            this.gruopAX15.SuspendLayout();
            this.gruopAX14.SuspendLayout();
            this.gruopAX4.SuspendLayout();
            this.gruopAX7.SuspendLayout();
            this.gruopAX9.SuspendLayout();
            this.gruopAX11.SuspendLayout();
            this.gruopAX2.SuspendLayout();
            this.gruopAX6.SuspendLayout();
            this.gruopAX12.SuspendLayout();
            this.gruopAX13.SuspendLayout();
            this.gruopAX5.SuspendLayout();
            this.gruopAX3.SuspendLayout();
            this.gruopAX10.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxMoveTo);
            this.groupBox1.Controls.Add(this.comboBoxOperand2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxOperand1);
            this.groupBox1.Controls.Add(this.buttonAddOrderToProgram);
            this.groupBox1.Controls.Add(this.buttonExeOrder);
            this.groupBox1.Controls.Add(this.operationBox);
            this.groupBox1.Controls.Add(this.groupBoxInstant);
            this.groupBox1.Controls.Add(this.groupBoxDX);
            this.groupBox1.Controls.Add(this.groupBoxCX);
            this.groupBox1.Controls.Add(this.groupBoxBX);
            this.groupBox1.Controls.Add(this.groupBoxAX);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1065, 723);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rozkazy";
            // 
            // comboBoxMoveTo
            // 
            this.comboBoxMoveTo.AllowDrop = true;
            this.comboBoxMoveTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMoveTo.FormattingEnabled = true;
            this.comboBoxMoveTo.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "I"});
            this.comboBoxMoveTo.Location = new System.Drawing.Point(759, 566);
            this.comboBoxMoveTo.Name = "comboBoxMoveTo";
            this.comboBoxMoveTo.Size = new System.Drawing.Size(73, 33);
            this.comboBoxMoveTo.TabIndex = 80;
            this.comboBoxMoveTo.SelectedIndexChanged += new System.EventHandler(this.comboBoxMoveTo_SelectedIndexChanged);
            // 
            // comboBoxOperand2
            // 
            this.comboBoxOperand2.AllowDrop = true;
            this.comboBoxOperand2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOperand2.FormattingEnabled = true;
            this.comboBoxOperand2.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "I"});
            this.comboBoxOperand2.Location = new System.Drawing.Point(828, 511);
            this.comboBoxOperand2.Name = "comboBoxOperand2";
            this.comboBoxOperand2.Size = new System.Drawing.Size(73, 33);
            this.comboBoxOperand2.TabIndex = 79;
            this.comboBoxOperand2.SelectedIndexChanged += new System.EventHandler(this.comboBoxOperand2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(776, 516);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 25);
            this.label1.TabIndex = 78;
            this.label1.Text = "=>";
            // 
            // comboBoxOperand1
            // 
            this.comboBoxOperand1.AllowDrop = true;
            this.comboBoxOperand1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOperand1.FormattingEnabled = true;
            this.comboBoxOperand1.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "I"});
            this.comboBoxOperand1.Location = new System.Drawing.Point(686, 511);
            this.comboBoxOperand1.Name = "comboBoxOperand1";
            this.comboBoxOperand1.Size = new System.Drawing.Size(73, 33);
            this.comboBoxOperand1.TabIndex = 76;
            this.comboBoxOperand1.SelectedIndexChanged += new System.EventHandler(this.comboBoxOperand1_SelectedIndexChanged);
            // 
            // buttonAddOrderToProgram
            // 
            this.buttonAddOrderToProgram.Location = new System.Drawing.Point(788, 623);
            this.buttonAddOrderToProgram.Name = "buttonAddOrderToProgram";
            this.buttonAddOrderToProgram.Size = new System.Drawing.Size(246, 35);
            this.buttonAddOrderToProgram.TabIndex = 75;
            this.buttonAddOrderToProgram.Text = "Zapisz rozkaz w programie";
            this.buttonAddOrderToProgram.UseVisualStyleBackColor = true;
            this.buttonAddOrderToProgram.Click += new System.EventHandler(this.buttonAddOrderToProgram_Click);
            // 
            // buttonExeOrder
            // 
            this.buttonExeOrder.Location = new System.Drawing.Point(590, 624);
            this.buttonExeOrder.Name = "buttonExeOrder";
            this.buttonExeOrder.Size = new System.Drawing.Size(165, 34);
            this.buttonExeOrder.TabIndex = 74;
            this.buttonExeOrder.Text = "Wykonaj rozkaz";
            this.buttonExeOrder.UseVisualStyleBackColor = true;
            this.buttonExeOrder.Click += new System.EventHandler(this.buttonExeOrder_Click);
            // 
            // operationBox
            // 
            this.operationBox.AllowDrop = true;
            this.operationBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.operationBox.FormattingEnabled = true;
            this.operationBox.Items.AddRange(new object[] {
            "MOV",
            "ADD",
            "SUB"});
            this.operationBox.Location = new System.Drawing.Point(752, 462);
            this.operationBox.Name = "operationBox";
            this.operationBox.Size = new System.Drawing.Size(80, 33);
            this.operationBox.TabIndex = 73;
            this.operationBox.SelectedIndexChanged += new System.EventHandler(this.operationBox_SelectedIndexChanged);
            // 
            // groupBoxInstant
            // 
            this.groupBoxInstant.Controls.Add(this.label26);
            this.groupBoxInstant.Controls.Add(this.label10);
            this.groupBoxInstant.Controls.Add(this.label27);
            this.groupBoxInstant.Controls.Add(this.label11);
            this.groupBoxInstant.Controls.Add(this.labelInL);
            this.groupBoxInstant.Controls.Add(this.labelInH);
            this.groupBoxInstant.Controls.Add(this.groupInstant0);
            this.groupBoxInstant.Controls.Add(this.groupInstant1);
            this.groupBoxInstant.Controls.Add(this.groupInstant8);
            this.groupBoxInstant.Controls.Add(this.groupInstant4);
            this.groupBoxInstant.Controls.Add(this.groupInstant9);
            this.groupBoxInstant.Controls.Add(this.groupInstant2);
            this.groupBoxInstant.Controls.Add(this.groupInstant12);
            this.groupBoxInstant.Controls.Add(this.groupInstant5);
            this.groupBoxInstant.Controls.Add(this.groupInstant10);
            this.groupBoxInstant.Controls.Add(this.groupInstant3);
            this.groupBoxInstant.Controls.Add(this.groupInstant13);
            this.groupBoxInstant.Controls.Add(this.groupInstant6);
            this.groupBoxInstant.Controls.Add(this.groupInstant11);
            this.groupBoxInstant.Controls.Add(this.groupInstant7);
            this.groupBoxInstant.Controls.Add(this.groupInstant14);
            this.groupBoxInstant.Controls.Add(this.groupInstant15);
            this.groupBoxInstant.Location = new System.Drawing.Point(6, 462);
            this.groupBoxInstant.Name = "groupBoxInstant";
            this.groupBoxInstant.Size = new System.Drawing.Size(530, 175);
            this.groupBoxInstant.TabIndex = 72;
            this.groupBoxInstant.TabStop = false;
            this.groupBoxInstant.Text = "Rejestr Trybu Natychmiastowego";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(360, 122);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(35, 25);
            this.label26.TabIndex = 92;
            this.label26.Text = "InL";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 25);
            this.label10.TabIndex = 82;
            this.label10.Text = "0";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(129, 122);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(40, 25);
            this.label27.TabIndex = 91;
            this.label27.Text = "InH";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 25);
            this.label11.TabIndex = 81;
            this.label11.Text = "1";
            // 
            // labelInL
            // 
            this.labelInL.AutoSize = true;
            this.labelInL.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelInL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelInL.Location = new System.Drawing.Point(261, 120);
            this.labelInL.Name = "labelInL";
            this.labelInL.Size = new System.Drawing.Size(94, 27);
            this.labelInL.TabIndex = 90;
            this.labelInL.Text = "00000000";
            // 
            // labelInH
            // 
            this.labelInH.AutoSize = true;
            this.labelInH.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelInH.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelInH.Location = new System.Drawing.Point(170, 120);
            this.labelInH.Name = "labelInH";
            this.labelInH.Size = new System.Drawing.Size(94, 27);
            this.labelInH.TabIndex = 89;
            this.labelInH.Text = "00000000";
            // 
            // groupInstant0
            // 
            this.groupInstant0.Controls.Add(this.InstantbuttonNo0s1);
            this.groupInstant0.Controls.Add(this.InstantbuttonNo0s0);
            this.groupInstant0.Location = new System.Drawing.Point(475, 30);
            this.groupInstant0.Name = "groupInstant0";
            this.groupInstant0.Size = new System.Drawing.Size(20, 70);
            this.groupInstant0.TabIndex = 45;
            this.groupInstant0.TabStop = false;
            // 
            // InstantbuttonNo0s1
            // 
            this.InstantbuttonNo0s1.AutoSize = true;
            this.InstantbuttonNo0s1.Location = new System.Drawing.Point(0, 19);
            this.InstantbuttonNo0s1.Name = "InstantbuttonNo0s1";
            this.InstantbuttonNo0s1.Size = new System.Drawing.Size(21, 20);
            this.InstantbuttonNo0s1.TabIndex = 32;
            this.InstantbuttonNo0s1.UseVisualStyleBackColor = true;
            this.InstantbuttonNo0s1.CheckedChanged += new System.EventHandler(this.InstantbuttonNo0s1_CheckedChanged);
            // 
            // InstantbuttonNo0s0
            // 
            this.InstantbuttonNo0s0.AutoSize = true;
            this.InstantbuttonNo0s0.Checked = true;
            this.InstantbuttonNo0s0.Location = new System.Drawing.Point(0, 45);
            this.InstantbuttonNo0s0.Name = "InstantbuttonNo0s0";
            this.InstantbuttonNo0s0.Size = new System.Drawing.Size(21, 20);
            this.InstantbuttonNo0s0.TabIndex = 33;
            this.InstantbuttonNo0s0.TabStop = true;
            this.InstantbuttonNo0s0.UseVisualStyleBackColor = true;
            // 
            // groupInstant1
            // 
            this.groupInstant1.Controls.Add(this.InstantbuttonNo1s1);
            this.groupInstant1.Controls.Add(this.InstantbuttonNo1s0);
            this.groupInstant1.Location = new System.Drawing.Point(449, 30);
            this.groupInstant1.Name = "groupInstant1";
            this.groupInstant1.Size = new System.Drawing.Size(20, 70);
            this.groupInstant1.TabIndex = 46;
            this.groupInstant1.TabStop = false;
            // 
            // InstantbuttonNo1s1
            // 
            this.InstantbuttonNo1s1.AutoSize = true;
            this.InstantbuttonNo1s1.Location = new System.Drawing.Point(0, 19);
            this.InstantbuttonNo1s1.Name = "InstantbuttonNo1s1";
            this.InstantbuttonNo1s1.Size = new System.Drawing.Size(21, 20);
            this.InstantbuttonNo1s1.TabIndex = 32;
            this.InstantbuttonNo1s1.UseVisualStyleBackColor = true;
            this.InstantbuttonNo1s1.CheckedChanged += new System.EventHandler(this.InstantbuttonNo1s1_CheckedChanged);
            // 
            // InstantbuttonNo1s0
            // 
            this.InstantbuttonNo1s0.AutoSize = true;
            this.InstantbuttonNo1s0.Checked = true;
            this.InstantbuttonNo1s0.Location = new System.Drawing.Point(0, 45);
            this.InstantbuttonNo1s0.Name = "InstantbuttonNo1s0";
            this.InstantbuttonNo1s0.Size = new System.Drawing.Size(21, 20);
            this.InstantbuttonNo1s0.TabIndex = 33;
            this.InstantbuttonNo1s0.TabStop = true;
            this.InstantbuttonNo1s0.UseVisualStyleBackColor = true;
            // 
            // groupInstant8
            // 
            this.groupInstant8.Controls.Add(this.InstantbuttonNo8s1);
            this.groupInstant8.Controls.Add(this.InstantbuttonNo8s0);
            this.groupInstant8.Location = new System.Drawing.Point(222, 30);
            this.groupInstant8.Name = "groupInstant8";
            this.groupInstant8.Size = new System.Drawing.Size(20, 70);
            this.groupInstant8.TabIndex = 37;
            this.groupInstant8.TabStop = false;
            // 
            // InstantbuttonNo8s1
            // 
            this.InstantbuttonNo8s1.AutoSize = true;
            this.InstantbuttonNo8s1.Location = new System.Drawing.Point(0, 19);
            this.InstantbuttonNo8s1.Name = "InstantbuttonNo8s1";
            this.InstantbuttonNo8s1.Size = new System.Drawing.Size(21, 20);
            this.InstantbuttonNo8s1.TabIndex = 32;
            this.InstantbuttonNo8s1.UseVisualStyleBackColor = true;
            this.InstantbuttonNo8s1.CheckedChanged += new System.EventHandler(this.InstantbuttonNo8s1_CheckedChanged);
            // 
            // InstantbuttonNo8s0
            // 
            this.InstantbuttonNo8s0.AutoSize = true;
            this.InstantbuttonNo8s0.Checked = true;
            this.InstantbuttonNo8s0.Location = new System.Drawing.Point(0, 45);
            this.InstantbuttonNo8s0.Name = "InstantbuttonNo8s0";
            this.InstantbuttonNo8s0.Size = new System.Drawing.Size(21, 20);
            this.InstantbuttonNo8s0.TabIndex = 33;
            this.InstantbuttonNo8s0.TabStop = true;
            this.InstantbuttonNo8s0.UseVisualStyleBackColor = true;
            // 
            // groupInstant4
            // 
            this.groupInstant4.Controls.Add(this.InstantbuttonNo4s1);
            this.groupInstant4.Controls.Add(this.InstantbuttonNo4s0);
            this.groupInstant4.Location = new System.Drawing.Point(370, 30);
            this.groupInstant4.Name = "groupInstant4";
            this.groupInstant4.Size = new System.Drawing.Size(20, 70);
            this.groupInstant4.TabIndex = 41;
            this.groupInstant4.TabStop = false;
            // 
            // InstantbuttonNo4s1
            // 
            this.InstantbuttonNo4s1.AutoSize = true;
            this.InstantbuttonNo4s1.Location = new System.Drawing.Point(0, 19);
            this.InstantbuttonNo4s1.Name = "InstantbuttonNo4s1";
            this.InstantbuttonNo4s1.Size = new System.Drawing.Size(21, 20);
            this.InstantbuttonNo4s1.TabIndex = 32;
            this.InstantbuttonNo4s1.UseVisualStyleBackColor = true;
            this.InstantbuttonNo4s1.CheckedChanged += new System.EventHandler(this.InstantbuttonNo4s1_CheckedChanged);
            // 
            // InstantbuttonNo4s0
            // 
            this.InstantbuttonNo4s0.AutoSize = true;
            this.InstantbuttonNo4s0.Checked = true;
            this.InstantbuttonNo4s0.Location = new System.Drawing.Point(0, 45);
            this.InstantbuttonNo4s0.Name = "InstantbuttonNo4s0";
            this.InstantbuttonNo4s0.Size = new System.Drawing.Size(21, 20);
            this.InstantbuttonNo4s0.TabIndex = 33;
            this.InstantbuttonNo4s0.TabStop = true;
            this.InstantbuttonNo4s0.UseVisualStyleBackColor = true;
            // 
            // groupInstant9
            // 
            this.groupInstant9.Controls.Add(this.InstantbuttonNo9s1);
            this.groupInstant9.Controls.Add(this.InstantbuttonNo9s0);
            this.groupInstant9.Location = new System.Drawing.Point(196, 30);
            this.groupInstant9.Name = "groupInstant9";
            this.groupInstant9.Size = new System.Drawing.Size(20, 70);
            this.groupInstant9.TabIndex = 38;
            this.groupInstant9.TabStop = false;
            // 
            // InstantbuttonNo9s1
            // 
            this.InstantbuttonNo9s1.AutoSize = true;
            this.InstantbuttonNo9s1.Location = new System.Drawing.Point(0, 19);
            this.InstantbuttonNo9s1.Name = "InstantbuttonNo9s1";
            this.InstantbuttonNo9s1.Size = new System.Drawing.Size(21, 20);
            this.InstantbuttonNo9s1.TabIndex = 32;
            this.InstantbuttonNo9s1.UseVisualStyleBackColor = true;
            this.InstantbuttonNo9s1.CheckedChanged += new System.EventHandler(this.InstantbuttonNo9s1_CheckedChanged);
            // 
            // InstantbuttonNo9s0
            // 
            this.InstantbuttonNo9s0.AutoSize = true;
            this.InstantbuttonNo9s0.Checked = true;
            this.InstantbuttonNo9s0.Location = new System.Drawing.Point(0, 45);
            this.InstantbuttonNo9s0.Name = "InstantbuttonNo9s0";
            this.InstantbuttonNo9s0.Size = new System.Drawing.Size(21, 20);
            this.InstantbuttonNo9s0.TabIndex = 33;
            this.InstantbuttonNo9s0.TabStop = true;
            this.InstantbuttonNo9s0.UseVisualStyleBackColor = true;
            // 
            // groupInstant2
            // 
            this.groupInstant2.Controls.Add(this.InstantbuttonNo2s1);
            this.groupInstant2.Controls.Add(this.InstantbuttonNo2s0);
            this.groupInstant2.Location = new System.Drawing.Point(423, 30);
            this.groupInstant2.Name = "groupInstant2";
            this.groupInstant2.Size = new System.Drawing.Size(20, 70);
            this.groupInstant2.TabIndex = 47;
            this.groupInstant2.TabStop = false;
            // 
            // InstantbuttonNo2s1
            // 
            this.InstantbuttonNo2s1.AutoSize = true;
            this.InstantbuttonNo2s1.Location = new System.Drawing.Point(0, 19);
            this.InstantbuttonNo2s1.Name = "InstantbuttonNo2s1";
            this.InstantbuttonNo2s1.Size = new System.Drawing.Size(21, 20);
            this.InstantbuttonNo2s1.TabIndex = 32;
            this.InstantbuttonNo2s1.UseVisualStyleBackColor = true;
            this.InstantbuttonNo2s1.CheckedChanged += new System.EventHandler(this.InstantbuttonNo2s1_CheckedChanged);
            // 
            // InstantbuttonNo2s0
            // 
            this.InstantbuttonNo2s0.AutoSize = true;
            this.InstantbuttonNo2s0.Checked = true;
            this.InstantbuttonNo2s0.Location = new System.Drawing.Point(0, 45);
            this.InstantbuttonNo2s0.Name = "InstantbuttonNo2s0";
            this.InstantbuttonNo2s0.Size = new System.Drawing.Size(21, 20);
            this.InstantbuttonNo2s0.TabIndex = 33;
            this.InstantbuttonNo2s0.TabStop = true;
            this.InstantbuttonNo2s0.UseVisualStyleBackColor = true;
            // 
            // groupInstant12
            // 
            this.groupInstant12.Controls.Add(this.InstantbuttonNo12s1);
            this.groupInstant12.Controls.Add(this.InstantbuttonNo12s0);
            this.groupInstant12.Location = new System.Drawing.Point(117, 30);
            this.groupInstant12.Name = "groupInstant12";
            this.groupInstant12.Size = new System.Drawing.Size(20, 70);
            this.groupInstant12.TabIndex = 35;
            this.groupInstant12.TabStop = false;
            // 
            // InstantbuttonNo12s1
            // 
            this.InstantbuttonNo12s1.AutoSize = true;
            this.InstantbuttonNo12s1.Location = new System.Drawing.Point(0, 19);
            this.InstantbuttonNo12s1.Name = "InstantbuttonNo12s1";
            this.InstantbuttonNo12s1.Size = new System.Drawing.Size(21, 20);
            this.InstantbuttonNo12s1.TabIndex = 32;
            this.InstantbuttonNo12s1.UseVisualStyleBackColor = true;
            this.InstantbuttonNo12s1.CheckedChanged += new System.EventHandler(this.InstantbuttonNo12s1_CheckedChanged);
            // 
            // InstantbuttonNo12s0
            // 
            this.InstantbuttonNo12s0.AutoSize = true;
            this.InstantbuttonNo12s0.Checked = true;
            this.InstantbuttonNo12s0.Location = new System.Drawing.Point(0, 45);
            this.InstantbuttonNo12s0.Name = "InstantbuttonNo12s0";
            this.InstantbuttonNo12s0.Size = new System.Drawing.Size(21, 20);
            this.InstantbuttonNo12s0.TabIndex = 33;
            this.InstantbuttonNo12s0.TabStop = true;
            this.InstantbuttonNo12s0.UseVisualStyleBackColor = true;
            // 
            // groupInstant5
            // 
            this.groupInstant5.Controls.Add(this.InstantbuttonNo5s1);
            this.groupInstant5.Controls.Add(this.InstantbuttonNo5s0);
            this.groupInstant5.Location = new System.Drawing.Point(344, 30);
            this.groupInstant5.Name = "groupInstant5";
            this.groupInstant5.Size = new System.Drawing.Size(20, 70);
            this.groupInstant5.TabIndex = 42;
            this.groupInstant5.TabStop = false;
            // 
            // InstantbuttonNo5s1
            // 
            this.InstantbuttonNo5s1.AutoSize = true;
            this.InstantbuttonNo5s1.Location = new System.Drawing.Point(0, 19);
            this.InstantbuttonNo5s1.Name = "InstantbuttonNo5s1";
            this.InstantbuttonNo5s1.Size = new System.Drawing.Size(21, 20);
            this.InstantbuttonNo5s1.TabIndex = 32;
            this.InstantbuttonNo5s1.UseVisualStyleBackColor = true;
            this.InstantbuttonNo5s1.CheckedChanged += new System.EventHandler(this.InstantbuttonNo5s1_CheckedChanged);
            // 
            // InstantbuttonNo5s0
            // 
            this.InstantbuttonNo5s0.AutoSize = true;
            this.InstantbuttonNo5s0.Checked = true;
            this.InstantbuttonNo5s0.Location = new System.Drawing.Point(0, 45);
            this.InstantbuttonNo5s0.Name = "InstantbuttonNo5s0";
            this.InstantbuttonNo5s0.Size = new System.Drawing.Size(21, 20);
            this.InstantbuttonNo5s0.TabIndex = 33;
            this.InstantbuttonNo5s0.TabStop = true;
            this.InstantbuttonNo5s0.UseVisualStyleBackColor = true;
            // 
            // groupInstant10
            // 
            this.groupInstant10.Controls.Add(this.InstantbuttonNo10s1);
            this.groupInstant10.Controls.Add(this.InstantbuttonNo10s0);
            this.groupInstant10.Location = new System.Drawing.Point(170, 30);
            this.groupInstant10.Name = "groupInstant10";
            this.groupInstant10.Size = new System.Drawing.Size(20, 70);
            this.groupInstant10.TabIndex = 39;
            this.groupInstant10.TabStop = false;
            // 
            // InstantbuttonNo10s1
            // 
            this.InstantbuttonNo10s1.AutoSize = true;
            this.InstantbuttonNo10s1.Location = new System.Drawing.Point(0, 19);
            this.InstantbuttonNo10s1.Name = "InstantbuttonNo10s1";
            this.InstantbuttonNo10s1.Size = new System.Drawing.Size(21, 20);
            this.InstantbuttonNo10s1.TabIndex = 32;
            this.InstantbuttonNo10s1.UseVisualStyleBackColor = true;
            this.InstantbuttonNo10s1.CheckedChanged += new System.EventHandler(this.InstantbuttonNo10s1_CheckedChanged);
            // 
            // InstantbuttonNo10s0
            // 
            this.InstantbuttonNo10s0.AutoSize = true;
            this.InstantbuttonNo10s0.Checked = true;
            this.InstantbuttonNo10s0.Location = new System.Drawing.Point(0, 45);
            this.InstantbuttonNo10s0.Name = "InstantbuttonNo10s0";
            this.InstantbuttonNo10s0.Size = new System.Drawing.Size(21, 20);
            this.InstantbuttonNo10s0.TabIndex = 33;
            this.InstantbuttonNo10s0.TabStop = true;
            this.InstantbuttonNo10s0.UseVisualStyleBackColor = true;
            // 
            // groupInstant3
            // 
            this.groupInstant3.Controls.Add(this.InstantbuttonNo3s1);
            this.groupInstant3.Controls.Add(this.InstantbuttonNo3s0);
            this.groupInstant3.Location = new System.Drawing.Point(397, 30);
            this.groupInstant3.Name = "groupInstant3";
            this.groupInstant3.Size = new System.Drawing.Size(20, 70);
            this.groupInstant3.TabIndex = 44;
            this.groupInstant3.TabStop = false;
            // 
            // InstantbuttonNo3s1
            // 
            this.InstantbuttonNo3s1.AutoSize = true;
            this.InstantbuttonNo3s1.Location = new System.Drawing.Point(0, 19);
            this.InstantbuttonNo3s1.Name = "InstantbuttonNo3s1";
            this.InstantbuttonNo3s1.Size = new System.Drawing.Size(21, 20);
            this.InstantbuttonNo3s1.TabIndex = 32;
            this.InstantbuttonNo3s1.UseVisualStyleBackColor = true;
            this.InstantbuttonNo3s1.CheckedChanged += new System.EventHandler(this.InstantbuttonNo3s1_CheckedChanged);
            // 
            // InstantbuttonNo3s0
            // 
            this.InstantbuttonNo3s0.AutoSize = true;
            this.InstantbuttonNo3s0.Checked = true;
            this.InstantbuttonNo3s0.Location = new System.Drawing.Point(0, 45);
            this.InstantbuttonNo3s0.Name = "InstantbuttonNo3s0";
            this.InstantbuttonNo3s0.Size = new System.Drawing.Size(21, 20);
            this.InstantbuttonNo3s0.TabIndex = 33;
            this.InstantbuttonNo3s0.TabStop = true;
            this.InstantbuttonNo3s0.UseVisualStyleBackColor = true;
            // 
            // groupInstant13
            // 
            this.groupInstant13.Controls.Add(this.InstantbuttonNo13s1);
            this.groupInstant13.Controls.Add(this.InstantbuttonNo13s0);
            this.groupInstant13.Location = new System.Drawing.Point(91, 30);
            this.groupInstant13.Name = "groupInstant13";
            this.groupInstant13.Size = new System.Drawing.Size(20, 70);
            this.groupInstant13.TabIndex = 35;
            this.groupInstant13.TabStop = false;
            // 
            // InstantbuttonNo13s1
            // 
            this.InstantbuttonNo13s1.AutoSize = true;
            this.InstantbuttonNo13s1.Location = new System.Drawing.Point(0, 19);
            this.InstantbuttonNo13s1.Name = "InstantbuttonNo13s1";
            this.InstantbuttonNo13s1.Size = new System.Drawing.Size(21, 20);
            this.InstantbuttonNo13s1.TabIndex = 32;
            this.InstantbuttonNo13s1.UseVisualStyleBackColor = true;
            this.InstantbuttonNo13s1.CheckedChanged += new System.EventHandler(this.InstantbuttonNo13s1_CheckedChanged);
            // 
            // InstantbuttonNo13s0
            // 
            this.InstantbuttonNo13s0.AutoSize = true;
            this.InstantbuttonNo13s0.Checked = true;
            this.InstantbuttonNo13s0.Location = new System.Drawing.Point(0, 45);
            this.InstantbuttonNo13s0.Name = "InstantbuttonNo13s0";
            this.InstantbuttonNo13s0.Size = new System.Drawing.Size(21, 20);
            this.InstantbuttonNo13s0.TabIndex = 33;
            this.InstantbuttonNo13s0.TabStop = true;
            this.InstantbuttonNo13s0.UseVisualStyleBackColor = true;
            // 
            // groupInstant6
            // 
            this.groupInstant6.Controls.Add(this.InstantbuttonNo6s1);
            this.groupInstant6.Controls.Add(this.InstantbuttonNo6s0);
            this.groupInstant6.Location = new System.Drawing.Point(318, 30);
            this.groupInstant6.Name = "groupInstant6";
            this.groupInstant6.Size = new System.Drawing.Size(20, 70);
            this.groupInstant6.TabIndex = 43;
            this.groupInstant6.TabStop = false;
            // 
            // InstantbuttonNo6s1
            // 
            this.InstantbuttonNo6s1.AutoSize = true;
            this.InstantbuttonNo6s1.Location = new System.Drawing.Point(0, 19);
            this.InstantbuttonNo6s1.Name = "InstantbuttonNo6s1";
            this.InstantbuttonNo6s1.Size = new System.Drawing.Size(21, 20);
            this.InstantbuttonNo6s1.TabIndex = 32;
            this.InstantbuttonNo6s1.UseVisualStyleBackColor = true;
            this.InstantbuttonNo6s1.CheckedChanged += new System.EventHandler(this.InstantbuttonNo6s1_CheckedChanged);
            // 
            // InstantbuttonNo6s0
            // 
            this.InstantbuttonNo6s0.AutoSize = true;
            this.InstantbuttonNo6s0.Checked = true;
            this.InstantbuttonNo6s0.Location = new System.Drawing.Point(0, 45);
            this.InstantbuttonNo6s0.Name = "InstantbuttonNo6s0";
            this.InstantbuttonNo6s0.Size = new System.Drawing.Size(21, 20);
            this.InstantbuttonNo6s0.TabIndex = 33;
            this.InstantbuttonNo6s0.TabStop = true;
            this.InstantbuttonNo6s0.UseVisualStyleBackColor = true;
            // 
            // groupInstant11
            // 
            this.groupInstant11.Controls.Add(this.InstantbuttonNo11s1);
            this.groupInstant11.Controls.Add(this.InstantbuttonNo11s0);
            this.groupInstant11.Location = new System.Drawing.Point(144, 30);
            this.groupInstant11.Name = "groupInstant11";
            this.groupInstant11.Size = new System.Drawing.Size(20, 70);
            this.groupInstant11.TabIndex = 36;
            this.groupInstant11.TabStop = false;
            // 
            // InstantbuttonNo11s1
            // 
            this.InstantbuttonNo11s1.AutoSize = true;
            this.InstantbuttonNo11s1.Location = new System.Drawing.Point(0, 19);
            this.InstantbuttonNo11s1.Name = "InstantbuttonNo11s1";
            this.InstantbuttonNo11s1.Size = new System.Drawing.Size(21, 20);
            this.InstantbuttonNo11s1.TabIndex = 32;
            this.InstantbuttonNo11s1.UseVisualStyleBackColor = true;
            this.InstantbuttonNo11s1.CheckedChanged += new System.EventHandler(this.InstantbuttonNo11s1_CheckedChanged);
            // 
            // InstantbuttonNo11s0
            // 
            this.InstantbuttonNo11s0.AutoSize = true;
            this.InstantbuttonNo11s0.Checked = true;
            this.InstantbuttonNo11s0.Location = new System.Drawing.Point(0, 45);
            this.InstantbuttonNo11s0.Name = "InstantbuttonNo11s0";
            this.InstantbuttonNo11s0.Size = new System.Drawing.Size(21, 20);
            this.InstantbuttonNo11s0.TabIndex = 33;
            this.InstantbuttonNo11s0.TabStop = true;
            this.InstantbuttonNo11s0.UseVisualStyleBackColor = true;
            // 
            // groupInstant7
            // 
            this.groupInstant7.Controls.Add(this.InstantbuttonNo7s1);
            this.groupInstant7.Controls.Add(this.InstantbuttonNo7s0);
            this.groupInstant7.Location = new System.Drawing.Point(292, 30);
            this.groupInstant7.Name = "groupInstant7";
            this.groupInstant7.Size = new System.Drawing.Size(20, 70);
            this.groupInstant7.TabIndex = 40;
            this.groupInstant7.TabStop = false;
            // 
            // InstantbuttonNo7s1
            // 
            this.InstantbuttonNo7s1.AutoSize = true;
            this.InstantbuttonNo7s1.Location = new System.Drawing.Point(0, 19);
            this.InstantbuttonNo7s1.Name = "InstantbuttonNo7s1";
            this.InstantbuttonNo7s1.Size = new System.Drawing.Size(21, 20);
            this.InstantbuttonNo7s1.TabIndex = 32;
            this.InstantbuttonNo7s1.UseVisualStyleBackColor = true;
            this.InstantbuttonNo7s1.CheckedChanged += new System.EventHandler(this.InstantbuttonNo7s1_CheckedChanged);
            // 
            // InstantbuttonNo7s0
            // 
            this.InstantbuttonNo7s0.AutoSize = true;
            this.InstantbuttonNo7s0.Checked = true;
            this.InstantbuttonNo7s0.Location = new System.Drawing.Point(0, 45);
            this.InstantbuttonNo7s0.Name = "InstantbuttonNo7s0";
            this.InstantbuttonNo7s0.Size = new System.Drawing.Size(21, 20);
            this.InstantbuttonNo7s0.TabIndex = 33;
            this.InstantbuttonNo7s0.TabStop = true;
            this.InstantbuttonNo7s0.UseVisualStyleBackColor = true;
            // 
            // groupInstant14
            // 
            this.groupInstant14.Controls.Add(this.InstantbuttonNo14s1);
            this.groupInstant14.Controls.Add(this.InstantbuttonNo14s0);
            this.groupInstant14.Location = new System.Drawing.Point(65, 30);
            this.groupInstant14.Name = "groupInstant14";
            this.groupInstant14.Size = new System.Drawing.Size(20, 70);
            this.groupInstant14.TabIndex = 35;
            this.groupInstant14.TabStop = false;
            // 
            // InstantbuttonNo14s1
            // 
            this.InstantbuttonNo14s1.AutoSize = true;
            this.InstantbuttonNo14s1.Location = new System.Drawing.Point(0, 19);
            this.InstantbuttonNo14s1.Name = "InstantbuttonNo14s1";
            this.InstantbuttonNo14s1.Size = new System.Drawing.Size(21, 20);
            this.InstantbuttonNo14s1.TabIndex = 32;
            this.InstantbuttonNo14s1.UseVisualStyleBackColor = true;
            this.InstantbuttonNo14s1.CheckedChanged += new System.EventHandler(this.InstantbuttonNo14s1_CheckedChanged);
            // 
            // InstantbuttonNo14s0
            // 
            this.InstantbuttonNo14s0.AutoSize = true;
            this.InstantbuttonNo14s0.Checked = true;
            this.InstantbuttonNo14s0.Location = new System.Drawing.Point(0, 45);
            this.InstantbuttonNo14s0.Name = "InstantbuttonNo14s0";
            this.InstantbuttonNo14s0.Size = new System.Drawing.Size(21, 20);
            this.InstantbuttonNo14s0.TabIndex = 33;
            this.InstantbuttonNo14s0.TabStop = true;
            this.InstantbuttonNo14s0.UseVisualStyleBackColor = true;
            // 
            // groupInstant15
            // 
            this.groupInstant15.Controls.Add(this.InstantbuttonNo15s1);
            this.groupInstant15.Controls.Add(this.InstantbuttonNo15s0);
            this.groupInstant15.Location = new System.Drawing.Point(39, 30);
            this.groupInstant15.Name = "groupInstant15";
            this.groupInstant15.Size = new System.Drawing.Size(20, 70);
            this.groupInstant15.TabIndex = 34;
            this.groupInstant15.TabStop = false;
            // 
            // InstantbuttonNo15s1
            // 
            this.InstantbuttonNo15s1.AutoSize = true;
            this.InstantbuttonNo15s1.Location = new System.Drawing.Point(0, 19);
            this.InstantbuttonNo15s1.Name = "InstantbuttonNo15s1";
            this.InstantbuttonNo15s1.Size = new System.Drawing.Size(21, 20);
            this.InstantbuttonNo15s1.TabIndex = 32;
            this.InstantbuttonNo15s1.UseVisualStyleBackColor = true;
            this.InstantbuttonNo15s1.CheckedChanged += new System.EventHandler(this.InstantbuttonNo15s1_CheckedChanged);
            // 
            // InstantbuttonNo15s0
            // 
            this.InstantbuttonNo15s0.AutoSize = true;
            this.InstantbuttonNo15s0.Checked = true;
            this.InstantbuttonNo15s0.Location = new System.Drawing.Point(0, 45);
            this.InstantbuttonNo15s0.Name = "InstantbuttonNo15s0";
            this.InstantbuttonNo15s0.Size = new System.Drawing.Size(21, 20);
            this.InstantbuttonNo15s0.TabIndex = 33;
            this.InstantbuttonNo15s0.TabStop = true;
            this.InstantbuttonNo15s0.UseVisualStyleBackColor = true;
            // 
            // groupBoxDX
            // 
            this.groupBoxDX.Controls.Add(this.label18);
            this.groupBoxDX.Controls.Add(this.label6);
            this.groupBoxDX.Controls.Add(this.label19);
            this.groupBoxDX.Controls.Add(this.label7);
            this.groupBoxDX.Controls.Add(this.labelDL);
            this.groupBoxDX.Controls.Add(this.labelDH);
            this.groupBoxDX.Controls.Add(this.buttonWriteDX);
            this.groupBoxDX.Controls.Add(this.DHActive);
            this.groupBoxDX.Controls.Add(this.DLActive);
            this.groupBoxDX.Controls.Add(this.gruopDX0);
            this.groupBoxDX.Controls.Add(this.gruopDX1);
            this.groupBoxDX.Controls.Add(this.gruopDX8);
            this.groupBoxDX.Controls.Add(this.gruopDX4);
            this.groupBoxDX.Controls.Add(this.gruopDX9);
            this.groupBoxDX.Controls.Add(this.gruopDX2);
            this.groupBoxDX.Controls.Add(this.gruopDX12);
            this.groupBoxDX.Controls.Add(this.gruopDX5);
            this.groupBoxDX.Controls.Add(this.gruopDX10);
            this.groupBoxDX.Controls.Add(this.gruopDX3);
            this.groupBoxDX.Controls.Add(this.gruopDX13);
            this.groupBoxDX.Controls.Add(this.gruopDX6);
            this.groupBoxDX.Controls.Add(this.gruopDX11);
            this.groupBoxDX.Controls.Add(this.gruopDX7);
            this.groupBoxDX.Controls.Add(this.gruopDX14);
            this.groupBoxDX.Controls.Add(this.gruopDX15);
            this.groupBoxDX.Location = new System.Drawing.Point(542, 236);
            this.groupBoxDX.Name = "groupBoxDX";
            this.groupBoxDX.Size = new System.Drawing.Size(517, 175);
            this.groupBoxDX.TabIndex = 3;
            this.groupBoxDX.TabStop = false;
            this.groupBoxDX.Text = "Rejestr DX";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(364, 136);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(33, 25);
            this.label18.TabIndex = 84;
            this.label18.Text = "DL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 25);
            this.label6.TabIndex = 78;
            this.label6.Text = "0";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(133, 136);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(38, 25);
            this.label19.TabIndex = 83;
            this.label19.Text = "DH";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 25);
            this.label7.TabIndex = 77;
            this.label7.Text = "1";
            // 
            // labelDL
            // 
            this.labelDL.AutoSize = true;
            this.labelDL.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelDL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDL.Location = new System.Drawing.Point(265, 134);
            this.labelDL.Name = "labelDL";
            this.labelDL.Size = new System.Drawing.Size(94, 27);
            this.labelDL.TabIndex = 82;
            this.labelDL.Text = "00000000";
            // 
            // labelDH
            // 
            this.labelDH.AutoSize = true;
            this.labelDH.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelDH.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDH.Location = new System.Drawing.Point(174, 134);
            this.labelDH.Name = "labelDH";
            this.labelDH.Size = new System.Drawing.Size(94, 27);
            this.labelDH.TabIndex = 81;
            this.labelDH.Text = "00000000";
            // 
            // buttonWriteDX
            // 
            this.buttonWriteDX.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonWriteDX.Location = new System.Drawing.Point(217, 106);
            this.buttonWriteDX.Name = "buttonWriteDX";
            this.buttonWriteDX.Size = new System.Drawing.Size(103, 25);
            this.buttonWriteDX.TabIndex = 68;
            this.buttonWriteDX.Text = "Wpisz";
            this.buttonWriteDX.UseVisualStyleBackColor = true;
            this.buttonWriteDX.Click += new System.EventHandler(this.buttonWriteDX_Click);
            // 
            // DHActive
            // 
            this.DHActive.AutoSize = true;
            this.DHActive.Location = new System.Drawing.Point(95, 103);
            this.DHActive.Name = "DHActive";
            this.DHActive.Size = new System.Drawing.Size(92, 25);
            this.DHActive.TabIndex = 69;
            this.DHActive.Text = "00000000";
            // 
            // DLActive
            // 
            this.DLActive.AutoSize = true;
            this.DLActive.Location = new System.Drawing.Point(348, 103);
            this.DLActive.Name = "DLActive";
            this.DLActive.Size = new System.Drawing.Size(92, 25);
            this.DLActive.TabIndex = 68;
            this.DLActive.Text = "00000000";
            // 
            // gruopDX0
            // 
            this.gruopDX0.Controls.Add(this.DXbuttonNo0s1);
            this.gruopDX0.Controls.Add(this.DXbuttonNo0s0);
            this.gruopDX0.Location = new System.Drawing.Point(471, 30);
            this.gruopDX0.Name = "gruopDX0";
            this.gruopDX0.Size = new System.Drawing.Size(20, 70);
            this.gruopDX0.TabIndex = 61;
            this.gruopDX0.TabStop = false;
            // 
            // DXbuttonNo0s1
            // 
            this.DXbuttonNo0s1.AutoSize = true;
            this.DXbuttonNo0s1.Location = new System.Drawing.Point(0, 19);
            this.DXbuttonNo0s1.Name = "DXbuttonNo0s1";
            this.DXbuttonNo0s1.Size = new System.Drawing.Size(21, 20);
            this.DXbuttonNo0s1.TabIndex = 32;
            this.DXbuttonNo0s1.UseVisualStyleBackColor = true;
            this.DXbuttonNo0s1.CheckedChanged += new System.EventHandler(this.DXbuttonNo0s1_CheckedChanged);
            // 
            // DXbuttonNo0s0
            // 
            this.DXbuttonNo0s0.AutoSize = true;
            this.DXbuttonNo0s0.Checked = true;
            this.DXbuttonNo0s0.Location = new System.Drawing.Point(0, 45);
            this.DXbuttonNo0s0.Name = "DXbuttonNo0s0";
            this.DXbuttonNo0s0.Size = new System.Drawing.Size(21, 20);
            this.DXbuttonNo0s0.TabIndex = 33;
            this.DXbuttonNo0s0.TabStop = true;
            this.DXbuttonNo0s0.UseVisualStyleBackColor = true;
            // 
            // gruopDX1
            // 
            this.gruopDX1.Controls.Add(this.DXbuttonNo1s1);
            this.gruopDX1.Controls.Add(this.DXbuttonNo1s0);
            this.gruopDX1.Location = new System.Drawing.Point(445, 30);
            this.gruopDX1.Name = "gruopDX1";
            this.gruopDX1.Size = new System.Drawing.Size(20, 70);
            this.gruopDX1.TabIndex = 62;
            this.gruopDX1.TabStop = false;
            // 
            // DXbuttonNo1s1
            // 
            this.DXbuttonNo1s1.AutoSize = true;
            this.DXbuttonNo1s1.Location = new System.Drawing.Point(0, 19);
            this.DXbuttonNo1s1.Name = "DXbuttonNo1s1";
            this.DXbuttonNo1s1.Size = new System.Drawing.Size(21, 20);
            this.DXbuttonNo1s1.TabIndex = 32;
            this.DXbuttonNo1s1.UseVisualStyleBackColor = true;
            this.DXbuttonNo1s1.CheckedChanged += new System.EventHandler(this.DXbuttonNo1s1_CheckedChanged);
            // 
            // DXbuttonNo1s0
            // 
            this.DXbuttonNo1s0.AutoSize = true;
            this.DXbuttonNo1s0.Checked = true;
            this.DXbuttonNo1s0.Location = new System.Drawing.Point(0, 45);
            this.DXbuttonNo1s0.Name = "DXbuttonNo1s0";
            this.DXbuttonNo1s0.Size = new System.Drawing.Size(21, 20);
            this.DXbuttonNo1s0.TabIndex = 33;
            this.DXbuttonNo1s0.TabStop = true;
            this.DXbuttonNo1s0.UseVisualStyleBackColor = true;
            // 
            // gruopDX8
            // 
            this.gruopDX8.Controls.Add(this.DXbuttonNo8s1);
            this.gruopDX8.Controls.Add(this.DXbuttonNo8s0);
            this.gruopDX8.Location = new System.Drawing.Point(218, 30);
            this.gruopDX8.Name = "gruopDX8";
            this.gruopDX8.Size = new System.Drawing.Size(20, 70);
            this.gruopDX8.TabIndex = 53;
            this.gruopDX8.TabStop = false;
            // 
            // DXbuttonNo8s1
            // 
            this.DXbuttonNo8s1.AutoSize = true;
            this.DXbuttonNo8s1.Location = new System.Drawing.Point(0, 19);
            this.DXbuttonNo8s1.Name = "DXbuttonNo8s1";
            this.DXbuttonNo8s1.Size = new System.Drawing.Size(21, 20);
            this.DXbuttonNo8s1.TabIndex = 32;
            this.DXbuttonNo8s1.UseVisualStyleBackColor = true;
            this.DXbuttonNo8s1.CheckedChanged += new System.EventHandler(this.DXbuttonNo8s1_CheckedChanged);
            // 
            // DXbuttonNo8s0
            // 
            this.DXbuttonNo8s0.AutoSize = true;
            this.DXbuttonNo8s0.Checked = true;
            this.DXbuttonNo8s0.Location = new System.Drawing.Point(0, 45);
            this.DXbuttonNo8s0.Name = "DXbuttonNo8s0";
            this.DXbuttonNo8s0.Size = new System.Drawing.Size(21, 20);
            this.DXbuttonNo8s0.TabIndex = 33;
            this.DXbuttonNo8s0.TabStop = true;
            this.DXbuttonNo8s0.UseVisualStyleBackColor = true;
            // 
            // gruopDX4
            // 
            this.gruopDX4.Controls.Add(this.DXbuttonNo4s1);
            this.gruopDX4.Controls.Add(this.DXbuttonNo4s0);
            this.gruopDX4.Location = new System.Drawing.Point(366, 30);
            this.gruopDX4.Name = "gruopDX4";
            this.gruopDX4.Size = new System.Drawing.Size(20, 70);
            this.gruopDX4.TabIndex = 57;
            this.gruopDX4.TabStop = false;
            // 
            // DXbuttonNo4s1
            // 
            this.DXbuttonNo4s1.AutoSize = true;
            this.DXbuttonNo4s1.Location = new System.Drawing.Point(0, 19);
            this.DXbuttonNo4s1.Name = "DXbuttonNo4s1";
            this.DXbuttonNo4s1.Size = new System.Drawing.Size(21, 20);
            this.DXbuttonNo4s1.TabIndex = 32;
            this.DXbuttonNo4s1.UseVisualStyleBackColor = true;
            this.DXbuttonNo4s1.CheckedChanged += new System.EventHandler(this.DXbuttonNo4s1_CheckedChanged);
            // 
            // DXbuttonNo4s0
            // 
            this.DXbuttonNo4s0.AutoSize = true;
            this.DXbuttonNo4s0.Checked = true;
            this.DXbuttonNo4s0.Location = new System.Drawing.Point(0, 45);
            this.DXbuttonNo4s0.Name = "DXbuttonNo4s0";
            this.DXbuttonNo4s0.Size = new System.Drawing.Size(21, 20);
            this.DXbuttonNo4s0.TabIndex = 33;
            this.DXbuttonNo4s0.TabStop = true;
            this.DXbuttonNo4s0.UseVisualStyleBackColor = true;
            // 
            // gruopDX9
            // 
            this.gruopDX9.Controls.Add(this.DXbuttonNo9s1);
            this.gruopDX9.Controls.Add(this.DXbuttonNo9s0);
            this.gruopDX9.Location = new System.Drawing.Point(192, 30);
            this.gruopDX9.Name = "gruopDX9";
            this.gruopDX9.Size = new System.Drawing.Size(20, 70);
            this.gruopDX9.TabIndex = 54;
            this.gruopDX9.TabStop = false;
            // 
            // DXbuttonNo9s1
            // 
            this.DXbuttonNo9s1.AutoSize = true;
            this.DXbuttonNo9s1.Location = new System.Drawing.Point(0, 19);
            this.DXbuttonNo9s1.Name = "DXbuttonNo9s1";
            this.DXbuttonNo9s1.Size = new System.Drawing.Size(21, 20);
            this.DXbuttonNo9s1.TabIndex = 32;
            this.DXbuttonNo9s1.UseVisualStyleBackColor = true;
            this.DXbuttonNo9s1.CheckedChanged += new System.EventHandler(this.DXbuttonNo9s1_CheckedChanged);
            // 
            // DXbuttonNo9s0
            // 
            this.DXbuttonNo9s0.AutoSize = true;
            this.DXbuttonNo9s0.Checked = true;
            this.DXbuttonNo9s0.Location = new System.Drawing.Point(0, 45);
            this.DXbuttonNo9s0.Name = "DXbuttonNo9s0";
            this.DXbuttonNo9s0.Size = new System.Drawing.Size(21, 20);
            this.DXbuttonNo9s0.TabIndex = 33;
            this.DXbuttonNo9s0.TabStop = true;
            this.DXbuttonNo9s0.UseVisualStyleBackColor = true;
            // 
            // gruopDX2
            // 
            this.gruopDX2.Controls.Add(this.DXbuttonNo2s1);
            this.gruopDX2.Controls.Add(this.DXbuttonNo2s0);
            this.gruopDX2.Location = new System.Drawing.Point(419, 30);
            this.gruopDX2.Name = "gruopDX2";
            this.gruopDX2.Size = new System.Drawing.Size(20, 70);
            this.gruopDX2.TabIndex = 63;
            this.gruopDX2.TabStop = false;
            // 
            // DXbuttonNo2s1
            // 
            this.DXbuttonNo2s1.AutoSize = true;
            this.DXbuttonNo2s1.Location = new System.Drawing.Point(0, 19);
            this.DXbuttonNo2s1.Name = "DXbuttonNo2s1";
            this.DXbuttonNo2s1.Size = new System.Drawing.Size(21, 20);
            this.DXbuttonNo2s1.TabIndex = 32;
            this.DXbuttonNo2s1.UseVisualStyleBackColor = true;
            this.DXbuttonNo2s1.CheckedChanged += new System.EventHandler(this.DXbuttonNo2s1_CheckedChanged);
            // 
            // DXbuttonNo2s0
            // 
            this.DXbuttonNo2s0.AutoSize = true;
            this.DXbuttonNo2s0.Checked = true;
            this.DXbuttonNo2s0.Location = new System.Drawing.Point(0, 45);
            this.DXbuttonNo2s0.Name = "DXbuttonNo2s0";
            this.DXbuttonNo2s0.Size = new System.Drawing.Size(21, 20);
            this.DXbuttonNo2s0.TabIndex = 33;
            this.DXbuttonNo2s0.TabStop = true;
            this.DXbuttonNo2s0.UseVisualStyleBackColor = true;
            // 
            // gruopDX12
            // 
            this.gruopDX12.Controls.Add(this.DXbuttonNo12s1);
            this.gruopDX12.Controls.Add(this.DXbuttonNo12s0);
            this.gruopDX12.Location = new System.Drawing.Point(113, 30);
            this.gruopDX12.Name = "gruopDX12";
            this.gruopDX12.Size = new System.Drawing.Size(20, 70);
            this.gruopDX12.TabIndex = 49;
            this.gruopDX12.TabStop = false;
            // 
            // DXbuttonNo12s1
            // 
            this.DXbuttonNo12s1.AutoSize = true;
            this.DXbuttonNo12s1.Location = new System.Drawing.Point(0, 19);
            this.DXbuttonNo12s1.Name = "DXbuttonNo12s1";
            this.DXbuttonNo12s1.Size = new System.Drawing.Size(21, 20);
            this.DXbuttonNo12s1.TabIndex = 32;
            this.DXbuttonNo12s1.UseVisualStyleBackColor = true;
            this.DXbuttonNo12s1.CheckedChanged += new System.EventHandler(this.DXbuttonNo12s1_CheckedChanged);
            // 
            // DXbuttonNo12s0
            // 
            this.DXbuttonNo12s0.AutoSize = true;
            this.DXbuttonNo12s0.Checked = true;
            this.DXbuttonNo12s0.Location = new System.Drawing.Point(0, 45);
            this.DXbuttonNo12s0.Name = "DXbuttonNo12s0";
            this.DXbuttonNo12s0.Size = new System.Drawing.Size(21, 20);
            this.DXbuttonNo12s0.TabIndex = 33;
            this.DXbuttonNo12s0.TabStop = true;
            this.DXbuttonNo12s0.UseVisualStyleBackColor = true;
            // 
            // gruopDX5
            // 
            this.gruopDX5.Controls.Add(this.DXbuttonNo5s1);
            this.gruopDX5.Controls.Add(this.DXbuttonNo5s0);
            this.gruopDX5.Location = new System.Drawing.Point(340, 30);
            this.gruopDX5.Name = "gruopDX5";
            this.gruopDX5.Size = new System.Drawing.Size(20, 70);
            this.gruopDX5.TabIndex = 58;
            this.gruopDX5.TabStop = false;
            // 
            // DXbuttonNo5s1
            // 
            this.DXbuttonNo5s1.AutoSize = true;
            this.DXbuttonNo5s1.Location = new System.Drawing.Point(0, 19);
            this.DXbuttonNo5s1.Name = "DXbuttonNo5s1";
            this.DXbuttonNo5s1.Size = new System.Drawing.Size(21, 20);
            this.DXbuttonNo5s1.TabIndex = 32;
            this.DXbuttonNo5s1.UseVisualStyleBackColor = true;
            this.DXbuttonNo5s1.CheckedChanged += new System.EventHandler(this.DXbuttonNo5s1_CheckedChanged);
            // 
            // DXbuttonNo5s0
            // 
            this.DXbuttonNo5s0.AutoSize = true;
            this.DXbuttonNo5s0.Checked = true;
            this.DXbuttonNo5s0.Location = new System.Drawing.Point(0, 45);
            this.DXbuttonNo5s0.Name = "DXbuttonNo5s0";
            this.DXbuttonNo5s0.Size = new System.Drawing.Size(21, 20);
            this.DXbuttonNo5s0.TabIndex = 33;
            this.DXbuttonNo5s0.TabStop = true;
            this.DXbuttonNo5s0.UseVisualStyleBackColor = true;
            // 
            // gruopDX10
            // 
            this.gruopDX10.Controls.Add(this.DXbuttonNo10s1);
            this.gruopDX10.Controls.Add(this.DXbuttonNo10s0);
            this.gruopDX10.Location = new System.Drawing.Point(166, 30);
            this.gruopDX10.Name = "gruopDX10";
            this.gruopDX10.Size = new System.Drawing.Size(20, 70);
            this.gruopDX10.TabIndex = 55;
            this.gruopDX10.TabStop = false;
            // 
            // DXbuttonNo10s1
            // 
            this.DXbuttonNo10s1.AutoSize = true;
            this.DXbuttonNo10s1.Location = new System.Drawing.Point(0, 19);
            this.DXbuttonNo10s1.Name = "DXbuttonNo10s1";
            this.DXbuttonNo10s1.Size = new System.Drawing.Size(21, 20);
            this.DXbuttonNo10s1.TabIndex = 32;
            this.DXbuttonNo10s1.UseVisualStyleBackColor = true;
            this.DXbuttonNo10s1.CheckedChanged += new System.EventHandler(this.DXbuttonNo10s1_CheckedChanged);
            // 
            // DXbuttonNo10s0
            // 
            this.DXbuttonNo10s0.AutoSize = true;
            this.DXbuttonNo10s0.Checked = true;
            this.DXbuttonNo10s0.Location = new System.Drawing.Point(0, 45);
            this.DXbuttonNo10s0.Name = "DXbuttonNo10s0";
            this.DXbuttonNo10s0.Size = new System.Drawing.Size(21, 20);
            this.DXbuttonNo10s0.TabIndex = 33;
            this.DXbuttonNo10s0.TabStop = true;
            this.DXbuttonNo10s0.UseVisualStyleBackColor = true;
            // 
            // gruopDX3
            // 
            this.gruopDX3.Controls.Add(this.DXbuttonNo3s1);
            this.gruopDX3.Controls.Add(this.DXbuttonNo3s0);
            this.gruopDX3.Location = new System.Drawing.Point(393, 30);
            this.gruopDX3.Name = "gruopDX3";
            this.gruopDX3.Size = new System.Drawing.Size(20, 70);
            this.gruopDX3.TabIndex = 60;
            this.gruopDX3.TabStop = false;
            // 
            // DXbuttonNo3s1
            // 
            this.DXbuttonNo3s1.AutoSize = true;
            this.DXbuttonNo3s1.Location = new System.Drawing.Point(0, 19);
            this.DXbuttonNo3s1.Name = "DXbuttonNo3s1";
            this.DXbuttonNo3s1.Size = new System.Drawing.Size(21, 20);
            this.DXbuttonNo3s1.TabIndex = 32;
            this.DXbuttonNo3s1.UseVisualStyleBackColor = true;
            this.DXbuttonNo3s1.CheckedChanged += new System.EventHandler(this.DXbuttonNo3s1_CheckedChanged);
            // 
            // DXbuttonNo3s0
            // 
            this.DXbuttonNo3s0.AutoSize = true;
            this.DXbuttonNo3s0.Checked = true;
            this.DXbuttonNo3s0.Location = new System.Drawing.Point(0, 45);
            this.DXbuttonNo3s0.Name = "DXbuttonNo3s0";
            this.DXbuttonNo3s0.Size = new System.Drawing.Size(21, 20);
            this.DXbuttonNo3s0.TabIndex = 33;
            this.DXbuttonNo3s0.TabStop = true;
            this.DXbuttonNo3s0.UseVisualStyleBackColor = true;
            // 
            // gruopDX13
            // 
            this.gruopDX13.Controls.Add(this.DXbuttonNo13s1);
            this.gruopDX13.Controls.Add(this.DXbuttonNo13s0);
            this.gruopDX13.Location = new System.Drawing.Point(87, 30);
            this.gruopDX13.Name = "gruopDX13";
            this.gruopDX13.Size = new System.Drawing.Size(20, 70);
            this.gruopDX13.TabIndex = 50;
            this.gruopDX13.TabStop = false;
            // 
            // DXbuttonNo13s1
            // 
            this.DXbuttonNo13s1.AutoSize = true;
            this.DXbuttonNo13s1.Location = new System.Drawing.Point(0, 19);
            this.DXbuttonNo13s1.Name = "DXbuttonNo13s1";
            this.DXbuttonNo13s1.Size = new System.Drawing.Size(21, 20);
            this.DXbuttonNo13s1.TabIndex = 32;
            this.DXbuttonNo13s1.UseVisualStyleBackColor = true;
            this.DXbuttonNo13s1.CheckedChanged += new System.EventHandler(this.DXbuttonNo13s1_CheckedChanged);
            // 
            // DXbuttonNo13s0
            // 
            this.DXbuttonNo13s0.AutoSize = true;
            this.DXbuttonNo13s0.Checked = true;
            this.DXbuttonNo13s0.Location = new System.Drawing.Point(0, 45);
            this.DXbuttonNo13s0.Name = "DXbuttonNo13s0";
            this.DXbuttonNo13s0.Size = new System.Drawing.Size(21, 20);
            this.DXbuttonNo13s0.TabIndex = 33;
            this.DXbuttonNo13s0.TabStop = true;
            this.DXbuttonNo13s0.UseVisualStyleBackColor = true;
            // 
            // gruopDX6
            // 
            this.gruopDX6.Controls.Add(this.DXbuttonNo6s1);
            this.gruopDX6.Controls.Add(this.DXbuttonNo6s0);
            this.gruopDX6.Location = new System.Drawing.Point(314, 30);
            this.gruopDX6.Name = "gruopDX6";
            this.gruopDX6.Size = new System.Drawing.Size(20, 70);
            this.gruopDX6.TabIndex = 59;
            this.gruopDX6.TabStop = false;
            // 
            // DXbuttonNo6s1
            // 
            this.DXbuttonNo6s1.AutoSize = true;
            this.DXbuttonNo6s1.Location = new System.Drawing.Point(0, 19);
            this.DXbuttonNo6s1.Name = "DXbuttonNo6s1";
            this.DXbuttonNo6s1.Size = new System.Drawing.Size(21, 20);
            this.DXbuttonNo6s1.TabIndex = 32;
            this.DXbuttonNo6s1.UseVisualStyleBackColor = true;
            this.DXbuttonNo6s1.CheckedChanged += new System.EventHandler(this.DXbuttonNo6s1_CheckedChanged);
            // 
            // DXbuttonNo6s0
            // 
            this.DXbuttonNo6s0.AutoSize = true;
            this.DXbuttonNo6s0.Checked = true;
            this.DXbuttonNo6s0.Location = new System.Drawing.Point(0, 45);
            this.DXbuttonNo6s0.Name = "DXbuttonNo6s0";
            this.DXbuttonNo6s0.Size = new System.Drawing.Size(21, 20);
            this.DXbuttonNo6s0.TabIndex = 33;
            this.DXbuttonNo6s0.TabStop = true;
            this.DXbuttonNo6s0.UseVisualStyleBackColor = true;
            // 
            // gruopDX11
            // 
            this.gruopDX11.Controls.Add(this.DXbuttonNo11s1);
            this.gruopDX11.Controls.Add(this.DXbuttonNo11s0);
            this.gruopDX11.Location = new System.Drawing.Point(140, 30);
            this.gruopDX11.Name = "gruopDX11";
            this.gruopDX11.Size = new System.Drawing.Size(20, 70);
            this.gruopDX11.TabIndex = 52;
            this.gruopDX11.TabStop = false;
            // 
            // DXbuttonNo11s1
            // 
            this.DXbuttonNo11s1.AutoSize = true;
            this.DXbuttonNo11s1.Location = new System.Drawing.Point(0, 19);
            this.DXbuttonNo11s1.Name = "DXbuttonNo11s1";
            this.DXbuttonNo11s1.Size = new System.Drawing.Size(21, 20);
            this.DXbuttonNo11s1.TabIndex = 32;
            this.DXbuttonNo11s1.UseVisualStyleBackColor = true;
            this.DXbuttonNo11s1.CheckedChanged += new System.EventHandler(this.DXbuttonNo11s1_CheckedChanged);
            // 
            // DXbuttonNo11s0
            // 
            this.DXbuttonNo11s0.AutoSize = true;
            this.DXbuttonNo11s0.Checked = true;
            this.DXbuttonNo11s0.Location = new System.Drawing.Point(0, 45);
            this.DXbuttonNo11s0.Name = "DXbuttonNo11s0";
            this.DXbuttonNo11s0.Size = new System.Drawing.Size(21, 20);
            this.DXbuttonNo11s0.TabIndex = 33;
            this.DXbuttonNo11s0.TabStop = true;
            this.DXbuttonNo11s0.UseVisualStyleBackColor = true;
            // 
            // gruopDX7
            // 
            this.gruopDX7.Controls.Add(this.DXbuttonNo7s1);
            this.gruopDX7.Controls.Add(this.DXbuttonNo7s0);
            this.gruopDX7.Location = new System.Drawing.Point(288, 30);
            this.gruopDX7.Name = "gruopDX7";
            this.gruopDX7.Size = new System.Drawing.Size(20, 70);
            this.gruopDX7.TabIndex = 56;
            this.gruopDX7.TabStop = false;
            // 
            // DXbuttonNo7s1
            // 
            this.DXbuttonNo7s1.AutoSize = true;
            this.DXbuttonNo7s1.Location = new System.Drawing.Point(0, 19);
            this.DXbuttonNo7s1.Name = "DXbuttonNo7s1";
            this.DXbuttonNo7s1.Size = new System.Drawing.Size(21, 20);
            this.DXbuttonNo7s1.TabIndex = 32;
            this.DXbuttonNo7s1.UseVisualStyleBackColor = true;
            this.DXbuttonNo7s1.CheckedChanged += new System.EventHandler(this.DXbuttonNo7s1_CheckedChanged);
            // 
            // DXbuttonNo7s0
            // 
            this.DXbuttonNo7s0.AutoSize = true;
            this.DXbuttonNo7s0.Checked = true;
            this.DXbuttonNo7s0.Location = new System.Drawing.Point(0, 45);
            this.DXbuttonNo7s0.Name = "DXbuttonNo7s0";
            this.DXbuttonNo7s0.Size = new System.Drawing.Size(21, 20);
            this.DXbuttonNo7s0.TabIndex = 33;
            this.DXbuttonNo7s0.TabStop = true;
            this.DXbuttonNo7s0.UseVisualStyleBackColor = true;
            // 
            // gruopDX14
            // 
            this.gruopDX14.Controls.Add(this.DXbuttonNo14s1);
            this.gruopDX14.Controls.Add(this.DXbuttonNo14s0);
            this.gruopDX14.Location = new System.Drawing.Point(61, 30);
            this.gruopDX14.Name = "gruopDX14";
            this.gruopDX14.Size = new System.Drawing.Size(20, 70);
            this.gruopDX14.TabIndex = 51;
            this.gruopDX14.TabStop = false;
            // 
            // DXbuttonNo14s1
            // 
            this.DXbuttonNo14s1.AutoSize = true;
            this.DXbuttonNo14s1.Location = new System.Drawing.Point(0, 19);
            this.DXbuttonNo14s1.Name = "DXbuttonNo14s1";
            this.DXbuttonNo14s1.Size = new System.Drawing.Size(21, 20);
            this.DXbuttonNo14s1.TabIndex = 32;
            this.DXbuttonNo14s1.UseVisualStyleBackColor = true;
            this.DXbuttonNo14s1.CheckedChanged += new System.EventHandler(this.DXbuttonNo14s1_CheckedChanged);
            // 
            // DXbuttonNo14s0
            // 
            this.DXbuttonNo14s0.AutoSize = true;
            this.DXbuttonNo14s0.Checked = true;
            this.DXbuttonNo14s0.Location = new System.Drawing.Point(0, 45);
            this.DXbuttonNo14s0.Name = "DXbuttonNo14s0";
            this.DXbuttonNo14s0.Size = new System.Drawing.Size(21, 20);
            this.DXbuttonNo14s0.TabIndex = 33;
            this.DXbuttonNo14s0.TabStop = true;
            this.DXbuttonNo14s0.UseVisualStyleBackColor = true;
            // 
            // gruopDX15
            // 
            this.gruopDX15.Controls.Add(this.DXbuttonNo15s1);
            this.gruopDX15.Controls.Add(this.DXbuttonNo15s0);
            this.gruopDX15.Location = new System.Drawing.Point(35, 30);
            this.gruopDX15.Name = "gruopDX15";
            this.gruopDX15.Size = new System.Drawing.Size(20, 70);
            this.gruopDX15.TabIndex = 48;
            this.gruopDX15.TabStop = false;
            // 
            // DXbuttonNo15s1
            // 
            this.DXbuttonNo15s1.AutoSize = true;
            this.DXbuttonNo15s1.Location = new System.Drawing.Point(0, 19);
            this.DXbuttonNo15s1.Name = "DXbuttonNo15s1";
            this.DXbuttonNo15s1.Size = new System.Drawing.Size(21, 20);
            this.DXbuttonNo15s1.TabIndex = 32;
            this.DXbuttonNo15s1.UseVisualStyleBackColor = true;
            this.DXbuttonNo15s1.CheckedChanged += new System.EventHandler(this.DXbuttonNo15s1_CheckedChanged);
            // 
            // DXbuttonNo15s0
            // 
            this.DXbuttonNo15s0.AutoSize = true;
            this.DXbuttonNo15s0.Checked = true;
            this.DXbuttonNo15s0.Location = new System.Drawing.Point(0, 45);
            this.DXbuttonNo15s0.Name = "DXbuttonNo15s0";
            this.DXbuttonNo15s0.Size = new System.Drawing.Size(21, 20);
            this.DXbuttonNo15s0.TabIndex = 33;
            this.DXbuttonNo15s0.TabStop = true;
            this.DXbuttonNo15s0.UseVisualStyleBackColor = true;
            // 
            // groupBoxCX
            // 
            this.groupBoxCX.Controls.Add(this.label22);
            this.groupBoxCX.Controls.Add(this.label8);
            this.groupBoxCX.Controls.Add(this.label23);
            this.groupBoxCX.Controls.Add(this.label9);
            this.groupBoxCX.Controls.Add(this.labelCL);
            this.groupBoxCX.Controls.Add(this.labelCH);
            this.groupBoxCX.Controls.Add(this.buttonWriteCX);
            this.groupBoxCX.Controls.Add(this.CHActive);
            this.groupBoxCX.Controls.Add(this.CLActive);
            this.groupBoxCX.Controls.Add(this.gruopCX0);
            this.groupBoxCX.Controls.Add(this.gruopCX1);
            this.groupBoxCX.Controls.Add(this.gruopCX8);
            this.groupBoxCX.Controls.Add(this.gruopCX4);
            this.groupBoxCX.Controls.Add(this.gruopCX9);
            this.groupBoxCX.Controls.Add(this.gruopCX2);
            this.groupBoxCX.Controls.Add(this.gruopCX12);
            this.groupBoxCX.Controls.Add(this.gruopCX5);
            this.groupBoxCX.Controls.Add(this.gruopCX10);
            this.groupBoxCX.Controls.Add(this.gruopCX3);
            this.groupBoxCX.Controls.Add(this.gruopCX13);
            this.groupBoxCX.Controls.Add(this.gruopCX6);
            this.groupBoxCX.Controls.Add(this.gruopCX11);
            this.groupBoxCX.Controls.Add(this.gruopCX7);
            this.groupBoxCX.Controls.Add(this.gruopCX14);
            this.groupBoxCX.Controls.Add(this.gruopCX15);
            this.groupBoxCX.Location = new System.Drawing.Point(6, 236);
            this.groupBoxCX.Name = "groupBoxCX";
            this.groupBoxCX.Size = new System.Drawing.Size(530, 175);
            this.groupBoxCX.TabIndex = 2;
            this.groupBoxCX.TabStop = false;
            this.groupBoxCX.Text = "Rejestr CX";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(360, 136);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(31, 25);
            this.label22.TabIndex = 88;
            this.label22.Text = "CL";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 25);
            this.label8.TabIndex = 80;
            this.label8.Text = "0";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(129, 136);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(36, 25);
            this.label23.TabIndex = 87;
            this.label23.Text = "CH";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 25);
            this.label9.TabIndex = 79;
            this.label9.Text = "1";
            // 
            // labelCL
            // 
            this.labelCL.AutoSize = true;
            this.labelCL.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelCL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCL.Location = new System.Drawing.Point(261, 134);
            this.labelCL.Name = "labelCL";
            this.labelCL.Size = new System.Drawing.Size(94, 27);
            this.labelCL.TabIndex = 86;
            this.labelCL.Text = "00000000";
            // 
            // labelCH
            // 
            this.labelCH.AutoSize = true;
            this.labelCH.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelCH.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCH.Location = new System.Drawing.Point(170, 134);
            this.labelCH.Name = "labelCH";
            this.labelCH.Size = new System.Drawing.Size(94, 27);
            this.labelCH.TabIndex = 85;
            this.labelCH.Text = "00000000";
            // 
            // buttonWriteCX
            // 
            this.buttonWriteCX.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonWriteCX.Location = new System.Drawing.Point(211, 106);
            this.buttonWriteCX.Name = "buttonWriteCX";
            this.buttonWriteCX.Size = new System.Drawing.Size(103, 25);
            this.buttonWriteCX.TabIndex = 70;
            this.buttonWriteCX.Text = "Wpisz";
            this.buttonWriteCX.UseVisualStyleBackColor = true;
            this.buttonWriteCX.Click += new System.EventHandler(this.buttonWriteCX_Click);
            // 
            // CHActive
            // 
            this.CHActive.AutoSize = true;
            this.CHActive.Location = new System.Drawing.Point(92, 103);
            this.CHActive.Name = "CHActive";
            this.CHActive.Size = new System.Drawing.Size(92, 25);
            this.CHActive.TabIndex = 71;
            this.CHActive.Text = "00000000";
            // 
            // CLActive
            // 
            this.CLActive.AutoSize = true;
            this.CLActive.Location = new System.Drawing.Point(344, 103);
            this.CLActive.Name = "CLActive";
            this.CLActive.Size = new System.Drawing.Size(92, 25);
            this.CLActive.TabIndex = 70;
            this.CLActive.Text = "00000000";
            // 
            // gruopCX0
            // 
            this.gruopCX0.Controls.Add(this.CXbuttonNo0s1);
            this.gruopCX0.Controls.Add(this.CXbuttonNo0s0);
            this.gruopCX0.Location = new System.Drawing.Point(475, 30);
            this.gruopCX0.Name = "gruopCX0";
            this.gruopCX0.Size = new System.Drawing.Size(20, 70);
            this.gruopCX0.TabIndex = 45;
            this.gruopCX0.TabStop = false;
            // 
            // CXbuttonNo0s1
            // 
            this.CXbuttonNo0s1.AutoSize = true;
            this.CXbuttonNo0s1.Location = new System.Drawing.Point(0, 19);
            this.CXbuttonNo0s1.Name = "CXbuttonNo0s1";
            this.CXbuttonNo0s1.Size = new System.Drawing.Size(21, 20);
            this.CXbuttonNo0s1.TabIndex = 32;
            this.CXbuttonNo0s1.UseVisualStyleBackColor = true;
            this.CXbuttonNo0s1.CheckedChanged += new System.EventHandler(this.CXbuttonNo0s1_CheckedChanged);
            // 
            // CXbuttonNo0s0
            // 
            this.CXbuttonNo0s0.AutoSize = true;
            this.CXbuttonNo0s0.Checked = true;
            this.CXbuttonNo0s0.Location = new System.Drawing.Point(0, 45);
            this.CXbuttonNo0s0.Name = "CXbuttonNo0s0";
            this.CXbuttonNo0s0.Size = new System.Drawing.Size(21, 20);
            this.CXbuttonNo0s0.TabIndex = 33;
            this.CXbuttonNo0s0.TabStop = true;
            this.CXbuttonNo0s0.UseVisualStyleBackColor = true;
            // 
            // gruopCX1
            // 
            this.gruopCX1.Controls.Add(this.CXbuttonNo1s1);
            this.gruopCX1.Controls.Add(this.CXbuttonNo1s0);
            this.gruopCX1.Location = new System.Drawing.Point(449, 30);
            this.gruopCX1.Name = "gruopCX1";
            this.gruopCX1.Size = new System.Drawing.Size(20, 70);
            this.gruopCX1.TabIndex = 46;
            this.gruopCX1.TabStop = false;
            // 
            // CXbuttonNo1s1
            // 
            this.CXbuttonNo1s1.AutoSize = true;
            this.CXbuttonNo1s1.Location = new System.Drawing.Point(0, 19);
            this.CXbuttonNo1s1.Name = "CXbuttonNo1s1";
            this.CXbuttonNo1s1.Size = new System.Drawing.Size(21, 20);
            this.CXbuttonNo1s1.TabIndex = 32;
            this.CXbuttonNo1s1.UseVisualStyleBackColor = true;
            this.CXbuttonNo1s1.CheckedChanged += new System.EventHandler(this.CXbuttonNo1s1_CheckedChanged);
            // 
            // CXbuttonNo1s0
            // 
            this.CXbuttonNo1s0.AutoSize = true;
            this.CXbuttonNo1s0.Checked = true;
            this.CXbuttonNo1s0.Location = new System.Drawing.Point(0, 45);
            this.CXbuttonNo1s0.Name = "CXbuttonNo1s0";
            this.CXbuttonNo1s0.Size = new System.Drawing.Size(21, 20);
            this.CXbuttonNo1s0.TabIndex = 33;
            this.CXbuttonNo1s0.TabStop = true;
            this.CXbuttonNo1s0.UseVisualStyleBackColor = true;
            // 
            // gruopCX8
            // 
            this.gruopCX8.Controls.Add(this.CXbuttonNo8s1);
            this.gruopCX8.Controls.Add(this.CXbuttonNo8s0);
            this.gruopCX8.Location = new System.Drawing.Point(222, 30);
            this.gruopCX8.Name = "gruopCX8";
            this.gruopCX8.Size = new System.Drawing.Size(20, 70);
            this.gruopCX8.TabIndex = 37;
            this.gruopCX8.TabStop = false;
            // 
            // CXbuttonNo8s1
            // 
            this.CXbuttonNo8s1.AutoSize = true;
            this.CXbuttonNo8s1.Location = new System.Drawing.Point(0, 19);
            this.CXbuttonNo8s1.Name = "CXbuttonNo8s1";
            this.CXbuttonNo8s1.Size = new System.Drawing.Size(21, 20);
            this.CXbuttonNo8s1.TabIndex = 32;
            this.CXbuttonNo8s1.UseVisualStyleBackColor = true;
            this.CXbuttonNo8s1.CheckedChanged += new System.EventHandler(this.CXbuttonNo8s1_CheckedChanged);
            // 
            // CXbuttonNo8s0
            // 
            this.CXbuttonNo8s0.AutoSize = true;
            this.CXbuttonNo8s0.Checked = true;
            this.CXbuttonNo8s0.Location = new System.Drawing.Point(0, 45);
            this.CXbuttonNo8s0.Name = "CXbuttonNo8s0";
            this.CXbuttonNo8s0.Size = new System.Drawing.Size(21, 20);
            this.CXbuttonNo8s0.TabIndex = 33;
            this.CXbuttonNo8s0.TabStop = true;
            this.CXbuttonNo8s0.UseVisualStyleBackColor = true;
            // 
            // gruopCX4
            // 
            this.gruopCX4.Controls.Add(this.CXbuttonNo4s1);
            this.gruopCX4.Controls.Add(this.CXbuttonNo4s0);
            this.gruopCX4.Location = new System.Drawing.Point(370, 30);
            this.gruopCX4.Name = "gruopCX4";
            this.gruopCX4.Size = new System.Drawing.Size(20, 70);
            this.gruopCX4.TabIndex = 41;
            this.gruopCX4.TabStop = false;
            // 
            // CXbuttonNo4s1
            // 
            this.CXbuttonNo4s1.AutoSize = true;
            this.CXbuttonNo4s1.Location = new System.Drawing.Point(0, 19);
            this.CXbuttonNo4s1.Name = "CXbuttonNo4s1";
            this.CXbuttonNo4s1.Size = new System.Drawing.Size(21, 20);
            this.CXbuttonNo4s1.TabIndex = 32;
            this.CXbuttonNo4s1.UseVisualStyleBackColor = true;
            this.CXbuttonNo4s1.CheckedChanged += new System.EventHandler(this.CXbuttonNo4s1_CheckedChanged);
            // 
            // CXbuttonNo4s0
            // 
            this.CXbuttonNo4s0.AutoSize = true;
            this.CXbuttonNo4s0.Checked = true;
            this.CXbuttonNo4s0.Location = new System.Drawing.Point(0, 45);
            this.CXbuttonNo4s0.Name = "CXbuttonNo4s0";
            this.CXbuttonNo4s0.Size = new System.Drawing.Size(21, 20);
            this.CXbuttonNo4s0.TabIndex = 33;
            this.CXbuttonNo4s0.TabStop = true;
            this.CXbuttonNo4s0.UseVisualStyleBackColor = true;
            // 
            // gruopCX9
            // 
            this.gruopCX9.Controls.Add(this.CXbuttonNo9s1);
            this.gruopCX9.Controls.Add(this.CXbuttonNo9s0);
            this.gruopCX9.Location = new System.Drawing.Point(196, 30);
            this.gruopCX9.Name = "gruopCX9";
            this.gruopCX9.Size = new System.Drawing.Size(20, 70);
            this.gruopCX9.TabIndex = 38;
            this.gruopCX9.TabStop = false;
            // 
            // CXbuttonNo9s1
            // 
            this.CXbuttonNo9s1.AutoSize = true;
            this.CXbuttonNo9s1.Location = new System.Drawing.Point(0, 19);
            this.CXbuttonNo9s1.Name = "CXbuttonNo9s1";
            this.CXbuttonNo9s1.Size = new System.Drawing.Size(21, 20);
            this.CXbuttonNo9s1.TabIndex = 32;
            this.CXbuttonNo9s1.UseVisualStyleBackColor = true;
            this.CXbuttonNo9s1.CheckedChanged += new System.EventHandler(this.CXbuttonNo9s1_CheckedChanged);
            // 
            // CXbuttonNo9s0
            // 
            this.CXbuttonNo9s0.AutoSize = true;
            this.CXbuttonNo9s0.Checked = true;
            this.CXbuttonNo9s0.Location = new System.Drawing.Point(0, 45);
            this.CXbuttonNo9s0.Name = "CXbuttonNo9s0";
            this.CXbuttonNo9s0.Size = new System.Drawing.Size(21, 20);
            this.CXbuttonNo9s0.TabIndex = 33;
            this.CXbuttonNo9s0.TabStop = true;
            this.CXbuttonNo9s0.UseVisualStyleBackColor = true;
            // 
            // gruopCX2
            // 
            this.gruopCX2.Controls.Add(this.CXbuttonNo2s1);
            this.gruopCX2.Controls.Add(this.CXbuttonNo2s0);
            this.gruopCX2.Location = new System.Drawing.Point(423, 30);
            this.gruopCX2.Name = "gruopCX2";
            this.gruopCX2.Size = new System.Drawing.Size(20, 70);
            this.gruopCX2.TabIndex = 47;
            this.gruopCX2.TabStop = false;
            // 
            // CXbuttonNo2s1
            // 
            this.CXbuttonNo2s1.AutoSize = true;
            this.CXbuttonNo2s1.Location = new System.Drawing.Point(0, 19);
            this.CXbuttonNo2s1.Name = "CXbuttonNo2s1";
            this.CXbuttonNo2s1.Size = new System.Drawing.Size(21, 20);
            this.CXbuttonNo2s1.TabIndex = 32;
            this.CXbuttonNo2s1.UseVisualStyleBackColor = true;
            this.CXbuttonNo2s1.CheckedChanged += new System.EventHandler(this.CXbuttonNo2s1_CheckedChanged);
            // 
            // CXbuttonNo2s0
            // 
            this.CXbuttonNo2s0.AutoSize = true;
            this.CXbuttonNo2s0.Checked = true;
            this.CXbuttonNo2s0.Location = new System.Drawing.Point(0, 45);
            this.CXbuttonNo2s0.Name = "CXbuttonNo2s0";
            this.CXbuttonNo2s0.Size = new System.Drawing.Size(21, 20);
            this.CXbuttonNo2s0.TabIndex = 33;
            this.CXbuttonNo2s0.TabStop = true;
            this.CXbuttonNo2s0.UseVisualStyleBackColor = true;
            // 
            // gruopCX12
            // 
            this.gruopCX12.Controls.Add(this.CXbuttonNo12s1);
            this.gruopCX12.Controls.Add(this.CXbuttonNo12s0);
            this.gruopCX12.Location = new System.Drawing.Point(117, 30);
            this.gruopCX12.Name = "gruopCX12";
            this.gruopCX12.Size = new System.Drawing.Size(20, 70);
            this.gruopCX12.TabIndex = 35;
            this.gruopCX12.TabStop = false;
            // 
            // CXbuttonNo12s1
            // 
            this.CXbuttonNo12s1.AutoSize = true;
            this.CXbuttonNo12s1.Location = new System.Drawing.Point(0, 19);
            this.CXbuttonNo12s1.Name = "CXbuttonNo12s1";
            this.CXbuttonNo12s1.Size = new System.Drawing.Size(21, 20);
            this.CXbuttonNo12s1.TabIndex = 32;
            this.CXbuttonNo12s1.UseVisualStyleBackColor = true;
            this.CXbuttonNo12s1.CheckedChanged += new System.EventHandler(this.CXbuttonNo12s1_CheckedChanged);
            // 
            // CXbuttonNo12s0
            // 
            this.CXbuttonNo12s0.AutoSize = true;
            this.CXbuttonNo12s0.Checked = true;
            this.CXbuttonNo12s0.Location = new System.Drawing.Point(0, 45);
            this.CXbuttonNo12s0.Name = "CXbuttonNo12s0";
            this.CXbuttonNo12s0.Size = new System.Drawing.Size(21, 20);
            this.CXbuttonNo12s0.TabIndex = 33;
            this.CXbuttonNo12s0.TabStop = true;
            this.CXbuttonNo12s0.UseVisualStyleBackColor = true;
            // 
            // gruopCX5
            // 
            this.gruopCX5.Controls.Add(this.CXbuttonNo5s1);
            this.gruopCX5.Controls.Add(this.CXbuttonNo5s0);
            this.gruopCX5.Location = new System.Drawing.Point(344, 30);
            this.gruopCX5.Name = "gruopCX5";
            this.gruopCX5.Size = new System.Drawing.Size(20, 70);
            this.gruopCX5.TabIndex = 42;
            this.gruopCX5.TabStop = false;
            // 
            // CXbuttonNo5s1
            // 
            this.CXbuttonNo5s1.AutoSize = true;
            this.CXbuttonNo5s1.Location = new System.Drawing.Point(0, 19);
            this.CXbuttonNo5s1.Name = "CXbuttonNo5s1";
            this.CXbuttonNo5s1.Size = new System.Drawing.Size(21, 20);
            this.CXbuttonNo5s1.TabIndex = 32;
            this.CXbuttonNo5s1.UseVisualStyleBackColor = true;
            this.CXbuttonNo5s1.CheckedChanged += new System.EventHandler(this.CXbuttonNo5s1_CheckedChanged);
            // 
            // CXbuttonNo5s0
            // 
            this.CXbuttonNo5s0.AutoSize = true;
            this.CXbuttonNo5s0.Checked = true;
            this.CXbuttonNo5s0.Location = new System.Drawing.Point(0, 45);
            this.CXbuttonNo5s0.Name = "CXbuttonNo5s0";
            this.CXbuttonNo5s0.Size = new System.Drawing.Size(21, 20);
            this.CXbuttonNo5s0.TabIndex = 33;
            this.CXbuttonNo5s0.TabStop = true;
            this.CXbuttonNo5s0.UseVisualStyleBackColor = true;
            // 
            // gruopCX10
            // 
            this.gruopCX10.Controls.Add(this.CXbuttonNo10s1);
            this.gruopCX10.Controls.Add(this.CXbuttonNo10s0);
            this.gruopCX10.Location = new System.Drawing.Point(170, 30);
            this.gruopCX10.Name = "gruopCX10";
            this.gruopCX10.Size = new System.Drawing.Size(20, 70);
            this.gruopCX10.TabIndex = 39;
            this.gruopCX10.TabStop = false;
            // 
            // CXbuttonNo10s1
            // 
            this.CXbuttonNo10s1.AutoSize = true;
            this.CXbuttonNo10s1.Location = new System.Drawing.Point(0, 19);
            this.CXbuttonNo10s1.Name = "CXbuttonNo10s1";
            this.CXbuttonNo10s1.Size = new System.Drawing.Size(21, 20);
            this.CXbuttonNo10s1.TabIndex = 32;
            this.CXbuttonNo10s1.UseVisualStyleBackColor = true;
            this.CXbuttonNo10s1.CheckedChanged += new System.EventHandler(this.CXbuttonNo10s1_CheckedChanged);
            // 
            // CXbuttonNo10s0
            // 
            this.CXbuttonNo10s0.AutoSize = true;
            this.CXbuttonNo10s0.Checked = true;
            this.CXbuttonNo10s0.Location = new System.Drawing.Point(0, 45);
            this.CXbuttonNo10s0.Name = "CXbuttonNo10s0";
            this.CXbuttonNo10s0.Size = new System.Drawing.Size(21, 20);
            this.CXbuttonNo10s0.TabIndex = 33;
            this.CXbuttonNo10s0.TabStop = true;
            this.CXbuttonNo10s0.UseVisualStyleBackColor = true;
            // 
            // gruopCX3
            // 
            this.gruopCX3.Controls.Add(this.CXbuttonNo3s1);
            this.gruopCX3.Controls.Add(this.CXbuttonNo3s0);
            this.gruopCX3.Location = new System.Drawing.Point(397, 30);
            this.gruopCX3.Name = "gruopCX3";
            this.gruopCX3.Size = new System.Drawing.Size(20, 70);
            this.gruopCX3.TabIndex = 44;
            this.gruopCX3.TabStop = false;
            // 
            // CXbuttonNo3s1
            // 
            this.CXbuttonNo3s1.AutoSize = true;
            this.CXbuttonNo3s1.Location = new System.Drawing.Point(0, 19);
            this.CXbuttonNo3s1.Name = "CXbuttonNo3s1";
            this.CXbuttonNo3s1.Size = new System.Drawing.Size(21, 20);
            this.CXbuttonNo3s1.TabIndex = 32;
            this.CXbuttonNo3s1.UseVisualStyleBackColor = true;
            this.CXbuttonNo3s1.CheckedChanged += new System.EventHandler(this.CXbuttonNo3s1_CheckedChanged);
            // 
            // CXbuttonNo3s0
            // 
            this.CXbuttonNo3s0.AutoSize = true;
            this.CXbuttonNo3s0.Checked = true;
            this.CXbuttonNo3s0.Location = new System.Drawing.Point(0, 45);
            this.CXbuttonNo3s0.Name = "CXbuttonNo3s0";
            this.CXbuttonNo3s0.Size = new System.Drawing.Size(21, 20);
            this.CXbuttonNo3s0.TabIndex = 33;
            this.CXbuttonNo3s0.TabStop = true;
            this.CXbuttonNo3s0.UseVisualStyleBackColor = true;
            // 
            // gruopCX13
            // 
            this.gruopCX13.Controls.Add(this.CXbuttonNo13s1);
            this.gruopCX13.Controls.Add(this.CXbuttonNo13s0);
            this.gruopCX13.Location = new System.Drawing.Point(91, 30);
            this.gruopCX13.Name = "gruopCX13";
            this.gruopCX13.Size = new System.Drawing.Size(20, 70);
            this.gruopCX13.TabIndex = 35;
            this.gruopCX13.TabStop = false;
            // 
            // CXbuttonNo13s1
            // 
            this.CXbuttonNo13s1.AutoSize = true;
            this.CXbuttonNo13s1.Location = new System.Drawing.Point(0, 19);
            this.CXbuttonNo13s1.Name = "CXbuttonNo13s1";
            this.CXbuttonNo13s1.Size = new System.Drawing.Size(21, 20);
            this.CXbuttonNo13s1.TabIndex = 32;
            this.CXbuttonNo13s1.UseVisualStyleBackColor = true;
            this.CXbuttonNo13s1.CheckedChanged += new System.EventHandler(this.CXbuttonNo13s1_CheckedChanged);
            // 
            // CXbuttonNo13s0
            // 
            this.CXbuttonNo13s0.AutoSize = true;
            this.CXbuttonNo13s0.Checked = true;
            this.CXbuttonNo13s0.Location = new System.Drawing.Point(0, 45);
            this.CXbuttonNo13s0.Name = "CXbuttonNo13s0";
            this.CXbuttonNo13s0.Size = new System.Drawing.Size(21, 20);
            this.CXbuttonNo13s0.TabIndex = 33;
            this.CXbuttonNo13s0.TabStop = true;
            this.CXbuttonNo13s0.UseVisualStyleBackColor = true;
            // 
            // gruopCX6
            // 
            this.gruopCX6.Controls.Add(this.CXbuttonNo6s1);
            this.gruopCX6.Controls.Add(this.CXbuttonNo6s0);
            this.gruopCX6.Location = new System.Drawing.Point(318, 30);
            this.gruopCX6.Name = "gruopCX6";
            this.gruopCX6.Size = new System.Drawing.Size(20, 70);
            this.gruopCX6.TabIndex = 43;
            this.gruopCX6.TabStop = false;
            // 
            // CXbuttonNo6s1
            // 
            this.CXbuttonNo6s1.AutoSize = true;
            this.CXbuttonNo6s1.Location = new System.Drawing.Point(0, 19);
            this.CXbuttonNo6s1.Name = "CXbuttonNo6s1";
            this.CXbuttonNo6s1.Size = new System.Drawing.Size(21, 20);
            this.CXbuttonNo6s1.TabIndex = 32;
            this.CXbuttonNo6s1.UseVisualStyleBackColor = true;
            this.CXbuttonNo6s1.CheckedChanged += new System.EventHandler(this.CXbuttonNo6s1_CheckedChanged);
            // 
            // CXbuttonNo6s0
            // 
            this.CXbuttonNo6s0.AutoSize = true;
            this.CXbuttonNo6s0.Checked = true;
            this.CXbuttonNo6s0.Location = new System.Drawing.Point(0, 45);
            this.CXbuttonNo6s0.Name = "CXbuttonNo6s0";
            this.CXbuttonNo6s0.Size = new System.Drawing.Size(21, 20);
            this.CXbuttonNo6s0.TabIndex = 33;
            this.CXbuttonNo6s0.TabStop = true;
            this.CXbuttonNo6s0.UseVisualStyleBackColor = true;
            // 
            // gruopCX11
            // 
            this.gruopCX11.Controls.Add(this.CXbuttonNo11s1);
            this.gruopCX11.Controls.Add(this.CXbuttonNo11s0);
            this.gruopCX11.Location = new System.Drawing.Point(144, 30);
            this.gruopCX11.Name = "gruopCX11";
            this.gruopCX11.Size = new System.Drawing.Size(20, 70);
            this.gruopCX11.TabIndex = 36;
            this.gruopCX11.TabStop = false;
            // 
            // CXbuttonNo11s1
            // 
            this.CXbuttonNo11s1.AutoSize = true;
            this.CXbuttonNo11s1.Location = new System.Drawing.Point(0, 19);
            this.CXbuttonNo11s1.Name = "CXbuttonNo11s1";
            this.CXbuttonNo11s1.Size = new System.Drawing.Size(21, 20);
            this.CXbuttonNo11s1.TabIndex = 32;
            this.CXbuttonNo11s1.UseVisualStyleBackColor = true;
            this.CXbuttonNo11s1.CheckedChanged += new System.EventHandler(this.CXbuttonNo11s1_CheckedChanged);
            // 
            // CXbuttonNo11s0
            // 
            this.CXbuttonNo11s0.AutoSize = true;
            this.CXbuttonNo11s0.Checked = true;
            this.CXbuttonNo11s0.Location = new System.Drawing.Point(0, 45);
            this.CXbuttonNo11s0.Name = "CXbuttonNo11s0";
            this.CXbuttonNo11s0.Size = new System.Drawing.Size(21, 20);
            this.CXbuttonNo11s0.TabIndex = 33;
            this.CXbuttonNo11s0.TabStop = true;
            this.CXbuttonNo11s0.UseVisualStyleBackColor = true;
            // 
            // gruopCX7
            // 
            this.gruopCX7.Controls.Add(this.CXbuttonNo7s1);
            this.gruopCX7.Controls.Add(this.CXbuttonNo7s0);
            this.gruopCX7.Location = new System.Drawing.Point(292, 30);
            this.gruopCX7.Name = "gruopCX7";
            this.gruopCX7.Size = new System.Drawing.Size(20, 70);
            this.gruopCX7.TabIndex = 40;
            this.gruopCX7.TabStop = false;
            // 
            // CXbuttonNo7s1
            // 
            this.CXbuttonNo7s1.AutoSize = true;
            this.CXbuttonNo7s1.Location = new System.Drawing.Point(0, 19);
            this.CXbuttonNo7s1.Name = "CXbuttonNo7s1";
            this.CXbuttonNo7s1.Size = new System.Drawing.Size(21, 20);
            this.CXbuttonNo7s1.TabIndex = 32;
            this.CXbuttonNo7s1.UseVisualStyleBackColor = true;
            this.CXbuttonNo7s1.CheckedChanged += new System.EventHandler(this.CXbuttonNo7s1_CheckedChanged);
            // 
            // CXbuttonNo7s0
            // 
            this.CXbuttonNo7s0.AutoSize = true;
            this.CXbuttonNo7s0.Checked = true;
            this.CXbuttonNo7s0.Location = new System.Drawing.Point(0, 45);
            this.CXbuttonNo7s0.Name = "CXbuttonNo7s0";
            this.CXbuttonNo7s0.Size = new System.Drawing.Size(21, 20);
            this.CXbuttonNo7s0.TabIndex = 33;
            this.CXbuttonNo7s0.TabStop = true;
            this.CXbuttonNo7s0.UseVisualStyleBackColor = true;
            // 
            // gruopCX14
            // 
            this.gruopCX14.Controls.Add(this.CXbuttonNo14s1);
            this.gruopCX14.Controls.Add(this.CXbuttonNo14s0);
            this.gruopCX14.Location = new System.Drawing.Point(65, 30);
            this.gruopCX14.Name = "gruopCX14";
            this.gruopCX14.Size = new System.Drawing.Size(20, 70);
            this.gruopCX14.TabIndex = 35;
            this.gruopCX14.TabStop = false;
            // 
            // CXbuttonNo14s1
            // 
            this.CXbuttonNo14s1.AutoSize = true;
            this.CXbuttonNo14s1.Location = new System.Drawing.Point(0, 19);
            this.CXbuttonNo14s1.Name = "CXbuttonNo14s1";
            this.CXbuttonNo14s1.Size = new System.Drawing.Size(21, 20);
            this.CXbuttonNo14s1.TabIndex = 32;
            this.CXbuttonNo14s1.UseVisualStyleBackColor = true;
            this.CXbuttonNo14s1.CheckedChanged += new System.EventHandler(this.CXbuttonNo14s1_CheckedChanged);
            // 
            // CXbuttonNo14s0
            // 
            this.CXbuttonNo14s0.AutoSize = true;
            this.CXbuttonNo14s0.Checked = true;
            this.CXbuttonNo14s0.Location = new System.Drawing.Point(0, 45);
            this.CXbuttonNo14s0.Name = "CXbuttonNo14s0";
            this.CXbuttonNo14s0.Size = new System.Drawing.Size(21, 20);
            this.CXbuttonNo14s0.TabIndex = 33;
            this.CXbuttonNo14s0.TabStop = true;
            this.CXbuttonNo14s0.UseVisualStyleBackColor = true;
            // 
            // gruopCX15
            // 
            this.gruopCX15.Controls.Add(this.CXbuttonNo15s1);
            this.gruopCX15.Controls.Add(this.CXbuttonNo15s0);
            this.gruopCX15.Location = new System.Drawing.Point(39, 30);
            this.gruopCX15.Name = "gruopCX15";
            this.gruopCX15.Size = new System.Drawing.Size(20, 70);
            this.gruopCX15.TabIndex = 34;
            this.gruopCX15.TabStop = false;
            // 
            // CXbuttonNo15s1
            // 
            this.CXbuttonNo15s1.AutoSize = true;
            this.CXbuttonNo15s1.Location = new System.Drawing.Point(0, 19);
            this.CXbuttonNo15s1.Name = "CXbuttonNo15s1";
            this.CXbuttonNo15s1.Size = new System.Drawing.Size(21, 20);
            this.CXbuttonNo15s1.TabIndex = 32;
            this.CXbuttonNo15s1.UseVisualStyleBackColor = true;
            this.CXbuttonNo15s1.CheckedChanged += new System.EventHandler(this.CXbuttonNo15s1_CheckedChanged);
            // 
            // CXbuttonNo15s0
            // 
            this.CXbuttonNo15s0.AutoSize = true;
            this.CXbuttonNo15s0.Checked = true;
            this.CXbuttonNo15s0.Location = new System.Drawing.Point(0, 45);
            this.CXbuttonNo15s0.Name = "CXbuttonNo15s0";
            this.CXbuttonNo15s0.Size = new System.Drawing.Size(21, 20);
            this.CXbuttonNo15s0.TabIndex = 33;
            this.CXbuttonNo15s0.TabStop = true;
            this.CXbuttonNo15s0.UseVisualStyleBackColor = true;
            // 
            // groupBoxBX
            // 
            this.groupBoxBX.Controls.Add(this.label14);
            this.groupBoxBX.Controls.Add(this.label4);
            this.groupBoxBX.Controls.Add(this.label15);
            this.groupBoxBX.Controls.Add(this.label5);
            this.groupBoxBX.Controls.Add(this.labelBL);
            this.groupBoxBX.Controls.Add(this.labelBH);
            this.groupBoxBX.Controls.Add(this.buttonWriteBX);
            this.groupBoxBX.Controls.Add(this.BLActive);
            this.groupBoxBX.Controls.Add(this.BHActive);
            this.groupBoxBX.Controls.Add(this.gruopBX0);
            this.groupBoxBX.Controls.Add(this.gruopBX1);
            this.groupBoxBX.Controls.Add(this.gruopBX15);
            this.groupBoxBX.Controls.Add(this.gruopBX8);
            this.groupBoxBX.Controls.Add(this.gruopBX14);
            this.groupBoxBX.Controls.Add(this.gruopBX4);
            this.groupBoxBX.Controls.Add(this.gruopBX7);
            this.groupBoxBX.Controls.Add(this.gruopBX9);
            this.groupBoxBX.Controls.Add(this.gruopBX11);
            this.groupBoxBX.Controls.Add(this.gruopBX2);
            this.groupBoxBX.Controls.Add(this.gruopBX6);
            this.groupBoxBX.Controls.Add(this.gruopBX12);
            this.groupBoxBX.Controls.Add(this.gruopBX13);
            this.groupBoxBX.Controls.Add(this.gruopBX5);
            this.groupBoxBX.Controls.Add(this.gruopBX3);
            this.groupBoxBX.Controls.Add(this.gruopBX10);
            this.groupBoxBX.Location = new System.Drawing.Point(542, 60);
            this.groupBoxBX.Name = "groupBoxBX";
            this.groupBoxBX.Size = new System.Drawing.Size(517, 170);
            this.groupBoxBX.TabIndex = 1;
            this.groupBoxBX.TabStop = false;
            this.groupBoxBX.Text = "Rejestr BX";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(366, 133);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(30, 25);
            this.label14.TabIndex = 80;
            this.label14.Text = "BL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 25);
            this.label4.TabIndex = 76;
            this.label4.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(135, 133);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 25);
            this.label15.TabIndex = 79;
            this.label15.Text = "BH";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 25);
            this.label5.TabIndex = 75;
            this.label5.Text = "1";
            // 
            // labelBL
            // 
            this.labelBL.AutoSize = true;
            this.labelBL.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelBL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelBL.Location = new System.Drawing.Point(267, 131);
            this.labelBL.Name = "labelBL";
            this.labelBL.Size = new System.Drawing.Size(94, 27);
            this.labelBL.TabIndex = 78;
            this.labelBL.Text = "00000000";
            // 
            // labelBH
            // 
            this.labelBH.AutoSize = true;
            this.labelBH.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelBH.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelBH.Location = new System.Drawing.Point(176, 131);
            this.labelBH.Name = "labelBH";
            this.labelBH.Size = new System.Drawing.Size(94, 27);
            this.labelBH.TabIndex = 77;
            this.labelBH.Text = "00000000";
            // 
            // buttonWriteBX
            // 
            this.buttonWriteBX.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonWriteBX.Location = new System.Drawing.Point(217, 106);
            this.buttonWriteBX.Name = "buttonWriteBX";
            this.buttonWriteBX.Size = new System.Drawing.Size(103, 25);
            this.buttonWriteBX.TabIndex = 67;
            this.buttonWriteBX.Text = "Wpisz";
            this.buttonWriteBX.UseVisualStyleBackColor = true;
            this.buttonWriteBX.Click += new System.EventHandler(this.buttonWriteBX_Click);
            // 
            // BLActive
            // 
            this.BLActive.AutoSize = true;
            this.BLActive.Location = new System.Drawing.Point(346, 103);
            this.BLActive.Name = "BLActive";
            this.BLActive.Size = new System.Drawing.Size(92, 25);
            this.BLActive.TabIndex = 67;
            this.BLActive.Text = "00000000";
            // 
            // BHActive
            // 
            this.BHActive.AutoSize = true;
            this.BHActive.Location = new System.Drawing.Point(93, 103);
            this.BHActive.Name = "BHActive";
            this.BHActive.Size = new System.Drawing.Size(92, 25);
            this.BHActive.TabIndex = 66;
            this.BHActive.Text = "00000000";
            // 
            // gruopBX0
            // 
            this.gruopBX0.Controls.Add(this.BXbuttonNo0s1);
            this.gruopBX0.Controls.Add(this.BXbuttonNo0s0);
            this.gruopBX0.Location = new System.Drawing.Point(470, 30);
            this.gruopBX0.Name = "gruopBX0";
            this.gruopBX0.Size = new System.Drawing.Size(20, 70);
            this.gruopBX0.TabIndex = 61;
            this.gruopBX0.TabStop = false;
            // 
            // BXbuttonNo0s1
            // 
            this.BXbuttonNo0s1.AutoSize = true;
            this.BXbuttonNo0s1.Location = new System.Drawing.Point(0, 19);
            this.BXbuttonNo0s1.Name = "BXbuttonNo0s1";
            this.BXbuttonNo0s1.Size = new System.Drawing.Size(21, 20);
            this.BXbuttonNo0s1.TabIndex = 32;
            this.BXbuttonNo0s1.UseVisualStyleBackColor = true;
            this.BXbuttonNo0s1.CheckedChanged += new System.EventHandler(this.BXbuttonNo0s1_CheckedChanged);
            // 
            // BXbuttonNo0s0
            // 
            this.BXbuttonNo0s0.AutoSize = true;
            this.BXbuttonNo0s0.Checked = true;
            this.BXbuttonNo0s0.Location = new System.Drawing.Point(0, 45);
            this.BXbuttonNo0s0.Name = "BXbuttonNo0s0";
            this.BXbuttonNo0s0.Size = new System.Drawing.Size(21, 20);
            this.BXbuttonNo0s0.TabIndex = 33;
            this.BXbuttonNo0s0.TabStop = true;
            this.BXbuttonNo0s0.UseVisualStyleBackColor = true;
            // 
            // gruopBX1
            // 
            this.gruopBX1.Controls.Add(this.BXbuttonNo1s1);
            this.gruopBX1.Controls.Add(this.BXbuttonNo1s0);
            this.gruopBX1.Location = new System.Drawing.Point(444, 30);
            this.gruopBX1.Name = "gruopBX1";
            this.gruopBX1.Size = new System.Drawing.Size(20, 70);
            this.gruopBX1.TabIndex = 62;
            this.gruopBX1.TabStop = false;
            // 
            // BXbuttonNo1s1
            // 
            this.BXbuttonNo1s1.AutoSize = true;
            this.BXbuttonNo1s1.Location = new System.Drawing.Point(0, 19);
            this.BXbuttonNo1s1.Name = "BXbuttonNo1s1";
            this.BXbuttonNo1s1.Size = new System.Drawing.Size(21, 20);
            this.BXbuttonNo1s1.TabIndex = 32;
            this.BXbuttonNo1s1.UseVisualStyleBackColor = true;
            this.BXbuttonNo1s1.CheckedChanged += new System.EventHandler(this.BXbuttonNo1s1_CheckedChanged);
            // 
            // BXbuttonNo1s0
            // 
            this.BXbuttonNo1s0.AutoSize = true;
            this.BXbuttonNo1s0.Checked = true;
            this.BXbuttonNo1s0.Location = new System.Drawing.Point(0, 45);
            this.BXbuttonNo1s0.Name = "BXbuttonNo1s0";
            this.BXbuttonNo1s0.Size = new System.Drawing.Size(21, 20);
            this.BXbuttonNo1s0.TabIndex = 33;
            this.BXbuttonNo1s0.TabStop = true;
            this.BXbuttonNo1s0.UseVisualStyleBackColor = true;
            // 
            // gruopBX15
            // 
            this.gruopBX15.Controls.Add(this.BXbuttonNo15s1);
            this.gruopBX15.Controls.Add(this.BXbuttonNo15s0);
            this.gruopBX15.Location = new System.Drawing.Point(34, 30);
            this.gruopBX15.Name = "gruopBX15";
            this.gruopBX15.Size = new System.Drawing.Size(20, 70);
            this.gruopBX15.TabIndex = 48;
            this.gruopBX15.TabStop = false;
            // 
            // BXbuttonNo15s1
            // 
            this.BXbuttonNo15s1.AutoSize = true;
            this.BXbuttonNo15s1.Location = new System.Drawing.Point(0, 19);
            this.BXbuttonNo15s1.Name = "BXbuttonNo15s1";
            this.BXbuttonNo15s1.Size = new System.Drawing.Size(21, 20);
            this.BXbuttonNo15s1.TabIndex = 32;
            this.BXbuttonNo15s1.UseVisualStyleBackColor = true;
            this.BXbuttonNo15s1.CheckedChanged += new System.EventHandler(this.BXbuttonNo15s1_CheckedChanged);
            // 
            // BXbuttonNo15s0
            // 
            this.BXbuttonNo15s0.AutoSize = true;
            this.BXbuttonNo15s0.Checked = true;
            this.BXbuttonNo15s0.Location = new System.Drawing.Point(0, 45);
            this.BXbuttonNo15s0.Name = "BXbuttonNo15s0";
            this.BXbuttonNo15s0.Size = new System.Drawing.Size(21, 20);
            this.BXbuttonNo15s0.TabIndex = 33;
            this.BXbuttonNo15s0.TabStop = true;
            this.BXbuttonNo15s0.UseVisualStyleBackColor = true;
            // 
            // gruopBX8
            // 
            this.gruopBX8.Controls.Add(this.BXbuttonNo8s1);
            this.gruopBX8.Controls.Add(this.BXbuttonNo8s0);
            this.gruopBX8.Location = new System.Drawing.Point(217, 30);
            this.gruopBX8.Name = "gruopBX8";
            this.gruopBX8.Size = new System.Drawing.Size(20, 70);
            this.gruopBX8.TabIndex = 53;
            this.gruopBX8.TabStop = false;
            // 
            // BXbuttonNo8s1
            // 
            this.BXbuttonNo8s1.AutoSize = true;
            this.BXbuttonNo8s1.Location = new System.Drawing.Point(0, 19);
            this.BXbuttonNo8s1.Name = "BXbuttonNo8s1";
            this.BXbuttonNo8s1.Size = new System.Drawing.Size(21, 20);
            this.BXbuttonNo8s1.TabIndex = 32;
            this.BXbuttonNo8s1.UseVisualStyleBackColor = true;
            this.BXbuttonNo8s1.CheckedChanged += new System.EventHandler(this.BXbuttonNo8s1_CheckedChanged);
            // 
            // BXbuttonNo8s0
            // 
            this.BXbuttonNo8s0.AutoSize = true;
            this.BXbuttonNo8s0.Checked = true;
            this.BXbuttonNo8s0.Location = new System.Drawing.Point(0, 45);
            this.BXbuttonNo8s0.Name = "BXbuttonNo8s0";
            this.BXbuttonNo8s0.Size = new System.Drawing.Size(21, 20);
            this.BXbuttonNo8s0.TabIndex = 33;
            this.BXbuttonNo8s0.TabStop = true;
            this.BXbuttonNo8s0.UseVisualStyleBackColor = true;
            // 
            // gruopBX14
            // 
            this.gruopBX14.Controls.Add(this.BXbuttonNo14s1);
            this.gruopBX14.Controls.Add(this.BXbuttonNo14s0);
            this.gruopBX14.Location = new System.Drawing.Point(60, 30);
            this.gruopBX14.Name = "gruopBX14";
            this.gruopBX14.Size = new System.Drawing.Size(20, 70);
            this.gruopBX14.TabIndex = 51;
            this.gruopBX14.TabStop = false;
            // 
            // BXbuttonNo14s1
            // 
            this.BXbuttonNo14s1.AutoSize = true;
            this.BXbuttonNo14s1.Location = new System.Drawing.Point(0, 19);
            this.BXbuttonNo14s1.Name = "BXbuttonNo14s1";
            this.BXbuttonNo14s1.Size = new System.Drawing.Size(21, 20);
            this.BXbuttonNo14s1.TabIndex = 32;
            this.BXbuttonNo14s1.UseVisualStyleBackColor = true;
            this.BXbuttonNo14s1.CheckedChanged += new System.EventHandler(this.BXbuttonNo14s1_CheckedChanged);
            // 
            // BXbuttonNo14s0
            // 
            this.BXbuttonNo14s0.AutoSize = true;
            this.BXbuttonNo14s0.Checked = true;
            this.BXbuttonNo14s0.Location = new System.Drawing.Point(0, 45);
            this.BXbuttonNo14s0.Name = "BXbuttonNo14s0";
            this.BXbuttonNo14s0.Size = new System.Drawing.Size(21, 20);
            this.BXbuttonNo14s0.TabIndex = 33;
            this.BXbuttonNo14s0.TabStop = true;
            this.BXbuttonNo14s0.UseVisualStyleBackColor = true;
            // 
            // gruopBX4
            // 
            this.gruopBX4.Controls.Add(this.BXbuttonNo4s1);
            this.gruopBX4.Controls.Add(this.BXbuttonNo4s0);
            this.gruopBX4.Location = new System.Drawing.Point(365, 30);
            this.gruopBX4.Name = "gruopBX4";
            this.gruopBX4.Size = new System.Drawing.Size(20, 70);
            this.gruopBX4.TabIndex = 57;
            this.gruopBX4.TabStop = false;
            // 
            // BXbuttonNo4s1
            // 
            this.BXbuttonNo4s1.AutoSize = true;
            this.BXbuttonNo4s1.Location = new System.Drawing.Point(0, 19);
            this.BXbuttonNo4s1.Name = "BXbuttonNo4s1";
            this.BXbuttonNo4s1.Size = new System.Drawing.Size(21, 20);
            this.BXbuttonNo4s1.TabIndex = 32;
            this.BXbuttonNo4s1.UseVisualStyleBackColor = true;
            this.BXbuttonNo4s1.CheckedChanged += new System.EventHandler(this.BXbuttonNo4s1_CheckedChanged);
            // 
            // BXbuttonNo4s0
            // 
            this.BXbuttonNo4s0.AutoSize = true;
            this.BXbuttonNo4s0.Checked = true;
            this.BXbuttonNo4s0.Location = new System.Drawing.Point(0, 45);
            this.BXbuttonNo4s0.Name = "BXbuttonNo4s0";
            this.BXbuttonNo4s0.Size = new System.Drawing.Size(21, 20);
            this.BXbuttonNo4s0.TabIndex = 33;
            this.BXbuttonNo4s0.TabStop = true;
            this.BXbuttonNo4s0.UseVisualStyleBackColor = true;
            // 
            // gruopBX7
            // 
            this.gruopBX7.Controls.Add(this.BXbuttonNo7s1);
            this.gruopBX7.Controls.Add(this.BXbuttonNo7s0);
            this.gruopBX7.Location = new System.Drawing.Point(287, 30);
            this.gruopBX7.Name = "gruopBX7";
            this.gruopBX7.Size = new System.Drawing.Size(20, 70);
            this.gruopBX7.TabIndex = 56;
            this.gruopBX7.TabStop = false;
            // 
            // BXbuttonNo7s1
            // 
            this.BXbuttonNo7s1.AutoSize = true;
            this.BXbuttonNo7s1.Location = new System.Drawing.Point(0, 19);
            this.BXbuttonNo7s1.Name = "BXbuttonNo7s1";
            this.BXbuttonNo7s1.Size = new System.Drawing.Size(21, 20);
            this.BXbuttonNo7s1.TabIndex = 32;
            this.BXbuttonNo7s1.UseVisualStyleBackColor = true;
            this.BXbuttonNo7s1.CheckedChanged += new System.EventHandler(this.BXbuttonNo7s1_CheckedChanged);
            // 
            // BXbuttonNo7s0
            // 
            this.BXbuttonNo7s0.AutoSize = true;
            this.BXbuttonNo7s0.Checked = true;
            this.BXbuttonNo7s0.Location = new System.Drawing.Point(0, 45);
            this.BXbuttonNo7s0.Name = "BXbuttonNo7s0";
            this.BXbuttonNo7s0.Size = new System.Drawing.Size(21, 20);
            this.BXbuttonNo7s0.TabIndex = 33;
            this.BXbuttonNo7s0.TabStop = true;
            this.BXbuttonNo7s0.UseVisualStyleBackColor = true;
            // 
            // gruopBX9
            // 
            this.gruopBX9.Controls.Add(this.BXbuttonNo9s1);
            this.gruopBX9.Controls.Add(this.BXbuttonNo9s0);
            this.gruopBX9.Location = new System.Drawing.Point(191, 30);
            this.gruopBX9.Name = "gruopBX9";
            this.gruopBX9.Size = new System.Drawing.Size(20, 70);
            this.gruopBX9.TabIndex = 54;
            this.gruopBX9.TabStop = false;
            // 
            // BXbuttonNo9s1
            // 
            this.BXbuttonNo9s1.AutoSize = true;
            this.BXbuttonNo9s1.Location = new System.Drawing.Point(0, 19);
            this.BXbuttonNo9s1.Name = "BXbuttonNo9s1";
            this.BXbuttonNo9s1.Size = new System.Drawing.Size(21, 20);
            this.BXbuttonNo9s1.TabIndex = 32;
            this.BXbuttonNo9s1.UseVisualStyleBackColor = true;
            this.BXbuttonNo9s1.CheckedChanged += new System.EventHandler(this.BXbuttonNo9s1_CheckedChanged);
            // 
            // BXbuttonNo9s0
            // 
            this.BXbuttonNo9s0.AutoSize = true;
            this.BXbuttonNo9s0.Checked = true;
            this.BXbuttonNo9s0.Location = new System.Drawing.Point(0, 45);
            this.BXbuttonNo9s0.Name = "BXbuttonNo9s0";
            this.BXbuttonNo9s0.Size = new System.Drawing.Size(21, 20);
            this.BXbuttonNo9s0.TabIndex = 33;
            this.BXbuttonNo9s0.TabStop = true;
            this.BXbuttonNo9s0.UseVisualStyleBackColor = true;
            // 
            // gruopBX11
            // 
            this.gruopBX11.Controls.Add(this.BXbuttonNo11s1);
            this.gruopBX11.Controls.Add(this.BXbuttonNo11s0);
            this.gruopBX11.Location = new System.Drawing.Point(139, 30);
            this.gruopBX11.Name = "gruopBX11";
            this.gruopBX11.Size = new System.Drawing.Size(20, 70);
            this.gruopBX11.TabIndex = 52;
            this.gruopBX11.TabStop = false;
            // 
            // BXbuttonNo11s1
            // 
            this.BXbuttonNo11s1.AutoSize = true;
            this.BXbuttonNo11s1.Location = new System.Drawing.Point(0, 19);
            this.BXbuttonNo11s1.Name = "BXbuttonNo11s1";
            this.BXbuttonNo11s1.Size = new System.Drawing.Size(21, 20);
            this.BXbuttonNo11s1.TabIndex = 32;
            this.BXbuttonNo11s1.UseVisualStyleBackColor = true;
            this.BXbuttonNo11s1.CheckedChanged += new System.EventHandler(this.BXbuttonNo11s1_CheckedChanged);
            // 
            // BXbuttonNo11s0
            // 
            this.BXbuttonNo11s0.AutoSize = true;
            this.BXbuttonNo11s0.Checked = true;
            this.BXbuttonNo11s0.Location = new System.Drawing.Point(0, 45);
            this.BXbuttonNo11s0.Name = "BXbuttonNo11s0";
            this.BXbuttonNo11s0.Size = new System.Drawing.Size(21, 20);
            this.BXbuttonNo11s0.TabIndex = 33;
            this.BXbuttonNo11s0.TabStop = true;
            this.BXbuttonNo11s0.UseVisualStyleBackColor = true;
            // 
            // gruopBX2
            // 
            this.gruopBX2.Controls.Add(this.BXbuttonNo2s1);
            this.gruopBX2.Controls.Add(this.BXbuttonNo2s0);
            this.gruopBX2.Location = new System.Drawing.Point(418, 30);
            this.gruopBX2.Name = "gruopBX2";
            this.gruopBX2.Size = new System.Drawing.Size(20, 70);
            this.gruopBX2.TabIndex = 63;
            this.gruopBX2.TabStop = false;
            // 
            // BXbuttonNo2s1
            // 
            this.BXbuttonNo2s1.AutoSize = true;
            this.BXbuttonNo2s1.Location = new System.Drawing.Point(0, 19);
            this.BXbuttonNo2s1.Name = "BXbuttonNo2s1";
            this.BXbuttonNo2s1.Size = new System.Drawing.Size(21, 20);
            this.BXbuttonNo2s1.TabIndex = 32;
            this.BXbuttonNo2s1.UseVisualStyleBackColor = true;
            this.BXbuttonNo2s1.CheckedChanged += new System.EventHandler(this.BXbuttonNo2s1_CheckedChanged);
            // 
            // BXbuttonNo2s0
            // 
            this.BXbuttonNo2s0.AutoSize = true;
            this.BXbuttonNo2s0.Checked = true;
            this.BXbuttonNo2s0.Location = new System.Drawing.Point(0, 45);
            this.BXbuttonNo2s0.Name = "BXbuttonNo2s0";
            this.BXbuttonNo2s0.Size = new System.Drawing.Size(21, 20);
            this.BXbuttonNo2s0.TabIndex = 33;
            this.BXbuttonNo2s0.TabStop = true;
            this.BXbuttonNo2s0.UseVisualStyleBackColor = true;
            // 
            // gruopBX6
            // 
            this.gruopBX6.Controls.Add(this.BXbuttonNo6s1);
            this.gruopBX6.Controls.Add(this.BXbuttonNo6s0);
            this.gruopBX6.Location = new System.Drawing.Point(313, 30);
            this.gruopBX6.Name = "gruopBX6";
            this.gruopBX6.Size = new System.Drawing.Size(20, 70);
            this.gruopBX6.TabIndex = 59;
            this.gruopBX6.TabStop = false;
            // 
            // BXbuttonNo6s1
            // 
            this.BXbuttonNo6s1.AutoSize = true;
            this.BXbuttonNo6s1.Location = new System.Drawing.Point(0, 19);
            this.BXbuttonNo6s1.Name = "BXbuttonNo6s1";
            this.BXbuttonNo6s1.Size = new System.Drawing.Size(21, 20);
            this.BXbuttonNo6s1.TabIndex = 32;
            this.BXbuttonNo6s1.UseVisualStyleBackColor = true;
            this.BXbuttonNo6s1.CheckedChanged += new System.EventHandler(this.BXbuttonNo6s1_CheckedChanged);
            // 
            // BXbuttonNo6s0
            // 
            this.BXbuttonNo6s0.AutoSize = true;
            this.BXbuttonNo6s0.Checked = true;
            this.BXbuttonNo6s0.Location = new System.Drawing.Point(0, 45);
            this.BXbuttonNo6s0.Name = "BXbuttonNo6s0";
            this.BXbuttonNo6s0.Size = new System.Drawing.Size(21, 20);
            this.BXbuttonNo6s0.TabIndex = 33;
            this.BXbuttonNo6s0.TabStop = true;
            this.BXbuttonNo6s0.UseVisualStyleBackColor = true;
            // 
            // gruopBX12
            // 
            this.gruopBX12.Controls.Add(this.BXbuttonNo12s1);
            this.gruopBX12.Controls.Add(this.BXbuttonNo12s0);
            this.gruopBX12.Location = new System.Drawing.Point(112, 30);
            this.gruopBX12.Name = "gruopBX12";
            this.gruopBX12.Size = new System.Drawing.Size(20, 70);
            this.gruopBX12.TabIndex = 49;
            this.gruopBX12.TabStop = false;
            // 
            // BXbuttonNo12s1
            // 
            this.BXbuttonNo12s1.AutoSize = true;
            this.BXbuttonNo12s1.Location = new System.Drawing.Point(0, 19);
            this.BXbuttonNo12s1.Name = "BXbuttonNo12s1";
            this.BXbuttonNo12s1.Size = new System.Drawing.Size(21, 20);
            this.BXbuttonNo12s1.TabIndex = 32;
            this.BXbuttonNo12s1.UseVisualStyleBackColor = true;
            this.BXbuttonNo12s1.CheckedChanged += new System.EventHandler(this.BXbuttonNo12s1_CheckedChanged);
            // 
            // BXbuttonNo12s0
            // 
            this.BXbuttonNo12s0.AutoSize = true;
            this.BXbuttonNo12s0.Checked = true;
            this.BXbuttonNo12s0.Location = new System.Drawing.Point(0, 45);
            this.BXbuttonNo12s0.Name = "BXbuttonNo12s0";
            this.BXbuttonNo12s0.Size = new System.Drawing.Size(21, 20);
            this.BXbuttonNo12s0.TabIndex = 33;
            this.BXbuttonNo12s0.TabStop = true;
            this.BXbuttonNo12s0.UseVisualStyleBackColor = true;
            // 
            // gruopBX13
            // 
            this.gruopBX13.Controls.Add(this.BXbuttonNo13s1);
            this.gruopBX13.Controls.Add(this.BXbuttonNo13s0);
            this.gruopBX13.Location = new System.Drawing.Point(86, 30);
            this.gruopBX13.Name = "gruopBX13";
            this.gruopBX13.Size = new System.Drawing.Size(20, 70);
            this.gruopBX13.TabIndex = 50;
            this.gruopBX13.TabStop = false;
            // 
            // BXbuttonNo13s1
            // 
            this.BXbuttonNo13s1.AutoSize = true;
            this.BXbuttonNo13s1.Location = new System.Drawing.Point(0, 19);
            this.BXbuttonNo13s1.Name = "BXbuttonNo13s1";
            this.BXbuttonNo13s1.Size = new System.Drawing.Size(21, 20);
            this.BXbuttonNo13s1.TabIndex = 32;
            this.BXbuttonNo13s1.UseVisualStyleBackColor = true;
            this.BXbuttonNo13s1.CheckedChanged += new System.EventHandler(this.BXbuttonNo13s1_CheckedChanged);
            // 
            // BXbuttonNo13s0
            // 
            this.BXbuttonNo13s0.AutoSize = true;
            this.BXbuttonNo13s0.Checked = true;
            this.BXbuttonNo13s0.Location = new System.Drawing.Point(0, 45);
            this.BXbuttonNo13s0.Name = "BXbuttonNo13s0";
            this.BXbuttonNo13s0.Size = new System.Drawing.Size(21, 20);
            this.BXbuttonNo13s0.TabIndex = 33;
            this.BXbuttonNo13s0.TabStop = true;
            this.BXbuttonNo13s0.UseVisualStyleBackColor = true;
            // 
            // gruopBX5
            // 
            this.gruopBX5.Controls.Add(this.BXbuttonNo5s1);
            this.gruopBX5.Controls.Add(this.BXbuttonNo5s0);
            this.gruopBX5.Location = new System.Drawing.Point(339, 30);
            this.gruopBX5.Name = "gruopBX5";
            this.gruopBX5.Size = new System.Drawing.Size(20, 70);
            this.gruopBX5.TabIndex = 58;
            this.gruopBX5.TabStop = false;
            // 
            // BXbuttonNo5s1
            // 
            this.BXbuttonNo5s1.AutoSize = true;
            this.BXbuttonNo5s1.Location = new System.Drawing.Point(0, 19);
            this.BXbuttonNo5s1.Name = "BXbuttonNo5s1";
            this.BXbuttonNo5s1.Size = new System.Drawing.Size(21, 20);
            this.BXbuttonNo5s1.TabIndex = 32;
            this.BXbuttonNo5s1.UseVisualStyleBackColor = true;
            this.BXbuttonNo5s1.CheckedChanged += new System.EventHandler(this.BXbuttonNo5s1_CheckedChanged);
            // 
            // BXbuttonNo5s0
            // 
            this.BXbuttonNo5s0.AutoSize = true;
            this.BXbuttonNo5s0.Checked = true;
            this.BXbuttonNo5s0.Location = new System.Drawing.Point(0, 45);
            this.BXbuttonNo5s0.Name = "BXbuttonNo5s0";
            this.BXbuttonNo5s0.Size = new System.Drawing.Size(21, 20);
            this.BXbuttonNo5s0.TabIndex = 33;
            this.BXbuttonNo5s0.TabStop = true;
            this.BXbuttonNo5s0.UseVisualStyleBackColor = true;
            // 
            // gruopBX3
            // 
            this.gruopBX3.Controls.Add(this.BXbuttonNo3s1);
            this.gruopBX3.Controls.Add(this.BXbuttonNo3s0);
            this.gruopBX3.Location = new System.Drawing.Point(392, 30);
            this.gruopBX3.Name = "gruopBX3";
            this.gruopBX3.Size = new System.Drawing.Size(20, 70);
            this.gruopBX3.TabIndex = 60;
            this.gruopBX3.TabStop = false;
            // 
            // BXbuttonNo3s1
            // 
            this.BXbuttonNo3s1.AutoSize = true;
            this.BXbuttonNo3s1.Location = new System.Drawing.Point(0, 19);
            this.BXbuttonNo3s1.Name = "BXbuttonNo3s1";
            this.BXbuttonNo3s1.Size = new System.Drawing.Size(21, 20);
            this.BXbuttonNo3s1.TabIndex = 32;
            this.BXbuttonNo3s1.UseVisualStyleBackColor = true;
            this.BXbuttonNo3s1.CheckedChanged += new System.EventHandler(this.BXbuttonNo3s1_CheckedChanged);
            // 
            // BXbuttonNo3s0
            // 
            this.BXbuttonNo3s0.AutoSize = true;
            this.BXbuttonNo3s0.Checked = true;
            this.BXbuttonNo3s0.Location = new System.Drawing.Point(0, 45);
            this.BXbuttonNo3s0.Name = "BXbuttonNo3s0";
            this.BXbuttonNo3s0.Size = new System.Drawing.Size(21, 20);
            this.BXbuttonNo3s0.TabIndex = 33;
            this.BXbuttonNo3s0.TabStop = true;
            this.BXbuttonNo3s0.UseVisualStyleBackColor = true;
            // 
            // gruopBX10
            // 
            this.gruopBX10.Controls.Add(this.BXbuttonNo10s1);
            this.gruopBX10.Controls.Add(this.BXbuttonNo10s0);
            this.gruopBX10.Location = new System.Drawing.Point(165, 30);
            this.gruopBX10.Name = "gruopBX10";
            this.gruopBX10.Size = new System.Drawing.Size(20, 70);
            this.gruopBX10.TabIndex = 55;
            this.gruopBX10.TabStop = false;
            // 
            // BXbuttonNo10s1
            // 
            this.BXbuttonNo10s1.AutoSize = true;
            this.BXbuttonNo10s1.Location = new System.Drawing.Point(0, 19);
            this.BXbuttonNo10s1.Name = "BXbuttonNo10s1";
            this.BXbuttonNo10s1.Size = new System.Drawing.Size(21, 20);
            this.BXbuttonNo10s1.TabIndex = 32;
            this.BXbuttonNo10s1.UseVisualStyleBackColor = true;
            this.BXbuttonNo10s1.CheckedChanged += new System.EventHandler(this.BXbuttonNo10s1_CheckedChanged);
            // 
            // BXbuttonNo10s0
            // 
            this.BXbuttonNo10s0.AutoSize = true;
            this.BXbuttonNo10s0.Checked = true;
            this.BXbuttonNo10s0.Location = new System.Drawing.Point(0, 45);
            this.BXbuttonNo10s0.Name = "BXbuttonNo10s0";
            this.BXbuttonNo10s0.Size = new System.Drawing.Size(21, 20);
            this.BXbuttonNo10s0.TabIndex = 33;
            this.BXbuttonNo10s0.TabStop = true;
            this.BXbuttonNo10s0.UseVisualStyleBackColor = true;
            // 
            // groupBoxAX
            // 
            this.groupBoxAX.Controls.Add(this.label13);
            this.groupBoxAX.Controls.Add(this.label12);
            this.groupBoxAX.Controls.Add(this.label3);
            this.groupBoxAX.Controls.Add(this.label2);
            this.groupBoxAX.Controls.Add(this.labelAL);
            this.groupBoxAX.Controls.Add(this.labelAH);
            this.groupBoxAX.Controls.Add(this.buttonWriteAX);
            this.groupBoxAX.Controls.Add(this.ALActive);
            this.groupBoxAX.Controls.Add(this.AHActive);
            this.groupBoxAX.Controls.Add(this.gruopAX0);
            this.groupBoxAX.Controls.Add(this.gruopAX8);
            this.groupBoxAX.Controls.Add(this.gruopAX1);
            this.groupBoxAX.Controls.Add(this.gruopAX15);
            this.groupBoxAX.Controls.Add(this.gruopAX14);
            this.groupBoxAX.Controls.Add(this.gruopAX4);
            this.groupBoxAX.Controls.Add(this.gruopAX7);
            this.groupBoxAX.Controls.Add(this.gruopAX9);
            this.groupBoxAX.Controls.Add(this.gruopAX11);
            this.groupBoxAX.Controls.Add(this.gruopAX2);
            this.groupBoxAX.Controls.Add(this.gruopAX6);
            this.groupBoxAX.Controls.Add(this.gruopAX12);
            this.groupBoxAX.Controls.Add(this.gruopAX13);
            this.groupBoxAX.Controls.Add(this.gruopAX5);
            this.groupBoxAX.Controls.Add(this.gruopAX3);
            this.groupBoxAX.Controls.Add(this.gruopAX10);
            this.groupBoxAX.Location = new System.Drawing.Point(6, 60);
            this.groupBoxAX.Name = "groupBoxAX";
            this.groupBoxAX.Size = new System.Drawing.Size(530, 170);
            this.groupBoxAX.TabIndex = 0;
            this.groupBoxAX.TabStop = false;
            this.groupBoxAX.Text = "Rejestr AX";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(360, 133);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 25);
            this.label13.TabIndex = 76;
            this.label13.Text = "AL";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(129, 133);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 25);
            this.label12.TabIndex = 75;
            this.label12.Text = "AH";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 25);
            this.label3.TabIndex = 74;
            this.label3.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 25);
            this.label2.TabIndex = 73;
            this.label2.Text = "1";
            // 
            // labelAL
            // 
            this.labelAL.AutoSize = true;
            this.labelAL.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelAL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelAL.Location = new System.Drawing.Point(261, 131);
            this.labelAL.Name = "labelAL";
            this.labelAL.Size = new System.Drawing.Size(94, 27);
            this.labelAL.TabIndex = 68;
            this.labelAL.Text = "00000000";
            // 
            // labelAH
            // 
            this.labelAH.AutoSize = true;
            this.labelAH.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelAH.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelAH.Location = new System.Drawing.Point(170, 131);
            this.labelAH.Name = "labelAH";
            this.labelAH.Size = new System.Drawing.Size(94, 27);
            this.labelAH.TabIndex = 67;
            this.labelAH.Text = "00000000";
            // 
            // buttonWriteAX
            // 
            this.buttonWriteAX.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonWriteAX.Location = new System.Drawing.Point(211, 103);
            this.buttonWriteAX.Name = "buttonWriteAX";
            this.buttonWriteAX.Size = new System.Drawing.Size(103, 25);
            this.buttonWriteAX.TabIndex = 66;
            this.buttonWriteAX.Text = "Wpisz";
            this.buttonWriteAX.UseVisualStyleBackColor = true;
            this.buttonWriteAX.Click += new System.EventHandler(this.buttonWriteAX_Click);
            // 
            // ALActive
            // 
            this.ALActive.AutoSize = true;
            this.ALActive.Location = new System.Drawing.Point(351, 103);
            this.ALActive.Name = "ALActive";
            this.ALActive.Size = new System.Drawing.Size(92, 25);
            this.ALActive.TabIndex = 65;
            this.ALActive.Text = "00000000";
            // 
            // AHActive
            // 
            this.AHActive.AutoSize = true;
            this.AHActive.Location = new System.Drawing.Point(91, 103);
            this.AHActive.Name = "AHActive";
            this.AHActive.Size = new System.Drawing.Size(92, 25);
            this.AHActive.TabIndex = 64;
            this.AHActive.Text = "00000000";
            // 
            // gruopAX0
            // 
            this.gruopAX0.Controls.Add(this.AXbuttonNo0s1);
            this.gruopAX0.Controls.Add(this.AXbuttonNo0s0);
            this.gruopAX0.Location = new System.Drawing.Point(476, 30);
            this.gruopAX0.Name = "gruopAX0";
            this.gruopAX0.Size = new System.Drawing.Size(20, 70);
            this.gruopAX0.TabIndex = 61;
            this.gruopAX0.TabStop = false;
            // 
            // AXbuttonNo0s1
            // 
            this.AXbuttonNo0s1.AutoSize = true;
            this.AXbuttonNo0s1.Location = new System.Drawing.Point(0, 19);
            this.AXbuttonNo0s1.Name = "AXbuttonNo0s1";
            this.AXbuttonNo0s1.Size = new System.Drawing.Size(21, 20);
            this.AXbuttonNo0s1.TabIndex = 32;
            this.AXbuttonNo0s1.UseVisualStyleBackColor = true;
            this.AXbuttonNo0s1.CheckedChanged += new System.EventHandler(this.AXbuttonNo0s1_CheckedChanged);
            // 
            // AXbuttonNo0s0
            // 
            this.AXbuttonNo0s0.AutoSize = true;
            this.AXbuttonNo0s0.Checked = true;
            this.AXbuttonNo0s0.Location = new System.Drawing.Point(0, 45);
            this.AXbuttonNo0s0.Name = "AXbuttonNo0s0";
            this.AXbuttonNo0s0.Size = new System.Drawing.Size(21, 20);
            this.AXbuttonNo0s0.TabIndex = 33;
            this.AXbuttonNo0s0.TabStop = true;
            this.AXbuttonNo0s0.UseVisualStyleBackColor = true;
            // 
            // gruopAX8
            // 
            this.gruopAX8.Controls.Add(this.AXbuttonNo8s1);
            this.gruopAX8.Controls.Add(this.AXbuttonNo8s0);
            this.gruopAX8.Location = new System.Drawing.Point(223, 30);
            this.gruopAX8.Name = "gruopAX8";
            this.gruopAX8.Size = new System.Drawing.Size(20, 70);
            this.gruopAX8.TabIndex = 53;
            this.gruopAX8.TabStop = false;
            // 
            // AXbuttonNo8s1
            // 
            this.AXbuttonNo8s1.AutoSize = true;
            this.AXbuttonNo8s1.Location = new System.Drawing.Point(0, 19);
            this.AXbuttonNo8s1.Name = "AXbuttonNo8s1";
            this.AXbuttonNo8s1.Size = new System.Drawing.Size(21, 20);
            this.AXbuttonNo8s1.TabIndex = 32;
            this.AXbuttonNo8s1.UseVisualStyleBackColor = true;
            this.AXbuttonNo8s1.CheckedChanged += new System.EventHandler(this.AXbuttonNo8s1_CheckedChanged);
            // 
            // AXbuttonNo8s0
            // 
            this.AXbuttonNo8s0.AutoSize = true;
            this.AXbuttonNo8s0.Checked = true;
            this.AXbuttonNo8s0.Location = new System.Drawing.Point(0, 45);
            this.AXbuttonNo8s0.Name = "AXbuttonNo8s0";
            this.AXbuttonNo8s0.Size = new System.Drawing.Size(21, 20);
            this.AXbuttonNo8s0.TabIndex = 33;
            this.AXbuttonNo8s0.TabStop = true;
            this.AXbuttonNo8s0.UseVisualStyleBackColor = true;
            // 
            // gruopAX1
            // 
            this.gruopAX1.Controls.Add(this.AXbuttonNo1s1);
            this.gruopAX1.Controls.Add(this.AXbuttonNo1s0);
            this.gruopAX1.Location = new System.Drawing.Point(450, 30);
            this.gruopAX1.Name = "gruopAX1";
            this.gruopAX1.Size = new System.Drawing.Size(20, 70);
            this.gruopAX1.TabIndex = 62;
            this.gruopAX1.TabStop = false;
            // 
            // AXbuttonNo1s1
            // 
            this.AXbuttonNo1s1.AutoSize = true;
            this.AXbuttonNo1s1.Location = new System.Drawing.Point(0, 19);
            this.AXbuttonNo1s1.Name = "AXbuttonNo1s1";
            this.AXbuttonNo1s1.Size = new System.Drawing.Size(21, 20);
            this.AXbuttonNo1s1.TabIndex = 32;
            this.AXbuttonNo1s1.UseVisualStyleBackColor = true;
            this.AXbuttonNo1s1.CheckedChanged += new System.EventHandler(this.AXbuttonNo1s1_CheckedChanged);
            // 
            // AXbuttonNo1s0
            // 
            this.AXbuttonNo1s0.AutoSize = true;
            this.AXbuttonNo1s0.Checked = true;
            this.AXbuttonNo1s0.Location = new System.Drawing.Point(0, 45);
            this.AXbuttonNo1s0.Name = "AXbuttonNo1s0";
            this.AXbuttonNo1s0.Size = new System.Drawing.Size(21, 20);
            this.AXbuttonNo1s0.TabIndex = 33;
            this.AXbuttonNo1s0.TabStop = true;
            this.AXbuttonNo1s0.UseVisualStyleBackColor = true;
            // 
            // gruopAX15
            // 
            this.gruopAX15.Controls.Add(this.AXbuttonNo15s1);
            this.gruopAX15.Controls.Add(this.AXbuttonNo15s0);
            this.gruopAX15.Location = new System.Drawing.Point(40, 30);
            this.gruopAX15.Name = "gruopAX15";
            this.gruopAX15.Size = new System.Drawing.Size(20, 70);
            this.gruopAX15.TabIndex = 48;
            this.gruopAX15.TabStop = false;
            // 
            // AXbuttonNo15s1
            // 
            this.AXbuttonNo15s1.AutoSize = true;
            this.AXbuttonNo15s1.Location = new System.Drawing.Point(0, 19);
            this.AXbuttonNo15s1.Name = "AXbuttonNo15s1";
            this.AXbuttonNo15s1.Size = new System.Drawing.Size(21, 20);
            this.AXbuttonNo15s1.TabIndex = 32;
            this.AXbuttonNo15s1.UseVisualStyleBackColor = true;
            // 
            // AXbuttonNo15s0
            // 
            this.AXbuttonNo15s0.AutoSize = true;
            this.AXbuttonNo15s0.Checked = true;
            this.AXbuttonNo15s0.Location = new System.Drawing.Point(0, 45);
            this.AXbuttonNo15s0.Name = "AXbuttonNo15s0";
            this.AXbuttonNo15s0.Size = new System.Drawing.Size(21, 20);
            this.AXbuttonNo15s0.TabIndex = 33;
            this.AXbuttonNo15s0.TabStop = true;
            this.AXbuttonNo15s0.UseVisualStyleBackColor = true;
            this.AXbuttonNo15s0.CheckedChanged += new System.EventHandler(this.AXbuttonNo15s0_CheckedChanged);
            // 
            // gruopAX14
            // 
            this.gruopAX14.Controls.Add(this.AXbuttonNo14s1);
            this.gruopAX14.Controls.Add(this.AXbuttonNo14s0);
            this.gruopAX14.Location = new System.Drawing.Point(66, 30);
            this.gruopAX14.Name = "gruopAX14";
            this.gruopAX14.Size = new System.Drawing.Size(20, 70);
            this.gruopAX14.TabIndex = 51;
            this.gruopAX14.TabStop = false;
            // 
            // AXbuttonNo14s1
            // 
            this.AXbuttonNo14s1.AutoSize = true;
            this.AXbuttonNo14s1.Location = new System.Drawing.Point(0, 19);
            this.AXbuttonNo14s1.Name = "AXbuttonNo14s1";
            this.AXbuttonNo14s1.Size = new System.Drawing.Size(21, 20);
            this.AXbuttonNo14s1.TabIndex = 32;
            this.AXbuttonNo14s1.UseVisualStyleBackColor = true;
            this.AXbuttonNo14s1.CheckedChanged += new System.EventHandler(this.AXbuttonNo14s1_CheckedChanged);
            // 
            // AXbuttonNo14s0
            // 
            this.AXbuttonNo14s0.AutoSize = true;
            this.AXbuttonNo14s0.Checked = true;
            this.AXbuttonNo14s0.Location = new System.Drawing.Point(0, 45);
            this.AXbuttonNo14s0.Name = "AXbuttonNo14s0";
            this.AXbuttonNo14s0.Size = new System.Drawing.Size(21, 20);
            this.AXbuttonNo14s0.TabIndex = 33;
            this.AXbuttonNo14s0.TabStop = true;
            this.AXbuttonNo14s0.UseVisualStyleBackColor = true;
            // 
            // gruopAX4
            // 
            this.gruopAX4.Controls.Add(this.AXbuttonNo4s1);
            this.gruopAX4.Controls.Add(this.AXbuttonNo4s0);
            this.gruopAX4.Location = new System.Drawing.Point(371, 30);
            this.gruopAX4.Name = "gruopAX4";
            this.gruopAX4.Size = new System.Drawing.Size(20, 70);
            this.gruopAX4.TabIndex = 57;
            this.gruopAX4.TabStop = false;
            // 
            // AXbuttonNo4s1
            // 
            this.AXbuttonNo4s1.AutoSize = true;
            this.AXbuttonNo4s1.Location = new System.Drawing.Point(0, 19);
            this.AXbuttonNo4s1.Name = "AXbuttonNo4s1";
            this.AXbuttonNo4s1.Size = new System.Drawing.Size(21, 20);
            this.AXbuttonNo4s1.TabIndex = 32;
            this.AXbuttonNo4s1.UseVisualStyleBackColor = true;
            this.AXbuttonNo4s1.CheckedChanged += new System.EventHandler(this.AXbuttonNo4s1_CheckedChanged);
            // 
            // AXbuttonNo4s0
            // 
            this.AXbuttonNo4s0.AutoSize = true;
            this.AXbuttonNo4s0.Checked = true;
            this.AXbuttonNo4s0.Location = new System.Drawing.Point(0, 45);
            this.AXbuttonNo4s0.Name = "AXbuttonNo4s0";
            this.AXbuttonNo4s0.Size = new System.Drawing.Size(21, 20);
            this.AXbuttonNo4s0.TabIndex = 33;
            this.AXbuttonNo4s0.TabStop = true;
            this.AXbuttonNo4s0.UseVisualStyleBackColor = true;
            // 
            // gruopAX7
            // 
            this.gruopAX7.Controls.Add(this.AXbuttonNo7s1);
            this.gruopAX7.Controls.Add(this.AXbuttonNo7s0);
            this.gruopAX7.Location = new System.Drawing.Point(293, 30);
            this.gruopAX7.Name = "gruopAX7";
            this.gruopAX7.Size = new System.Drawing.Size(20, 70);
            this.gruopAX7.TabIndex = 56;
            this.gruopAX7.TabStop = false;
            // 
            // AXbuttonNo7s1
            // 
            this.AXbuttonNo7s1.AutoSize = true;
            this.AXbuttonNo7s1.Location = new System.Drawing.Point(0, 19);
            this.AXbuttonNo7s1.Name = "AXbuttonNo7s1";
            this.AXbuttonNo7s1.Size = new System.Drawing.Size(21, 20);
            this.AXbuttonNo7s1.TabIndex = 32;
            this.AXbuttonNo7s1.UseVisualStyleBackColor = true;
            this.AXbuttonNo7s1.CheckedChanged += new System.EventHandler(this.AXbuttonNo7s1_CheckedChanged);
            // 
            // AXbuttonNo7s0
            // 
            this.AXbuttonNo7s0.AutoSize = true;
            this.AXbuttonNo7s0.Checked = true;
            this.AXbuttonNo7s0.Location = new System.Drawing.Point(0, 45);
            this.AXbuttonNo7s0.Name = "AXbuttonNo7s0";
            this.AXbuttonNo7s0.Size = new System.Drawing.Size(21, 20);
            this.AXbuttonNo7s0.TabIndex = 33;
            this.AXbuttonNo7s0.TabStop = true;
            this.AXbuttonNo7s0.UseVisualStyleBackColor = true;
            // 
            // gruopAX9
            // 
            this.gruopAX9.Controls.Add(this.AXbuttonNo9s1);
            this.gruopAX9.Controls.Add(this.AXbuttonNo9s0);
            this.gruopAX9.Location = new System.Drawing.Point(197, 30);
            this.gruopAX9.Name = "gruopAX9";
            this.gruopAX9.Size = new System.Drawing.Size(20, 70);
            this.gruopAX9.TabIndex = 54;
            this.gruopAX9.TabStop = false;
            // 
            // AXbuttonNo9s1
            // 
            this.AXbuttonNo9s1.AutoSize = true;
            this.AXbuttonNo9s1.Location = new System.Drawing.Point(0, 19);
            this.AXbuttonNo9s1.Name = "AXbuttonNo9s1";
            this.AXbuttonNo9s1.Size = new System.Drawing.Size(21, 20);
            this.AXbuttonNo9s1.TabIndex = 32;
            this.AXbuttonNo9s1.UseVisualStyleBackColor = true;
            this.AXbuttonNo9s1.CheckedChanged += new System.EventHandler(this.AXbuttonNo9s1_CheckedChanged);
            // 
            // AXbuttonNo9s0
            // 
            this.AXbuttonNo9s0.AutoSize = true;
            this.AXbuttonNo9s0.Checked = true;
            this.AXbuttonNo9s0.Location = new System.Drawing.Point(0, 45);
            this.AXbuttonNo9s0.Name = "AXbuttonNo9s0";
            this.AXbuttonNo9s0.Size = new System.Drawing.Size(21, 20);
            this.AXbuttonNo9s0.TabIndex = 33;
            this.AXbuttonNo9s0.TabStop = true;
            this.AXbuttonNo9s0.UseVisualStyleBackColor = true;
            // 
            // gruopAX11
            // 
            this.gruopAX11.Controls.Add(this.AXbuttonNo11s1);
            this.gruopAX11.Controls.Add(this.AXbuttonNo11s0);
            this.gruopAX11.Location = new System.Drawing.Point(145, 30);
            this.gruopAX11.Name = "gruopAX11";
            this.gruopAX11.Size = new System.Drawing.Size(20, 70);
            this.gruopAX11.TabIndex = 52;
            this.gruopAX11.TabStop = false;
            // 
            // AXbuttonNo11s1
            // 
            this.AXbuttonNo11s1.AutoSize = true;
            this.AXbuttonNo11s1.Location = new System.Drawing.Point(0, 19);
            this.AXbuttonNo11s1.Name = "AXbuttonNo11s1";
            this.AXbuttonNo11s1.Size = new System.Drawing.Size(21, 20);
            this.AXbuttonNo11s1.TabIndex = 32;
            this.AXbuttonNo11s1.UseVisualStyleBackColor = true;
            this.AXbuttonNo11s1.CheckedChanged += new System.EventHandler(this.AXbuttonNo11s1_CheckedChanged);
            // 
            // AXbuttonNo11s0
            // 
            this.AXbuttonNo11s0.AutoSize = true;
            this.AXbuttonNo11s0.Checked = true;
            this.AXbuttonNo11s0.Location = new System.Drawing.Point(0, 45);
            this.AXbuttonNo11s0.Name = "AXbuttonNo11s0";
            this.AXbuttonNo11s0.Size = new System.Drawing.Size(21, 20);
            this.AXbuttonNo11s0.TabIndex = 33;
            this.AXbuttonNo11s0.TabStop = true;
            this.AXbuttonNo11s0.UseVisualStyleBackColor = true;
            // 
            // gruopAX2
            // 
            this.gruopAX2.Controls.Add(this.AXbuttonNo2s1);
            this.gruopAX2.Controls.Add(this.AXbuttonNo2s0);
            this.gruopAX2.Location = new System.Drawing.Point(424, 30);
            this.gruopAX2.Name = "gruopAX2";
            this.gruopAX2.Size = new System.Drawing.Size(20, 70);
            this.gruopAX2.TabIndex = 63;
            this.gruopAX2.TabStop = false;
            // 
            // AXbuttonNo2s1
            // 
            this.AXbuttonNo2s1.AutoSize = true;
            this.AXbuttonNo2s1.Location = new System.Drawing.Point(0, 19);
            this.AXbuttonNo2s1.Name = "AXbuttonNo2s1";
            this.AXbuttonNo2s1.Size = new System.Drawing.Size(21, 20);
            this.AXbuttonNo2s1.TabIndex = 32;
            this.AXbuttonNo2s1.UseVisualStyleBackColor = true;
            this.AXbuttonNo2s1.CheckedChanged += new System.EventHandler(this.AXbuttonNo2s1_CheckedChanged);
            // 
            // AXbuttonNo2s0
            // 
            this.AXbuttonNo2s0.AutoSize = true;
            this.AXbuttonNo2s0.Checked = true;
            this.AXbuttonNo2s0.Location = new System.Drawing.Point(0, 45);
            this.AXbuttonNo2s0.Name = "AXbuttonNo2s0";
            this.AXbuttonNo2s0.Size = new System.Drawing.Size(21, 20);
            this.AXbuttonNo2s0.TabIndex = 33;
            this.AXbuttonNo2s0.TabStop = true;
            this.AXbuttonNo2s0.UseVisualStyleBackColor = true;
            // 
            // gruopAX6
            // 
            this.gruopAX6.Controls.Add(this.AXbuttonNo6s1);
            this.gruopAX6.Controls.Add(this.AXbuttonNo6s0);
            this.gruopAX6.Location = new System.Drawing.Point(319, 30);
            this.gruopAX6.Name = "gruopAX6";
            this.gruopAX6.Size = new System.Drawing.Size(20, 70);
            this.gruopAX6.TabIndex = 59;
            this.gruopAX6.TabStop = false;
            // 
            // AXbuttonNo6s1
            // 
            this.AXbuttonNo6s1.AutoSize = true;
            this.AXbuttonNo6s1.Location = new System.Drawing.Point(0, 19);
            this.AXbuttonNo6s1.Name = "AXbuttonNo6s1";
            this.AXbuttonNo6s1.Size = new System.Drawing.Size(21, 20);
            this.AXbuttonNo6s1.TabIndex = 32;
            this.AXbuttonNo6s1.UseVisualStyleBackColor = true;
            this.AXbuttonNo6s1.CheckedChanged += new System.EventHandler(this.AXbuttonNo6s1_CheckedChanged);
            // 
            // AXbuttonNo6s0
            // 
            this.AXbuttonNo6s0.AutoSize = true;
            this.AXbuttonNo6s0.Checked = true;
            this.AXbuttonNo6s0.Location = new System.Drawing.Point(0, 45);
            this.AXbuttonNo6s0.Name = "AXbuttonNo6s0";
            this.AXbuttonNo6s0.Size = new System.Drawing.Size(21, 20);
            this.AXbuttonNo6s0.TabIndex = 33;
            this.AXbuttonNo6s0.TabStop = true;
            this.AXbuttonNo6s0.UseVisualStyleBackColor = true;
            // 
            // gruopAX12
            // 
            this.gruopAX12.Controls.Add(this.AXbuttonNo12s1);
            this.gruopAX12.Controls.Add(this.AXbuttonNo12s0);
            this.gruopAX12.Location = new System.Drawing.Point(118, 30);
            this.gruopAX12.Name = "gruopAX12";
            this.gruopAX12.Size = new System.Drawing.Size(20, 70);
            this.gruopAX12.TabIndex = 49;
            this.gruopAX12.TabStop = false;
            // 
            // AXbuttonNo12s1
            // 
            this.AXbuttonNo12s1.AutoSize = true;
            this.AXbuttonNo12s1.Location = new System.Drawing.Point(0, 19);
            this.AXbuttonNo12s1.Name = "AXbuttonNo12s1";
            this.AXbuttonNo12s1.Size = new System.Drawing.Size(21, 20);
            this.AXbuttonNo12s1.TabIndex = 32;
            this.AXbuttonNo12s1.UseVisualStyleBackColor = true;
            this.AXbuttonNo12s1.CheckedChanged += new System.EventHandler(this.AXbuttonNo12s1_CheckedChanged);
            // 
            // AXbuttonNo12s0
            // 
            this.AXbuttonNo12s0.AutoSize = true;
            this.AXbuttonNo12s0.Checked = true;
            this.AXbuttonNo12s0.Location = new System.Drawing.Point(0, 45);
            this.AXbuttonNo12s0.Name = "AXbuttonNo12s0";
            this.AXbuttonNo12s0.Size = new System.Drawing.Size(21, 20);
            this.AXbuttonNo12s0.TabIndex = 33;
            this.AXbuttonNo12s0.TabStop = true;
            this.AXbuttonNo12s0.UseVisualStyleBackColor = true;
            // 
            // gruopAX13
            // 
            this.gruopAX13.Controls.Add(this.AXbuttonNo13s1);
            this.gruopAX13.Controls.Add(this.AXbuttonNo13s0);
            this.gruopAX13.Location = new System.Drawing.Point(92, 30);
            this.gruopAX13.Name = "gruopAX13";
            this.gruopAX13.Size = new System.Drawing.Size(20, 70);
            this.gruopAX13.TabIndex = 50;
            this.gruopAX13.TabStop = false;
            // 
            // AXbuttonNo13s1
            // 
            this.AXbuttonNo13s1.AutoSize = true;
            this.AXbuttonNo13s1.Location = new System.Drawing.Point(0, 19);
            this.AXbuttonNo13s1.Name = "AXbuttonNo13s1";
            this.AXbuttonNo13s1.Size = new System.Drawing.Size(21, 20);
            this.AXbuttonNo13s1.TabIndex = 32;
            this.AXbuttonNo13s1.UseVisualStyleBackColor = true;
            this.AXbuttonNo13s1.CheckedChanged += new System.EventHandler(this.AXbuttonNo13s1_CheckedChanged);
            // 
            // AXbuttonNo13s0
            // 
            this.AXbuttonNo13s0.AutoSize = true;
            this.AXbuttonNo13s0.Checked = true;
            this.AXbuttonNo13s0.Location = new System.Drawing.Point(0, 45);
            this.AXbuttonNo13s0.Name = "AXbuttonNo13s0";
            this.AXbuttonNo13s0.Size = new System.Drawing.Size(21, 20);
            this.AXbuttonNo13s0.TabIndex = 33;
            this.AXbuttonNo13s0.TabStop = true;
            this.AXbuttonNo13s0.UseVisualStyleBackColor = true;
            // 
            // gruopAX5
            // 
            this.gruopAX5.Controls.Add(this.AXbuttonNo5s1);
            this.gruopAX5.Controls.Add(this.AXbuttonNo5s0);
            this.gruopAX5.Location = new System.Drawing.Point(345, 30);
            this.gruopAX5.Name = "gruopAX5";
            this.gruopAX5.Size = new System.Drawing.Size(20, 70);
            this.gruopAX5.TabIndex = 58;
            this.gruopAX5.TabStop = false;
            // 
            // AXbuttonNo5s1
            // 
            this.AXbuttonNo5s1.AutoSize = true;
            this.AXbuttonNo5s1.Location = new System.Drawing.Point(0, 19);
            this.AXbuttonNo5s1.Name = "AXbuttonNo5s1";
            this.AXbuttonNo5s1.Size = new System.Drawing.Size(21, 20);
            this.AXbuttonNo5s1.TabIndex = 32;
            this.AXbuttonNo5s1.UseVisualStyleBackColor = true;
            this.AXbuttonNo5s1.CheckedChanged += new System.EventHandler(this.AXbuttonNo5s1_CheckedChanged);
            // 
            // AXbuttonNo5s0
            // 
            this.AXbuttonNo5s0.AutoSize = true;
            this.AXbuttonNo5s0.Checked = true;
            this.AXbuttonNo5s0.Location = new System.Drawing.Point(0, 45);
            this.AXbuttonNo5s0.Name = "AXbuttonNo5s0";
            this.AXbuttonNo5s0.Size = new System.Drawing.Size(21, 20);
            this.AXbuttonNo5s0.TabIndex = 33;
            this.AXbuttonNo5s0.TabStop = true;
            this.AXbuttonNo5s0.UseVisualStyleBackColor = true;
            // 
            // gruopAX3
            // 
            this.gruopAX3.Controls.Add(this.AXbuttonNo3s1);
            this.gruopAX3.Controls.Add(this.AXbuttonNo3s0);
            this.gruopAX3.Location = new System.Drawing.Point(398, 30);
            this.gruopAX3.Name = "gruopAX3";
            this.gruopAX3.Size = new System.Drawing.Size(20, 70);
            this.gruopAX3.TabIndex = 60;
            this.gruopAX3.TabStop = false;
            // 
            // AXbuttonNo3s1
            // 
            this.AXbuttonNo3s1.AutoSize = true;
            this.AXbuttonNo3s1.Location = new System.Drawing.Point(0, 19);
            this.AXbuttonNo3s1.Name = "AXbuttonNo3s1";
            this.AXbuttonNo3s1.Size = new System.Drawing.Size(21, 20);
            this.AXbuttonNo3s1.TabIndex = 32;
            this.AXbuttonNo3s1.UseVisualStyleBackColor = true;
            this.AXbuttonNo3s1.CheckedChanged += new System.EventHandler(this.AXbuttonNo3s1_CheckedChanged);
            // 
            // AXbuttonNo3s0
            // 
            this.AXbuttonNo3s0.AutoSize = true;
            this.AXbuttonNo3s0.Checked = true;
            this.AXbuttonNo3s0.Location = new System.Drawing.Point(0, 45);
            this.AXbuttonNo3s0.Name = "AXbuttonNo3s0";
            this.AXbuttonNo3s0.Size = new System.Drawing.Size(21, 20);
            this.AXbuttonNo3s0.TabIndex = 33;
            this.AXbuttonNo3s0.TabStop = true;
            this.AXbuttonNo3s0.UseVisualStyleBackColor = true;
            // 
            // gruopAX10
            // 
            this.gruopAX10.Controls.Add(this.AXbuttonNo10s1);
            this.gruopAX10.Controls.Add(this.AXbuttonNo10s0);
            this.gruopAX10.Location = new System.Drawing.Point(171, 30);
            this.gruopAX10.Name = "gruopAX10";
            this.gruopAX10.Size = new System.Drawing.Size(20, 70);
            this.gruopAX10.TabIndex = 55;
            this.gruopAX10.TabStop = false;
            // 
            // AXbuttonNo10s1
            // 
            this.AXbuttonNo10s1.AutoSize = true;
            this.AXbuttonNo10s1.Location = new System.Drawing.Point(0, 19);
            this.AXbuttonNo10s1.Name = "AXbuttonNo10s1";
            this.AXbuttonNo10s1.Size = new System.Drawing.Size(21, 20);
            this.AXbuttonNo10s1.TabIndex = 32;
            this.AXbuttonNo10s1.UseVisualStyleBackColor = true;
            this.AXbuttonNo10s1.CheckedChanged += new System.EventHandler(this.AXbuttonNo10s1_CheckedChanged);
            // 
            // AXbuttonNo10s0
            // 
            this.AXbuttonNo10s0.AutoSize = true;
            this.AXbuttonNo10s0.Checked = true;
            this.AXbuttonNo10s0.Location = new System.Drawing.Point(0, 45);
            this.AXbuttonNo10s0.Name = "AXbuttonNo10s0";
            this.AXbuttonNo10s0.Size = new System.Drawing.Size(21, 20);
            this.AXbuttonNo10s0.TabIndex = 33;
            this.AXbuttonNo10s0.TabStop = true;
            this.AXbuttonNo10s0.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonProgramReset);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.buttonProgram);
            this.groupBox2.Controls.Add(this.buttonProgramStep);
            this.groupBox2.Controls.Add(this.listProgram);
            this.groupBox2.Location = new System.Drawing.Point(1083, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(449, 723);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Program";
            // 
            // buttonProgramReset
            // 
            this.buttonProgramReset.Location = new System.Drawing.Point(165, 20);
            this.buttonProgramReset.Name = "buttonProgramReset";
            this.buttonProgramReset.Size = new System.Drawing.Size(112, 34);
            this.buttonProgramReset.TabIndex = 4;
            this.buttonProgramReset.Text = "Reset";
            this.buttonProgramReset.UseVisualStyleBackColor = true;
            this.buttonProgramReset.Click += new System.EventHandler(this.buttonProgramReset_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonRead);
            this.groupBox3.Controls.Add(this.buttonSave);
            this.groupBox3.Location = new System.Drawing.Point(42, 584);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(352, 119);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Zapis i odczyt programu";
            // 
            // buttonRead
            // 
            this.buttonRead.Location = new System.Drawing.Point(186, 30);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(115, 71);
            this.buttonRead.TabIndex = 1;
            this.buttonRead.Text = "Wczytaj";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(51, 30);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(115, 71);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Zapisz";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonProgram
            // 
            this.buttonProgram.Location = new System.Drawing.Point(228, 537);
            this.buttonProgram.Name = "buttonProgram";
            this.buttonProgram.Size = new System.Drawing.Size(166, 34);
            this.buttonProgram.TabIndex = 2;
            this.buttonProgram.Text = "Wykonaj program";
            this.buttonProgram.UseVisualStyleBackColor = true;
            this.buttonProgram.Click += new System.EventHandler(this.buttonProgram_Click);
            // 
            // buttonProgramStep
            // 
            this.buttonProgramStep.Location = new System.Drawing.Point(42, 537);
            this.buttonProgramStep.Name = "buttonProgramStep";
            this.buttonProgramStep.Size = new System.Drawing.Size(166, 34);
            this.buttonProgramStep.TabIndex = 1;
            this.buttonProgramStep.Text = "Wykonaj krok";
            this.buttonProgramStep.UseVisualStyleBackColor = true;
            this.buttonProgramStep.Click += new System.EventHandler(this.buttonProgramStep_Click);
            // 
            // listProgram
            // 
            this.listProgram.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listProgram.FormattingEnabled = true;
            this.listProgram.ItemHeight = 38;
            this.listProgram.Location = new System.Drawing.Point(139, 60);
            this.listProgram.Name = "listProgram";
            this.listProgram.Size = new System.Drawing.Size(166, 460);
            this.listProgram.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1533, 747);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxInstant.ResumeLayout(false);
            this.groupBoxInstant.PerformLayout();
            this.groupInstant0.ResumeLayout(false);
            this.groupInstant0.PerformLayout();
            this.groupInstant1.ResumeLayout(false);
            this.groupInstant1.PerformLayout();
            this.groupInstant8.ResumeLayout(false);
            this.groupInstant8.PerformLayout();
            this.groupInstant4.ResumeLayout(false);
            this.groupInstant4.PerformLayout();
            this.groupInstant9.ResumeLayout(false);
            this.groupInstant9.PerformLayout();
            this.groupInstant2.ResumeLayout(false);
            this.groupInstant2.PerformLayout();
            this.groupInstant12.ResumeLayout(false);
            this.groupInstant12.PerformLayout();
            this.groupInstant5.ResumeLayout(false);
            this.groupInstant5.PerformLayout();
            this.groupInstant10.ResumeLayout(false);
            this.groupInstant10.PerformLayout();
            this.groupInstant3.ResumeLayout(false);
            this.groupInstant3.PerformLayout();
            this.groupInstant13.ResumeLayout(false);
            this.groupInstant13.PerformLayout();
            this.groupInstant6.ResumeLayout(false);
            this.groupInstant6.PerformLayout();
            this.groupInstant11.ResumeLayout(false);
            this.groupInstant11.PerformLayout();
            this.groupInstant7.ResumeLayout(false);
            this.groupInstant7.PerformLayout();
            this.groupInstant14.ResumeLayout(false);
            this.groupInstant14.PerformLayout();
            this.groupInstant15.ResumeLayout(false);
            this.groupInstant15.PerformLayout();
            this.groupBoxDX.ResumeLayout(false);
            this.groupBoxDX.PerformLayout();
            this.gruopDX0.ResumeLayout(false);
            this.gruopDX0.PerformLayout();
            this.gruopDX1.ResumeLayout(false);
            this.gruopDX1.PerformLayout();
            this.gruopDX8.ResumeLayout(false);
            this.gruopDX8.PerformLayout();
            this.gruopDX4.ResumeLayout(false);
            this.gruopDX4.PerformLayout();
            this.gruopDX9.ResumeLayout(false);
            this.gruopDX9.PerformLayout();
            this.gruopDX2.ResumeLayout(false);
            this.gruopDX2.PerformLayout();
            this.gruopDX12.ResumeLayout(false);
            this.gruopDX12.PerformLayout();
            this.gruopDX5.ResumeLayout(false);
            this.gruopDX5.PerformLayout();
            this.gruopDX10.ResumeLayout(false);
            this.gruopDX10.PerformLayout();
            this.gruopDX3.ResumeLayout(false);
            this.gruopDX3.PerformLayout();
            this.gruopDX13.ResumeLayout(false);
            this.gruopDX13.PerformLayout();
            this.gruopDX6.ResumeLayout(false);
            this.gruopDX6.PerformLayout();
            this.gruopDX11.ResumeLayout(false);
            this.gruopDX11.PerformLayout();
            this.gruopDX7.ResumeLayout(false);
            this.gruopDX7.PerformLayout();
            this.gruopDX14.ResumeLayout(false);
            this.gruopDX14.PerformLayout();
            this.gruopDX15.ResumeLayout(false);
            this.gruopDX15.PerformLayout();
            this.groupBoxCX.ResumeLayout(false);
            this.groupBoxCX.PerformLayout();
            this.gruopCX0.ResumeLayout(false);
            this.gruopCX0.PerformLayout();
            this.gruopCX1.ResumeLayout(false);
            this.gruopCX1.PerformLayout();
            this.gruopCX8.ResumeLayout(false);
            this.gruopCX8.PerformLayout();
            this.gruopCX4.ResumeLayout(false);
            this.gruopCX4.PerformLayout();
            this.gruopCX9.ResumeLayout(false);
            this.gruopCX9.PerformLayout();
            this.gruopCX2.ResumeLayout(false);
            this.gruopCX2.PerformLayout();
            this.gruopCX12.ResumeLayout(false);
            this.gruopCX12.PerformLayout();
            this.gruopCX5.ResumeLayout(false);
            this.gruopCX5.PerformLayout();
            this.gruopCX10.ResumeLayout(false);
            this.gruopCX10.PerformLayout();
            this.gruopCX3.ResumeLayout(false);
            this.gruopCX3.PerformLayout();
            this.gruopCX13.ResumeLayout(false);
            this.gruopCX13.PerformLayout();
            this.gruopCX6.ResumeLayout(false);
            this.gruopCX6.PerformLayout();
            this.gruopCX11.ResumeLayout(false);
            this.gruopCX11.PerformLayout();
            this.gruopCX7.ResumeLayout(false);
            this.gruopCX7.PerformLayout();
            this.gruopCX14.ResumeLayout(false);
            this.gruopCX14.PerformLayout();
            this.gruopCX15.ResumeLayout(false);
            this.gruopCX15.PerformLayout();
            this.groupBoxBX.ResumeLayout(false);
            this.groupBoxBX.PerformLayout();
            this.gruopBX0.ResumeLayout(false);
            this.gruopBX0.PerformLayout();
            this.gruopBX1.ResumeLayout(false);
            this.gruopBX1.PerformLayout();
            this.gruopBX15.ResumeLayout(false);
            this.gruopBX15.PerformLayout();
            this.gruopBX8.ResumeLayout(false);
            this.gruopBX8.PerformLayout();
            this.gruopBX14.ResumeLayout(false);
            this.gruopBX14.PerformLayout();
            this.gruopBX4.ResumeLayout(false);
            this.gruopBX4.PerformLayout();
            this.gruopBX7.ResumeLayout(false);
            this.gruopBX7.PerformLayout();
            this.gruopBX9.ResumeLayout(false);
            this.gruopBX9.PerformLayout();
            this.gruopBX11.ResumeLayout(false);
            this.gruopBX11.PerformLayout();
            this.gruopBX2.ResumeLayout(false);
            this.gruopBX2.PerformLayout();
            this.gruopBX6.ResumeLayout(false);
            this.gruopBX6.PerformLayout();
            this.gruopBX12.ResumeLayout(false);
            this.gruopBX12.PerformLayout();
            this.gruopBX13.ResumeLayout(false);
            this.gruopBX13.PerformLayout();
            this.gruopBX5.ResumeLayout(false);
            this.gruopBX5.PerformLayout();
            this.gruopBX3.ResumeLayout(false);
            this.gruopBX3.PerformLayout();
            this.gruopBX10.ResumeLayout(false);
            this.gruopBX10.PerformLayout();
            this.groupBoxAX.ResumeLayout(false);
            this.groupBoxAX.PerformLayout();
            this.gruopAX0.ResumeLayout(false);
            this.gruopAX0.PerformLayout();
            this.gruopAX8.ResumeLayout(false);
            this.gruopAX8.PerformLayout();
            this.gruopAX1.ResumeLayout(false);
            this.gruopAX1.PerformLayout();
            this.gruopAX15.ResumeLayout(false);
            this.gruopAX15.PerformLayout();
            this.gruopAX14.ResumeLayout(false);
            this.gruopAX14.PerformLayout();
            this.gruopAX4.ResumeLayout(false);
            this.gruopAX4.PerformLayout();
            this.gruopAX7.ResumeLayout(false);
            this.gruopAX7.PerformLayout();
            this.gruopAX9.ResumeLayout(false);
            this.gruopAX9.PerformLayout();
            this.gruopAX11.ResumeLayout(false);
            this.gruopAX11.PerformLayout();
            this.gruopAX2.ResumeLayout(false);
            this.gruopAX2.PerformLayout();
            this.gruopAX6.ResumeLayout(false);
            this.gruopAX6.PerformLayout();
            this.gruopAX12.ResumeLayout(false);
            this.gruopAX12.PerformLayout();
            this.gruopAX13.ResumeLayout(false);
            this.gruopAX13.PerformLayout();
            this.gruopAX5.ResumeLayout(false);
            this.gruopAX5.PerformLayout();
            this.gruopAX3.ResumeLayout(false);
            this.gruopAX3.PerformLayout();
            this.gruopAX10.ResumeLayout(false);
            this.gruopAX10.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxDX;
        private System.Windows.Forms.GroupBox groupBoxCX;
        private System.Windows.Forms.GroupBox groupBoxBX;
        private System.Windows.Forms.GroupBox groupBoxAX;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox gruopCX15;
        private System.Windows.Forms.RadioButton CXbuttonNo15s1;
        private System.Windows.Forms.RadioButton CXbuttonNo15s0;
        private System.Windows.Forms.GroupBox gruopCX0;
        private System.Windows.Forms.RadioButton CXbuttonNo0s1;
        private System.Windows.Forms.RadioButton CXbuttonNo0s0;
        private System.Windows.Forms.GroupBox gruopCX1;
        private System.Windows.Forms.RadioButton CXbuttonNo1s1;
        private System.Windows.Forms.RadioButton CXbuttonNo1s0;
        private System.Windows.Forms.GroupBox gruopCX8;
        private System.Windows.Forms.RadioButton CXbuttonNo8s1;
        private System.Windows.Forms.RadioButton CXbuttonNo8s0;
        private System.Windows.Forms.GroupBox gruopCX4;
        private System.Windows.Forms.RadioButton CXbuttonNo4s1;
        private System.Windows.Forms.RadioButton CXbuttonNo4s0;
        private System.Windows.Forms.GroupBox gruopCX9;
        private System.Windows.Forms.RadioButton CXbuttonNo9s1;
        private System.Windows.Forms.RadioButton CXbuttonNo9s0;
        private System.Windows.Forms.GroupBox gruopCX2;
        private System.Windows.Forms.RadioButton CXbuttonNo2s1;
        private System.Windows.Forms.RadioButton CXbuttonNo2s0;
        private System.Windows.Forms.GroupBox gruopCX12;
        private System.Windows.Forms.RadioButton CXbuttonNo12s1;
        private System.Windows.Forms.RadioButton CXbuttonNo12s0;
        private System.Windows.Forms.GroupBox gruopCX5;
        private System.Windows.Forms.RadioButton CXbuttonNo5s1;
        private System.Windows.Forms.RadioButton CXbuttonNo5s0;
        private System.Windows.Forms.GroupBox gruopCX10;
        private System.Windows.Forms.RadioButton CXbuttonNo10s1;
        private System.Windows.Forms.RadioButton CXbuttonNo10s0;
        private System.Windows.Forms.GroupBox gruopCX3;
        private System.Windows.Forms.RadioButton CXbuttonNo3s1;
        private System.Windows.Forms.RadioButton CXbuttonNo3s0;
        private System.Windows.Forms.GroupBox gruopCX13;
        private System.Windows.Forms.RadioButton CXbuttonNo13s1;
        private System.Windows.Forms.RadioButton CXbuttonNo13s0;
        private System.Windows.Forms.GroupBox gruopCX6;
        private System.Windows.Forms.RadioButton CXbuttonNo6s1;
        private System.Windows.Forms.RadioButton CXbuttonNo6s0;
        private System.Windows.Forms.GroupBox gruopCX11;
        private System.Windows.Forms.RadioButton CXbuttonNo11s1;
        private System.Windows.Forms.RadioButton CXbuttonNo11s0;
        private System.Windows.Forms.GroupBox gruopCX7;
        private System.Windows.Forms.RadioButton CXbuttonNo7s1;
        private System.Windows.Forms.RadioButton CXbuttonNo7s0;
        private System.Windows.Forms.GroupBox gruopCX14;
        private System.Windows.Forms.RadioButton CXbuttonNo14s1;
        private System.Windows.Forms.RadioButton CXbuttonNo14s0;
        private System.Windows.Forms.GroupBox gruopDX0;
        private System.Windows.Forms.RadioButton DXbuttonNo0s1;
        private System.Windows.Forms.RadioButton DXbuttonNo0s0;
        private System.Windows.Forms.GroupBox gruopDX1;
        private System.Windows.Forms.RadioButton DXbuttonNo1s1;
        private System.Windows.Forms.RadioButton DXbuttonNo1s0;
        private System.Windows.Forms.GroupBox gruopDX8;
        private System.Windows.Forms.RadioButton DXbuttonNo8s1;
        private System.Windows.Forms.RadioButton DXbuttonNo8s0;
        private System.Windows.Forms.GroupBox gruopDX4;
        private System.Windows.Forms.RadioButton DXbuttonNo4s1;
        private System.Windows.Forms.RadioButton DXbuttonNo4s0;
        private System.Windows.Forms.GroupBox gruopDX9;
        private System.Windows.Forms.RadioButton DXbuttonNo9s1;
        private System.Windows.Forms.RadioButton DXbuttonNo9s0;
        private System.Windows.Forms.GroupBox gruopDX2;
        private System.Windows.Forms.RadioButton DXbuttonNo2s1;
        private System.Windows.Forms.RadioButton DXbuttonNo2s0;
        private System.Windows.Forms.GroupBox gruopDX12;
        private System.Windows.Forms.RadioButton DXbuttonNo12s1;
        private System.Windows.Forms.RadioButton DXbuttonNo12s0;
        private System.Windows.Forms.GroupBox gruopDX5;
        private System.Windows.Forms.RadioButton DXbuttonNo5s1;
        private System.Windows.Forms.RadioButton DXbuttonNo5s0;
        private System.Windows.Forms.GroupBox gruopDX10;
        private System.Windows.Forms.RadioButton DXbuttonNo10s1;
        private System.Windows.Forms.RadioButton DXbuttonNo10s0;
        private System.Windows.Forms.GroupBox gruopDX3;
        private System.Windows.Forms.RadioButton DXbuttonNo3s1;
        private System.Windows.Forms.RadioButton DXbuttonNo3s0;
        private System.Windows.Forms.GroupBox gruopDX13;
        private System.Windows.Forms.RadioButton DXbuttonNo13s1;
        private System.Windows.Forms.RadioButton DXbuttonNo13s0;
        private System.Windows.Forms.GroupBox gruopDX6;
        private System.Windows.Forms.RadioButton DXbuttonNo6s1;
        private System.Windows.Forms.RadioButton DXbuttonNo6s0;
        private System.Windows.Forms.GroupBox gruopDX11;
        private System.Windows.Forms.RadioButton DXbuttonNo11s1;
        private System.Windows.Forms.RadioButton DXbuttonNo11s0;
        private System.Windows.Forms.GroupBox gruopDX7;
        private System.Windows.Forms.RadioButton DXbuttonNo7s1;
        private System.Windows.Forms.RadioButton DXbuttonNo7s0;
        private System.Windows.Forms.GroupBox gruopDX14;
        private System.Windows.Forms.RadioButton DXbuttonNo14s1;
        private System.Windows.Forms.RadioButton DXbuttonNo14s0;
        private System.Windows.Forms.GroupBox gruopDX15;
        private System.Windows.Forms.RadioButton DXbuttonNo15s1;
        private System.Windows.Forms.RadioButton DXbuttonNo15s0;
        private System.Windows.Forms.GroupBox gruopBX0;
        private System.Windows.Forms.RadioButton BXbuttonNo0s1;
        private System.Windows.Forms.RadioButton BXbuttonNo0s0;
        private System.Windows.Forms.GroupBox gruopBX1;
        private System.Windows.Forms.RadioButton BXbuttonNo1s1;
        private System.Windows.Forms.RadioButton BXbuttonNo1s0;
        private System.Windows.Forms.GroupBox gruopBX15;
        private System.Windows.Forms.RadioButton BXbuttonNo15s1;
        private System.Windows.Forms.RadioButton BXbuttonNo15s0;
        private System.Windows.Forms.GroupBox gruopBX8;
        private System.Windows.Forms.RadioButton BXbuttonNo8s1;
        private System.Windows.Forms.RadioButton BXbuttonNo8s0;
        private System.Windows.Forms.GroupBox gruopBX14;
        private System.Windows.Forms.RadioButton BXbuttonNo14s1;
        private System.Windows.Forms.RadioButton BXbuttonNo14s0;
        private System.Windows.Forms.GroupBox gruopBX4;
        private System.Windows.Forms.RadioButton BXbuttonNo4s1;
        private System.Windows.Forms.RadioButton BXbuttonNo4s0;
        private System.Windows.Forms.GroupBox gruopBX7;
        private System.Windows.Forms.RadioButton BXbuttonNo7s1;
        private System.Windows.Forms.RadioButton BXbuttonNo7s0;
        private System.Windows.Forms.GroupBox gruopBX9;
        private System.Windows.Forms.RadioButton BXbuttonNo9s1;
        private System.Windows.Forms.RadioButton BXbuttonNo9s0;
        private System.Windows.Forms.GroupBox gruopBX11;
        private System.Windows.Forms.RadioButton BXbuttonNo11s1;
        private System.Windows.Forms.RadioButton BXbuttonNo11s0;
        private System.Windows.Forms.GroupBox gruopBX2;
        private System.Windows.Forms.RadioButton BXbuttonNo2s1;
        private System.Windows.Forms.RadioButton BXbuttonNo2s0;
        private System.Windows.Forms.GroupBox gruopBX6;
        private System.Windows.Forms.RadioButton BXbuttonNo6s1;
        private System.Windows.Forms.RadioButton BXbuttonNo6s0;
        private System.Windows.Forms.GroupBox gruopBX12;
        private System.Windows.Forms.RadioButton BXbuttonNo12s1;
        private System.Windows.Forms.RadioButton BXbuttonNo12s0;
        private System.Windows.Forms.GroupBox gruopBX13;
        private System.Windows.Forms.RadioButton BXbuttonNo13s1;
        private System.Windows.Forms.RadioButton BXbuttonNo13s0;
        private System.Windows.Forms.GroupBox gruopBX5;
        private System.Windows.Forms.RadioButton BXbuttonNo5s1;
        private System.Windows.Forms.RadioButton BXbuttonNo5s0;
        private System.Windows.Forms.GroupBox gruopBX3;
        private System.Windows.Forms.RadioButton BXbuttonNo3s1;
        private System.Windows.Forms.RadioButton BXbuttonNo3s0;
        private System.Windows.Forms.GroupBox gruopBX10;
        private System.Windows.Forms.RadioButton BXbuttonNo10s1;
        private System.Windows.Forms.RadioButton BXbuttonNo10s0;
        private System.Windows.Forms.GroupBox gruopAX0;
        private System.Windows.Forms.RadioButton AXbuttonNo0s1;
        private System.Windows.Forms.RadioButton AXbuttonNo0s0;
        private System.Windows.Forms.GroupBox gruopAX8;
        private System.Windows.Forms.RadioButton AXbuttonNo8s1;
        private System.Windows.Forms.RadioButton AXbuttonNo8s0;
        private System.Windows.Forms.GroupBox gruopAX1;
        private System.Windows.Forms.RadioButton AXbuttonNo1s1;
        private System.Windows.Forms.RadioButton AXbuttonNo1s0;
        private System.Windows.Forms.GroupBox gruopAX15;
        private System.Windows.Forms.RadioButton AXbuttonNo15s1;
        private System.Windows.Forms.RadioButton AXbuttonNo15s0;
        private System.Windows.Forms.GroupBox gruopAX14;
        private System.Windows.Forms.RadioButton AXbuttonNo14s1;
        private System.Windows.Forms.RadioButton AXbuttonNo14s0;
        private System.Windows.Forms.GroupBox gruopAX4;
        private System.Windows.Forms.RadioButton AXbuttonNo4s1;
        private System.Windows.Forms.RadioButton AXbuttonNo4s0;
        private System.Windows.Forms.GroupBox gruopAX7;
        private System.Windows.Forms.RadioButton AXbuttonNo7s1;
        private System.Windows.Forms.RadioButton AXbuttonNo7s0;
        private System.Windows.Forms.GroupBox gruopAX9;
        private System.Windows.Forms.RadioButton AXbuttonNo9s1;
        private System.Windows.Forms.RadioButton AXbuttonNo9s0;
        private System.Windows.Forms.GroupBox gruopAX11;
        private System.Windows.Forms.RadioButton AXbuttonNo11s1;
        private System.Windows.Forms.RadioButton AXbuttonNo11s0;
        private System.Windows.Forms.GroupBox gruopAX2;
        private System.Windows.Forms.RadioButton AXbuttonNo2s1;
        private System.Windows.Forms.RadioButton AXbuttonNo2s0;
        private System.Windows.Forms.GroupBox gruopAX6;
        private System.Windows.Forms.RadioButton AXbuttonNo6s1;
        private System.Windows.Forms.RadioButton AXbuttonNo6s0;
        private System.Windows.Forms.GroupBox gruopAX12;
        private System.Windows.Forms.RadioButton AXbuttonNo12s1;
        private System.Windows.Forms.RadioButton AXbuttonNo12s0;
        private System.Windows.Forms.GroupBox gruopAX13;
        private System.Windows.Forms.RadioButton AXbuttonNo13s1;
        private System.Windows.Forms.RadioButton AXbuttonNo13s0;
        private System.Windows.Forms.GroupBox gruopAX5;
        private System.Windows.Forms.RadioButton AXbuttonNo5s1;
        private System.Windows.Forms.RadioButton AXbuttonNo5s0;
        private System.Windows.Forms.GroupBox gruopAX3;
        private System.Windows.Forms.RadioButton AXbuttonNo3s1;
        private System.Windows.Forms.RadioButton AXbuttonNo3s0;
        private System.Windows.Forms.GroupBox gruopAX10;
        private System.Windows.Forms.RadioButton AXbuttonNo10s1;
        private System.Windows.Forms.RadioButton AXbuttonNo10s0;
        private System.Windows.Forms.Label DHActive;
        private System.Windows.Forms.Label DLActive;
        private System.Windows.Forms.Label CHActive;
        private System.Windows.Forms.Label CLActive;
        private System.Windows.Forms.Label BLActive;
        private System.Windows.Forms.Label BHActive;
        private System.Windows.Forms.Label ALActive;
        private System.Windows.Forms.Label AHActive;
        private System.Windows.Forms.GroupBox groupBoxInstant;
        private System.Windows.Forms.GroupBox groupInstant0;
        private System.Windows.Forms.RadioButton InstantbuttonNo0s1;
        private System.Windows.Forms.RadioButton InstantbuttonNo0s0;
        private System.Windows.Forms.GroupBox groupInstant1;
        private System.Windows.Forms.RadioButton InstantbuttonNo1s1;
        private System.Windows.Forms.RadioButton InstantbuttonNo1s0;
        private System.Windows.Forms.GroupBox groupInstant8;
        private System.Windows.Forms.RadioButton InstantbuttonNo8s1;
        private System.Windows.Forms.RadioButton InstantbuttonNo8s0;
        private System.Windows.Forms.GroupBox groupInstant4;
        private System.Windows.Forms.RadioButton InstantbuttonNo4s1;
        private System.Windows.Forms.RadioButton InstantbuttonNo4s0;
        private System.Windows.Forms.GroupBox groupInstant9;
        private System.Windows.Forms.RadioButton InstantbuttonNo9s1;
        private System.Windows.Forms.RadioButton InstantbuttonNo9s0;
        private System.Windows.Forms.GroupBox groupInstant2;
        private System.Windows.Forms.RadioButton InstantbuttonNo2s1;
        private System.Windows.Forms.RadioButton InstantbuttonNo2s0;
        private System.Windows.Forms.GroupBox groupInstant12;
        private System.Windows.Forms.RadioButton InstantbuttonNo12s1;
        private System.Windows.Forms.RadioButton InstantbuttonNo12s0;
        private System.Windows.Forms.GroupBox groupInstant5;
        private System.Windows.Forms.RadioButton InstantbuttonNo5s1;
        private System.Windows.Forms.RadioButton InstantbuttonNo5s0;
        private System.Windows.Forms.GroupBox groupInstant10;
        private System.Windows.Forms.RadioButton InstantbuttonNo10s1;
        private System.Windows.Forms.RadioButton InstantbuttonNo10s0;
        private System.Windows.Forms.GroupBox groupInstant3;
        private System.Windows.Forms.RadioButton InstantbuttonNo3s1;
        private System.Windows.Forms.RadioButton InstantbuttonNo3s0;
        private System.Windows.Forms.GroupBox groupInstant13;
        private System.Windows.Forms.RadioButton InstantbuttonNo13s1;
        private System.Windows.Forms.RadioButton InstantbuttonNo13s0;
        private System.Windows.Forms.GroupBox groupInstant6;
        private System.Windows.Forms.RadioButton InstantbuttonNo6s1;
        private System.Windows.Forms.RadioButton InstantbuttonNo6s0;
        private System.Windows.Forms.GroupBox groupInstant11;
        private System.Windows.Forms.RadioButton InstantbuttonNo11s1;
        private System.Windows.Forms.RadioButton InstantbuttonNo11s0;
        private System.Windows.Forms.GroupBox groupInstant7;
        private System.Windows.Forms.RadioButton InstantbuttonNo7s1;
        private System.Windows.Forms.RadioButton InstantbuttonNo7s0;
        private System.Windows.Forms.GroupBox groupInstant14;
        private System.Windows.Forms.RadioButton InstantbuttonNo14s1;
        private System.Windows.Forms.RadioButton InstantbuttonNo14s0;
        private System.Windows.Forms.GroupBox groupInstant15;
        private System.Windows.Forms.RadioButton InstantbuttonNo15s1;
        private System.Windows.Forms.RadioButton InstantbuttonNo15s0;
        private System.Windows.Forms.Button buttonWriteDX;
        private System.Windows.Forms.Button buttonWriteCX;
        private System.Windows.Forms.Button buttonWriteBX;
        private System.Windows.Forms.Button buttonWriteAX;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelInL;
        private System.Windows.Forms.Label labelInH;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelDL;
        private System.Windows.Forms.Label labelDH;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelCL;
        private System.Windows.Forms.Label labelCH;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelBL;
        private System.Windows.Forms.Label labelBH;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelAL;
        private System.Windows.Forms.Label labelAH;
        private System.Windows.Forms.ComboBox operationBox;
        private System.Windows.Forms.ComboBox comboBoxOperand2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxOperand1;
        private System.Windows.Forms.Button buttonAddOrderToProgram;
        private System.Windows.Forms.Button buttonExeOrder;
        private System.Windows.Forms.ComboBox comboBoxMoveTo;
        private System.Windows.Forms.ListBox listProgram;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonProgram;
        private System.Windows.Forms.Button buttonProgramStep;
        private System.Windows.Forms.Button buttonProgramReset;
    }
}

