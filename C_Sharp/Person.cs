
using System;
using System.Collections;

namespace Persons
{
	public class Person
	{
		//Свойства
		public string FirstName{get;set;}
		public string LastName {get;set;}
		public int Age {get;set;}
		
		//Конструкторы
		public Person(string firstName, string lastName, int age)
		{
			this.FirstName = firstName;
			this.LastName = lastName;
			this.Age = age;
		}
		public Person(){}
		
		//Методы
		public override string ToString(){
			return base.ToString()+String.Format("[Name={0}; LastName={1}; Age={2};]",FirstName,LastName,Age);
		}
		public override bool Equals(object obj)
		{
			return this.ToString()==obj.ToString();
		}		
		public override int GetHashCode()
		{
			int hashCode = 0;
			unchecked {
				if (FirstName != null)
					hashCode += 1000000007 * FirstName.GetHashCode();
				if (LastName != null)
					hashCode += 1000000009 * LastName.GetHashCode();
				hashCode += 1000000021 * Age.GetHashCode();
			}
			return hashCode;
		}

			
	}
    public class PersonCollection : ICloneable
    {
        ArrayList personsArray = new ArrayList();
        public Person this[int index]
        {
            get { return (Person)personsArray[index]; }
            set { personsArray.Insert(index, value); }
        }
        

        public object Clone()
        {
            return  this.MemberwiseClone();
        }
    }
}
