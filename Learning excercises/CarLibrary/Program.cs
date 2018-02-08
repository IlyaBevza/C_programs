
using System;

namespace CarLibrary
{
	
	public abstract class Car{
		
		public string PetName {get;set;}
		public int CurrentSpeed {get;set;}
		public int MaxSpeed {get;set;}
		
		protected EngineState engineState=EngineState.engineAlive;
		public EngineState EngineState{
			get {return engineState;}
		  }
		public abstract void TurboBoost();
		
		public Car(){}
		public Car(string name,int maxspeed,int currspeed){
			PetName=name;
			MaxSpeed=maxspeed;
			CurrentSpeed=currspeed;
			
		}
	}
	public enum EngineState{
		engineAlive
	   ,engineDead};
	
	class Minivan:Car{
		public Minivan(string name,int maxspedd,int cuurspeed):base(name,maxspedd,cuurspeed){}
		
		public override void TurboBoost()
		{
			Console.WriteLine("Max speed is less than 100 mph");                               	
		                               	
		 }				
	}
	class SportCar:Car{
		public SportCar(string name,int maxspedd,int cuurspeed):base(name,maxspedd,cuurspeed){}
		
		public override void TurboBoost()
		{
			Console.WriteLine("MaxSpeed like a jet");                               	
		                               	
		 }				
	}
}