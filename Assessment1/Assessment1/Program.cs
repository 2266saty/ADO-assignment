using Assessment1.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment1
{
  public class Program
    {
        public static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("\nMenu\n1. View Winning Teams\n2. View Japan Matches");
                Console.Write("\nEnter Your Choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                switch (choice)
                {
                    case 1:
                        {
                            ViewWinTeams();
                            break;
                        }
                    case 2:
                        {
                            ViewJapanMatches();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid Choice.Please Enter a Valid Choice");
                            break;
                        }
                }

            }
        }
        public static void ViewWinTeams()
        {
            FootballLeagueDAL footballDalObject = new FootballLeagueDAL();

            var matchData = footballDalObject.GetWinTeamNames();

           
                Console.WriteLine("{0,-20}", "Winning Team");

                foreach (var item in matchData)
                {
                    Console.WriteLine("{0,-20}",  item.WinningTeam);
                }
            

        }

        public static void ViewJapanMatches()
        {
            FootballLeagueDAL footballDalObject = new FootballLeagueDAL();

            var matchData = footballDalObject.GetJapanMatches();

            //if (matchData == null || matchData.Count == 0)
            //{
            //    Console.WriteLine(" No Records Found");
            //}
            //else if (matchData.Count > 0)
            //{
                Console.WriteLine("{0,-20}{1,-20}{2,-20}{3,-20}{4,-20}{5,-20}","MatchId","TeamName1","TeamName2","MatchStatus", "Winning Team","Points");

                foreach (var item in matchData)
                {
                    Console.WriteLine("{0,-20}{1,-20}{2,-20}{3,-20}{4,-20}{5,-20}", item.MatchId, item.TeamName1, item.TeamName2, item.MatchStatus, item.WinningTeam, item.Points);
                }
            

        }
  
    }
}
