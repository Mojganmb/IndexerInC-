namespace indexer
{
	public class Person
	{
		public int Age;
		public string FullName;

		public Person(string fullName, int age)
		{
			Age = age;
			FullName = fullName;
		}

		public void ShowInfo()
		{
			System.Console.WriteLine("\n--------------------");
			System.Console.WriteLine("Full Name: {0}", FullName);
			System.Console.WriteLine("Age      : {0}", Age);
			System.Console.WriteLine("--------------------");
		}
	}

	public class Factory
	{
		public int _index;
		public Person[] Persons;

		public Person this[int index]
		{
			get
			{
				return (Persons[index]);
			}
			set
			{
				Persons[index] = value;
			}
		}

		public Factory(int size)
		{
			_index = -1;
			Persons = new Person[size];
		}

		public bool Add(Person person)
		{
			bool blnResult = false;

			if (_index < Persons.Length - 1)
			{
				_index++;
				Persons[_index] = person;

				blnResult = true;
			}

			return (blnResult);
		}

		public void ShowPersons()
		{
			foreach (Person oPerson in Persons)
				oPerson.ShowInfo();
		}
	}

	class MainClass
	{
		static void Main(string[] args)
		{
			Factory oFactory = new Factory(3);

			oFactory.Add(new Person("Ali Ravanbod", 27));
			oFactory.Add(new Person("Bardia Salehi", 22));
			oFactory.Add(new Person("Afshin Sadeghi", 30));
			oFactory.Add(new Person("Hamid Gorji", 32));

			oFactory.Persons[0].ShowInfo();
			oFactory[0].ShowInfo();

			System.Console.ReadLine();
		}
	}
}
