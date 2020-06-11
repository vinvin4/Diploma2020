using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using Res = Diploma2020.Properties.Resources;
using Newtonsoft.Json;

namespace Diploma2020.Helpers
{
    class Utilities
    {
        #region Dialogs
        /// <summary>
        /// Dialog for asking about school registration
        /// </summary>
        /// <returns></returns>
        public static DialogResult RegistrationDialog()
        {
            DialogResult result = MessageBox.Show(Res.RegisterText, Res.RegisterTitle, MessageBoxButtons.OKCancel);
            return result;
        }

        /// <summary>
        /// Dialog, to show, that file reading process end
        /// </summary>
        /// <param name="completed">false - file was not readed; true - file successfully readed</param>
        public static void ReadingDialog(bool completed = true)
        {
            MessageBox.Show((completed) ? Res.ReadingFileText : Res.ReadingFileFailureText,
                Res.ReadintFileTitle);
        }

        public static DialogResult CheckFunctionalityDialog()
        {
            var result = MessageBox.Show(Res.CheckingDataText, Res.CheckingDataTitle);
            return result;
        }

        public static void FillTheTable(string classes = null)
        {
            MessageBox.Show(string.IsNullOrEmpty(classes) ?
                Res.IncorrectDataTxtDef : string.Format(Res.IncorrectDataTxtExt, classes),
                Res.IncorrectDataTitle);
        }

        public static void RepeatedValues()
        {
            MessageBox.Show(Res.RepeatedValues, Res.IncorrectDataTitle);
        }
        #endregion

        /// <summary>
        /// Read Word file and return string content
        /// </summary>
        /// <param name="filePath">File pat, what file should be readed</param>
        /// <returns>String-content</returns>
        public static string ReadWordFile(string filePath)
        {
            string content = string.Empty;
            if (File.Exists(filePath))
            {
                Word.Application app = new Word.Application();
                object docPath = filePath;
                Word.Document doc = app.Documents.Open(ref docPath);
                doc.Activate();

                content = doc.Content.Text;
                doc.Close();
                ReadingDialog(true);
            }
            else
            {
                ReadingDialog(false);
            }
            return content;
        }

