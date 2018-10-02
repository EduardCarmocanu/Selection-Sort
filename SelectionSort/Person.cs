using System;
using System.Collections.Generic;
using System.Text;

namespace SelectionSort
{
	class Person
	{
		public string FirstName;
		public string LastName;
		public string Gender;
		public string HomeTown;
		public string BirthDate;

		public Person()
		{
			this.FirstName = Ask("First Name: ");
			this.LastName = Ask("Last Name: ");
			this.Gender = Ask("Gender(m/f): ");
			this.HomeTown = Ask("Home Town: ");
			this.BirthDate = Ask("Birth date: ");
		}

		public string Ask(string question)
		{
			Console.Write(question);
			return Console.ReadLine();
		}

		

	}
}
