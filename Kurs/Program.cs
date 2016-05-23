using System;
using System.ComponentModel;
using System.Windows.Forms;
using Kurs.Classes;
using Kurs.Classes.Model;
using Kurs.Views;

namespace Kurs
{
    /*   	Справочник начальника тюрьмы. Анкетные данные заключенных, статья, срок, дата заключения под стражу,
     *    место в тюремной иерархии, камера, сведения о родственниках, особенности характера. 
     *    Формирование статистических сводок о составе, выбор по произвольному признаку.
     **/
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            //FillXmlFile();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }


        /// <summary>
        /// Заполняет файл XML случайными данными.
        /// </summary>
        public static void FillXmlFile()
        {
            var list = new BindingList<Prisoner>();

            Random rand = new Random();
            for (var i = 0; i < 100; i++)
            {
                var persInf = new PersonalInfo()
                {
                    FirstName = "Имя " + i,
                    SecondName = "Фамилия" + i,
                    MiddleName = "Отчество " + i,
                    Birthday = new DateTime(rand.Next(1900, 2000), rand.Next(1, 13), rand.Next(1, 28)),
                    FamilyStatus = FamilyStatus.Married,
                    СityOfBirth = "Kiev"
                };
                var imprisonInf = new ImprisonmentInfo()
                {
                    Prison = Prisons.BlackDolphin,
                    PrisonCell = rand.Next(1, 2000),
                    ImprisonmentCount = rand.Next(0, 20),
                    JailingMonths = rand.Next(1, 256),
                    JailedDate = new DateTime(rand.Next(persInf.Birthday.Year + 15, 2016), rand.Next(1, 13), rand.Next(1, 28))
                };

                list.Add(new Prisoner()
                {
                    Id = i,
                    ImprisonmentInfo = imprisonInf,
                    PersonalInfo = persInf
                });
            }
            InOutXml.SaveToFile(list);
        }

    }
}
