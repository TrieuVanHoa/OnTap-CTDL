using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DslkDon
{
    internal class MyList
    {
        private IntNode first;
        private IntNode last;

        internal IntNode First { get => first; set => first = value; }
        internal IntNode Last { get => last; set => last = value; }

        public void AddFirst(IntNode newNode)
        {
            if(IsEmpty())
            {
                first = last = newNode;
            }
            else
            {
                newNode.Next = first;
                first = newNode;
            }
        }
        public bool IsEmpty()
        {
            return first == null;
        }
        public void InPut()
        {
            do
            {
                Console.Write("Nhap gia tri (nhan 0 de dung)) ");
                int x = int.Parse(Console.ReadLine());
                if (x == 0)
                    break;
                IntNode newNode=new IntNode(x);
                AddFirst(newNode);
            }while(true);
        }
        public void ShowList()
        {
            if(IsEmpty())
            {
                Console.WriteLine("Danh sach rong");
            }
            else
            {
                IntNode p=first;
                while(p!=null){
                    Console.WriteLine(p.Data+"--->");
                    p=p.Next;

                }
            }
        }
        public IntNode SearchX(int x)
        {
            IntNode p = first;
            while (p != null)
            {
                if(p.Data==x)
                {
                    return p;
                }
                p=p.Next;
            }
            return null;

        }
       
    }
}
