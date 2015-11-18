using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MoreTrain
{
    internal class Program
    {

        //class Pet
        //{
        //    public string Name { get; set; }
        //    public int Age { get; set; }
        //}


        //static void Main()
        //{
        //    var pets = new Pet[]
        //       {
        //  new Pet { Name="Sharo", Age=8 },
        //  new Pet { Name="Rex", Age=4 },
        //  new Pet { Name="Strela", Age=1 },
        //  new Pet { Name="Bora", Age=3 }
        //       };

        //    var sortedPets = pets.OrderBy(x => x.Age).ThenBy(x => x.Name);

        //    foreach (Pet pet in sortedPets)
        //    {
        //        Console.WriteLine("{0} -> {1}",
        //          pet.Name, pet.Age);
        //    }

    //}

    static void Main()
    {
            //int[] numbers = new[] {1, 2, 5, 7, 8, 9, 11};

            //var dobleNums = from num in numbers
            //    where num > 5
            //    select num;

            //Console.WriteLine(string.Join(",",dobleNums));


            string[] games = { "Morrowind", "BioShock", "Half Life",
    "The Darkness", "Daxter", "System Shock 2" };

        var subset = games.Where(game => game.Length > 6).OrderBy(game => game).Select(game => game);

        Console.WriteLine(string.Join(", ",subset));

    }


    }
    }

