using HomeTaskInPolAcMethod;

internal class Program
{
    private static void Main(string[] args)
    {
        Student student=new("Ali","Xudiyev",24,new int[] {1,2,3,4,5,6,8});
        student.GetInfo(student);
    }
}