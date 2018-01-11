
using System;

namespace КНБ
{
	class Program
	{
		public static void Main(string[] args)
		{
			PlayGame();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	static void PlayGame(){
			Console.WriteLine("Добро пожаловать в игру Камень-Ножницы-Бумага");
			Game game=new Game();
			game.WriteTheRules();
			while(!game.gameOver){
				game.Player_step=Console.ReadKey().KeyChar;
				game.PC_Turn();
				game.CompareRezult();							
			}
			
		}
	}
	class Game{
		// свойства, в которых хранятся выбираемые игроками символы
		
		private char pc_step;
		private char player_step;
		private bool trueValue;
		public bool gameOver{get;set;}
		private Random rnd;
		public char Player_step{
			get{return player_step;}
			set{
				trueValue=false;
				bool rezult=FindInSymbolsArray(value);
				if (rezult==false){
					int exitCode=Array.Find(exitSymbols,ix=>ix==value);
					if(exitCode==0)Console.WriteLine("\nУпс. Не та кнопка. Будьте внимательнее.");
					else {
						Console.WriteLine("\nПриятно было встретиться. До свидания!");
						gameOver=true;
					}
					
					}
				else {player_step=value; trueValue=true;}
				}
			}
		char[][] Symbols=
				{
			new char[]{'К','к','R','r'},
			new char[]{'Н','н','Y','y'},
			new char[]{'Б','б','<',','}
				};
		char[]mainSymbols=new char[3];
		char[] exitSymbols={'Q','q','Й','й'};
		// хранится счет сторон
		private int player_count;
		private int pc_count;
		public Game()
		{
			gameOver=false;
			player_count=pc_count=0;
			rnd=new Random();
			trueValue=false;
			for(int i=0;i<mainSymbols.Length;i++)
				mainSymbols[i]=Symbols[i][0];
			
		
		}
		public void WriteTheRules(){
			Console.WriteLine("Для выбора значения нажмите соответствующую кнопку на клавиатуре");
			Console.WriteLine("\tК-камень\n\tН-ножницы\n\tБ-бумага");
			Console.WriteLine("Для выхода нажмите на кнопку Й");
			
		}
		//ход компьютера
		public void PC_Turn(){
			pc_step=mainSymbols[rnd.Next(mainSymbols.Length)];
			Console.WriteLine("\nПК выбрал {0}",pc_step);
		}
		public void CompareRezult(){
			if(!trueValue) return;
			bool isK=Array.Find(Symbols[0],ix=>ix==player_step)>0; // Камень
			bool isH=Array.Find(Symbols[1],ix=>ix==player_step)>0; //Ножницы
			bool isB=Array.Find(Symbols[2],ix=>ix==player_step)>0; //Бумага
			if(pc_step=='К')
			{
				if(isK) {player_count++;pc_count++;}
				if(isH) pc_count++;
				if(isB) player_count++;
			}
			if(pc_step=='Н')
			{
				if(isK) player_count++;
				if(isH) {pc_count++;player_count++;}
				if(isB) pc_count++;
			}
			if(pc_step=='Б')
			{
				if(isK) pc_count++;
				if(isH) player_count++;
				if(isB) {pc_count++;player_count++;}
			}
					
			Console.WriteLine("Общий счет Игрок: Компьютер");
			Console.WriteLine("             {0}:   {1}",player_count,pc_count);
			if(player_count>pc_count)Console.WriteLine("Йухуу! Молодец!!!!!!");
		}
		private bool FindInSymbolsArray(char ch){
			bool TrueSymbol=false;
			foreach(char[] array in Symbols){
				for(int ix=0;ix<array.Length;ix++){
					if(array[ix]==ch)TrueSymbol=true;
				}
				
			}
			return TrueSymbol;
		}
		
	}
}