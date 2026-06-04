namespace TP03_Martinez_Loufer.Models;

public class PalabrasAhorcado{
    private List<string> palabras;

    public PalabrasAhorcado(){
        palabras = new List<string>(){"petricor", "ataraxia", "megalovania", "arrebol", "melifluo", "afrodita", "resiliencia", "yacimiento", "nihilismo", "ferviente"};
    }
    public string obtenerPalabra(){
        Random rnd = new Random();
        return palabras[rnd.Next(0, 9)];
    }
}