        public static void WriteOlympicIntoWordFile(string Subject, string Content)
        {
            string filePath = string.Join(@"\", AppConstants.DiskToDocs, AppConstants.ProjectDirectory, AppConstants.OlympicDirectory);
            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }
            filePath = string.Join(@"\", filePath, $"Олимпиада_{Subject}.doc");

            Word.Application app = new Word.Application();
            object oMissing = System.Reflection.Missing.Value;
            Word.Document doc = app.Documents.Add();
            doc.Activate();

            doc.Content.Font.Bold = 1;
            doc.Content.Font.Size = 14;
            doc.Content.Font.Name = "Times New Roman";
            Word.Paragraph oPara0;
            oPara0 = doc.Content.Paragraphs.Add(ref oMissing);
            oPara0.Range.Font.Size = 18;
            oPara0.Range.Text = $"ВОШ. {Subject}";
            oPara0.Range.InsertParagraphAfter();

            Word.Paragraph oPara1;
            oPara1 = doc.Content.Paragraphs.Add(ref oMissing);

            oPara1.Range.Text = Content;

            doc.SaveAs2(filePath);
            doc.Close();
        }

        public static void WriteClassInfoIntoWordFile(Dictionary<string, List<string>> dict)
        {
            string filePath = string.Join(@"\", AppConstants.DiskToDocs, AppConstants.ProjectDirectory, AppConstants.ClassDataDirectory);
            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }
            filePath = string.Join(@"\", filePath, AppConstants.ClassDataFile);

            Word.Application app = new Word.Application();
            object oMissing = System.Reflection.Missing.Value;
            Word.Document doc = app.Documents.Add();
            doc.Activate();

            doc.Content.Font.Bold = 1;
            doc.Content.Font.Size = 14;
            doc.Content.Font.Name = "Times New Roman";
            Word.Paragraph oPara0 = doc.Content.Paragraphs.Add(ref oMissing);
            oPara0.Range.Font.Size = 18;
            oPara0.Range.Text += "Информация о классах";
            oPara0.Range.InsertParagraphAfter();

            Word.Paragraph oPara1;

            Object defaultTableBehavior =
                Word.WdDefaultTableBehavior.wdWord9TableBehavior;
            Object autoFitBehavior =
                Word.WdAutoFitBehavior.wdAutoFitWindow;

            foreach (var item in dict)
            {
                oPara1 = doc.Content.Paragraphs.Add(ref oMissing);

                Word.Table Table = doc.Tables.Add(oPara1.Range, 5, 2,
                  ref defaultTableBehavior, ref autoFitBehavior);

                List<Pupil> pupils = AppConstants.pupils
                    .Where(value => value.Class == item.Key)
                    .ToList();

                Table.Cell(1, 1).Range.Text = "Класс:";
                Table.Cell(2, 1).Range.Text = "Дети:";
                Table.Cell(3, 1).Range.Text = "Год рождения:";
                Table.Cell(4, 1).Range.Text = "Из них:";
                Table.Cell(5, 1).Range.Text = "Группы англ. языка:";

                Table.Cell(1, 2).Range.Text = item.Key;
                Table.Cell(2, 2).Range.Text = pupils.Count.ToString();
                Table.Cell(3, 2).Range.Text = string.Join(", ", pupils
                    .Select(value => value.AddInfo.Birthday.Substring(value.AddInfo.Birthday.Length - 4))
                    .ToList().Distinct()
                    .ToList());
                int womansNumber = pupils.Where(value => value.AddInfo.Sex == "Ж").Count();
;
                Table.Cell(4, 2).Range.Text = $"Девочки: {womansNumber.ToString()}; Мальчики: {(pupils.Count - womansNumber).ToString()}";
                Table.Cell(5, 2).Range.Text = string.Format("{0}{1}",
                    item.Value[0], string.IsNullOrEmpty(item.Value[1]) ? string.Empty : $", {item.Value[1]}");
                oPara1.Range.Text += "\n";
            }

            doc.SaveAs2(filePath);
            doc.Close();
        }

        public static void WriteFiltersResultIntoFile(string line)
        {
            string filePath = string.Join(@"\", AppConstants.DiskToDocs, AppConstants.ProjectDirectory, AppConstants.FiltersDirectory);
            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }
            filePath = string.Join(@"\", filePath, AppConstants.FiltersFile);

            Word.Application app = new Word.Application();
            //object docPath = filePath;
            object oMissing = System.Reflection.Missing.Value;
            Word.Document doc = app.Documents.Add();
            doc.Activate();

            doc.Content.Font.Bold = 1;
            doc.Content.Font.Size = 14;
            doc.Content.Font.Name = "Times New Roman";
            Word.Paragraph oPara1;
            oPara1 = doc.Content.Paragraphs.Add(ref oMissing);

            oPara1.Range.Text = line;

            doc.SaveAs2(filePath);
            doc.Close();
        }

        public static void WriteActivitiesIntoWordFile(List<Tuple<string, Tuple<string, string>>> dict)
        {
            string filePath = string.Join(@"\", AppConstants.DiskToDocs,
                AppConstants.ProjectDirectory, AppConstants.ActivityDirectory);
            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }
            filePath = string.Join(@"\", filePath, AppConstants.ActivitiesFile);

            Word.Application app = new Word.Application();
            object oMissing = System.Reflection.Missing.Value;
            Word.Document doc = app.Documents.Add();
            doc.Activate();

            doc.Content.Font.Bold = 1;
            doc.Content.Font.Size = 14;
            doc.Content.Font.Name = "Times New Roman";

            Word.Paragraph oPara0 = doc.Content.Paragraphs.Add(ref oMissing);
            oPara0.Range.Font.Size = 18;
            oPara0.Range.Text = "Ежегодная активность учителей";
            oPara0.Range.InsertParagraphAfter();

            Word.Paragraph oPara1;

            Object defaultTableBehavior =
                Word.WdDefaultTableBehavior.wdWord9TableBehavior;
            Object autoFitBehavior =
                Word.WdAutoFitBehavior.wdAutoFitWindow;

            oPara1 = doc.Content.Paragraphs.Add(ref oMissing);

            Word.Table Table = doc.Tables.Add(oPara1.Range, dict.Count, 4,
              ref defaultTableBehavior, ref autoFitBehavior);

            dict = dict.OrderBy(item => item.Item1).ToList();
            for (int i = 0; i < dict.Count; i++)
            {
                string Teacher = dict[i].Item1;
                string ActivityName = dict[i].Item2.Item1;
                string Class = string.Empty;
                string ResultLine = string.Empty;
                KeyValuePair<string, Dictionary<string, string>> activeInfo = JsonConvert
                    .DeserializeObject<KeyValuePair<string, Dictionary<string, string>>>(dict[i].Item2.Item2);
                Class = activeInfo.Key;
                foreach(var item in activeInfo.Value)
                {
                    ResultLine += string.Format("{0} : {1};\n", item.Key, item.Value);
                }

                Table.Cell(i + 1, 1).Range.Text = Teacher;
                Table.Cell(i + 1, 2).Range.Text = ActivityName;
                Table.Cell(i + 1, 3).Range.Text = Class;
                Table.Cell(i + 1, 4).Range.Text = ResultLine;
            }                      

            doc.SaveAs2(filePath);
            doc.Close();
        }
    }
}
