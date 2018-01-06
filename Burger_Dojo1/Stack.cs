using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burger_Dojo1
{
    class Stack<T>
    {
        //The element which is currently on top of the stack
        private StackElement<T> curr;


        //Push on stack. Adds the Parameter 'obj' on top of the stack
        public void Push(T obj)
        {
            //New element is the first element in stack -> has no successor 
            if(curr == null)
            {
                curr = new StackElement<T>() { Value = obj, Pre = null };
            }
            //Sets the new element to a temporary StackElement (newObj) with the current element as previous element
            else
            {
                StackElement<T> newObj = new StackElement<T>() { Value = obj, Pre = curr };
                curr = newObj;
            }
        }

        //Pop from stack. Gives back the current element (the one on top)
        public T Pop()
        {
            //Stack empty
            if(curr == null)
            {
                throw new NullReferenceException();
            }

            T temp = curr.Value;
            curr = curr.Pre;
            return temp;
        }

        //Peek on Stack. Shows the current element (the one on top)
        public T Peek()
        {
            if (curr != null)
            {
                return curr.Value;
            }
            else
                throw new NullReferenceException();
        }

    }
}
