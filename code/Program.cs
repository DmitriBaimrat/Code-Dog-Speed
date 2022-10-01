int Distance = 10000;
int FirstFriendSpeed = 1;
int SecondFriendSpeed = 2;
int DogSpeed = 5;
double Count = 0;
int Friend = 2;
int Time = 0;


while (Distance > 10)
{
    if (Friend == 1)
    {
        Time = Distance / (FirstFriendSpeed + DogSpeed);
    }
    else if (Friend == 2)
    {
        Time = Distance / (SecondFriendSpeed + DogSpeed);
    }
    Distance = (Distance - (FirstFriendSpeed + SecondFriendSpeed) * Time);
    Count++;
}
System.Console.WriteLine("Собака пробежит от одного человека к другому " + Count + " раз.");