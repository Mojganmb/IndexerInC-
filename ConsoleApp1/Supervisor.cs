using System.Linq;

namespace ConsoleApp1
{
	public sealed class Supervisor
	{
		private Supervisor()
		{
		}

		private static Supervisor _instance;
		public static Supervisor Instance
		{
			get
			{
				if (_instance == null)
				{
					_instance = new Supervisor();
				}

				return (_instance);
			}
		}

		public static Supervisor GetInstance()
		{
			if (_instance == null)
			{
				_instance = new Supervisor();
			}

			return (_instance);
		}

		public void ShowInfo()
		{
			System.Console.WriteLine($"Age: {Age}");
			System.Console.WriteLine($"Name: {Name}");
			if (AccessList != null && AccessList.Count() > 0)
			{
				System.Console.WriteLine($"Access List:");
				foreach (string accessItem in AccessList)
				{
					System.Console.WriteLine(accessItem);
				}
			}
		}

		public string Name { get; set; }

		public int Age { get; set; }

		public string[] AccessList { get; set; }
	}
}
