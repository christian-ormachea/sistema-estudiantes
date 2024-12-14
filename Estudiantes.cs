using System.Runtime.CompilerServices;

class Estudiante {
    private string NombreEstudiante { get; set; }
    private int edad;
    public List<int> Notas { get; private set; }


    public Estudiante(string nombreDelEstudiante, int edadDelEstudiante){
        NombreEstudiante = nombreDelEstudiante;
        edad = edadDelEstudiante;
        Notas = new List<int>();
    }

    public void AgregarNota(int unaNota){
        Notas.Add(unaNota);
    }

     public decimal Promedio(){
        return Notas.Count > 0 ? (decimal)Notas.Sum() / Notas.Count : 0;
    }

    public int Edad(){
        return edad;
    }

    public string Nombre(){
        return NombreEstudiante;
    }
}