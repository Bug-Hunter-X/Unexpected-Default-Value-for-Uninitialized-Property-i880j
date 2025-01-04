public class ExampleClass
{
    public int MyProperty { get; set; } = 0; // Initialize the property

    public void MyMethod()
    {
        Console.WriteLine(MyProperty); // This will now output the initialized value.
    }
}