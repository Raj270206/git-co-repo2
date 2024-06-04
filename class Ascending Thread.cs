class Ascending Thread 
{
    public void run()
    {
        for(int i=1;i,=50;i++)
        {
            System.out.println("Ascending Thread:"+i);
        }}}
class Descending Thread
{
    public void run()
    {
        for(int i=50;i<0;i++)
        {
            System.out.println("Descending Thread:"+i);
        }}}
        public class AscendingDescendingh
        {
            public static void main(Stringh args[])
            {
                Ascending a= new Ascending();
                a.start();
                Descending d= new Descending();
                d.start();
            }}