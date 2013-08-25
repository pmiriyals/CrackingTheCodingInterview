using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CCIChapter20
{
    class Node
    {
        public char c { get; set; }
        public List<string> suffixes = new List<string>();
        public bool isWord { get; set; }
        public List<int> indexes = new List<int>();
        public Dictionary<char, Node> children = new Dictionary<char, Node>();
        public static int count = 0;
        public static Node node = null;

        public Node()
        {            
        }

        public void insertSuffix(string suffix, int index)
        {
            indexes.Add(index);
            if (!isWord && indexes.Count > count)
            {
                count = indexes.Count;
                node = this;
            }
            
            if (suffix == null || suffix.Length == 0)
                return;

            suffixes.Add(suffix);  
            c = suffix[0];
            Node cur = null;
            if (!children.ContainsKey(c))
            {
                children.Add(c, new Node());
            }

            cur = children[c];
            cur.insertSuffix(suffix.Substring(1), index);
        }

        public List<int> getIndexes(string s)
        {
            if (s == null || s.Length == 0)
                return indexes;

            if (children.ContainsKey(s[0]))
                return children[s[0]].getIndexes(s.Substring(1));

            return null;
        }
    }
    
    class SuffixTree20_8
    {
        private Node root = new Node();        

        public SuffixTree20_8(string s)
        {
            root.isWord = true;
            for(int i = 0; i < s.Length; i++)
                root.insertSuffix(s.Substring(i), i);
        }

        public List<int> getIndexes(string s)
        {
            return root.getIndexes(s);
        }

        public static void driver()
        {
            string test = "banana";
            SuffixTree20_8 tree = new SuffixTree20_8(test);
            string sub = "b";
            List<int> indexes = tree.getIndexes(sub);
            indexes = Node.node.indexes;
            foreach (int i in indexes)
                Console.WriteLine("{0}: index = {1}", test.Substring(i), i);

            
        }
    }
}
