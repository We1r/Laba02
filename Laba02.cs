using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/***********************
 * Автор: Козлов Егор  * 
 * Тема: ООП на C#     *
 ***********************/

namespace Laba02
{
  public class Singleton
  {
    public static Singleton single = null;
    
    protected Singleton()
    {
      
    }

    public static Singleton Initislize()
    {
      if (single == null) single = new Singleton();
      return single;
    }
    public string name = "file name";
    public string authtor = "file author";
    public string keywords = "file keywords";
    public string subjectMatter = "file subgect matter";
    public string filePath = "file path";
    public void data()
    { Console.WriteLine($"Имя: {name}");
      Console.WriteLine($"Автор: {authtor}");
      Console.WriteLine($"Ключевые слова: {keywords}");
      Console.WriteLine($"Тематика: {subjectMatter}");
      Console.WriteLine($"Путь к файлу: {filePath}");
    }
  }

  public class MSWord : Singleton
  {
    public void fileTypeMSWord()
    {
      Console.WriteLine($"Тип файла: MS Word");
    }
  }

  public class PDF : Singleton
  {
    public void fileTypePDF()
    {
      Console.WriteLine($"Тип файла: PDF");
    }
  }

  public class MSExcel : Singleton
  {
    public void fileTypeMSExcel()
    {
      Console.WriteLine($"Тип файла: MSExcel");
    }
  }

  public class TXT : Singleton
  {
    public void fileTypeTXT()
    {
      Console.WriteLine($"Тип файла: TXT");
    }
  }

  public class HTML : Singleton
  {
    public void fileTypeHTML()
    {
      Console.WriteLine($"Тип файла: HTML");
    }
  }
  internal class Laba02
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Введите файлы каких типов нужно вывести:");
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("(1 - MSWord)");
      Console.WriteLine("(2 - PDF)");
      Console.WriteLine("(3 - MSExcel)");
      Console.WriteLine("(4 - TXT)");
      Console.WriteLine("(5 - HTML)");
      Console.ForegroundColor = ConsoleColor.White;

      int number = int.Parse(Console.ReadLine());
      if (number == 1)
      {
        MSWord fileMSWordType = new MSWord();
        fileMSWordType.fileTypeMSWord();
        Singleton fileMSWord = Singleton.Initislize();
        fileMSWord.name = "Виды грибов";
        fileMSWord.authtor = "Алексей Грибоедов";
        fileMSWord.keywords = "Классификация и названия грибов";
        fileMSWord.subjectMatter = "Грибы";
        fileMSWord.filePath = "D:/Biology";
        fileMSWord.data();
        Console.ReadKey();
        System.Environment.Exit(0);
      } if (number == 2)
      {
        PDF filePDFType = new PDF();
        filePDFType.fileTypePDF();
        Singleton filePDF = Singleton.Initislize();
        filePDF.name = "Солнечная система";
        filePDF.authtor = "Алодий Шпак";
        filePDF.keywords = "Изображение солнечной системы";
        filePDF.subjectMatter = "Астрономия";
        filePDF.filePath = "D:/Astronomy";
        filePDF.data();
        Console.ReadKey();
        System.Environment.Exit(0);
      } if (number == 3)
      {
        MSExcel fileMSExcelType = new MSExcel();
        fileMSExcelType.fileTypeMSExcel();
        Singleton fileMSExcel = Singleton.Initislize();
        fileMSExcel.name = "Доходы";
        fileMSExcel.authtor = "Геннадий Гук";
        fileMSExcel.keywords = "Доходы за месяц";
        fileMSExcel.subjectMatter = "Экономика";
        fileMSExcel.filePath = "С:/Documents";
        fileMSExcel.data();
        Console.ReadKey();
        System.Environment.Exit(0);
      } if (number == 4)
      {
        TXT fileTXTType = new TXT();
        fileTXTType.fileTypeTXT();
        Singleton fileTXT = Singleton.Initislize();
        fileTXT.name = "Стихотворение";
        fileTXT.authtor = "Михаил Мавродий";
        fileTXT.keywords = "Небольшой текст, записанный с рифмой";
        fileTXT.subjectMatter = "Литература";
        fileTXT.filePath = "D:/Poems";
        fileTXT.data();
        Console.ReadKey();
        System.Environment.Exit(0);
      } if (number == 5)
      {
        HTML fileHTMLType = new HTML();
        fileHTMLType.fileTypeHTML();
        Singleton fileHTML = Singleton.Initislize();
        fileHTML.name = "Обучение";
        fileHTML.authtor = "Александр Синицин";
        fileHTML.keywords = "Первое знакомство с HYML";
        fileHTML.subjectMatter = "Языки";
        fileHTML.filePath = "D:/HTML";
        fileHTML.data();
        Console.ReadKey();
        System.Environment.Exit(0);
      } else
      {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Такого типа файлов нет");
        Console.ReadKey();
        System.Environment.Exit(0);
      }
    }
  }
}
