# WordSearch
WordSearch - Optimized Approach Using Trie and HashSet

Trie Data Structure:

The Trie is used to store all the words in the word stream. This allows us to quickly search for any word in the matrix without having to repeatedly scan the entire word stream.
Efficient Search in Matrix:

We perform a Depth-First Search (DFS) on the matrix to search for words using the Trie. The DFS will traverse horizontally and vertically, checking for possible words that match the Trie nodes.
Avoid Duplicates:

A HashSet is used to track the found words, ensuring that duplicates are not counted multiple times.
