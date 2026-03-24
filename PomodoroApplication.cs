int contPomodoro = 1;

void CiclosPomodoro()
{

    while (contPomodoro <= 4)
    {

        Console.WriteLine($"\nIniciando contagem do {contPomodoro}º pomodoro");

        for (int i = 1500000; i > 0; i--)
        {
            int min = i / 60000;
            int sec = i % 60;
            Console.Write($"\rSeu tempo: {min}:{sec}");
            Thread.Sleep(1000);
        }

        Console.WriteLine("\nAgora, sua pausa de 5 minutos, estarei cronometrando para você!");
        for (long i = 300000; i > 0; i--)
        {
            long min = i / 60000;
            long sec = i % 60;
            Console.Write($"\rSeu tempo: {min}:{sec}");
            Thread.Sleep(1000);
        }
        contPomodoro++;
    }
}

Console.WriteLine($"\nChegamos ao fim do seu {contPomodoro}º neste momento, é recomendado que você faça uma pausa maior, de 15-30 minutos");
Console.WriteLine($"Vamos iniciar o seu timer minutos, poderá retomar ao ciclo de pomodoros em no mínimo 15 minutos");
for (long i = 1800000; i > 0; i--)
{
    long min = i / 60000;
    long sec = i % 60;
    Console.Write($"\rSeu tempo: {min}:{sec}");
    Thread.Sleep(1000);
}
Console.WriteLine("\nIniciando novo ciclo!");
CiclosPomodoro();