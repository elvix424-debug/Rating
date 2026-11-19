string[] names = { "Анна", "Борис", "Вера", "Глеб", "Дарья" };
int[] scores = { 78, 92, 85, 60, 92 };

for(int i = 0; i < scores.Length - 1; i++)
{
    for (int j = 0; j < scores.Length - i - 1; j++)
    {
        if (scores[j] < scores[j + 1])
        {
            int tempScore = scores[j];
            scores[j] = scores[j + 1];
            scores[j + 1] = tempScore;

            string tempName = names[j];
            names[j] = names[j + 1];
            names[j + 1] = tempName;
        }
    }
}

for(int i = 0; i < names.Length; i++)
{
    Console.WriteLine($"{i + 1}. {names[i]} - {scores[i]}");
}