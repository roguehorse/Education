// declaring

#include <iostream>
using namespace std;

int odd (int a);
int even (int a);


int main()
{
cout << "\n";

  int i;
  do {
  	cout << "Type a number (0 to exit): ";
  	cin >> i;
  	odd (i);
      } while (i!=0);
  	

    cout << "\n" "\n"; //CReate space before terminating
return 0; //Terminate program

} // Int Main End

int odd (int a)
{
  if ((a%2)!=0) cout << "Number is odd.\n";
  else even (a);
      cout << "\n"; //CReate space before terminating
}

int even (int a)
{
  if ((a%2)==0) cout << "Number is even.\n";
  else odd (a);
      cout << "\n"; //CReate space before terminating
}  







