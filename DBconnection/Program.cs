using MySql.Data.MySqlClient;

string cs = @"server=localhost;userid=dbuser;password=s$cret;database=mydb";

using var con = new MySqlConnection(cs);
con.Open();

var stm = "SELECT VERSION()";
var cmd = new MySqlCommand(stm, con);

var version = cmd.ExecuteScalar().ToString();
Console.WriteLine($"MySQL version: {version}");