// passing parameters by reference

#include <iostream>
using namespace std;

void prevnext (int x, int& prev, int& next)

{
 prev = x-1;
 next = x+1;
} 

int main()
{
cout << "\n";

  int x=100, y, z;
  prevnext (x, y, z);
  cout << "Previous=" << y << ", Next=" << z;

cout << "\n" "\n"; //CReate space before terminating
return 0; //Terminate program

} // Int Main End


  






