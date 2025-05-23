Console.WriteLine("--- Manteiga ou Margarina? ---\n");

Console.Write("Digite o preço da Manteiga (R$).....: ");
decimal Manteiga = Convert.ToDecimal(Console.ReadLine());

Console.Write("Digite o preço da Margarina (R$)...: ");
decimal Margarina = Convert.ToDecimal(Console.ReadLine());

string recomendacao;

if (ComprarAMargarina(Manteiga, Margarina))
{
    recomendacao = "Margarina";
}
else
{
    recomendacao = "Manteiga";
}

bool ComprarAMargarina(decimal manteiga, decimal margarina)
{
    throw new NotImplementedException();
}

double razao = RazaoMargarinaManteiga(Manteiga, Margarina) * 100;

int RazaoMargarinaManteiga(decimal manteiga, decimal margarina)
{
    throw new NotImplementedException();
}

Console.WriteLine($"\nO preço da Manteiga corresponde a {razao:N1}% do preço da Margarina.");
Console.WriteLine($"\nRecomendação: Compre a {recomendacao.ToUpper()}.");

double RazaoManteigaMargarina(decimal precoManteiga, decimal precoMargarina)
{
    return Convert.ToDouble(precoManteiga / precoMargarina);
}

bool ComprarAManteiga(decimal precoManteiga, decimal precoMargarina)
{
    const double MinRazaoCompraMargarina = 0.73;
    return RazaoManteigaMargarina(precoManteiga, precoMargarina) >= MinRazaoCompraMargarina;
}