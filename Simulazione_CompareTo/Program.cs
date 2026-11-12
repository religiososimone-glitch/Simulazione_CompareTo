string frase1, frase2;
int i = 0;
bool uguaglianza = true;

Console.WriteLine("Inserire la prima stringa");
frase1 = Console.ReadLine();
Console.WriteLine("Inserire la prima stringa");
frase2 = Console.ReadLine();

if(frase1.Length == frase2.Length)
{
    do
    {
        int c1 = frase1[i];
        int c2 = frase2[i];

        if (c1 == c2 || c1 == c2 + 32 || c1 == c2 - 32)
        {
            i++;
        }
        else
        {
            uguaglianza = false;
        }
    }while ( i+1 < frase1.Length  && uguaglianza == true);
    if (i+1 == frase1.Length)
    {
        Console.WriteLine("la parola e' uguale");
    }
    else
    {
        Console.WriteLine("la parola non è uguale");
    }
}
else
{
    Console.WriteLine("la parola non e' uguale");
}



