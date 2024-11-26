using Ex_6___Animal;

Gato gato1 = new Gato
{
   Especie = "Maine Coon"

};

Porco porco1 = new Porco
{
    Especie = "Javali"

};

Capivara capi1 = new Capivara
{
    Especie = "Hydrochoerus hydrochaeris"

};

gato1.EmitirSom();
porco1.EmitirSom();
capi1.EmitirSom();

Console.WriteLine($"A especie do gato é {gato1.Especie}, do porco é {porco1.Especie}, e da capivara é {capi1.Especie} ");
Console.ReadKey();