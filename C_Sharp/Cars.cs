using System;
using System.Collections.Generic;
using System.Collections;

namespace Cars
{
	public class Car:IComparable<Car>
	{
		private Radio myRadio=new Radio(); // радиоприемник в автомобиле
		bool CarIsDead;
		public void TurnOnRadio(bool onOff){
			myRadio.Power(onOff);
		}
        public Car(string name,short speed):this()
        {
            PetName = name;
            CurrentSpeed = speed;
        }
		public Car(string name, short maxspeed,short currspeed):this(name,currspeed){
			MaxSpeed=maxspeed;
		}	
		public Car(){
			PetName="Chuck";
			CurrentSpeed=10;
            CarID = 0;
		}
		
		//Свойства
		public string PetName{get;set;} //Имя машины
		public int CurrentSpeed{get;set;}//Текущая скорость
        public int MaxSpeed { get; set; }
		public string Color{get;set;} //Цвет машины
        public int CarID { get; set; } //ID машины
        public string Make { get; set; }

        //DELEGATES AND EVENTS
        public delegate void CarEngineHandler(object sender,CarEventArgs e);
        public event CarEngineHandler Exploded;
        public event CarEngineHandler AboutToBlow;

       

        //Методы
        public void printState()
		{
			Console.WriteLine("{0} is going {1} mph.", this.PetName,this.CurrentSpeed);
		}
	public void Accelerate(short delta)
		{
            if (CarIsDead==true && Exploded!=null)
            {
                Exploded(this,new CarEventArgs("Sorry. Car is dead. We called an emergency"));
                return;
            }
            CurrentSpeed += delta;
            if (10 == (MaxSpeed - CurrentSpeed) && AboutToBlow != null) AboutToBlow(this,new CarEventArgs("Carefull buddy - gonna blow!"));
            if (CurrentSpeed > MaxSpeed) CarIsDead = true;
            else Console.WriteLine("Current speed: {0}",CurrentSpeed);
            
		}
    public int CompareTo(Car obj)
        {
            return this.CarID.CompareTo(obj.CarID);
        }
    }
    public class CarEventArgs : EventArgs
    {
        public readonly string msg;
        public CarEventArgs(string message)
        {
            msg = message;
        }
    }
	public class CarIsDeadException:ApplicationException{
		string messageDetails=string.Empty;
		public  DateTime ErrorTimeStamp{get;set;}
		public string CauseOfError{get;set;}
		
		public CarIsDeadException(){}
		public CarIsDeadException(string messageDetails,  string causeOfError, DateTime errorTimeStamp):base(messageDetails)
		{
			this.ErrorTimeStamp = errorTimeStamp;
			this.CauseOfError = causeOfError;
		}
		
	}
	class Radio
{
	public void Power(bool turnOn)
	{
		Console.WriteLine((turnOn==true)?"Jamming..":"Quiet time..");
	}
}
	class Garage:IEnumerable{
		public int NumberOfCars{get;set;}
		public Car MyAuto { get; set; }
       
        public Garage(){
            carArray[0] = new Car("Rusty", 30);
            carArray[1] = new Car("Clunker", 55);
            carArray[2] = new Car("Zippy", 30);
            carArray[3] = new Car("Fred", 30);
        }
		public Garage(Car car, int nums){
			MyAuto=car;
			NumberOfCars=nums;
		}
        Car[] carArray = new Car[4];

        public IEnumerator GetEnumerator()
        {
            foreach (Car car in carArray) yield return car;
        }

    }

   

}