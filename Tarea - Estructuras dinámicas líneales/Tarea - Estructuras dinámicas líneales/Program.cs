using System;

public class PuestoLimonadas
{
    public static bool PuedeDarCambio(int[] billetes)
    {
        int cinco = 0;
        int diez = 0;

        foreach (int billete in billetes)
        {
            if (billete == 5)
            {
                cinco++;
            }
            else if (billete == 10)
            {
                if (cinco == 0)
                {
                    return false;
                }
                cinco--;
                diez++;
            }
            else if (billete == 20)
            {
                if (diez > 0 && cinco > 0)
                {
                    diez--;
                    cinco--;
                }
                else if (cinco >= 3)
                {
                    cinco -= 3;
                }
                else
                {
                    return false;
                }
            }
        }

        return true;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(PuedeDarCambio(new int[] { 5, 5, 5, 10, 20 })); 
        Console.WriteLine(PuedeDarCambio(new int[] { 5, 5, 10, 10, 20 })); 
        Console.WriteLine(PuedeDarCambio(new int[] { 10, 10 }));          
        Console.WriteLine(PuedeDarCambio(new int[] { 5, 5, 10 }));         
    }
}
