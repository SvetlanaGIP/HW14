using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW14
{
//    Разработать абстрактный класс Animal, который описывает животное.Класс содержит следующие элементы:
//абстрактное свойство - название животного.
//В классе Animal нужно определить следующие методы:
//конструктор, устанавливающий значение по умолчанию для названия;
//    абстрактный метод Say(), который выводит звук, который издает животное;
//неабстрактный метод ShowInfo(), который выводит на консоль последовательно название, а затем звук(вызывая метод Say()).
//Разработать классы Cat и Dog, которые реализуют абстрактный класс Animal.В классах реализовать следующие элементы:
//свойство – название животного;
//    метод Say(), выводящий на экран «Мяу» либо «Гав» соответственно.
//   Создайте экземпляры классов Cat и Dog и проверьте их работоспособность.
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            //Console.WriteLine(cat.Name, cat.Say);
            cat.ShowInfo();

            Dog dog = new Dog();
            dog.ShowInfo();

            Console.Write("press any key to exit");
            Console.ReadLine();
        }

        abstract class Animal
        {
            public abstract string Name
            {
                get;
                set;
            }

            public Animal()
            {
                this.Name = "Животное";
            }

            public abstract void Say();

            public void ShowInfo()
            {
                Console.WriteLine(this.Name);
                Say();
            }

        }

        class Cat : Animal
        {
            public override String Name { get; set; }

            public Cat()
            {
                Name = "Кошка";
            }

            public override void Say()
            {
                Console.WriteLine("мяy");
            }
        }

        class Dog : Animal
        {
            public override String Name { get; set; }

            public Dog()
            {
                Name = "Собака";
            }

            public override void Say()
            {
                Console.WriteLine("гав");
            }
        }
    }
}
