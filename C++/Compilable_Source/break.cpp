/* Assignment Operator */

#include <iostream>
using namespace std;

int main()
{

int n;
for (n=10; n>0; n--)
 {
  if (n==5) continue;
  cout << n << "\n";
  if (n==3)
  {
   cout << "countdown aborted!";
   break;
  }
  
 }

//Terminate program
cout << "\n";
return 0;

}


  






