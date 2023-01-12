int speed_one_frend = 1;
int speed_two_frend = 2;
int speed_dog = 5;
int distans = 10000;
int count = 0;
int frend = 1;
int time = 0;

while (distans>10)
{
    if (frend == 1)
    {
    time = distans/(speed_dog+speed_two_frend);
    frend = 2;
    }
    if (frend == 2)
    {
    time = distans/(speed_dog+speed_one_frend);
    frend = 1;
    }
distans = distans - time * (speed_one_frend+speed_two_frend);
count+=1;


}

Console.Write("Собака пробежала ");
Console.Write(count);
Console.WriteLine(" раз!");
