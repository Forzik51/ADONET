using EntityIntro21._01._22.Data;
using System;

namespace EntityIntro21._01._22
{
    class Program
    {
        static void Main(string[] args)
        {
            //FootballTeamRepos.AddTeam("Valencia", "Valencia",55,15,100,30);
            //FootballTeamRepos.AddTeam("Madrid", "Madrid", 105, 23, 520, 50);
            //FootballTeamRepos.Print();
            //FootballTeamRepos.SearchForMaxWin();
            int k = 0;
            while (k != 12)
            {
                Console.WriteLine(
                    "1-  PrintAll\n" +
                    "2-  SearchForName\n" +
                    "3-  SearchForCity\n" +
                    "4-  SearchForCityAndName\n" +
                    "5-  SearchForMaxWin\n" +
                    "6-  SearchForMinWin\n" +
                    "7-  SearchForMaxGoalsScored\n" +
                    "8-  SearchForMaxGoalsConceded\n" +
                    "9-  AddTeam\n" +
                    "10-  UpdateTeam\n" +
                    "11-  DeleteTeam\n" +
                    "12-  Exit\n"
                    );
                k = Int32.Parse(Console.ReadLine());
                switch (k)
                {
                    case 1:
                        FootballTeamRepos.Print();
                        break;

                    case 2:
                        Console.WriteLine("Enter team name");
                        string name = Console.ReadLine();
                        FootballTeamRepos.SearchForName(name);
                        break;

                    case 3:
                        Console.WriteLine("Enter city name");
                        name = Console.ReadLine();
                        FootballTeamRepos.SearchForCity(name);
                        break;
                    case 4:
                        Console.WriteLine("Enter city name");
                        string nameC = Console.ReadLine();
                        Console.WriteLine("Enter team name");
                        name= Console.ReadLine();
                        FootballTeamRepos.SearchForCityAndName(nameC, name);
                        break;
                    case 5:
                        FootballTeamRepos.SearchForMaxWin();
                        break;
                    case 6:
                        FootballTeamRepos.SearchForMinWin();
                        break;
                    case 7:
                        FootballTeamRepos.SearchForMaxGoalsScored();
                        break;
                    case 8:
                        FootballTeamRepos.SearchForMaxGoalsConceded();
                        break;
                    case 9:
                        string nameN, city; short win, loss, goalsScored, goalsConceded;
                        Console.WriteLine("Enter team name");
                        nameN = Console.ReadLine();
                        Console.WriteLine("Enter city name");
                        city = Console.ReadLine();

                        Console.WriteLine("Enter team win");
                        win = short.Parse(Console.ReadLine());
                        Console.WriteLine("Enter team loss");
                        loss = short.Parse(Console.ReadLine());

                        Console.WriteLine("Enter team goalsScored");
                        goalsScored = short.Parse(Console.ReadLine());
                        Console.WriteLine("Enter team goalsConceded");
                        goalsConceded = short.Parse(Console.ReadLine());
                        FootballTeamRepos.AddTeam( nameN, city, win, loss, goalsScored, goalsConceded);
                        break;
                    case 10:
                        int id;
                        Console.WriteLine("Enter team id");
                        id = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter team name");
                        nameN = Console.ReadLine();
                        Console.WriteLine("Enter city name");
                        city = Console.ReadLine();

                        Console.WriteLine("Enter team win");
                        win = short.Parse(Console.ReadLine());
                        Console.WriteLine("Enter team loss");
                        loss = short.Parse(Console.ReadLine());

                        Console.WriteLine("Enter team goalsScored");
                        goalsScored = short.Parse(Console.ReadLine());
                        Console.WriteLine("Enter team goalsConceded");
                        goalsConceded = short.Parse(Console.ReadLine());
                        FootballTeamRepos.UpdateTeam(id,nameN, city, win, loss, goalsScored, goalsConceded);
                        break;
                    case 11:
                        Console.WriteLine("Enter team id");
                        id = int.Parse(Console.ReadLine());
                        FootballTeamRepos.DeleteTeam(id);
                        break;


                }
            }
        }
    }
}
