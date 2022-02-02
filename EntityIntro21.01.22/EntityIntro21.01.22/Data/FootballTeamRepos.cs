using EntityIntro21._01._22.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityIntro21._01._22.Data
{
    class FootballTeamRepos
    {
        public static void SearchForName(string name)
        {
            using (AppDbContext context = new AppDbContext())
            {
                FootballTeam team = context.FootballTeam.Where(u => u.Name == name).FirstOrDefault();
                if (team != null)
                {
                    Console.WriteLine($"Name: {team.Name}\nCity: {team.City}\nWin: {team.Win}\nLoss: {team.Loss}\nGoalsScored: {team.GoalsScored}\nGoalsConceded: {team.GoalsConceded}");
                    Console.WriteLine(new string('_', 30));
                }
                else
                {
                    Console.WriteLine($"Team with name: {name} not found.");
                }
            }
        }

        public static void SearchForCity(string city)
        {
            using (AppDbContext context = new AppDbContext())
            {
                FootballTeam team = context.FootballTeam.Where(u => u.City == city).FirstOrDefault();
                if (team != null)
                {
                    Console.WriteLine($"Name: {team.Name}\nCity: {team.City}\nWin: {team.Win}\nLoss: {team.Loss}\nGoalsScored: {team.GoalsScored}\nGoalsConceded: {team.GoalsConceded}");
                    Console.WriteLine(new string('_', 30));
                }
                else
                {
                    Console.WriteLine($"Team with city: {city} not found.");
                }
            }
        }

        public static void SearchForCityAndName(string city,string name)
        {
            using (AppDbContext context = new AppDbContext())
            {
                FootballTeam team = context.FootballTeam.Where(u => u.City == city && u.Name == name).FirstOrDefault();
                if (team != null)
                {
                    Console.WriteLine($"Name: {team.Name}\nCity: {team.City}\nWin: {team.Win}\nLoss: {team.Loss}\nGoalsScored: {team.GoalsScored}\nGoalsConceded: {team.GoalsConceded}");
                    Console.WriteLine(new string('_', 30));
                }
                else
                {
                    Console.WriteLine($"Team with city: {city} and name {name} not found.");
                }
            }
        }
        //===============================2============================

        public static void SearchForMaxWin()
        {
            using (AppDbContext context = new AppDbContext())

            {
                FootballTeam team = context.FootballTeam.OrderByDescending(x => x.Win).FirstOrDefault();
                if (team != null)
                {
                    Console.WriteLine($"Name: {team.Name}\nCity: {team.City}\nWin: {team.Win}\nLoss: {team.Loss}\nGoalsScored: {team.GoalsScored}\nGoalsConceded: {team.GoalsConceded}");
                    Console.WriteLine(new string('_', 30));
                }
                else
                {
                    Console.WriteLine($"Team not found.");
                }
            }
        }

        public static void SearchForMinWin()
        {
            using (AppDbContext context = new AppDbContext())

            {
                FootballTeam team = context.FootballTeam.Where(x=> x.Loss == context.FootballTeam.Max(x => x.Loss)).FirstOrDefault();
                if (team != null)
                {
                    Console.WriteLine($"Name: {team.Name}\nCity: {team.City}\nWin: {team.Win}\nLoss: {team.Loss}\nGoalsScored: {team.GoalsScored}\nGoalsConceded: {team.GoalsConceded}");
                    Console.WriteLine(new string('_', 30));
                }
                else
                {
                    Console.WriteLine($"Team not found.");
                }
            }
        }
        public static void SearchForMaxGoalsScored()
        {
            using (AppDbContext context = new AppDbContext())

            {
                FootballTeam team = context.FootballTeam.Where(x => x.GoalsScored == context.FootballTeam.Max(x => x.GoalsScored)).FirstOrDefault();
                if (team != null)
                {
                    Console.WriteLine($"Name: {team.Name}\nCity: {team.City}\nWin: {team.Win}\nLoss: {team.Loss}\nGoalsScored: {team.GoalsScored}\nGoalsConceded: {team.GoalsConceded}");
                    Console.WriteLine(new string('_', 30));
                }
                else
                {
                    Console.WriteLine($"Team not found.");
                }
            }
        }
        public static void SearchForMaxGoalsConceded()
        {
            using (AppDbContext context = new AppDbContext())

            {
                FootballTeam team = context.FootballTeam.Where(x => x.GoalsConceded == context.FootballTeam.Max(x => x.GoalsConceded)).FirstOrDefault();
                if (team != null)
                {
                    Console.WriteLine($"Name: {team.Name}\nCity: {team.City}\nWin: {team.Win}\nLoss: {team.Loss}\nGoalsScored: {team.GoalsScored}\nGoalsConceded: {team.GoalsConceded}");
                    Console.WriteLine(new string('_', 30));
                }
                else
                {
                    Console.WriteLine($"Team not found.");
                }
            }
        }
        public static void Print()
        {
            using (AppDbContext context = new AppDbContext())
            {
                var Teams = context.FootballTeam.ToList();
                foreach (FootballTeam team in Teams)
                {
                    Console.WriteLine($"Name: {team.Name}\nCity: {team.City}\nWin: {team.Win}\nLoss: {team.Loss}\nGoalsScored: {team.GoalsScored}\nGoalsConceded: {team.GoalsConceded}");
                    Console.WriteLine(new string('_', 30));
                }
            }
        }
        //=======================3==========================
        public static void AddTeam(string name, string city, short win, short loss, short goalsScored, short goalsConceded)
        {
            using (AppDbContext context = new AppDbContext())
            {
                FootballTeam Team = new FootballTeam
                {
                    Name = name,
                    City = city,
                    Win = win,
                    Loss = loss,
                    GoalsScored = goalsScored,
                    GoalsConceded = goalsConceded
                };
                context.FootballTeam.Add(Team);
                context.SaveChanges();
            }
        }

        public static void UpdateTeam(int id, string name, string city, short win, short loss, short goalsScored, short goalsConceded)
        {
            using (AppDbContext context = new AppDbContext())
            {
                FootballTeam team = context.FootballTeam.Where(u => u.Id == id).FirstOrDefault();
                if (team != null)
                {
                    team.Name = name;
                    team.City = city;
                    team.Win = win;
                    team.Loss = loss;
                    team.GoalsScored=goalsScored;
                    team.GoalsConceded=goalsConceded;
                    context.SaveChanges();
                }
                else
                {
                    Console.WriteLine($"User with id {id} not found.");
                }
            }
        }

        public static void DeleteTeam(int id)
        {
            using (AppDbContext context = new AppDbContext())
            {
                FootballTeam user = context.FootballTeam.Where(u => u.Id == id).FirstOrDefault();
                if (user != null)
                {
                    context.FootballTeam.Remove(user);
                    context.SaveChanges();
                }
                else
                {
                    Console.WriteLine($"User with id {id} not found.");
                }
            }
            }
        }
}
