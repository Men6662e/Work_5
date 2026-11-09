class Person
{
	public string name = "Неизвестный";
	public int age;
	public Person()
	{
		Console.WriteLine("Создание объекта Person");
		name = "Tom";
		age = 18;
	}
	public void Print()
	{
		Console.WriteLine($"Имя: {name}, Возраст: {age}");
    }
}