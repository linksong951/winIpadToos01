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
            BaseTools.KeyCom(BaseTools.vbKeyCTRL, BaseTools.vbKeyAlt, BaseTools.vbKeyD);
        }

        /// <summary>
        /// winĬ�Ͻ��� 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WinKeyShift_Win_S(object sender, EventArgs e)
        {
            BaseTools.KeyCom(BaseTools.vbKeyShift, BaseTools.vbKeyWin, BaseTools.vbKeyS);
        }


        /// <summary>
        /// ���� 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Win_Mute(object sender, EventArgs e)
        {

            //��鵱ǰ�������Ƿ���
            if (BaseTools.GetIsMuteState())
            {
                this.button3.Text = "����";
            }
            else
            {
                this.button3.Text = "ȡ������";
            }

            BaseTools.WinMuteReversal(this.Handle);

        }

        /// <summary>
        /// �رձ�����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WinKeyAlt_F4(object sender, EventArgs e)
        {
            BaseTools.KeyCom(BaseTools.vbKeyAlt, BaseTools.vbKeyF4);
        }

        /// <summary>
        /// �������� 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WinKeyWin_D(object sender, EventArgs e)
        {
            BaseTools.KeyCom(BaseTools.vbKeyWin, BaseTools.vbKeyD);
        }

        /// <summary>
        /// win�Դ�����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WinKeyWIn_S(object sender, EventArgs e)
        {
            BaseTools.KeyCom(BaseTools.vbKeyWin, BaseTools.vbKeyS);
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
            if (BaseTools.GetIsMuteState())
            {
                this.button3.Text = "ȡ������";
                MuteOrNot = true;
            }
        }

    }
}
