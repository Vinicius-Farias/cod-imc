public class CalcularImc 
{

    public string nome { get; set; }
    public float[] imc { get; set; }

}

class Program
{
    static void Main()
    {

        CalcularImc[] ResImc = new CalcularImc[5];

        ResImc[0] = new CalcularImc{
            nome = "abaixo do peso",
            imc = new float[] {18.5f, 19}
        };
         ResImc[1] = new CalcularImc{
            nome = "peso ideal",
            imc = new float[] {20, 25}
        };
         ResImc[2] = new CalcularImc{
            nome = "sobrepeso",
            imc = new float[] {25, 30}
        };
         ResImc[3] = new CalcularImc{
            nome = "obesidade",
            imc = new float[] {30, 40}
        };
         ResImc[4] = new CalcularImc{
            nome = "obesidade morbida",
            imc = new float[] {40, 200}
        };




        Console.WriteLine("Calcular o IMC:");

        Console.Write("Digite sua altura: ");
        float altura = float.Parse(Console.ReadLine());

        Console.Write("Digite seu peso: ");
        float peso = float.Parse(Console.ReadLine());

        float CalImc = peso / (altura * altura);

        foreach (CalcularImc res in ResImc) {
            if (CalImc >= res.imc[0] & CalImc < res.imc[1]){
                Console.WriteLine($"Seu IMC é: {CalImc} cituação: {res.nome} ");
            }
        }


    }
}
