using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex14
{
    class Program
    {
        // Разработать абстрактный класс Animal, который описывает животное.Класс содержит следующие элементы:
        //•	абстрактное свойство - название животного.
        //В классе Animal нужно определить следующие методы:
        //•	конструктор, устанавливающий значение по умолчанию для названия;
        //•	абстрактный метод Say(), который выводит звук, который издает животное;
        //•	неабстрактный метод ShowInfo(), который выводит на консоль последовательно название, а затем звук(вызывая метод Say()).
        //Разработать классы Cat и Dog, которые реализуют абстрактный класс Animal.В классах реализовать следующие элементы:
        //•	свойство – название животного;
        //•	метод Say(), выводящий на экран «Мяу» либо «Гав» соответственно.
        //Создайте экземпляры классов Cat и Dog и проверьте их работоспособность.

        static void Main(string[] args)
        {
            Cat cat = new Cat("кот");
            Dog dog = new Dog("пёс");

            cat.ShowInfo();
            dog.ShowInfo();

            Console.ReadKey();
        }
    }
    abstract class Animal
    {
        public abstract string Name { get; set; }
        public Animal(string name)
        {
            Name = name;
        }
        public abstract string Say();

    }
    class Cat : Animal
    {
        string name = "кот";
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public Cat(string name)
            : base(name)
        {

        }
        public override string Say()
        {
            return "Мяу";
        }
        public void ShowInfo()
        {
            Console.WriteLine("Привет! Я {0}, {1}", Name, Say());
        }
    }
    class Dog : Animal
    {
        string name = "пёс";
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public Dog(string name)
            : base(name)
        {

        }
        public override string Say()
        {
            return "Гав";
        }
        public void ShowInfo()
        {
            Console.WriteLine("Привет! Я {0}, {1}", Name, Say());
        }
    }
}
