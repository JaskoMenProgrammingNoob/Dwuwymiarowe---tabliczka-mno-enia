class Program
{
    static void Main(string[] args)
    {
        int n = 10;
        double sredniaP = 0;
        double sredniaNP = 0;
        double sredniaPWszystkich = 0;
        double sredniaNPWszystkich = 0;
        int sumaNp = 0;
        int sumaP= 0;
        int sumaPW = 0;
        int sumaNPW = 0;
        int sumaOgolna = 0;
        int[,] tabliczka = new int[11, 11];
        
        

        for (int i =1; i <= n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                
                tabliczka[i, j] = i * j;
                Console.WriteLine($"{i} * {j} = {tabliczka[i,j]}");
                if (tabliczka[i,j] % 2 != 0)
                {
                    sumaNp += tabliczka[i, j];
                    sredniaNP = tabliczka[i, j] / 25;
                    sredniaNPWszystkich = tabliczka[i, j] / 125;
                    sumaNPW += i + j;

                } else
                {
                   sumaP += tabliczka[i, j];
                    sredniaP = tabliczka[i, j] / 75;
                    sredniaPWszystkich = tabliczka[i, j] / 175;
                    sumaPW = i + j;
                }
            }
            Console.WriteLine();
            

        }
        sumaOgolna = sumaP + sumaNp;
        Console.WriteLine($"Suma liczb parzystych: {sumaP}");
        Console.WriteLine($"Suma liczb nieparzystych: {sumaNp}");
        Console.WriteLine($"Średnia liczb parzystych: {sredniaP}");
        Console.WriteLine($"Średnia liczb nieparzystych: {sredniaNP}");
        Console.WriteLine($"Średnia wszsytkich liczb nieparzystych: {sredniaNPWszystkich}");
        Console.WriteLine($"Średnia wszystkich liczb parzystych: {sredniaPWszystkich}");
        Console.WriteLine($"Suma indeksów liczb nieparzystych: {sumaNPW}");
        Console.WriteLine($"Suma indeksów liczb parzystych: {sumaPW}");
        Console.WriteLine($"Suma wszystkich liczb: {sumaOgolna}");
    }





}