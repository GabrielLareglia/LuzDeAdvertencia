string entradaT, entradaP, entradaR;
bool sensorT, sensorP, sensorR, luzAdvertenciaW;

Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("Simulador de Luz de Advertência");
Console.ResetColor();
Console.WriteLine();


Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("Digite: [A]tivado, [D]esativado");
Console.ResetColor();
Console.WriteLine();


Console.Write("Sensor de temperatura...: ");
entradaT = Console.ReadLine()!.Trim().Substring(0, 1).ToUpper();

if (entradaT != "A" && entradaT != "D")
{
    Console.WriteLine("Valor inválido.");
    return;
}
sensorT = entradaT == "A";

Console.Write("Sensor de pressão: ");
entradaP = Console.ReadLine()!.Trim().Substring(0, 1).ToUpper();

if (entradaP != "A" && entradaP != "D")
{
    Console.WriteLine("Valor inválido.");
    return;
}
sensorP = entradaP == "A";

Console.Write("Sensor de rotação: ");
entradaR = Console.ReadLine()!.Trim().Substring(0, 1).ToUpper();

if (entradaR != "A" && entradaR != "D")
{
    Console.WriteLine("Valor inválido.");
    return;
}
sensorR = entradaR == "A";

luzAdvertenciaW = sensorT && (sensorP || !sensorR);

Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine($"\nA luz de advertência estará {(luzAdvertenciaW ? "ATIVADA" : "DESATIVADA")}.");