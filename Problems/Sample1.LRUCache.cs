namespace Problems
{
    public static partial class Sample1
    {
        // LRU Cache
        public partial class LRUCache
        {
            private readonly int _capacity;
            private readonly Dictionary<int, LinkedListNode<(int key, int value)>> _map;
            private readonly LinkedList<(int key, int value)> _list;
            public LRUCache(int capacity)
            {
                _capacity = capacity;
                _map = new Dictionary<int, LinkedListNode<(int, int)>>();
                _list = new LinkedList<(int, int)>();
            }
            public int Get(int key)
            {
                if (!_map.TryGetValue(key, out var node)) return -1;
                _list.Remove(node);
                _list.AddFirst(node); // mark most recently used
                return node.Value.value;
            }
            public void Put(int key, int value)
            {
                if (_map.TryGetValue(key, out var node))
                {
                    _list.Remove(node);
                }
                else if (_map.Count >= _capacity)
                {
                    var lru = _list.Last;
                    if (lru != null)
                    {
                        _map.Remove(lru.Value.key);
                        _list.RemoveLast();
                    }
                }
                var newNode = new LinkedListNode<(int, int)>((key, value));
                _list.AddFirst(newNode);
                _map[key] = newNode;
            }

            
        }
    }

}
