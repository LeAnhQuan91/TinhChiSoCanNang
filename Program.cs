using System.Runtime.Intrinsics.X86;

internal class Program
{
    static void Main(string[] args)
    {
        double weight;
        double height;

        Console.WriteLine("Moi ban nhap ten cua minh: ");
        string YourName = Console.ReadLine();
        Console.WriteLine($"Xin chao {YourName}");

        Console.WriteLine("Moi ban nhap so can nang cua minh: ");
        weight = double.Parse(Console.ReadLine());
        Console.WriteLine("Moi ban nhap chieu cao cua minh: ");
        height = double.Parse(Console.ReadLine());

       double Bmi = weight/(height*height);

       Console.WriteLine("BMI cua ban la: " + Bmi);

       if(Bmi <18.5)
       {
        Console.WriteLine("Underweight");
       }
       else if(Bmi>=18.5 && Bmi <=25)
       {
        Console.WriteLine("Normal");
       }
       else if (Bmi >= 25 && Bmi <= 30)
       {
        Console.WriteLine("OverWeight");
       }
       else if (Bmi >= 30)
       {
        Console.WriteLine("Obese");
       }



    }
}