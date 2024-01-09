using RingBuffer;

var buffer = new Buffer<int>();
var ringBuuffer = buffer.CreateBuffer(5, [0,1,2]);

Console.WriteLine("Initial buffer {0 , 1, 2}:");
buffer.PrintBuffer(ringBuuffer);


for (int i = 3; i < 7; i++)
{
    ringBuuffer.PushBack(i);
}
Console.WriteLine("\nAfter adding a 7 elements to a 5 elements capacity buffer:");
buffer.PrintBuffer(ringBuuffer);


ringBuuffer.PopFront();
Console.WriteLine("\nbuffer.PopFront():");
buffer.PrintBuffer(ringBuuffer);


ringBuuffer.PopBack();
Console.WriteLine("\nbuffer.PopBack():");
buffer.PrintBuffer(ringBuuffer);

for (int i = 2; i >= 0; i--)
{
    ringBuuffer.PushFront(i);
}
Console.WriteLine("\nbuffer.PushFront() {2,1,0} respectively:");
buffer.PrintBuffer(ringBuuffer);

ringBuuffer.Clear();
Console.WriteLine("\nbuffer.Clear():");
buffer.PrintBuffer(ringBuuffer);
        


