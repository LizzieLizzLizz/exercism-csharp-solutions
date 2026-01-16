# Meu Diário de Aprendizado: Lasagna

**Data:** 15/01/2026
**Conceitos Praticados:** Métodos básicos, retorno de valores, constantes.
**Dificuldade Percebida:** 🟢 Fácil (mas ótimo para fixar a sintaxe!)
**Link para o Exercício:** [Lasagna no Exercism](https://exercism.org/tracks/csharp/exercises/lasagna)

## 🧠 O Que Aprendi Neste Exercício

Este foi meu **primeiro exercício de lógica** no Exercism! Aprendi na prática:
1.  Como **estruturar um método** em C#: `public static int NomeDoMetodo() { ... }`.
2.  O uso de **constantes** (`ExpectedMinutesInOven`) para valores que não mudam.
3.  Como fazer métodos **conversarem entre si** (um método usar o valor retornado por outro).

**"Ahá!" Moment:** Percebi que na programação, muitas vezes a gente quebra uma tarefa grande (fazer uma lasanha) em funções pequenas e específicas (tempo no forno, tempo de preparo). Isso se chama **decomposição de problemas** e é a base de tudo!

## ⚙️ Minha Solução e Decisões

```csharp
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

}
