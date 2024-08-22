using System.Collections.Generic;

namespace WordSearchApp
{
    public class TrieNode
    {
        public Dictionary<char, TrieNode> Children { get; } = new Dictionary<char, TrieNode>();
        public bool IsWord { get; set; }
    }

}
