int aux, max = 6;
int[] sorteados = new int[max];

aux = new Random().Next(1, 60);
sorteados[0] = aux;


for (int i = 1; i < 6; i++)
{
    aux = new Random().Next(1, 60);

    for (int j = 0; j < i; j++)
    {
        if (sorteados[j] == aux)
        {
            i--;
            break;
        }
        else
        {
            sorteados[i] = aux;
        }
    }

}

for (int i = 0; i < max; i++)
{
    for (int j = i + 1; j < max; j++)
    {
        if (sorteados[j] < sorteados[i])
        {
            aux = sorteados[i];
            sorteados[i] = sorteados[j];
            sorteados[j] = aux;

        }
    }
}

for (int i = 0; i < max; i++)
    Console.WriteLine("Os numeros da MegaSenna são  " + sorteados[i]);