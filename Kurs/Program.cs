using System;
using System.Windows.Forms;
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
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
        
    }
}
