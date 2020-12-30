using System;
using System.Collections.Generic;
using System.Text;

namespace Pelmen
{
    abstract class Pelmeni
    {
        public void Make()
        {
            getName();
            addMeet();
            AddDough();
            AddSpice();
            AddSalt();
        }
        public abstract string Name { get; }
        public abstract void getName();
        public abstract void addMeet();
        public abstract void AddDough();
        public abstract void AddSpice();
        public abstract void AddSalt();
        public virtual void getReadyEat()
        {
            Console.WriteLine("Получили еду");
        }
        class Cupecheskie : Pelmeni
        {
            public override string Name
            {
                get
                {
                    return "Пельмени Купеческие на развес";
                }
            }

            public override void addMeet()
            {
                Console.WriteLine("Добавляем мясо");
            }

            public override void AddDough()
            {
                Console.WriteLine("Добавляем тесто");
            }

            public override void AddSalt()
            {
                Console.WriteLine("Добавляем добаляем соль в мясо");
            }

            public override void AddSpice()
            {
                Console.WriteLine("Добавляем специи");
            }

            public override void getName()
            {
                Console.WriteLine("Добавляем" + this.Name);
            }
        }
        class Bavarskie : Pelmeni
        {
            public override string Name
            {
                get
                {
                    return "пельмени Баварские на развес";
                }
            }

            public override void addMeet()
            {
                Console.WriteLine("Добавляем мясо");
            }

            public override void AddDough()
            {
                Console.WriteLine("Добавляем тесто");
            }

            public override void AddSalt()
            {
                Console.WriteLine("Добавляем добаляем соль в мясо");
            }

            public override void AddSpice()
            {
                Console.WriteLine("Добавляем специи");
            }

            public override void getName()
            {
                Console.WriteLine("Добавляем" + this.Name);
            }
        }
        class Studencheskie : Pelmeni
        {
            public override string Name
            {
                get
                {
                    return "Пельмени Студенческие на развес";
                }
            }

            public override void addMeet()
            {
                Console.WriteLine("Добавляем мясо");
            }

            public override void AddDough()
            {
                Console.WriteLine("Добавляем тесто");
            }

            public override void AddSalt()
            {
                Console.WriteLine("Добавляем добаляем соль в мясо");
            }

            public override void AddSpice()
            {
                Console.WriteLine("Добавляем специи");
            }

            public override void getName()
            {
                Console.WriteLine("Добавляем" + this.Name);
            }
        }
    }
}
