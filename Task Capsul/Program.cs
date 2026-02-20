namespace Task_Capsul
{
    internal class Program
    {
        static void Main(string[] args)
        {
			Notebook myLaptop = new Notebook("Acer Nitro", 1, 1850.5, 16);
			myLaptop.Description = "Gaming laptop";
			myLaptop.Storage = 512;

			myLaptop.Sale();
			myLaptop.ShowFullData();

			Console.ReadLine();



		}
	}
	public class Product
	{
		public string? Name;
		public string? Description;
		public int Count;
		public bool IsStock;
		private double _price;

		public double Price
		{
			get { return _price; }
			set { if (value >= 0) _price = value; }
		}

		public void Sale()
		{
			if (Count > 0)
			{
				Count--;
				IsStock = Count > 0;
				Console.WriteLine("Satış uğurla başa çatdı.");
			}
			else
			{
				IsStock = false;
				Console.WriteLine("Məhsul yoxdur!");
			}
		}
	}

	public class Notebook : Product
	{
		private byte _ram;
		public int Storage;

		public byte RAM
		{
			get { return _ram; }
			set { if (value > 0) _ram = value; }
		}

		public Notebook(string name, int count, double price, byte ram)
		{
			Name = name;
			Count = count;
			Price = price;
			RAM = ram;
			IsStock = count > 0;
		}

		public string GetFullInfo()
		{
			return $"Ad: {Name}, RAM: {RAM}GB, Qiymət: {Price}, Say: {Count}";
		}

		public void ShowFullData()
		{
			Console.WriteLine(GetFullInfo());
		}
	}


}
