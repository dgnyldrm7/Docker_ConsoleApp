for (int i = 0; i < 5; i++)
{
	for(int j = 0; j< i + 1; j++)
	{
		Console.Write("* ");
		Thread.Sleep(30000);
	}
	Console.WriteLine(" ");
}
Console.Read();