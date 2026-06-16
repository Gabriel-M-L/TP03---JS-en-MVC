namespace TP03_Martinez_Loufer.Models;

public class PalabrasAhorcado{
    private List<string> palabras;

    public PalabrasAhorcado(){
        BD bd = new BD();
        palabras = bd.traerPalabras();
    }
    public string obtenerPalabra(){
        Random rnd = new Random();
        return palabras[rnd.Next(0, palabras.Count)];
    }
}