#include <stdio.h>

int main(){

    char ch, begin;
    begin=1;
    while((ch=getchar())!=EOF){
        if(begin==1){
            putchar('\"');
            begin=0;
        }
        if(ch=='\n'){
            putchar('\"');
            putchar(ch);
            putchar(',');
            putchar('\"');
        } else{
            putchar(ch);
        }
    }
    putchar('\"');
    return 0;
}