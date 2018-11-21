using System;
using System.Runtime.InteropServices;
using System.Text;

namespace Lab_5_C
{
    public class WinAPIClass
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
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int GetUserNameEx(int nameFormat, StringBuilder userName, ref uint userNameSize);
        public static extern int MessageBox(IntPtr handle, string text, string title, uint type);

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
}

