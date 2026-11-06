System.Console.WriteLine("Меню");

string menuChoice;
do {
    System.Console.WriteLine("1 - Проанализировать предложение");
    System.Console.WriteLine("2 - Найти позицию первой заглавной буквы");
    System.Console.WriteLine("0 - Выход");
    menuChoice = System.Console.ReadLine();

    switch (menuChoice) {
        case "1":
            System.Console.WriteLine("\nВведите предложение: ");
            string predlojenie = System.Console.ReadLine();
            int glasnieCount = 0;
            int soglasCount = 0;
            int spaceCount = 0;
            string proverka = "аеёиоуыэюяАЕЁИОУЫЭЮЯaeiouyAEIOUY";

            foreach (char letter in predlojenie)
            {
                if (letter == ' ')
                {
                    spaceCount++;
                    continue; 
                }

                if (char.IsLetter(letter))
                {
                    if (proverka.Contains(letter))
                    {
                        glasnieCount++;
                    }
                    else
                    {
                        soglasCount++;
                    }
                }
            }

            System.Console.WriteLine($"Всего символов: {predlojenie.Length}");
            System.Console.WriteLine($"Гласных: {glasnieCount}");
            System.Console.WriteLine($"Согласных: {soglasCount}");
            System.Console.WriteLine($"Пробелов: {spaceCount}");
            break;
        case "2":
                    
            System.Console.Write("\nВведите предложение: ");
            string stroka = System.Console.ReadLine();
                    
            int indexer = -1;

            for (int i = 0; i < stroka.Length; i++)
            {
                        
                if (char.IsLetter(stroka[i]) && char.IsUpper(stroka[i]))
                {
                    indexer = i; 
                    break;            
                }
            }

            if (indexer != -1)
            {
                System.Console.WriteLine($"Позиция первой заглавной буквы: {indexer}");
            }
            else
            {
            System.Console.WriteLine("Заглавных букв нет.");
            }
            break;    
        case "0":
            System.Console.WriteLine("До свидания!");
            break;    
        default:
            System.Console.WriteLine("Выберите другой пункт");
            break;    
    }
} while (menuChoice != "0");
