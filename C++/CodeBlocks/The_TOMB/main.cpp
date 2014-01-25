#include <iostream>

using namespace std;

int main()
{

    int a,b,c,d,e,f,g,h,x;
    string answer;

    START:cout << "You are standing in the middle of a 50' x 50' room." << endl;
    cout << "There is a door in the middle of each wall to the north, south, east and west." << endl;
    cout << "Select a direction to go." << endl;
    ROOM1:cout << "\n";
    cout << "    1 = North" << endl;
    cout << "    2 = South" << endl;
    cout << "    3 = East" << endl;
    cout << "    4 = West" << endl;
    cout << "\n";
    cin >> a;
        if (a < 1 || a > 4)
    {
        cout << "That selection is invalid\n" << endl;
            goto ROOM1;
    }


    if (a == 1)
    {
        cout << "\nYou travel down a long hall which ends at an intersection." << endl;
        cout << "You may go east or west." << endl;
        ROOM2:cout << "\n";
        cout << "    1 = East" << endl;
        cout << "    2 = West" << endl;
        cout << "\n";
        cin >> b;
            if (b < 1 || b > 2)
        {
            cout << "That selection is invalid\n" << endl;
                goto ROOM2;
        }

        if (b == 1)
        {
            cout << "\nThe east direction leads down a long hall." << endl;
            cout << "At the end of the hall, you head south then east." << endl;
            cout << "The hall then turns north and ends\n" << endl;
            cout << "    Game Over" << endl;
            cout << "\n    Would you like to try again? Y or N" << endl;
            cin >> answer;
                if (answer == "y")
                {
                    cout << string(50, '\n');
                    goto START;
                }
            return (0);
        }
        if (b == 2)
        {
            cout << "\nThe West hall travels about 50' then turns south." << endl;
            cout << "Traveling south for approximately 40' you again travel east." << endl;
            cout << "You again come to an intersection." << endl;
            cout << "You may go north or south." << endl;
            ROOM3:cout << "\n";
            cout << "    1 = North" << endl;
            cout << "    2 = South" << endl;
            cout << "\n";
            cin >> c;
                if (c < 1 || c > 2)
                {
                    cout << "That selection is invalid\n" << endl;
                        goto ROOM3;
                }
        }
            if (c == 1)
            {
                cout << "\nThe North passage leads for 60'" << endl;
                cout << "then comes to an intersection where you may go" << endl;
                cout << "north or west." << endl;
                ROOM4:cout << "\n";
                cout << "    1 = North" << endl;
                cout << "    2 = West" << endl;
                cout << "\n";
                cin >> d;
                    if (d < 1 || d > 2)
                {
                    cout << "That selection is invalid\n" << endl;
                        goto ROOM4;
                }

                if (d == 1)
                {
                    cout << "\nThe corridor goes north for about 50'" << endl;
                    cout << "then turns east again and you come to an intersection." << endl;
                    cout << "You may continue east or go south." << endl;
                    ROOM5:cout << "\n";
                    cout << "    1 = East" << endl;
                    cout << "    2 = South\n" << endl;
                    cin >> e;
                        if (e < 1 || e > 2)
                        {
                            cout << "That selection is invalid\n" << endl;
                                goto ROOM5;
                        }
                        if (e == 1)
                        {
                            cout << "\nThe hall that leads east goes for about 40'" << endl;
                            cout << "then it turns south for another 40'." << endl;
                            cout << "Finally it turns west and ends.\n" << endl;
                            cout << "    Game Over" << endl;
                            cout << "\n    Would you like to try again? Y or N" << endl;
                            cin >> answer;
                                if (answer == "y")
                                {
                                    cout << string(50, '\n');
                                    goto START;
                                }
                            return (0);
                        }
                        if (e == 2)
                        {
                            cout << "\nThe South leading passage goes on for 40'" << endl;
                            cout << "then it turns and goes west and ends.\n" << endl;
                            cout << "    Game Over" << endl;
                            cout << "\n    Would you like to try again? Y or N" << endl;
                            cin >> answer;
                                if (answer == "y")
                                {
                                    cout << string(50, '\n');
                                    goto START;
                                }
                            return (0);
                        }
                }
                else
                {
                    cout << "\nThe West passage goes on for about 70' then" << endl;
                    cout << "turns north where you find daylight at the end!\n" << endl;
                    cout << "    You have escaped!" << endl;
                    return (0);
                }
            }
            if (c == 2)
            {
                cout << "\nThe passage heads south and continues for 60'." << endl;
                cout << "You come to an intersection and may continue" << endl;
                cout << "to head south or go west." << endl;
                ROOM6:cout << "\n";
                cout << "    1 = South" << endl;
                cout << "    2 = West" << endl;
                cout << "\n";
                cin >> f;
                    if (f < 1 || f > 2)
                {
                    cout << "That selection is invalid\n" << endl;
                        goto ROOM6;
                }
            }
                if (f == 1)
                {
                    cout << "\nThe hall travels south and goes 30'" << endl;
                    cout << "then it turns and goes west for about 50'." << endl;
                    cout << "Finally it turns north for another 50' and ends.\n" << endl;
                    cout << "    Game Over" << endl;
                    cout << "\n    Would you like to try again? Y or N" << endl;
                    cin >> answer;
                        if (answer == "y")
                        {
                            cout << string(50, '\n');
                            goto START;
                        }
                    return (0);
                }
                if (f == 2)
                {
                    cout << "\nThe West passage travels for some 40' then" << endl;
                    cout << "turns north for another 40' and turns west." << endl;
                    cout << "You continue for about 60' then come to an intersection and" << endl;
                    cout << "can go south or continue west." << endl;
                    ROOM7:cout << "\n";
                    cout << "    1 = South" << endl;
                    cout << "    2 = West" << endl;
                    cout << "\n";
                    cin >> g;
                        if (g < 1 || g > 2)
                {
                    cout << "That selection is invalid\n" << endl;
                        goto ROOM7;
                }

                    if (g == 1)
                    {
                        cout << "\nThe south hall travels for 60' and" << endl;
                        cout << "you have walked right back to where you started!\n" << endl;
                        cout << "    Game Over" << endl;
                        cout << "\n    Would you like to try again? Y or N" << endl;
                        cin >> answer;
                            if (answer == "y")
                            {
                                cout << string(50, '\n');
                                goto START;
                            }
                        return (0);
                    }
                    if (g == 2)
                    {
                        cout << "\nThe West passage travels for 50' then turns south." << endl;
                        cout << "It continues south for another 40' then turns east." << endl;
                        cout << "After another 40' the hall turns north again and ends.\n" << endl;
                        cout << "    Game Over" << endl;
                        cout << "\n    Would you like to try again? Y or N" << endl;
                        cin >> answer;
                            if (answer == "y")
                            {
                                cout << string(50, '\n');
                                goto START;
                            }
                        return (0);
                    }
                }

    }
    if (a == 2)
    {
        cout << "\nYou travel down a short hall." << endl;
        cout << "In 30' the hall turns east for a long distance." << endl;
        cout << "At the end of the distance the hall turns north and ends.\n" << endl;
        cout << "    Game Over" << endl;
        cout << "\n    Would you like to try again? Y or N" << endl;
        cin >> answer;
            if (answer == "y")
            {
                cout << string(50, '\n');
                goto START;
            }
        return (0);
    }
    if (a == 3)
    {
        cout << "\nThe corridor leads east for 50'" << endl;
        cout << "then it turns south and ends.\n" << endl;
        cout << "    Game Over" << endl;
        cout << "\n    Would you like to try again? Y or N" << endl;
        cin >> answer;
            if (answer == "y")
            {
                cout << string(50, '\n');
                goto START;
            }
        return (0);
    }
    if (a == 4)
    {
        cout << "\nThe corridor heads west and goes for about 30'." << endl;
        cout << "Then you come to an intersection where" << endl;
        cout << "you may choose to go north or south" << endl;
        ROOM8:cout << "\n";
        cout << "    1 = North" << endl;
        cout << "    2 = South" << endl;
        cout << "\n";
        cin >> h;
            if (h < 1 || h > 2)
        {
            cout << "That selection is invalid\n" << endl;
                goto ROOM8;
        }

        if (h == 1)
        {
            cout << "\nThe North hall travels for about 40'." << endl;
            cout << "Then it turns and heads east for 40' and ends.\n" << endl;
            cout << "    Game Over" << endl;
            cout << "\n    Would you like to try again? Y or N" << endl;
            cin >> answer;
                if (answer == "y")
                {
                    cout << string(50, '\n');
                    goto START;
                }
            return (0);
        }
        if (h == 2)
        {
            cout << "\nThe hallway travels south and goes for 40'." << endl;
            cout << "It then turns and heads east for another 40' and ends.\n" << endl;
            cout << "    Game Over" << endl;
            cout << "\n    Would you like to try again? Y or N" << endl;
            cin >> answer;
                if (answer == "y")
                {
                    cout << string(50, '\n');
                    goto START;
                }
            return (0);
        }
    }
    return 0;
}

