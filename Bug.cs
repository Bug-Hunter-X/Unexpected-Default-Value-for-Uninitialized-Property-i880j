public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a property before it's assigned a value.
        Console.WriteLine(MyProperty); // This will output 0, not throw an exception.
    }
}