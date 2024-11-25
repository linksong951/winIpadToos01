using NAudio.CoreAudioApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{

    public class BaseTools
    {


        #region bVk参数 常量定义

        #region 常用功能键


        /// <summary>
        /// 鼠标左键
        /// </summary>
        public const byte vbKeyLButton = 0x1;

        /// <summary>
        /// 鼠标右键
        /// </summary>
        public const byte vbKeyRButton = 0x2;

        /// <summary>
        /// CANCEL 键
        /// </summary>
        public const byte vbKeyCancel = 0x3;

        /// <summary>
        /// 鼠标中键
        /// </summary>
        public const byte vbKeyMButton = 0x4;

        /// <summary>
        /// BACKSPACE 键
        /// </summary>
        public const byte vbKeyBack = 0x8;

        /// <summary>
        /// TAB 键
        /// </summary>
        public const byte vbKeyTab = 0x9;

        /// <summary>
        /// CLEAR 键
        /// </summary>
        public const byte vbKeyClear = 0xC;

        /// <summary>
        /// ENTER 键
        /// </summary>
        public const byte vbKeyReturn = 0xD;

        /// <summary>
        /// SHIFT 键
        /// </summary>
        public const byte vbKeyShift = 0x10;

        /// <summary>
        /// CTRL 键
        /// </summary>
        public const byte vbKeyCTRL = 0x11;

        /// <summary>
        /// Alt 键  (键码18)
        /// </summary>
        public const byte vbKeyAlt = 18;

        /// <summary>
        /// MENU 键
        /// </summary>
        public const byte vbKeyMenu = 0x12;

        /// <summary>
        /// PAUSE 键
        /// </summary>
        public const byte vbKeyPause = 0x13;

        /// <summary>
        /// CAPS LOCK 键
        /// </summary>
        public const byte vbKeyCapital = 0x14;

        /// <summary>
        /// ESC 键
        /// </summary>
        public const byte vbKeyEscape = 0x1B;

        /// <summary>
        /// SPACEBAR 键
        /// </summary>
        public const byte vbKeySpace = 0x20;

        /// <summary>
        /// PAGE UP 键
        /// </summary>
        public const byte vbKeyPageUp = 0x21;

        /// <summary>
        /// End 键
        /// </summary>
        public const byte vbKeyEnd = 0x23;

        /// <summary>
        /// HOME 键
        /// </summary>
        public const byte vbKeyHome = 0x24;

        /// <summary>
        /// LEFT ARROW 键
        /// </summary>
        public const byte vbKeyLeft = 0x25;

        /// <summary>
        /// UP ARROW 键
        /// </summary>
        public const byte vbKeyUp = 0x26;

        /// <summary>
        /// RIGHT ARROW 键
        /// </summary>
        public const byte vbKeyRight = 0x27;

        /// <summary>
        /// DOWN ARROW 键
        /// </summary>
        public const byte vbKeyDown = 0x28;

        /// <summary>
        /// Select 键
        /// </summary>
        public const byte vbKeySelect = 0x29;

        /// <summary>
        /// PRINT SCREEN 键
        /// </summary>
        public const byte vbKeyPrint = 0x2A;

        /// <summary>
        /// EXECUTE 键
        /// </summary>
        public const byte vbKeyExecute = 0x2B;

        /// <summary>
        /// SNAPSHOT 键
        /// </summary>
        public const byte vbKeySnapshot = 0x2C;

        /// <summary>
        /// Delete 键
        /// </summary>
        public const byte vbKeyDelete = 0x2E;

        /// <summary>
        /// HELP 键
        /// </summary>
        public const byte vbKeyHelp = 0x2F;

        /// <summary>
        /// NUM LOCK 键
        /// </summary>
        public const byte vbKeyNumlock = 0x90;

        /// <summary>
        /// win键
        /// </summary>
        public const byte vbKeyWin = 0x5B;

        #endregion

        #region 常用键 字母键A到Z


        /// <summary>
        /// 字母A
        /// </summary>
        public const byte vbKeyA = 65;

        /// <summary>
        /// 字母B
        /// </summary>
        public const byte vbKeyB = 66;

        /// <summary>
        /// 字母C
        /// </summary>
        public const byte vbKeyC = 67;

        /// <summary>
        /// 字母D
        /// </summary>
        public const byte vbKeyD = 68;

        /// <summary>
        /// 字母E
        /// </summary>
        public const byte vbKeyE = 69;

        /// <summary>
        /// 字母F
        /// </summary>
        public const byte vbKeyF = 70;

        /// <summary>
        /// 字母G
        /// </summary>
        public const byte vbKeyG = 71;

        /// <summary>
        /// 字母H
        /// </summary>
        public const byte vbKeyH = 72;

        /// <summary>
        /// 字母I
        /// </summary>
        public const byte vbKeyI = 73;

        /// <summary>
        /// 字母J
        /// </summary>
        public const byte vbKeyJ = 74;

        /// <summary>
        /// 字母K
        /// </summary>
        public const byte vbKeyK = 75;

        /// <summary>
        /// 字母L
        /// </summary>
        public const byte vbKeyL = 76;

        /// <summary>
        /// 字母M
        /// </summary>
        public const byte vbKeyM = 77;

        /// <summary>
        /// 字母N
        /// </summary>
        public const byte vbKeyN = 78;

        /// <summary>
        /// 字母O
        /// </summary>
        public const byte vbKeyO = 79;

        /// <summary>
        /// 字母P
        /// </summary>
        public const byte vbKeyP = 80;

        /// <summary>
        /// 字母Q
        /// </summary>
        public const byte vbKeyQ = 81;

        /// <summary>
        /// 字母R
        /// </summary>
        public const byte vbKeyR = 82;

        /// <summary>
        /// 字母S
        /// </summary>
        public const byte vbKeyS = 83;

        /// <summary>
        /// 字母T
        /// </summary>
        public const byte vbKeyT = 84;

        /// <summary>
        /// 字母U
        /// </summary>
        public const byte vbKeyU = 85;

        /// <summary>
        /// 字母V
        /// </summary>
        public const byte vbKeyV = 86;

        /// <summary>
        /// 字母W
        /// </summary>
        public const byte vbKeyW = 87;

        /// <summary>
        /// 字母X
        /// </summary>
        public const byte vbKeyX = 88;

        /// <summary>
        /// 字母Y
        /// </summary>
        public const byte vbKeyY = 89;

        /// <summary>
        /// 字母Z
        /// </summary>
        public const byte vbKeyZ = 90;

        #endregion

        #region 数字键盘0到9

        /// <summary>
        /// 0键
        /// </summary>
        public const byte vbKey0 = 48;

        /// <summary>
        /// 1 键
        /// </summary>
        public const byte vbKey1 = 49;

        /// <summary>
        /// 2 键
        /// </summary>
        public const byte vbKey2 = 50;

        /// <summary>
        /// 3 键
        /// </summary>
        public const byte vbKey3 = 51;

        /// <summary>
        /// 4 键
        /// </summary>
        public const byte vbKey4 = 52;

        /// <summary>
        /// 5 键
        /// </summary>
        public const byte vbKey5 = 53;

        /// <summary>
        /// 6 键
        /// </summary>
        public const byte vbKey6 = 54;

        /// <summary>
        /// 7 键
        /// </summary>
        public const byte vbKey7 = 55;

        /// <summary>
        /// 8 键
        /// </summary>
        public const byte vbKey8 = 56;

        /// <summary>
        /// 9 键
        /// </summary>
        public const byte vbKey9 = 57;

        /// <summary>
        /// 0 键
        /// </summary>
        public const byte vbKeyNumpad0 = 0x60;

        /// <summary>
        /// 1 键
        /// </summary>
        public const byte vbKeyNumpad1 = 0x61;

        /// <summary>
        /// 2 键
        /// </summary>
        public const byte vbKeyNumpad2 = 0x62;

        /// <summary>
        /// 3 键
        /// </summary>
        public const byte vbKeyNumpad3 = 0x63;

        /// <summary>
        /// 4 键
        /// </summary>
        public const byte vbKeyNumpad4 = 0x64;

        /// <summary>
        /// 5 键
        /// </summary>
        public const byte vbKeyNumpad5 = 0x65;

        /// <summary>
        /// 6 键
        /// </summary>
        public const byte vbKeyNumpad6 = 0x66;

        /// <summary>
        /// 7 键
        /// </summary>
        public const byte vbKeyNumpad7 = 0x67;

        /// <summary>
        /// 8 键
        /// </summary>
        public const byte vbKeyNumpad8 = 0x68;

        /// <summary>
        /// 9 键
        /// </summary>
        public const byte vbKeyNumpad9 = 0x69;

        /// <summary>
        /// MULTIPLICATIONSIGN(*)键
        /// </summary>
        public const byte vbKeyMultiply = 0x6A;

        /// <summary>
        /// PLUS SIGN(+) 键
        /// </summary>
        public const byte vbKeyAdd = 0x6B;

        /// <summary>
        /// ENTER 键
        /// </summary>
        public const byte vbKeySeparator = 0x6C;

        /// <summary>
        /// MINUS SIGN(-) 键
        /// </summary>
        public const byte vbKeySubtract = 0x6D;

        /// <summary>
        /// DECIMAL POINT(.) 键
        /// </summary>
        public const byte vbKeyDecimal = 0x6E;

        /// <summary>
        /// DIVISION SIGN(/) 键
        /// </summary>
        public const byte vbKeyDivide = 0x6F;

        #endregion

        #region F1到F12按键

        /// <summary>
        /// F1 键
        /// </summary>
        public const byte vbKeyF1 = 0x70;

        /// <summary>
        /// F2 键
        /// </summary>
        public const byte vbKeyF2 = 0x71;

        /// <summary>
        /// F3 键
        /// </summary>
        public const byte vbKeyF3 = 0x72;

        /// <summary>
        /// F4 键
        /// </summary>
        public const byte vbKeyF4 = 0x73;

        /// <summary>
        /// F5 键
        /// </summary>
        public const byte vbKeyF5 = 0x74;

        /// <summary>
        /// F6 键
        /// </summary>
        public const byte vbKeyF6 = 0x75;

        /// <summary>
        /// F7 键
        /// </summary>
        public const byte vbKeyF7 = 0x76;

        /// <summary>
        /// F8 键
        /// </summary>
        public const byte vbKeyF8 = 0x77;

        /// <summary>
        /// F9 键
        /// </summary>
        public const byte vbKeyF9 = 0x78;

        /// <summary>
        /// F10 键
        /// </summary>
        public const byte vbKeyF10 = 0x79;

        /// <summary>
        /// F11 键
        /// </summary>
        public const byte vbKeyF11 = 0x7A;

        /// <summary>
        /// F12 键
        /// </summary>
        public const byte vbKeyF12 = 0x7B;

        #endregion


        #endregion

        #region 引用win32api方法

        /// <summary>
        /// 导入模拟键盘的方法
        /// </summary>
        /// <param name="bVk" >按键的虚拟键值</param>
        /// <param name= "bScan" >扫描码，一般不用设置，用0代替就行</param>
        /// <param name= "dwFlags" >选项标志：0：表示按下，2：表示松开</param>
        /// <param name= "dwExtraInfo">一般设置为0</param>
        [DllImport("user32.dll")]
        public static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);


        private const int APPCOMMAND_VOLUME_MUTE = 0x80000;
        private const int APPCOMMAND_VOLUME_UP = 0xA0000;
        private const int APPCOMMAND_VOLUME_DOWN = 0x90000;
        private const int WM_APPCOMMAND = 0x319;
        [DllImport("user32.dll")]
        public static extern IntPtr SendMessageW(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

        #endregion


        #region 组合键封装


        public static void KeyCom(byte key1)
        {
            //模拟按下
            keybd_event(key1, 0, 0, 0);

            //模拟松开
            keybd_event(key1, 0, 2, 0);
        }

        public static void KeyCom(byte key1, byte key2)
        {
            //模拟按下
            keybd_event(key1, 0, 0, 0);
            keybd_event(key2, 0, 0, 0);

            //模拟松开
            keybd_event(key1, 0, 2, 0);
            keybd_event(key2, 0, 2, 0);
        }

        public static void KeyCom(byte key1, byte key2, byte key3)
        {
            //模拟按下
            keybd_event(key1, 0, 0, 0);
            keybd_event(key2, 0, 0, 0);
            keybd_event(key3, 0, 0, 0);

            //模拟松开
            keybd_event(key1, 0, 2, 0);
            keybd_event(key2, 0, 2, 0);
            keybd_event(key3, 0, 2, 0);
        }

        public static void KeyCom(byte key1, byte key2, byte key3, byte key4)
        {
            //模拟按下
            keybd_event(key1, 0, 0, 0);
            keybd_event(key2, 0, 0, 0);
            keybd_event(key3, 0, 0, 0);
            keybd_event(key4, 0, 0, 0);

            //模拟松开
            keybd_event(key1, 0, 2, 0);
            keybd_event(key2, 0, 2, 0);
            keybd_event(key3, 0, 2, 0);
            keybd_event(key4, 0, 2, 0);
        }

        #endregion





        #region 声音相关

        /// <summary>
        /// 改变静音状态 取反
        /// </summary>
        public static void WinMuteReversal(nint handle)
        {
            SendMessageW(handle, WM_APPCOMMAND, handle, (IntPtr)APPCOMMAND_VOLUME_MUTE);
        }

        /// <summary>
        /// 获取当前音量
        /// </summary>
        /// <returns></returns>
        public static int GetCurrentSpeakerVolume()
        {
            int volume = 0;
            var enumerator = new MMDeviceEnumerator();

            //获取音频输出设备
            IEnumerable<MMDevice> speakDevices = enumerator.EnumerateAudioEndPoints(DataFlow.Render, DeviceState.Active).ToArray();
            if (speakDevices.Count() > 0)
            {
                MMDevice mMDevice = speakDevices.ToList()[0];
                volume = Convert.ToInt16(mMDevice.AudioEndpointVolume.MasterVolumeLevelScalar * 100);
            }
            return volume;
        }


        /// <summary>
        /// 是否静音
        /// </summary>
        /// <returns></returns>
        public static bool GetIsMuteState()
        {
            var enumerator = new MMDeviceEnumerator();
            IEnumerable<MMDevice> speakDevices = enumerator.EnumerateAudioEndPoints(DataFlow.Render, DeviceState.Active).ToArray();
            MMDevice mMDevice = speakDevices.ToList()[0];
            return mMDevice.AudioEndpointVolume.Mute;
        }

        #endregion

    }
}
