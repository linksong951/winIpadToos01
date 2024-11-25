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

        //是否静音
        private bool MuteOrNot = false;

        //最小化按钮状态
        private bool MinBtnState = false;


        //存储历史窗体宽高变量
        private int FromLastWidth = 0; 
        private int FromLastHeight = 0; 

        public Form1()
        {
            InitializeComponent();
            SetWindowRegion();
            // 添加鼠标事件处理程序
            this.MouseDown += new MouseEventHandler(Form1_MouseDown);
            this.MouseMove += new MouseEventHandler(Form1_MouseMove);
            this.MouseUp += new MouseEventHandler(Form1_MouseUp);

        }

        #region 设置拖动效果

        /// <summary>
        /// 鼠标按下
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
        /// 鼠标移动窗体跟随移动
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
        /// 鼠标松开
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

        #region 绘制圆角窗体

        /// <summary>
        /// 设置窗体的Region
        /// </summary>
        public void SetWindowRegion()
        {
            GraphicsPath FormPath;
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
            FormPath = GetRoundedRectPath(rect, 20);
            this.Region = new Region(FormPath);

        }
        /// <summary>
        /// 绘制圆角路径
        /// </summary>
        /// <param name="rect"></param>
        /// <param name="radius"></param>
        /// <returns></returns>
        private GraphicsPath GetRoundedRectPath(Rectangle rect, int radius)
        {
            int diameter = radius;
            Rectangle arcRect = new Rectangle(rect.Location, new Size(diameter, diameter));
            GraphicsPath path = new GraphicsPath();

            // 左上角
            path.AddArc(arcRect, 180, 90);

            // 右上角
            arcRect.X = rect.Right - diameter;
            path.AddArc(arcRect, 270, 90);

            // 右下角
            arcRect.Y = rect.Bottom - diameter;
            path.AddArc(arcRect, 0, 90);

            // 左下角
            arcRect.X = rect.Left;
            path.AddArc(arcRect, 90, 90);
            path.CloseFigure();//闭合曲线
            return path;
        }

        /// <summary>
        /// 窗体size发生改变时重新设置Region属性
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Resize(object sender, EventArgs e)
        {
            SetWindowRegion();
        }

        #endregion

        #region 按键功能区


        /// <summary>
        /// 开启有道翻译截屏 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WinKeyCtrl_Alt_D(object sender, EventArgs e)
        {
            BaseTools.KeyCom(BaseTools.vbKeyCTRL, BaseTools.vbKeyAlt, BaseTools.vbKeyD);
        }

        /// <summary>
        /// win默认截屏 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WinKeyShift_Win_S(object sender, EventArgs e)
        {
            BaseTools.KeyCom(BaseTools.vbKeyShift, BaseTools.vbKeyWin, BaseTools.vbKeyS);
        }


        /// <summary>
        /// 静音 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Win_Mute(object sender, EventArgs e)
        {

            //检查当前扬声器是否静音
            if (BaseTools.GetIsMuteState())
            {
                this.button3.Text = "静音";
            }
            else
            {
                this.button3.Text = "取消静音";
            }

            BaseTools.WinMuteReversal(this.Handle);

        }

        /// <summary>
        /// 关闭本工具
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WinKeyAlt_F4(object sender, EventArgs e)
        {
            BaseTools.KeyCom(BaseTools.vbKeyAlt, BaseTools.vbKeyF4);
        }

        /// <summary>
        /// 返回桌面 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WinKeyWin_D(object sender, EventArgs e)
        {
            BaseTools.KeyCom(BaseTools.vbKeyWin, BaseTools.vbKeyD);
        }

        /// <summary>
        /// win自带搜索
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WinKeyWIn_S(object sender, EventArgs e)
        {
            BaseTools.KeyCom(BaseTools.vbKeyWin, BaseTools.vbKeyS);
        }

        /// <summary>
        /// 最小化功能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MinimizedAction(object sender, EventArgs e)
        {
            //状态取反
            MinBtnState = !MinBtnState;
            if (MinBtnState)
            {

                //隐藏不需要的按钮
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
                button6.Visible = false;

                button7.Text = "恢复";

                //重新绘制窗口大小
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

                button7.Text = "最小化";

                //重新绘制窗口大小

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
            //检查当前扬声器是否静音
            if (BaseTools.GetIsMuteState())
            {
                this.button3.Text = "取消静音";
                MuteOrNot = true;
            }
        }

    }
}
