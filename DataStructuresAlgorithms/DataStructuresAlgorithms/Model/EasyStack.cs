namespace DataStructuresAlgorithms.Model
{
    public class EasyStack<T>: ICloneable
    {
        private List<T> items = new List<T>();
        public int Count => items.Count;
        public bool IsEmpty => Count == 0;

        public void Clear()
        { 
            items.Clear();
        }

        public void Push(T item)
        {
            items.Add(item);
        }

        public T Pop()
        {
            if(!IsEmpty)
            {
                var item = items.LastOrDefault();
                items.Remove(item);
                return item;
            }
            else
            {
                throw new NullReferenceException("Stack is empty");
            }
        }

        public T Peek()
        {
            if (!IsEmpty)
            {
                return items.LastOrDefault();
            }
            else
            {
                throw new NullReferenceException("Stack is empty");
            }
        }

        public override string ToString()
        {
            return $"Count is{Count}";
        }

        public object Clone()
        {
            var newStack = new EasyStack<T>();
            newStack.items = new List<T>(items);
            return newStack;
        }
    }
}
