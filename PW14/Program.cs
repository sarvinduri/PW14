string text = File.ReadAllText("Input.txt");

int count = 0;

    if (text[0] == 'о')
        count++;
    for (int i = 1; i < text.Length; i++)
    {
        if (text[i] == 'о' && text[i - 1] == ' ')
            count++;
    }
    Console.WriteLine("Количество слов начинающихся на о: " + count);
    Console.ReadKey();