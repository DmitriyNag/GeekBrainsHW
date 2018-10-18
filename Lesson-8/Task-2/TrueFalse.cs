using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Task_2
{
    class TrueFalse
    {
        private string _fileName;
        public List<Question> list;

        public string FileName
        {
            set => _fileName = value;
            get => _fileName;
        }
        public TrueFalse(string fileName)
        {
            FileName = fileName;
            list = new List<Question>();
        }
        /// <summary>
        /// добавить вопрос в список
        /// </summary>
        /// <param name="text"></param>
        /// <param name="trueFalse"></param>
        public void Add(string text, bool trueFalse)
        {
            list.Add(new Question(text, trueFalse));
        }
        /// <summary>
        /// удалить вопрос из стека
        /// </summary>
        /// <param name="index"></param>
        public void Remove(int index)
        {
            if (list != null && index < list.Count && index >= 0) list.RemoveAt(index);
        }
        // Индексатор - свойство для доступа к закрытому объекту
        public Question this[int index] => list[index];

        /// <summary>
        /// сохранить список вопросов в файл
        /// </summary>
        public void Save()
        {
            string json = JsonConvert.SerializeObject(list);
            Stream fStream = new FileStream(FileName, FileMode.Create, FileAccess.Write);
            StreamWriter sWrite = new StreamWriter(fStream);
            sWrite.Write(json);
            sWrite.Close();
            fStream.Close();
        }
        /// <summary>
        /// загрузить список вопросов из файла
        /// </summary>
        /// <returns></returns>
        public List<Question> Load()
        {
            Stream fStream = new FileStream(FileName, FileMode.Open, FileAccess.Read);
            StreamReader sRead = new StreamReader(fStream);
            string json = sRead.ReadToEnd();
            list = JsonConvert.DeserializeObject<List<Question>>(json);
            sRead.Close();
            fStream.Close();
            return list;
        }
        public int Count => list.Count;
        public override string ToString()
        {
            string str = string.Empty;
            foreach (var t in list)
            {
                str += t.Text + t.TrueFalse + "\n";
            }
            return str;
        }
    }

}
