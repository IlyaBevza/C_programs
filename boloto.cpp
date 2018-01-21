#include <iostream>
#include <conio.h>
#include <process.h>

using namespace std;

void play_the_game(void);

int main()
{
	play_the_game();
	return 0;
}

void play_the_game(void)
{
	int x,y;
	x=y=10;
	char dir='a';
	cout<<"Press Enter to exit...";
	while(dir!='\r')
	{
		cout<<"\nYour coords: "<<x<<":"<<y;
		if(x<=5||x>=15)cout<<"\nBe careful! Dragons!";
		if(x%7==0&&y%7==0)cout<<"\nHo! There are mushrooms.";
		cout<<"\nChose direction (n,s,e,w)";
		dir=getche();
		switch(dir){
			case 'n':y--;break;
			case 's':y++;break;
			case 'e':x++;break;
			case 'w':x--;break;
			case '\r':cout<<"\nGood bye\n";break;
			default:cout<<"\nwrong key";break;
			
		}
		if(x==7&&y==7)
		{
			cout<<"\nCongratulations! You`ve found the bounty!";
			exit(0);
		}
		
		
	}
}