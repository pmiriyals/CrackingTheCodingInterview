using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CCIChapter3
{
    class Tower
    {
        Stack<int> disks = new Stack<int>();
        public int index { get; set; }
        public Tower(int i)
        {
            index = i;
        }

        public void add(int val)
        {
            if (disks.Count > 0 && disks.Peek() < val)
                Console.WriteLine("Error placing disk");
            else
                disks.Push(val);
        }

        public void MoveTopTo(Tower t)
        {
            if (disks.Count > 0)
            {
                Console.WriteLine("Move disk = {0} from tower = {1} to tower = {2}", disks.Peek(), this.index, t.index);
                t.add(disks.Pop());
            }
        }

        public void print()
        {
            Console.WriteLine("Contents of Tower {0}: ", index);            

            foreach (int i in disks)
                Console.Write("{0} ", i);
        }

        public void MoveDisks(int n, Tower destn, Tower buf)
        {
            if (n >= 0)
            {
                MoveDisks(n - 1, buf, destn);
                MoveTopTo(destn);
                buf.MoveDisks(n-1, destn, this);
            }
        }
    }
    
    class TowerOfHanoi3_4
    {
        public static void driver()
        {
            int n = 5;
            Tower[] towers = new Tower[3];
            
            for (int i = 0; i < towers.Length; i++)
                towers[i] = new Tower(i + 1);

            for (int i = n; i >= 0; i--)
                towers[0].add(i);
            
            towers[0].MoveDisks(n, towers[2], towers[1]);
            towers[2].print();
        }
    }
}
