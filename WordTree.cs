namespace WordSearchApp
{
    public class WordTree
    {
        public TrieNode Root { get; } = new TrieNode();

        public void Insert(string word)
        {
            var node = Root;
            foreach (var c in word)
            {
                if (!node.Children.ContainsKey(c))
                {
                    node.Children[c] = new TrieNode();
                }
                node = node.Children[c];
            }
            node.IsWord = true;
        }
    }
}
