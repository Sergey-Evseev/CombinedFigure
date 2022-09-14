//Lesson 6. Problem 1. Разработать абстрактный класс Геометрическая-Фигура с полями ПлощадьФигуры и ПериметрФигуры.

//Разработать классы-наследники: Треугольник, Квадрат, Ромб, Прямоугольник, Параллелограмм, Трапеция,
//Круг, Эллипс и реализовать свойства, которые однозначно определяют объекты данных классов.

//Реализовать интерфейс ПростойN-Угольник, который имеет свойства: Высота, Основание, УголМеждуОснованиемИСмежнойСтороной, КоличествоСторон, 
//ДлиныСторон, Площадь, Периметр. Реализовать класс СоставнаяФигура который может состоять из любого количества ПростыхНУгольников.
//Для данного класса определить метод нахождения площади фигуры.
//Предусмотреть варианты невозможности задания фигуры (введены отрицательные длины сторон или при создании объекта треугольника существует пара сторон,
//сумма длин которых меньше длины третьей стороны и т.п.)

//Площадь, периметр в интерфейс. Внутри каждого класса сделать свой метод. 
//Lesson 5 page 34, lesson 6 page 8 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;
using static System.Console;

namespace CombinedFigure
{
    abstract class Figure 
    { 
    public int Width { get; set; }
    public int Height { get; set; }    
    public abstract void Draw(); //в классе наследнике: : base(param1, param2)
    public Figure() {
            Width = 0;
            Height = 0;
        }    
    }    
        
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle
            {
                Width = 5,
                Height = 10
            };
            Square square = new Square { Length = 7 };
            Rectangle rectSquare = square;
            WriteLine($"Неявное преобразование квадрата({ square}) к прямоугольнику.\n{ rectSquare}\n");
            //rectSquare.Draw();
            Square squareRect = (Square)rectangle;
            WriteLine($"Явное преобразование прямоугольника({ rectangle}) к квадрату.\n{ squareRect}\n");
            //squareRect.Draw();
            WriteLine("Введите целое число.");
            int number = int.Parse(ReadLine());
            Square squareInt = number;
            WriteLine($"Неявное преобразование целого ({ number}) к квадрату.\n{ squareInt}\n");
            //squareInt.Draw();
            number = (int)square;
            WriteLine($"Явное преобразование квадрата ({ square}) к целому.\n{ number}");

            square.Draw();
            rectangle.Draw();
            
        }
    }
}
