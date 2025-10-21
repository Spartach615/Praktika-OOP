using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktika
{
    internal class Program
    {
        class Person
        {
            private string name;
            private int age;

            public string Nam
            {
                get { return name; }
                set { name = value; }
            }

            public int Ag
            {
                get { return age; }
                set
                {
                    if (value > 0 || value < 120)
                        age = value;
                    else
                        Console.WriteLine("Возраст должен быть от 0 до 120!");
                }
            }
            public Person(string name, int age)
            {
                Nam = name;
                Ag = age < 0 || age > 120 ? 0 : age;
            }
            public void SayHello()
            {
                Console.WriteLine($"Привет, я {Nam}, мне {Ag} лет!");
            }
        }
        class Phone
        {
            private string brand;
            private int batteryLevel;

            public string Brand
            {
                get
                {
                    return brand;
                }
                set
                {
                    brand = value;
                }
            }
            public int BatteryLevel
            {
                get
                {
                    return batteryLevel;
                }
                set
                {
                    if (value > 0 && value <= 100)
                        batteryLevel = value;
                    else
                    {
                        Console.WriteLine("Ошибка");
                    }
                }
            }
            public Phone(string brand, int batteryLevel)
            {
                Brand = brand;
                BatteryLevel = batteryLevel;

            }
            public void UsePhone()
            {
                int bet = batteryLevel - 10;
                if (bet < 0)
                {
                    bet = 0;
                }
                Console.WriteLine($"Телефон {Brand},заряд {bet}%");
            }
        }
        class BankAccount
        {
            private string owner;
            private double balance;

            public string Owner
            {
                get
                {
                    return owner;
                }
                set
                {
                    owner = value;
                }
            }
            public double Balance
            {
                get
                {
                    return balance;
                }
                set
                {
                    if (balance >= 0)
                    {
                        balance = value;
                    }
                    else
                    {
                        Console.WriteLine("Ошибка");
                    }
                }
            }
            public BankAccount(string owner, double balance)
            {
                Owner = owner;
                Balance = balance;
            }
            public void Deposit(double summ)
            {
                if (summ > 0)
                {
                    Balance += summ;
                    Console.WriteLine($"{Owner},баланс: {Balance}");
                }
                else
                {
                    Console.WriteLine("Сумма должна быть больше 0");
                }
            }
            public void Withdraft(double summ)
            {
                if (summ > 0 && summ <= Balance)
                {

                    Balance -= summ;
                    Console.WriteLine($"{Owner},баланс: {Balance}");
                }
                else
                {
                    Console.WriteLine("Недостаточно средств");
                }
            }
        }
        class Circle
        {
            private double radius;
            public double Radius
            {
                get { return radius; }
                set
                {
                    if (value <= 0)
                    {
                        Console.WriteLine("Радиус должен быть больше 0!");
                    }
                    else
                    {
                        radius = value;
                    }
                }
            }
            public Circle(double radius)
            {
                Radius = radius;
            }
            public void GetArea()
            {
                double area = Math.PI * radius * radius;
                Console.WriteLine($"Площадь круга: {area}.");
            }

        }
        class Pet
        {
            private string name;
            private int energy;

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public int Energy
            {
                get { return energy; }
                set
                {
                    if (value < 0 || value > 100)
                        Console.WriteLine("Энергия должна быть от 0 до 100!");
                    else
                        energy = value;
                }
            }
            public Pet(string name, int energy)
            {
                Name = name;
                Energy = energy;
            }

            public void Play()
            {
                energy -= 20;
                if (energy < 0) energy = 0;
                Console.WriteLine($"{name} играет, энергия: {energy}.");
            }

            public void Rest()
            {
                energy += 30;
                if (energy > 100) energy = 100;
                Console.WriteLine($"{name} отдыхает, энергия: {energy}.");
            }
        }
        static void Main(string[] args)
        {
            Person person = new Person("Маша", 52);
            person.SayHello();
            Console.WriteLine();
           
            Phone phone = new Phone("самсунг", 52);
            phone.UsePhone();
            Console.WriteLine();
            
            BankAccount bankAccount = new BankAccount("Иван", 1000);
            bankAccount.Deposit(1500);
            bankAccount.Withdraft(1000);
            Console.WriteLine();
           
            Circle circle = new Circle(5);
            circle.GetArea();
            circle.Radius = -2;
            circle.Radius = 1;
            circle.GetArea();
            Console.WriteLine();


            Pet pet = new Pet("Рекс",52);
            pet.Play();
            pet.Rest();
            pet.Energy = 150;
        }
    }
}
