using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using ScreenShot;

namespace Lab_5_C
{
    public partial class Form1 : Form
    {

        private System.Windows.Forms.Button btnABORTRETRYIGNORE;
        private System.Windows.Forms.Button btnYESNOCANCEL;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnYESNO;

        private System.Windows.Forms.Button btnDo;
        private System.Windows.Forms.Button btnRe;
        private System.Windows.Forms.Button btnMi;
        private System.Windows.Forms.Button btnFa;
        private System.Windows.Forms.Button btnSol;
        private System.Windows.Forms.Button btnLya;
        private System.Windows.Forms.Button btnC;

        private System.Windows.Forms.Button btnAW_BLEND;
        private System.Windows.Forms.Button btnHOR_AW_SLIDE;
        private System.Windows.Forms.Button btnCenter_AW_SLIDE;

        private System.Windows.Forms.Button btnTurnOff;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUserOut;

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;

        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem mnuFile;
        private System.Windows.Forms.MenuItem mnuOpen;
        //private AcroPDFLib.AcroPDF axAcroPDF1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;

        public Form1()
        {
            InitializeComponent();
        }

        [STAThread]
        static void Main()
        {
            Application.Run(new Form1());
        }

        private void btnGetUserName_Click(object sender, EventArgs e)
        {
            StringBuilder builder = new StringBuilder(100);
            uint size = 100;
            WinAPIClass.GetUserNameEx((int)WinAPIClass.NameFormat.NameSamCompatible, builder, ref size);
            lblGetUserName.Text = String.Format("Имя пользователя: {0}", builder.ToString());
        }

        /////////////////////////// Задание 2 /////////////////////////// 
        ///Диалоговые окна. Библиотека user32.dll

        private void btnABORTRETRYIGNORE_Click(object sender, System.EventArgs e)
        {
            //Текст сообщения
            string text = "Hello World";
            //Заголовок окна
            string title = "From WinApi";
            // Тип данных IntPtr - указатель на объект. 
            WinAPIClass2.MessageBox(IntPtr.Zero, text, title, (uint)(WinAPIClass2.MessageBoxType.MB_ABORTRETRYIGNORE | WinAPIClass2.MessageBoxType.MB_ICONQUESTION));


        }

        private void btnYESNOCANCEL_Click(object sender, System.EventArgs e)
        {
            string text = "Hello World";
            string title = "From WinApi";
            WinAPIClass2.MessageBox(IntPtr.Zero, text, title, (uint)(WinAPIClass2.MessageBoxType.MB_YESNOCANCEL | WinAPIClass2.MessageBoxType.MB_ICONINFORMATION));
        }

        private void btnOK_Click(object sender, System.EventArgs e)
        {
            string text = "Hello World";
            string title = "From WinApi";
            WinAPIClass2.MessageBox(IntPtr.Zero, text, title, (uint)(WinAPIClass2.MessageBoxType.MB_OK | WinAPIClass2.MessageBoxType.MB_ICONSTOP));


        }

        private void btnYESNO_Click(object sender, System.EventArgs e)
        {
            string text = "Hello World";
            string title = "From WinApi";
            WinAPIClass2.MessageBox(IntPtr.Zero, text, title, (uint)(WinAPIClass2.MessageBoxType.MB_YESNO | WinAPIClass2.MessageBoxType.MB_ICONEXCLAMATION));


        }


        /////////////////////////// Задание 3 /////////////////////////// 
        ///Динамик компьютера. Библиотека Kernel32.dll

        private void btnDo_Click(object sender, System.EventArgs e)
        {
            //В скобках - первый параметр частота, второй продолжительность сигнала
            WinAPIClass3.Beep(1000, 100);
        }

        private void btnRe_Click(object sender, System.EventArgs e)
        {
            WinAPIClass3.Beep(3000, 100);
        }

        private void btnMi_Click(object sender, System.EventArgs e)
        {
            WinAPIClass3.Beep(5000, 100);
        }

