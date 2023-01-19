// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//dotnet add package Microsoft.Data.SqlClient -> Microsoft.Data.SqlClient;
using Microsoft.Data.SqlClient;

var Connection = new SqlConnection();
Connection.ConnectionString = "server=.;database=master;User id=sa;password=Admin123;TrustServerCertificate=true"; 
                                                                                    //TrustServerCertificate => para que confie en el certificado de seguridad 

Connection.Open();

var Command = Connection.CreateCommand();
Command.CommandText = "Select name from sysdatabases";
var Reader = Command.ExecuteReader();

while(Reader.Read()){
    Console.WriteLine(Reader[0]);
}

Reader.Dispose();
Command.Dispose();
Connection.Dispose();
