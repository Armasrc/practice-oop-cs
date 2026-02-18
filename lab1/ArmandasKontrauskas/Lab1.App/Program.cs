using System.Security.Cryptography;

Random rnd = new Random();
bool allowChallenge = args.Contains("--challenge");
int max = allowChallenge ? 5 : 4;
int task = rnd.Next(1, max + 1);

if(allowChallenge)
{
    Console.WriteLine("**Vardas Pavardė:** Armandas Kontrauskas");
    Console.WriteLine("**Grupė:** PS-5");
    Console.WriteLine("**Paskaitos data:** 2026-02-11");
    Console.WriteLine("**Random užduotis:** {0}", task);
}


