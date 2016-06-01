using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;
using Kurs.Model;

namespace Kurs
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            //RandomGenerationXML();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Views.MainForm());
        }
    }
}


/* static void RandomGenerationXML()
      {
          List<string> СписокИмен = new List<string>(),
                       СписокФамилий = new List<string>(),
                       СписокОтчеств = new List<string>();

          StreamReader streamReader = new StreamReader(@"genData/имена.txt", true);
          string Имена = "", Фамилии = "", Отчества = "";
          while (!streamReader.EndOfStream)
              Имена += streamReader.ReadLine();

          streamReader = new StreamReader(@"genData/фамилии.txt", true);
          while (!streamReader.EndOfStream)
              Фамилии += streamReader.ReadLine();

          streamReader = new StreamReader(@"genData/отчества.txt", true);
          while (!streamReader.EndOfStream)
              Отчества += streamReader.ReadLine();

          for (int i = 0; i < Имена.Length; i++)
              if (Имена[i] + "" == (Имена[i] + "").ToUpper())
                  СписокИмен.Add(Имена[i] + "");
              else
                  СписокИмен[СписокИмен.Count - 1] += Имена[i];

          for (int i = 0; i < Фамилии.Length; i++)
              if (Фамилии[i] + "" == (Фамилии[i] + "").ToUpper())
                  СписокФамилий.Add(Фамилии[i] + "");
              else
                  СписокФамилий[СписокФамилий.Count - 1] += Фамилии[i];
          СписокОтчеств = Отчества.Split(' ').ToList();

          var СписокГородов = new List<string>() { "Москва", "Харьков", "Киев", "Луганск", "Снегово", "Варшава", "Оренбург", "Минск", "Одесса", "Житомир" };
          var СемейныеПоложения = new List<FamilyStatus>() { FamilyStatus.Divorced, FamilyStatus.Married, FamilyStatus.NotMarried };
          var СписокТюрем = new List<Prisons>()
          {
              Prisons.Butyrskaya, Prisons.Crosses, Prisons.Lefortovo,
              Prisons.Sailor, Prisons.VladimirskyCentral, Prisons.WhiteSwan
          };

          var BindList = new BindingList<Prisoner>();

          Random rand = new Random();

          for (int i = 0; i < 15000; i++)
          {

              var pers = new PersonalInfo()
              {
                  Birthday = new DateTime(rand.Next(1900, 2000), rand.Next(1, 12), rand.Next(1, 28)),
                  FamilyStatus = СемейныеПоложения[rand.Next(0, 2)],
                  FirstName = СписокИмен[rand.Next(0, СписокИмен.Count - 1)],
                  MiddleName = СписокОтчеств[rand.Next(0, СписокОтчеств.Count - 1)],
                  SecondName = СписокФамилий[rand.Next(0, СписокФамилий.Count - 1)],
                  СityOfBirth = СписокГородов[rand.Next(0, СписокГородов.Count - 1)]
              };
              var impr = new ImprisonmentInfo()
              {
                  ImprisonmentCount = rand.Next(1, 10),
                  JailingMonths = rand.Next(1, 800),
                  Prison = СписокТюрем[rand.Next(0, СписокТюрем.Count - 1)],
                  PrisonCell = rand.Next(1, 4000),
                  JailedDate = new DateTime(rand.Next(pers.Birthday.Year + 16, 2016), rand.Next(1, 12), rand.Next(1, 28))
              };
              var pris = new Prisoner()
              {
                  ImprisonmentInfo = impr,
                  PersonalInfo = pers,
                  Id = (BindList.Count > 0)
                      ? BindList.Max(x => x.Id) + 1
                      : 1
              };
              BindList.Add(pris);
          }
          XmlSerializator.SaveToFile(BindList);
      }*/
