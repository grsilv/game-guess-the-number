// A game where the challenging player choices a number from 1 to 9, and the player must guess it. 

{
    Console.WriteLine("Player challenging, choose the number from 1 to 9.");
    int chal = int.Parse(Console.ReadLine());

    while ((chal < 1) || (chal > 9))
    {
        Console.WriteLine("Invalid number. Player challenging, choose the number from 1 to 9.");
        chal = int.Parse(Console.ReadLine());
    }

    Console.Clear();

    Console.WriteLine("Player, guess the number from 1 to 9.");
    int play = int.Parse(Console.ReadLine());

    while ((play < 1) || (play > 9))
    {
        Console.WriteLine("Invalid number. Player, guess the number from 1 to 9.");
        play = int.Parse(Console.ReadLine());
    }

    Console.Clear();

    while (play != chal)
    {
        Console.WriteLine("Failed. Try again.");
        play = int.Parse(Console.ReadLine());

        while ((play < 1) || (play > 9))
        {
            Console.WriteLine("Invalid number. Player, guess the number from 1 to 9.");
            play = int.Parse(Console.ReadLine());
        }

    }

    Console.Clear();

    Console.WriteLine("This is the correct number! Congratulations!");
}