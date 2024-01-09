using CircularBuffer;

namespace RingBuffer
{
    public class Buffer<T>
    {
        public CircularBuffer<T> CreateBuffer(int capacity, T[]? itens = null)
        {
            if (itens is not null)
            return new CircularBuffer<T>(capacity, itens);

            return new CircularBuffer<T>(capacity);
        }
        public void PrintBuffer(CircularBuffer<T> buffer)
        {
            Console.WriteLine($"{{{string.Join(",", buffer.ToArray())}}}");
        }
    }
}
