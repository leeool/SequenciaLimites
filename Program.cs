int n1, n2, sequencia;

Console.Write("Digite o primeiro numero: ");
n1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o segundo numero: ");
n2 = Convert.ToInt32(Console.ReadLine());

sequencia = n1;

while (sequencia != n2){
    sequencia = n1++;
    Console.Write($"{n1-1} ");
}

Console.Write("\n");