using System;

namespace OOPSuperHeroes
{
    class Program
    {
        class Player
        {
            string name;
            int HP;

            public Player(string _name)
            {
                name = _name;
                Random rnd = new Random();
                HP = rnd.Next(100, 151);
            }

            public void SayHello()
            {
                Console.WriteLine($"{name} says Hello!");
            }

            public void ShowYourHP()
            {
                Console.WriteLine($"{name}S HP: {HP}");
            }

            public int MakeDamage()
            {
                Random rnd = new Random();
                return rnd.Next(10, 51);
            }

            public void TakeDamage(int damage)
            {
                if(HP <= 0)
                {
                    HP = 0;
                }
                else
                {
                    HP = HP - damage;
                }
            }

            public int hp
            {
                get { return HP; }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Name your first character: ");
            string characterName1 = Console.ReadLine();
            Console.WriteLine("Name your second character: ");
            string characterName2 = Console.ReadLine();


            Player playerOne = new Player(characterName1);
            Player playerTwo = new Player(characterName2);

            playerOne.SayHello();
            playerOne.ShowYourHP();

            playerTwo.SayHello();
            playerTwo.ShowYourHP();


            for (int i = 0; i < 3; i++)
            {
                playerOne.TakeDamage(playerTwo.MakeDamage());
                playerTwo.TakeDamage(playerOne.MakeDamage());
                playerOne.ShowYourHP();
                playerTwo.ShowYourHP();
            }

            if (playerOne.hp > playerTwo.hp)
            {
                Console.WriteLine($"{characterName1} won!");
            } else if (playerOne.hp < playerTwo.hp)
            {
                Console.WriteLine($"{characterName2} won!");
            }
            else
            {
                Console.WriteLine("Its a tie!");
            }



        }
    }
}
