double conAparelho, hrUsoDia, CusEnergia, Estimado;

Console.Write("Digite o Consumo em kWh/mês: ");
conAparelho = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Horas de uso por dia: ");
hrUsoDia = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Custo de energia em R$/kWh");
CusEnergia = Convert.ToDouble(Console.ReadLine());

Estimado = conAparelho * hrUsoDia * CusEnergia;

Console.Clear();
Console.WriteLine("--- Custo de Energia ---");
Console.WriteLine($"Consumo do aparelho (em kWh/mês)...: {conAparelho}");
Console.WriteLine($"Horas de uso por dia...............: {hrUsoDia}");
Console.WriteLine($"Custo da energia (em R$/kWh).......: {CusEnergia}");
Console.WriteLine($"Custo estimado: R${Estimado:N6}");