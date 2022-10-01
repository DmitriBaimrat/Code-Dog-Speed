int distance = 10000;
int firstfriendspeed = 1;
int secondfriendspeed = 2;
int dogspeed = 5;
double count = 0;
int friend = 2;
int time = 0;


while (distance > 10)
{
    if (friend == 1)
    {
        time = distance / (firstfriendspeed + dogspeed);
    }
    else if (friend == 2)
    {
        time = distance / (secondfriendspeed + dogspeed);
    }
    distance = (distance - (firstfriendspeed + secondfriendspeed) * time);
    count++;
}
System.Console.WriteLine(count);