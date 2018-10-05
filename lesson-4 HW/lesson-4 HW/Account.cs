using System;
using System.IO;

namespace lesson_4_HW
{
    struct Account
    {
        private string name;
        private string password;
        private string login;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="login">логин</param>
        /// <param name="password">пароль</param>
        /// <param name="name">имя пользователя</param>
        public Account(string login, string password, string name)
        {
            if (name != "" && password != "" && login != "")
            {
                this.name = name;
                this.login = login;
                this.password = password;
            }
            else
            {
                throw new Exception("Не верные параметры длясоздания объекта account");
            }

        }
        /// <summary>
        /// Проверка пароля
        /// </summary>
        /// <param name="pathname">путь к файлу со списком пар логин пароль</param>
        public bool PassControl(string pathname)
        {
            string[][] reqs = GetPassLog(pathname);

            for (int i = 0; i < reqs.Length; i++)
            {
                if (login == reqs[i][0] && password == reqs[i][1]) return true;

            }
            return false;
        }
        /// <summary>
        /// Получает массив массивов, первое измеремение -количество попток, второе - лоигн и пароль
        /// </summary>
        /// <param name="pathname">путь к файлу</param>
        /// <returns>мссив массивов с парами логин пароль</returns>
        private string[][] GetPassLog (string pathname)
        {
            try
            {
                if (!File.Exists(pathname)) throw new Exception ("Файла не существует");
                else
                {
                    string[] lines = File.ReadAllLines(pathname);
                    string[][] reqs = new string[lines.Length][];
                    for (int i = 0; i < lines.Length; i++)
                    {
                        reqs[i] = lines[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries); ;
                    }
                    return reqs;
                }

            }
            catch
            {
                throw new Exception("Формат файла не корректный");
            }
        }
    }
}
