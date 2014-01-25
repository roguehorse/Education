/* Number Echo */

#include <iostream>
#include <unistd.h>//Timer Header
using namespace std;
#define N '\n'

int main()
{


for (int n=1; n<10; n++) {

  sleep (1);//Timer creates 1 sec intervals between counts
 cout << n << "\n";

 }
 

 cout << "FIRE!";



//Terminate program
cout<<N;
return 0;

}


  






