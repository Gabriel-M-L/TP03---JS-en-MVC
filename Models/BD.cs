using Microsoft.Data.SqlClient;
using Dapper;

namespace TP03_Martinez_Loufer.Models;

public class BD
{
    private string connectionString = @"Server=localhost; DataBase=ahorcado; Integrated Security=True; TrustServerCertificate=True;";

    public List<string> traerPalabras()
    {
        List<string> palabras = new List<string>();
        using(SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = "SELECT palabra FROM palabras";
            palabras = connection.Query<string>(query).ToList();
        }
        return palabras;
    }

    public void agregarPalabra(string palabra)
    {
        string encontrado = "";
        string query = "SELECT palabra FROM palabras WHERE palabra = @palabra";
        using(SqlConnection connection = new SqlConnection(connectionString))
        {
            encontrado = connection.QueryFirstOrDefault<string>(query, new{palabra = palabra});
            if(encontrado == "")
            {
                query = "INSERT INTO Palabras (palabra) Values (@palabra)";
                connection.Execute(query, new {palabra = palabra});
            }
        }
    }
}