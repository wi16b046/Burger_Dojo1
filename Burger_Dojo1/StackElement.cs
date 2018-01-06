namespace Burger_Dojo1
{
    public class StackElement<T>
    {
        //Value of the stackelemen, can be any object
        public T Value { get; set; }
        //Shows the element which comes before this element
        public StackElement<T> Pre { get; set; }
    }
}