using System;

namespace PrefixTree_Trie_ConsoleApp1
{
    public static class Node
    {
        private static int numOfChars = 26;
        Node[] children = new Node[numOfChars];
        int size = 0;


        private static int getCharIndex(char c)
        {
            return c - 'a';
        }

        private Node getNode(char c)
        {
            return children(getCharIndex(c));
        }

        private void setNode(char c, Node node)
        {
            children(getCharIndex(c)) = node;
        }

        private void add(string s, int index)
        {
            size++;
            if (index == s.Length())
            {
                return;
            }
            char current = s[index]; //get index value
            int charCode = getCharIndex(current);
            Node child = getNode(current);
            if (child == null)
            {
                child = new Node();
                setNode(current, child);
            }
        }

        public int findCount(string s, int index)
        {
            if (index = s.Length)
            {
                return size;
            }
            Node child = getNode(s[index]);
            if (child == null)
            {
                return 0;
            }
            return findCount(s, index + 1);
        }
                          
    }

    public static void main(string[] args)     

    {

    }
    
}
