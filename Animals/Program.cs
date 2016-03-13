using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Program
    {
        public class Animal
        {
            public string Name { get; set; }
            public float Weight { get; set; }
            public bool HaveFur { get; set; }

            public virtual string Sound()
            {
                return "Sound of an animal";
            }
            public virtual string Trick()
            {
                return "Trick made by animal";
            }
            public virtual int CountLegs()
            {
                return 2;
            }
        }
        public class Cat : Animal
        {
            public string Color { get; set; }
            public override string Sound()
            {
                return "MEOW!";
            }
            public override string Trick()
            {
                return "jumping";
            }
            public override int CountLegs()
            {
                return 4;
            }
        }
        public class Pony : Animal
        {
            public bool IsMagic { get; set; }
            public override string Sound()
            {
                return "Neigh";
            }
            public override string Trick()
            {
                return "Keep on galloping and jump through fences";
            }
            public override int CountLegs()
            {
                return 4;
            }
        }
        public class Ant : Animal
        {
            public bool isQueen { get; set; }
            public override string Sound()
            {
                return "sssss";
            }
            public override string Trick()
            {
                return "Many of them can carry increadible weights";
            }
            public override int CountLegs()
            {
                return 6;
            }
        }
        public class Elephant : Animal
        {
            public override string Sound()
            {
                return "Trumpet";
            }
            public override string Trick()
            {
                return "Balancing on a big ball";
            }
            public override int CountLegs()
            {
                return 4;
            }
        }
        public class Giraffe : Animal
        {
            public override string Sound()
            {
                return "Bleat";
            }
            public override string Trick()
            {
                return "Just looking awesome";
            }
            public override int CountLegs()
            {
                return 4;
            }
        }
        interface ICircus
        {
            string AnimalsIntroduction();
            string Show();
            int Patter(int howMuch); // tupanie
        }
        public class Circus : ICircus
        {
            public List<Animal> Animals;
            public string Name { get; set; }
            // konstruktor
            public Circus(string _name)
            {
                Name = _name;
                Animals = new List<Animal>();
                Animals.Add(new Pony() { Name = "Sugar", HaveFur = true, Weight = 34.6F, IsMagic = true });
                Animals.Add(new Pony() { Name = "BigFat", HaveFur = true, Weight = 54.1F, IsMagic = false });
                Animals.Add(new Cat() { Name = "Sugar", HaveFur = true, Weight = 34.6F, Color = "grey" });
                Animals.Add(new Cat() { Name = "Jean Paul", HaveFur = true, Weight = 12.78F, Color = "black and white" });
                Animals.Add(new Ant() { Name = "FN2187", HaveFur = false, Weight = 0.06F, isQueen = false});
                Animals.Add(new Ant() { Name = "red one", HaveFur = false, Weight = 0.05F, isQueen = true });
                Animals.Add(new Elephant() { Name = "Dumbo", HaveFur = false, Weight = 256.5F });
                Animals.Add(new Elephant() { Name = "Mammoth", HaveFur = true, Weight = 768.32F });
                Animals.Add(new Giraffe() { Name = "Gir", HaveFur = false, Weight = 234F });
                Animals.Add(new Giraffe() { Name = "Gir's sister", HaveFur = false, Weight = 217F });
            }
            public string AnimalsIntroduction()
            {
                string allSounds="";
                foreach(var animal in Animals)
                {
                    allSounds += animal.Sound()+", ";
                }
                return allSounds;
            }

            public int Patter(int howMuch)
            {
                int allPats = 0;
                foreach (var animal in Animals)
                {
                    allPats += animal.CountLegs();
                }
                allPats *= howMuch;
                return allPats;
            }

            public string Show()
            {
                string allTricks = "";
                foreach (var animal in Animals)
                {
                    allTricks += ", " + animal.Trick();
                }
                return allTricks;
            }
        }
        interface IZoo
        {
            string Sounds();
        }
        public class Zoo:IZoo
        {
            public List<Animal> Animals;
            public string Name { get; set; }

            public Zoo()
            {
                Animals = new List<Animal>();
                Animals.Add(new Pony() { Name = "Avalanche", HaveFur = true, Weight = 134.6F, IsMagic = false });
                Animals.Add(new Pony() { Name = "BigFat", HaveFur = true, Weight = 43.1F, IsMagic = true });
                Animals.Add(new Cat() { Name = "Garffield", HaveFur = true, Weight = 34.6F, Color = "brown" });
                Animals.Add(new Cat() { Name = "Wolverine", HaveFur = true, Weight = 14.67F, Color = "red and yellow" });
                Animals.Add(new Ant() { Name = "007", HaveFur = false, Weight = 0.06F, isQueen = true });
                Animals.Add(new Elephant() { Name = "Dumbooooo", HaveFur = false, Weight = 456.56F });
                Animals.Add(new Giraffe() { Name = "GiraffeIGuess", HaveFur = false, Weight = 334F });
            }
            public string Sounds()
            {
                string allSounds = "";
                foreach (var animal in Animals)
                {
                    allSounds += animal.Sound() + ", ";
                }
                return allSounds;
            }
        }

        static void Main(string[] args)
        {
            Circus myCircus = new Circus("Cyrk Podwawelski");
            Zoo myZoo = new Zoo();
            Menu(myCircus,myZoo);
        }
        public static void Menu(Circus myCircus,Zoo myZoo)
        {
            Console.WriteLine("###########################################################");
            Console.WriteLine("###             Witaj w menu glownym                    ###");
            Console.WriteLine("###########################################################");
            Console.WriteLine("###                Wybierz opcje:                       ###");
            Console.WriteLine("###########################################################");
            Console.WriteLine();
            Console.WriteLine("### A: Prezentacja zwierzat w cyrku "+ myCircus.Name );
            Console.WriteLine("### B: Obejrzenie programu cyrku " + myCircus.Name );
            Console.WriteLine("### C: Posluchanie dzwiekow zoo " + myZoo.Name);
            Console.WriteLine("### D: Wyswietla imie pierwszego znalezionego futrzaka w Zoo");
            Console.WriteLine("### E: Wyswietla wszystkie imiona zwierzat w Cyrku");
            Console.WriteLine("### ESC: Aby wyjsc");

            ConsoleKeyInfo choosenOption = Console.ReadKey();
            Console.ReadLine();

            switch (choosenOption.Key)
            {
                case ConsoleKey.A:
                    Console.WriteLine();
                    Console.WriteLine("### Prezentacja zwierzat ##");
                    Console.WriteLine(myCircus.AnimalsIntroduction());
                    Console.WriteLine();
                    break;
                case ConsoleKey.B:
                    Console.WriteLine();
                    Console.WriteLine("### Program cyrku ##");
                    Console.WriteLine(myCircus.Show());
                    Console.WriteLine();
                    break;
                case ConsoleKey.C:
                    Console.WriteLine();
                    Console.WriteLine("### Dzwieki w Zoo ##");
                    Console.WriteLine(myZoo.Sounds());
                    Console.WriteLine();
                    break;
                case ConsoleKey.D:
                    Console.WriteLine();
                    Console.WriteLine("### Pierwszy znaleziony futrzak ");
                    Console.Write(myZoo.Animals.Where(x => x.HaveFur == true).FirstOrDefault().Name+ " ##");
                    Console.WriteLine();
                    break;
                case ConsoleKey.E:
                    Console.WriteLine();
                    Console.WriteLine("### Wszystkie imiona zwierza w cyrku ##");
                    foreach(var animal in myCircus.Animals)
                    {
                        Console.WriteLine(animal.Name);
                    }
                    Console.WriteLine();
                    break;
                case ConsoleKey.Escape:
                    System.Environment.Exit(1);
                    break;
                default:
                    Console.WriteLine("### NIE MA TAKIEJ OPCJI ##");
                    break;
            }
            Console.WriteLine("### Nacisnij dowolny klawisz aby wrocic do Menu ##");
            Console.ReadKey();
            Console.Clear();
            Menu(myCircus, myZoo);
        }

    }
}
