int qtdlinha = 3, qtdcoluna = 3, diagonal = 0, soma_linha = 0,soma_coluna = 0;
int[,] matriz = new int[qtdlinha, qtdcoluna];
for (int linha = 0; linha < qtdlinha; linha++)
{
    for (int coluna = 0; coluna < qtdcoluna; coluna++)
    {
        matriz[linha, coluna] = new Random().Next(1, 11);

    }
}
for (int linha = 0; linha < qtdlinha; linha++)
{
    for (int coluna = 0; coluna < qtdcoluna; coluna++)
    {
        Console.Write(matriz[linha,coluna] + " ");


    }
    Console.WriteLine();
}

for (int linha = 0; linha < qtdlinha; linha++)
{
    soma_coluna = 0;
    for (int coluna = 0; coluna < qtdcoluna; coluna++)
    {
     soma_coluna += matriz[linha, coluna];
    }
                Console.WriteLine($"Linha {linha} soma = {soma_coluna}");
    }

for (int coluna = 0; coluna < qtdcoluna; coluna++) { 
    soma_linha = 0;
    for (int linha = 0; linha < qtdlinha; linha++)
    {
        soma_linha += matriz[linha, coluna];
    } Console.WriteLine($"coluna {coluna} soma = " + soma_linha);
}
for (int linha = 0; linha < qtdlinha; linha++)
{
    for (int coluna = 0; coluna < qtdcoluna; coluna++)
    {
        if (coluna == linha)
        {
            diagonal += matriz[linha, coluna];
            continue;
        }
    }
}
        Console.WriteLine("Diagonal soma = " + diagonal);
diagonal = 0;
for (int linha = 0; linha < qtdlinha; linha++)
{
    for (int coluna = 0; coluna <qtdcoluna; coluna++)
    {
        if (linha + coluna ==  qtdlinha - 1)
        {
            diagonal += matriz[linha, coluna];
            continue;
        }
    }
}
        Console.WriteLine("Diagonal soma = " + diagonal);