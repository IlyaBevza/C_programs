using System;

namespace Employees
{
	
	abstract class Employee{
		string empName;
		int empID;
		float currPay;
		int empAge;
		readonly string ssn;
		
		public Employee(string ssn){
			this.ssn=ssn;
		}
		public Employee(string name, string ssn,int id, float cpay,int age){
			Name=name;
			this.ssn=ssn;
			ID=id;
			Pay=cpay;
			Age=age;
		}
		public virtual void GiveBonus(float amount){
			currPay+=amount;
		}
		public virtual void DisplayStatus(){
			Console.WriteLine("Name: {0}",empName);
			Console.WriteLine("ID: {0}",empID);
			Console.WriteLine("Pay: {0}",currPay);
			Console.WriteLine("Age: {0}",empAge);
			Console.WriteLine("SSN is {0}", ssn);
		}
		//свойства
		public string Name{
			get{return empName;}
			set{
				if(value.Length>15||value.Length<2)
				Console.WriteLine("Ошибка. В иммени должно быть от двух до 15 символов.");
			else empName=value;
			
			}
		}
		public int ID{
			get{return empID;}
			set{
				empID=value;
			}
			}
		public float Pay{
			get{return currPay;}
			set{currPay=value;}
		}
		public int Age{
			get{return empAge;}
			set{
				if(value<16|| value>65) Console.WriteLine("Неверно указан возраст сотрудника");
				else empAge=value;
			}
			}
		
		}
//	class Manager:Employee{
//		public int StockOptions{get;set;}
//		//public Manager(){}
//	}
	class SalesPerson:Employee{
		public int SalesNumber{get;set;}
		//public SalesPerson(){}
		public SalesPerson(string name, string ssn,int id, float cpay,int age, int salesnumber):
			base( name, ssn, id, cpay, age){
			this.SalesNumber=salesnumber;
		}
		public override void GiveBonus(float amount){
			float bonus;
			if(SalesNumber<80) bonus=1f;
			else if(SalesNumber>=80 && SalesNumber<=100)  bonus=1.1f;
			else if(SalesNumber>100 && SalesNumber<=200)  bonus=1.15f;
			else bonus=1.2f;
			base.GiveBonus(amount*bonus);
		}
		public override void DisplayStatus(){
			base.DisplayStatus();
			Console.WriteLine("Number of sales: {0}",SalesNumber);
		}
		
	}
}