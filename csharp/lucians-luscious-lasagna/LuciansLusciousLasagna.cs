class Lasagna
{
// 1. Definir o tempo esperado de forno (40 minutos)
    public int ExpectedMinutesInOven()
    {
        return 40;
    }

    // 2. Calcular o tempo restante (Tempo esperado - tempo que já passou)
    public int RemainingMinutesInOven(int actualMinutes)
    {
        return ExpectedMinutesInOven() - actualMinutes;
    }

    // 3. Calcular tempo de preparo (2 minutos por camada)
    public int PreparationTimeInMinutes(int layers)
    {
        return layers * 2;
    }

    // 4. Calcular tempo total gasto (Preparo + tempo de forno atual)
    public int ElapsedTimeInMinutes(int layers, int actualMinutes)
    {
        return PreparationTimeInMinutes(layers) + actualMinutes;
    }
}