        private void btnFa_Click(object sender, System.EventArgs e)
        {
            WinAPIClass3.Beep(7000, 100);
        }

        private void btnSol_Click(object sender, System.EventArgs e)
        {
            WinAPIClass3.Beep(9000, 100);
        }

        private void btnLya_Click(object sender, System.EventArgs e)
        {
            WinAPIClass3.Beep(11000, 100);
        }

        private void btnC_Click(object sender, System.EventArgs e)
        {
            WinAPIClass3.Beep(13000, 100);
        }

        /////////////////////////// Задание 4 /////////////////////////// 
        ///Проявление окна
        private void btnAW_BLEND_Click(object sender, System.EventArgs e)
        {

            // Скрываем окно
            this.Hide();
            // Запускаем анимацию. Второй параметр в скобках - время анимации в миллисекундах.
            WinAPIClass4.AnimateWindow(this, 3000, WinAPIClass4.AnimateWindowFlags.AW_ACTIVATE | WinAPIClass4.AnimateWindowFlags.AW_BLEND);
            // Отображаем кнопки после анимации
            this.btnAW_BLEND.Invalidate();
            this.btnHOR_AW_SLIDE.Invalidate();
            this.btnCenter_AW_SLIDE.Invalidate();

        }

        private void btnHOR_AW_SLIDE_Click(object sender, System.EventArgs e)
        {

            this.Hide();
            WinAPIClass4.AnimateWindow(this, 3000, WinAPIClass4.AnimateWindowFlags.AW_HOR_POSITIVE | WinAPIClass4.AnimateWindowFlags.AW_SLIDE);
            this.btnAW_BLEND.Invalidate();
            this.btnHOR_AW_SLIDE.Invalidate();
            this.btnCenter_AW_SLIDE.Invalidate();
        }

        private void btnCenter_AW_SLIDE_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            WinAPIClass4.AnimateWindow(this, 3000, WinAPIClass4.AnimateWindowFlags.AW_CENTER | WinAPIClass4.AnimateWindowFlags.AW_SLIDE);
            this.btnAW_BLEND.Invalidate();
            this.btnHOR_AW_SLIDE.Invalidate();
            this.btnCenter_AW_SLIDE.Invalidate();

        }


        /////////////////////////// Задание 5 /////////////////////////// 
        ///Завершение работы Windows, перезагрузка, выход пользователя из системы
        
        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnUserOut_Click(object sender, System.EventArgs e)
        {
            WinAPIClass5.ExitWindowsEx((uint)WinAPIClass5.ShutdownType.LogOf, "Win Api test");
        }

        private void btnTurnOff_Click(object sender, System.EventArgs e)
        {
            RestartOrShotDown(WinAPIClass5.ShutdownType.Shutdown);
        }

        private void btnRestart_Click(object sender, System.EventArgs e)
        {
            RestartOrShotDown(WinAPIClass5.ShutdownType.Reboot);
        }
        void RestartOrShotDown(WinAPIClass5.ShutdownType type)
        {
            WinAPIClass5.TokPriv1Luid tp;
            IntPtr hproc = WinAPIClass5.GetCurrentProcess();
            IntPtr hToken = IntPtr.Zero;
            WinAPIClass5.OpenProcessToken(hproc, WinAPIClass5.TOKEN_ADJUST_PRIVILEGES | WinAPIClass5.TOKEN_QUERY, ref hToken);
            tp.Count = 1;
            tp.Luid = 0;
            tp.Attr = WinAPIClass5.SE_PRIVILEGE_ENABLED;
            WinAPIClass5.LookupPrivilegeValue(null, WinAPIClass5.SE_SHUTDOWN_NAME, ref tp.Luid);
            WinAPIClass5.AdjustTokenPrivileges(hToken, false, ref tp, 0, IntPtr.Zero, IntPtr.Zero);
            WinAPIClass5.ExitWindowsEx((uint)type, "Win Api test");

        }

