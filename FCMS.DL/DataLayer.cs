using System.Data.SqlClient;

namespace FCMS.DL
{
    public class DataLayer
    {
        static string connectionString
            = "Data Source =.; Initial Catalog = FCMSDATA; Integrated Security = True;";
        static SqlConnection sqlConnection = new SqlConnection(connectionString);

        static public bool Username(string Username)
        {
            var selectStatement = "SELECT Username FROM Login WHERE Username = @Username";
            SqlCommand selectCommand = new SqlCommand(selectStatement, sqlConnection);
            selectCommand.Parameters.AddWithValue("@Username", Username);
            sqlConnection.Open();
            SqlDataReader reader = selectCommand.ExecuteReader();
            var isExists = reader.Read();
            sqlConnection.Close();
            return isExists;
        }
        static public bool Password(string Password)
        {
            var selectStatement = "SELECT Password FROM Login WHERE Password = @Password";
            SqlCommand selectCommand = new SqlCommand(selectStatement, sqlConnection);
            selectCommand.Parameters.AddWithValue("@Password", Password);
            sqlConnection.Open();
            SqlDataReader reader = selectCommand.ExecuteReader();
            var isExists = reader.Read();
            sqlConnection.Close();
            return isExists;
        }
        static public bool ID(string ID)
        {
            var selectStatement = "SELECT ID FROM Login WHERE ID = @ID";
            SqlCommand selectCommand = new SqlCommand(selectStatement, sqlConnection);
            selectCommand.Parameters.AddWithValue("@ID", ID);
            sqlConnection.Open();
            SqlDataReader reader = selectCommand.ExecuteReader();
            var isExists = reader.Read();
            sqlConnection.Close();
            return isExists;
        }
    }
}