#include "strins.h"

int main(void){
	printf("%d\n",aatoi("1234"));
	return 0;
}

int str_to_int(char str[]){
	int i,n;
	n=0;
	for(i=0;str[i]>='0' && str[i]<='9';i++){
		printf("%d\n",n);
		n=10*n+(str[i]-'0');
	}
		
	return n;
}

int lower(int ch){
	if(ch>='A'&& ch<='Z')
		return c+'a'-'A';
	return ch;	
}
int isdigit(int ch){
	return (ch>='0'&& ch<='9')
}