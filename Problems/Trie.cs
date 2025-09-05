namespace Problems
{
    public static partial class Sample1
    {

        public partial class LRUCache
        {
            public class Trie

            {

                private class Node

                {

                    public bool End;

                    public Dictionary<char, Node> Children = new();

                }

                private readonly Node _root = new();

                public void Insert(string word)

                {

                    var node = _root;

                    foreach (var c in word)

                    {

                        if (!node.Children.ContainsKey(c)) node.Children[c] = new Node();

                        node = node.Children[c];

                    }

                    node.End = true;

                }

                public bool Search(string word)

                {

                    var node = _root;

                    foreach (var c in word)

                    {

                        if (!node.Children.TryGetValue(c, out node)) return false;

                    }

                    return node.End;

                }

                public bool StartsWith(string prefix)

                {

                    var node = _root;

                    foreach (var c in prefix)

                    {

                        if (!node.Children.TryGetValue(c, out node)) return false;

                    }

                    return true;

                }

            }

        }
    }

}
