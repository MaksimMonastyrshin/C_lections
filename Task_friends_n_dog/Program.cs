// Задача про собаку и друзей

Console.Clear();

int count = 0,
    friend = 2;

double distance = 10000,
       FirstFriendSpeed = 1,
       SecondFriendSpeed = 2,
       DogSpeed = 3;
Time = 0;

while (distance > 10)
{
    if (friend == 1)
    {
        Time = distance / (FirstFriendSpeed + DogSpeed);
        friend = 2;
    }
    else
    {
        Time = distance / (SecondFriendSpeed + DogSpeed);
        friend = 1;
    }
    distance = distance - (FirstFriendSpeed + SecondFriendSpeed) * Time;
    count++;
}
    Console.Write("Собака пробежит: ");
    Console.Write(count);
    Console.Write(" раз.");
