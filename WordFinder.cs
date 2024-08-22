using System.Collections.Generic;
using System.Linq;

namespace WordSearchApp
{
    internal partial class Program
    {
        public class WordFinder
        {
            private readonly char[][] _matrix;
            private readonly int _rows;
            private readonly int _cols;
            private readonly WordTree _trie = new WordTree();
            private readonly HashSet<string> _foundWords = new HashSet<string>();

            public WordFinder(IEnumerable<string> matrix)
            {
                _matrix = matrix.Select(row => row.ToCharArray()).ToArray();
                _rows = _matrix.Length;
                _cols = _matrix[0].Length;

            }

            public IEnumerable<string> Find(IEnumerable<string> wordstream)
            {
                // var foundWords = new HashSet<string>();

                // Build the WordTree with the words in the word stream
                foreach (var word in wordstream)
                {
                    _trie.Insert(word);
                }

                // Search the matrix
                for (int row = 0; row < _rows; row++)
                {
                    for (int col = 0; col < _cols; col++)
                    {
                        DFS(row, col, _trie.Root);
                    }
                }

                // Return top 10 most frequent words found
                return _foundWords.Take(10);
            }

            private void DFS(int row, int col, TrieNode node, string currentWord = "")
            {
                if (row < 0 || col < 0 || row >= _rows || col >= _cols || _matrix[row][col] == '#') return;

                char c = _matrix[row][col];
                if (!node.Children.ContainsKey(c)) return;

                node = node.Children[c];
                currentWord += c;

                if (node.IsWord)
                {
                    _foundWords.Add(currentWord);
                }

                // Mark the current cell as visited
                _matrix[row][col] = '#';

                // Explore the neighbors (right and down only for horizontal and vertical search)
                DFS(row + 1, col, node, currentWord); // down
                DFS(row, col + 1, node, currentWord); // right

                // Unmark the current cell (backtracking)
                _matrix[row][col] = c;
            }



        }




    }
}
