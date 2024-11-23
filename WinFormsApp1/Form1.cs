using NAudio.CoreAudioApi;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {


        private bool isDragging = false;
        private Point lastCursor;
        private Point lastForm;

        //�Ƿ���
        private bool MuteOrNot = false;

        //��С����ť״̬
        private bool MinBtnState = false;


        //�洢��ʷ�����߱���
        private int FromLastWidth = 0;
        private int FromLastHeight = 0;

        public Form1()
        {
            InitializeComponent();
            SetWindowRegion();
            // �������¼��������
            this.MouseDown += new MouseEventHandler(Form1_MouseDown);
            this.MouseMove += new MouseEventHandler(Form1_MouseMove);
            this.MouseUp += new MouseEventHandler(Form1_MouseUp);

        }

        #region �����϶�Ч��

        /// <summary>
        /// ��갴��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastCursor = Cursor.Position;
                lastForm = this.Location;
            }
        }


        /// <summary>
        /// ����ƶ���������ƶ�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                int xDiff = Cursor.Position.X - lastCursor.X;
                int yDiff = Cursor.Position.Y - lastCursor.Y;

                this.Location = new Point(lastForm.X + xDiff, lastForm.Y + yDiff);
            }
        }

        /// <summary>
        /// ����ɿ�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }

        #endregion

        #region bVk���� ��������

        public const byte vbKeyLButton = 0x1;    // ������
        public const byte vbKeyRButton = 0x2;    // ����Ҽ�
        public const byte vbKeyCancel = 0x3;     // CANCEL ��
        public const byte vbKeyMButton = 0x4;    // ����м�
        public const byte vbKeyBack = 0x8;       // BACKSPACE ��
        public const byte vbKeyTab = 0x9;        // TAB ��
        public const byte vbKeyClear = 0xC;      // CLEAR ��
        public const byte vbKeyReturn = 0xD;     // ENTER ��
        public const byte vbKeyShift = 0x10;     // SHIFT ��
        public const byte vbKeyCTRL = 0x11;   // CTRL ��
        public const byte vbKeyAlt = 18;         // Alt ��  (����18)
        public const byte vbKeyMenu = 0x12;      // MENU ��
        public const byte vbKeyPause = 0x13;     // PAUSE ��
        public const byte vbKeyCapital = 0x14;   // CAPS LOCK ��
        public const byte vbKeyEscape = 0x1B;    // ESC ��
        public const byte vbKeySpace = 0x20;     // SPACEBAR ��
        public const byte vbKeyPageUp = 0x21;    // PAGE UP ��
        public const byte vbKeyEnd = 0x23;       // End ��
        public const byte vbKeyHome = 0x24;      // HOME ��
        public const byte vbKeyLeft = 0x25;      // LEFT ARROW ��
        public const byte vbKeyUp = 0x26;        // UP ARROW ��
        public const byte vbKeyRight = 0x27;     // RIGHT ARROW ��
        public const byte vbKeyDown = 0x28;      // DOWN ARROW ��
        public const byte vbKeySelect = 0x29;    // Select ��
        public const byte vbKeyPrint = 0x2A;     // PRINT SCREEN ��
        public const byte vbKeyExecute = 0x2B;   // EXECUTE ��
        public const byte vbKeySnapshot = 0x2C;  // SNAPSHOT ��
        public const byte vbKeyDelete = 0x2E;    // Delete ��
        public const byte vbKeyHelp = 0x2F;      // HELP ��
        public const byte vbKeyNumlock = 0x90;   // NUM LOCK ��
        public const byte vbKeyWin = 0x5B;       // win��



        //���ü� ��ĸ��A��Z
        public const byte vbKeyA = 65;
        public const byte vbKeyB = 66;
        public const byte vbKeyC = 67;
        public const byte vbKeyD = 68;
        public const byte vbKeyE = 69;
        public const byte vbKeyF = 70;
        public const byte vbKeyG = 71;
        public const byte vbKeyH = 72;
        public const byte vbKeyI = 73;
        public const byte vbKeyJ = 74;
        public const byte vbKeyK = 75;
        public const byte vbKeyL = 76;
        public const byte vbKeyM = 77;
        public const byte vbKeyN = 78;
        public const byte vbKeyO = 79;
        public const byte vbKeyP = 80;
        public const byte vbKeyQ = 81;
        public const byte vbKeyR = 82;
        public const byte vbKeyS = 83;
        public const byte vbKeyT = 84;
        public const byte vbKeyU = 85;
        public const byte vbKeyV = 86;
        public const byte vbKeyW = 87;
        public const byte vbKeyX = 88;
        public const byte vbKeyY = 89;
        public const byte vbKeyZ = 90;

        //���ּ���0��9
        public const byte vbKey0 = 48;    // 0 ��
        public const byte vbKey1 = 49;    // 1 ��
        public const byte vbKey2 = 50;    // 2 ��
        public const byte vbKey3 = 51;    // 3 ��
        public const byte vbKey4 = 52;    // 4 ��
        public const byte vbKey5 = 53;    // 5 ��
        public const byte vbKey6 = 54;    // 6 ��
        public const byte vbKey7 = 55;    // 7 ��
        public const byte vbKey8 = 56;    // 8 ��
        public const byte vbKey9 = 57;    // 9 ��


        public const byte vbKeyNumpad0 = 0x60;    //0 ��
        public const byte vbKeyNumpad1 = 0x61;    //1 ��
        public const byte vbKeyNumpad2 = 0x62;    //2 ��
        public const byte vbKeyNumpad3 = 0x63;    //3 ��
        public const byte vbKeyNumpad4 = 0x64;    //4 ��
        public const byte vbKeyNumpad5 = 0x65;    //5 ��
        public const byte vbKeyNumpad6 = 0x66;    //6 ��
        public const byte vbKeyNumpad7 = 0x67;    //7 ��
        public const byte vbKeyNumpad8 = 0x68;    //8 ��
        public const byte vbKeyNumpad9 = 0x69;    //9 ��
        public const byte vbKeyMultiply = 0x6A;   // MULTIPLICATIONSIGN(*)��
        public const byte vbKeyAdd = 0x6B;        // PLUS SIGN(+) ��
        public const byte vbKeySeparator = 0x6C;  // ENTER ��
        public const byte vbKeySubtract = 0x6D;   // MINUS SIGN(-) ��
        public const byte vbKeyDecimal = 0x6E;    // DECIMAL POINT(.) ��
        public const byte vbKeyDivide = 0x6F;     // DIVISION SIGN(/) ��


        //F1��F12����
        public const byte vbKeyF1 = 0x70;   //F1 ��
        public const byte vbKeyF2 = 0x71;   //F2 ��
        public const byte vbKeyF3 = 0x72;   //F3 ��
        public const byte vbKeyF4 = 0x73;   //F4 ��
        public const byte vbKeyF5 = 0x74;   //F5 ��
        public const byte vbKeyF6 = 0x75;   //F6 ��
        public const byte vbKeyF7 = 0x76;   //F7 ��
        public const byte vbKeyF8 = 0x77;   //F8 ��
        public const byte vbKeyF9 = 0x78;   //F9 ��
        public const byte vbKeyF10 = 0x79;  //F10 ��
        public const byte vbKeyF11 = 0x7A;  //F11 ��
        public const byte vbKeyF12 = 0x7B;  //F12 ��

        #endregion

        #region ����win32api����

        /// <summary>
        /// ����ģ����̵ķ���
        /// </summary>
        /// <param name="bVk" >�����������ֵ</param>
        /// <param name= "bScan" >ɨ���룬һ�㲻�����ã���0�������</param>
        /// <param name= "dwFlags" >ѡ���־��0����ʾ���£�2����ʾ�ɿ�</param>
        /// <param name= "dwExtraInfo">һ������Ϊ0</param>
        [DllImport("user32.dll")]
        public static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);


        private const int APPCOMMAND_VOLUME_MUTE = 0x80000;
        private const int APPCOMMAND_VOLUME_UP = 0xA0000;
        private const int APPCOMMAND_VOLUME_DOWN = 0x90000;
        private const int WM_APPCOMMAND = 0x319;
        [DllImport("user32.dll")]
        public static extern IntPtr SendMessageW(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

        #endregion

        #region �������

        /// <summary>
        /// ��ȡ��ǰ����
        /// </summary>
        /// <returns></returns>
        private int GetCurrentSpeakerVolume()
        {
            int volume = 0;
            var enumerator = new MMDeviceEnumerator();

            //��ȡ��Ƶ����豸
            IEnumerable<MMDevice> speakDevices = enumerator.EnumerateAudioEndPoints(DataFlow.Render, DeviceState.Active).ToArray();
            if (speakDevices.Count() > 0)
            {
                MMDevice mMDevice = speakDevices.ToList()[0];
                volume = Convert.ToInt16(mMDevice.AudioEndpointVolume.MasterVolumeLevelScalar * 100);
            }
            return volume;
        }


        /// <summary>
        /// �Ƿ���
        /// </summary>
        /// <returns></returns>
        private bool GetIsMuteState()
        {
            var enumerator = new MMDeviceEnumerator();
            IEnumerable<MMDevice> speakDevices = enumerator.EnumerateAudioEndPoints(DataFlow.Render, DeviceState.Active).ToArray();
            MMDevice mMDevice = speakDevices.ToList()[0];
            return mMDevice.AudioEndpointVolume.Mute;
        }

        #endregion

        #region ���ÿ���������


        #endregion

        #region ����Բ�Ǵ���

        /// <summary>
        /// ���ô����Region
        /// </summary>
        public void SetWindowRegion()
        {
            GraphicsPath FormPath;
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
            FormPath = GetRoundedRectPath(rect, 20);
            this.Region = new Region(FormPath);

        }
        /// <summary>
        /// ����Բ��·��
        /// </summary>
        /// <param name="rect"></param>
        /// <param name="radius"></param>
        /// <returns></returns>
        private GraphicsPath GetRoundedRectPath(Rectangle rect, int radius)
        {
            int diameter = radius;
            Rectangle arcRect = new Rectangle(rect.Location, new Size(diameter, diameter));
            GraphicsPath path = new GraphicsPath();

            // ���Ͻ�
            path.AddArc(arcRect, 180, 90);

            // ���Ͻ�
            arcRect.X = rect.Right - diameter;
            path.AddArc(arcRect, 270, 90);

            // ���½�
            arcRect.Y = rect.Bottom - diameter;
            path.AddArc(arcRect, 0, 90);

            // ���½�
            arcRect.X = rect.Left;
            path.AddArc(arcRect, 90, 90);
            path.CloseFigure();//�պ�����
            return path;
        }

        /// <summary>
        /// ����size�����ı�ʱ��������Region����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Resize(object sender, EventArgs e)
        {
            SetWindowRegion();
        }

        #endregion

        #region ����������


        /// <summary>
        /// �����е�������� 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WinKeyCtrl_Alt_D(object sender, EventArgs e)
        {
            //ģ�ⰴ��
            keybd_event(vbKeyCTRL, 0, 0, 0);
            keybd_event(vbKeyAlt, 0, 0, 0);
            keybd_event(vbKeyD, 0, 0, 0);

            //ģ���ɿ�
            keybd_event(vbKeyCTRL, 0, 2, 0);
            keybd_event(vbKeyAlt, 0, 2, 0);
            keybd_event(vbKeyD, 0, 2, 0);

        }

        /// <summary>
        /// winĬ�Ͻ��� 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WinKeyShift_Win_S(object sender, EventArgs e)
        {
            //ģ�ⰴ��
            keybd_event(vbKeyShift, 0, 0, 0);
            keybd_event(vbKeyWin, 0, 0, 0);
            keybd_event(vbKeyS, 0, 0, 0);

            //ģ���ɿ�
            keybd_event(vbKeyShift, 0, 2, 0);
            keybd_event(vbKeyWin, 0, 2, 0);
            keybd_event(vbKeyS, 0, 2, 0);

        }


        /// <summary>
        /// ���� 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Win_Mute(object sender, EventArgs e)
        {

            //��鵱ǰ�������Ƿ���
            if (GetIsMuteState())
            {
                this.button3.Text = "����";
            }
            else
            {
                this.button3.Text = "ȡ������";
            }

            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle, (IntPtr)APPCOMMAND_VOLUME_MUTE);

        }

        /// <summary>
        /// �رձ�����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WinKeyAlt_F4(object sender, EventArgs e)
        {
            //ģ�ⰴ��
            keybd_event(vbKeyAlt, 0, 0, 0);
            keybd_event(vbKeyF4, 0, 0, 0);

            //ģ���ɿ�
            keybd_event(vbKeyAlt, 0, 2, 0);
            keybd_event(vbKeyF4, 0, 2, 0);

        }

        /// <summary>
        /// �������� 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WinKeyWin_D(object sender, EventArgs e)
        {
            //ģ�ⰴ��
            keybd_event(vbKeyWin, 0, 0, 0);
            keybd_event(vbKeyD, 0, 0, 0);

            //ģ���ɿ�
            keybd_event(vbKeyWin, 0, 2, 0);
            keybd_event(vbKeyD, 0, 2, 0);

        }

        /// <summary>
        /// win�Դ�����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WinKeyWIn_S(object sender, EventArgs e)
        {
            //ģ�ⰴ��
            keybd_event(vbKeyWin, 0, 0, 0);
            keybd_event(vbKeyS, 0, 0, 0);

            //ģ���ɿ�
            keybd_event(vbKeyWin, 0, 2, 0);
            keybd_event(vbKeyS, 0, 2, 0);
        }

        /// <summary>
        /// ��С������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MinimizedAction(object sender, EventArgs e)
        {
            //״̬ȡ��
            MinBtnState = !MinBtnState;
            if (MinBtnState)
            {

                //���ز���Ҫ�İ�ť
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
                button6.Visible = false;

                button7.Text = "�ָ�";

                //���»��ƴ��ڴ�С
                FromLastWidth = this.Width;
                FromLastHeight = this.Height;


                this.button7.Width = this.button7.Width / 2;
                this.button7.Height = this.button7.Height / 2;

                this.Width = this.button7.Width + 23;
                this.Height = this.button7.Height + 50;


                this.button7.Location = new Point(12, 12);

            }
            else
            {
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                button6.Visible = true;

                button7.Text = "��С��";

                //���»��ƴ��ڴ�С

                this.Width = FromLastWidth;
                this.Height = FromLastHeight;



                this.button7.Width = this.button7.Width * 2;
                this.button7.Height = this.button7.Height * 2;


                this.button7.Location = new Point(12, 404);
                //this.button7.Location = new Point(15, 490);

            }





        }


        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            //��鵱ǰ�������Ƿ���
            if (GetIsMuteState())
            {
                this.button3.Text = "ȡ������";
                MuteOrNot = true;
            }
        }

    }
}
