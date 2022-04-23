using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Assessment1.Model;

namespace Assessment1.DAL
{
    public class FootballLeagueDAL
    {
       public List<FootballLeagueModel> GetWinTeamNames()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["fCon"].ConnectionString);
            string query = "select distinct WinningTeam from FootballLeague where WinningTeam is not null;";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            List<FootballLeagueModel> list = new List<FootballLeagueModel>();
            while (reader.Read())
            {
                FootballLeagueModel fite = new FootballLeagueModel();
                //fite.MatchId = (int)reader[0];
                //fite.Id = reader[0].ToString();
                //fite.TeamName1 = reader[1].ToString();
                //fite.TeamName2 = reader[2].ToString();
                //fite.MatchStatus = reader[3].ToString();
                fite.WinningTeam = reader[0].ToString();
                //fite.Points =(int)reader[5];
                list.Add(fite);
            }
            con.Close();
            return list;
        }
        public List<FootballLeagueModel> GetJapanMatches()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["fCon"].ConnectionString);
            string query = "select * from FootballLeague where TeamName1 = 'Japan' or TeamName2='Japan'";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            List<FootballLeagueModel> list = new List<FootballLeagueModel>();
            while (reader.Read())
            {
                FootballLeagueModel fite = new FootballLeagueModel();
                fite.MatchId = (int)reader[0];
                //fite.Id = reader[0].ToString();
                fite.TeamName1 = reader[1].ToString();
                fite.TeamName2 = reader[2].ToString();
                fite.MatchStatus = reader[3].ToString();
                fite.WinningTeam = reader[4].ToString();
                fite.Points =(int)reader[5];
                list.Add(fite);
            }
            con.Close();
            return list;

        }

    }
}