        private void btnCancel2_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }



        /////////////////////////// Задание 8 /////////////////////////// 
        ///Программа для фотографирования экрана. Библиотеки user32.dll и GDI32

        private void btnCreate_Click(object sender, System.EventArgs e)
        {

            SaveFileDialog diag = new SaveFileDialog();
            diag.Filter = "Файлы bmp|*.bmp";
            if (diag.ShowDialog() != DialogResult.OK)
                return;
            // Получаем адрес файла.
            string filename = diag.FileName;
            // Создаем экземпляр  класса ScreenShotDll
            ScreenShotDll shoter = new ScreenShotDll();
            // Создаем и сохраняем изображение.
            shoter.CaptureScreen(filename, System.Drawing.Imaging.ImageFormat.Bmp);


        }

        /////////////////////////// Задание 8 /////////////////////////// 
        ///Программа для фотографирования экрана. Библиотеки user32.dll и GDI32

        private void mnuOpen_Click(object sender, System.EventArgs e)
        {
            openFileDialog1.Filter = "Файлы pdf|*.pdf";
            openFileDialog1.ShowDialog();
            axAcroPDF1.LoadFile(openFileDialog1.FileName);
        }

  
    }




    internal class WinAPIClass
    {
        #region Получение имени текущего пользователя
        /// <summary>
        /// Получение имени текущего пользователя.
        /// </summary>
        /// <param name="nameFormat">Формат имени из перечисления NameFormat.</param>
        /// <param name="userName">Выходной параметр — имя.пользователя</param>
        /// <param name="userNameSize">Количество символов в имени.</param>
        /// <param name="handle">Родительская форма окна</param>
		/// <param name="text">Текст окна.</param>
		/// <param name="title">Заголовок окна.</param>
		/// <param name="type">Тип окна.</param>
        /// <returns></returns>
        //Подключение библиотеки secur32.dll
        [DllImport("secur32.dll", CharSet = CharSet.Auto)]
        public static extern int GetUserNameEx(int nameFormat, StringBuilder userName, ref uint userNameSize);


        /// <summary>
        /// Формат имени.
        /// </summary>
        public enum NameFormat : int
        {
            NameUnknown = 0,
            NameFullyQualifiedDN = 1,
            NameSamCompatible = 2,
            NameDisplay = 3,
            NameUniqueId = 6,
            NameCanonical = 7,
            NameUserPrincipal = 8,
            NameCanonicalEx = 9,
            NameServicePrincipal = 10,
            NameDnsDomain = 12
        };
        #endregion

    }

    /////////////////////////// Задание 2 /////////////////////////// 
    ///Диалоговые окна. Библиотека user32.dll
    internal class WinAPIClass2
    {
        #region Вызов диалогового окна MessageBox
        /// <summary>
        /// Вызов диалогового окна MessageBox.
        /// </summary>
        /// <param name="handle">Родительская форма окна</param>
        /// <param name="text">Текст окна.</param>
        /// <param name="title">Заголовок окна.</param>
        /// <param name="type">Тип окна.</param>		
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int MessageBox(IntPtr handle, string text, string title, uint type);
        /// <summary>
        /// Тип диалогового окна.
        /// </summary>
        public enum MessageBoxType : int
        {
            /// <summary>
            /// Три кнопки - Abort, Retry, Ignore
            /// </summary>
            MB_ABORTRETRYIGNORE = 2,
            /// <summary>
            /// Три кнопки - Cancel, Try, Continue
            /// </summary>
            MB_CANCELTRYCONTINUE = 6,
            /// <summary>
            /// Одна кнопка - Ok.
            /// </summary>
            MB_OK = 0,
            /// <summary>
            /// Две кнопки - Ok, Cancel.
            /// </summary>
            MB_OKCANCEL = 1,
            /// <summary>
            /// Две кнопки - Retry, Cancel
            /// </summary>
            MB_RETRYCANCEL = 5,
            /// <summary>
            /// Две кнопки - Yes, No
            /// </summary>
            MB_YESNO = 4,
            /// <summary>
            ///  Три кнопки - Yes, No, Cancel
            /// </summary>
            MB_YESNOCANCEL = 3,
            /// <summary>
            /// Иконка - восклицание
            /// </summary>
            MB_ICONEXCLAMATION = 0x30,
            /// <summary>
            /// Иконка - предупреждение
            /// </summary>
            MB_ICONWARNING = 0x30,
            /// <summary>
            /// Иконка - информация
            /// </summary>
            MB_ICONINFORMATION = 0x40,
            /// <summary>
            /// Иконка - вопрос
            /// </summary>
            MB_ICONQUESTION = 0x20,
            /// <summary>
            /// Иконка - стоп
            /// </summary>
            MB_ICONSTOP = 0x10,
            /// <summary>
            /// Иконка - ошибка
            /// </summary>
            MB_ICONERROR = 0x10,

        }
        /// <summary>
        /// Тип возвращаемого значения.
        /// </summary>
        public enum MessageBoxReturnType : int
        {
            IDABORT = 3,
            IDCANCEL = 2,
            IDCONTINUE = 11,
            IDIGNORE = 5,
            IDNO = 7,
            IDOK = 1,
            IDRETRY = 4,
            IDTRYAGAIN = 10,
            IDYES = 6
        }
        #endregion
    }

    /////////////////////////// Задание 3 /////////////////////////// 
    ///Динамик компьютера. Библиотека Kernel32.dll
    public class WinAPIClass3
    {
        #region Вызов сигнала
        /// <summary>
        /// Вызов сигнала.
        /// </summary>
        /// <param name="frequency">Частота сигнала в герцах. Диапазон от 37 до 32767 Гц.</param>
        /// <param name="duration">Продолжительность сигнала в миллисекундах.</param>			
        /// <returns></returns>		
        [DllImport("Kernel32.dll")]
        public static extern bool Beep(int frequency, int duration);
        #endregion

    }

    /////////////////////////// Задание 4 /////////////////////////// 
    ///Проявление окна

    public class WinAPIClass4
    {
        #region Анимация окна
        /// <summary>
        /// Тип анимации окна. Перечисление возвращает тип данных int
        /// после приведения. Каждому элементу перечисления присвоено 
        /// свое значение типа int.
        /// </summary>	
        [Flags]
        public enum AnimateWindowFlags : int
        {
            AW_HOR_POSITIVE = 1,
            AW_HOR_NEGATIVE = 2,
            AW_VER_POSITIVE = 4,
            AW_VER_NEGATIVE = 8,
            AW_CENTER = 16,
            AW_HIDE = 65536,
            AW_ACTIVATE = 131072,
            AW_SLIDE = 262144,
            AW_BLEND = 524288
        };

        /// <summary>
        /// Анимация окна.
        /// </summary>
        /// <param name="hwnd">Окно.</param>
        /// <param name="dwTime">Время.</param>
        /// <param name="dwFlags">Тип анимации. Если в неуправляемом 
        /// коде используется перечисление, то его нужно конвертировать
        /// в тип данных int. </param>			
        /// <returns></returns>
        [DllImportAttribute("user32.dll", EntryPoint = "AnimateWindow", SetLastError = true)]
        public static extern bool AnimateWindow(IntPtr hwnd, int dwTime, int dwFlags);

        /// <summary>
        /// Анимация окна.
        /// </summary>
        /// <param name="ctrl">Окно.</param>
        /// <param name="dwTime">Время.</param>
        /// <param name="Flags">Флаги.</param>		
        /// <returns></returns>
        public static bool AnimateWindow(Control ctrl, int dwTime, AnimateWindowFlags Flags)
        {
            return AnimateWindow(ctrl.Handle, dwTime, (int)Flags);
        }
        #endregion
    }

    /////////////////////////// Задание 5 /////////////////////////// 
    ///Завершение работы Windows, перезагрузка, выход пользователя из системы
    public class WinAPIClass5
    {

        #region Завершение работы Windows. 
        /// <summary>
        /// Завершение работы.
        /// </summary>
        /// <param name="shutDownType">Тип завершения работы.</param>
        /// <param name="reason">Причина</param>		
        /// <returns></returns>
        [DllImport("user32.dll")]
        public static extern bool ExitWindowsEx(uint shutDownType, string reason);

        //To shut down or restart the system, the calling process must use the 
        //AdjustTokenPrivileges function to enable the SE_SHUTDOWN_NAME privilege.
        // Для выключения или перезагрузки системы вызываемый процесс 
        //должен использовать функцию AdjustTokenPrivileges для получения 
        //определенного уровня доступа (привелегии)

        /// <summary>
        /// Тип завершения работы.
        /// </summary>
        public enum ShutdownType : int
        {
            LogOf = 0,
            Shutdown = 0x00000001,
            Reboot = 0x00000002,
            PowerOf = 0x00000008
        }

        #endregion
        // Дополнительные переменные
        public const int SE_PRIVILEGE_ENABLED = 2;
        public const string SE_SHUTDOWN_NAME = "SeShutdownPrivilege";
        public const int ANYSIZE_ARRAY = 1;
        public const int TOKEN_QUERY = 8;
        public const int TOKEN_ADJUST_PRIVILEGES = 32;//0x00000020;



        // Структура, используемая  для передачи в метод AdjustTokenPrivileges
        //  в качестве необходимой привилегии.
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        internal struct TokPriv1Luid
        {
            // Количество привелегий в наборе.
            public int Count;
            public long Luid;
            // Тип привилегии.
            public int Attr;
        }

        /// <summary>
        /// Возвращение указателя на текущий процесс.
        /// </summary>
        /// <returns></returns>
        [DllImport("kernel32.dll", ExactSpelling = true)]
        internal static extern IntPtr GetCurrentProcess();
        /// <summary>
        /// Открывание процесса  access token, содержащего информацию о безопасности текущего пользователя, 
        /// привязанного  к заданному процессу.
        /// </summary>
        /// <param name="h">Указатель на процесс.</param>
        /// <param name="acc">Тип access token.</param>
        /// <param name="phtok">Указатель на access token.</param>
        /// <returns></returns>
        [DllImport("advapi32.dll", ExactSpelling = true)]
        internal static extern bool OpenProcessToken(IntPtr h, int acc, ref IntPtr phtok);
        /// <summary>
        /// Возвращение значения переменной в текущей сессии ОС.
        /// </summary>
        /// <param name="host">Название системы. Если значение  null,  поиск осуществляется
        ///  в локальной системе.</param>
        /// <param name="name">Название переменной.</param>
        /// <param name="pluid">Указатель на значение переменной.</param>
        /// <returns></returns>
        [DllImport("advapi32.dll")]
        internal static extern bool LookupPrivilegeValue(string host, string name, ref long pluid);
        /// <summary>
        /// Включение  указанной привилегии.
        /// </summary>
        /// <param name="htok">Указатель на access token</param>
        /// <param name="disall">Необходимость выключения  всех привилегии.</param>
        /// <param name="newst">Новое значение привилегии. Если предыдущее значение установлено в true, 
        /// то это значение не учитывается.</param>
        /// <param name="len">Размер буфера для следующего значения.</param>
        /// <param name="prev">Предыдущая привелегия.</param>
        /// <param name="relen">Указатель на  размер полученных привилегий.</param>
        /// <returns></returns>
        [DllImport("advapi32.dll", ExactSpelling = true)]
        internal static extern bool AdjustTokenPrivileges(IntPtr htok, bool disall,
            ref TokPriv1Luid newst, int len, IntPtr prev, IntPtr relen);

    }


}
