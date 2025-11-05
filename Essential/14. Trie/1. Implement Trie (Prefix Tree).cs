namespace Essential.Trie
{
    class ImplementTriePrefixTreeClass
    {
        /// <summary>
        /// Method-1: Dictionary (Best)
        /// TC: O(n)
        /// SC: O(n)
        /// </summary>

        public class TrieNode
        {
            public bool IsWord;
            public Dictionary<char, TrieNode> Children;

            public TrieNode()
            {
                IsWord = false;
                Children = new Dictionary<char, TrieNode>();
            }
        }

        public class Trie
        {
            private readonly TrieNode root;

            public Trie()
            {
                root = new TrieNode();
            }

            // TC: O(n)
            // SC: O(n)
            public void Insert(string word)
            {
                TrieNode node = root;
                foreach (char c in word)
                {
                    if (!node.Children.ContainsKey(c))
                    {
                        node.Children[c] = new TrieNode();
                    }
                    node = node.Children[c];
                }
                node.IsWord = true;
            }

            // TC: O(n)
            // SC: O(1)
            public bool Search(string word)
            {
                TrieNode node = FindNode(word);
                return node != null && node.IsWord;
            }

            // TC: O(n)
            // SC: O(1)
            public bool StartsWith(string prefix)
            {
                return FindNode(prefix) != null;
            }

            // TC: O(n)
            // SC: O(1)
            private TrieNode FindNode(string prefix)
            {
                TrieNode node = root;
                foreach (char c in prefix)
                {
                    if (!node.Children.ContainsKey(c))
                    {
                        return null;
                    }
                    node = node.Children[c];
                }
                return node;
            }
        }
    }
}
