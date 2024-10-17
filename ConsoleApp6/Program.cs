using System;
using System.IO.Compression;
using Microsoft.VisualBasic;
class DayOfWeek
{
    enum DayWeek : byte {Monday = 1, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday};

    public string GiveMeDayWeek()
    {
        Random rnd = new();
        byte day_num = (byte)rnd.Next(1, 8);
        switch (day_num)
        {
        case (byte)DayWeek.Monday:
            return "Понедельник";
        case (byte)DayWeek.Tuesday:
            return "Вторник";
        case (byte)DayWeek.Wednesday:
            return "Среда";
        case (byte)DayWeek.Thursday:
            return "Четверг";
        case (byte)DayWeek.Friday:
            return "Пятница";
        case (byte)DayWeek.Saturday:
            return "Суббота";
        case (byte)DayWeek.Sunday:
            return "Воскресенье";
            default:
                return $"Число {day_num} не входит в диапозон 1 до 7";
        }
    }
}
class ColorSix
{
    enum Color : byte {Red, Green, Blue, Yellow, Cyan, Magenta}
    public string ReturnColorToHexString()
    {
      Random rnd = new();
      byte takecolor = (byte)rnd.Next(0, 6);
      switch (takecolor)
      {
        case (byte)Color.Red:
            return Color.Red.ToString("X");
        case (byte)Color.Green:
            return Color.Green.ToString("X");
        case (byte)Color.Blue:
            return Color.Blue.ToString("X");
        case (byte)Color.Yellow:
            return Color.Yellow.ToString("X");
        case (byte)Color.Cyan:
            return Color.Cyan.ToString("X");
        case (byte)Color.Magenta:
            return Color.Cyan.ToString("X");
        default:
            return "Error";
      }
    }
}
class Operation
{
    public enum ArifmeticOperation {Add = 1, Substract, Multiply, Divine}
    public float OperationOnNumbers(float num1, float num2, ArifmeticOperation arifmeticOperation)
    {
        switch (arifmeticOperation)
        {
            case ArifmeticOperation.Add:
                return num1 + num2;
            case ArifmeticOperation.Substract:
                return num1 - num2;
            case ArifmeticOperation.Multiply:
                return num1 * num2;
            case ArifmeticOperation.Divine:
                if (num2 != 0)
                {
                    return num1 / num2;
                }
                else
                {
                    return float.NaN;
                }
                default:
                    return float.NaN;
        }
    }

}
class Program
{
    static void Main(string[] args)
    {
        //Task 1
        DayOfWeek dayOfWeek =  new();
        System.Console.WriteLine(dayOfWeek.GiveMeDayWeek());

        //Task 2
        ColorSix myColor = new();
        string colorHexString = myColor.ReturnColorToHexString();
        System.Console.WriteLine($"Цвет в hex формате - {colorHexString}");

        //task 3
        Random rnd = new Random();
        Operation operation = new();
        float numOne = 350;
        float numTwo = 100;
        float add = operation.OperationOnNumbers(numOne, numTwo, (Operation.ArifmeticOperation)1);
        float substract = operation.OperationOnNumbers(numOne, numTwo, (Operation.ArifmeticOperation)2);
        float multiply = operation.OperationOnNumbers(numOne, numTwo, (Operation.ArifmeticOperation)3);
        float devine = operation.OperationOnNumbers(numOne, numTwo, (Operation.ArifmeticOperation)4);
        System.Console.WriteLine($"Плюс {add} Минус {substract} Умножение {multiply} Деление {devine}");
    }
}