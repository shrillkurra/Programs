using System;
using System.Collections.Generic;
using System.Text;

namespace Pract_Prob
{
    class AddTwoNumbersProblem
    {
          public class ListNode {
              public int val;
              public ListNode next;
              public ListNode(int val=0, ListNode next=null) {
                  this.val = val;
                  this.next = next;
              }
          }
 
        public class Solution
        {
            public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
            {
                ListNode ln = new ListNode();
                while(ln.next != null)
                {
                    Console.WriteLine(ln.val);
                }
            }
        }
    }
}
