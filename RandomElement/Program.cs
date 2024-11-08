string[] snacks = { "sushi", "pizza", "chicken", "asian takeaway" };

Random rand = new Random();

int randomindex = rand.Next(0, snacks.Length);

Console.WriteLine($"Tonight we are going to eat {snacks[randomindex]}.");