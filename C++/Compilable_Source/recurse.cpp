// recursivity

#include <iostream>
using namespace std;

long factorial (long a)

{
  if (a > 1)
   return (a * factorial (a-1));
  else
   return (1); 
}


int main()
{
cout << "\n";

  long number;
  cout << "Please type a number: ";
  cin >> number;
  cout << number << "! = " << factorial (number);

cout << "\n" "\n"; //CReate space before terminating
return 0; //Terminate program

} // Int Main End


  






