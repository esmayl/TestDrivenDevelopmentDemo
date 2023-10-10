namespace CodeToPassTest;

public class FloatGenerator
{
    float generatedInt = -1;
    
    public FloatGenerator()
    {
        // This is a reusable context for all tests in this file
        generatedInt = 1337f / new Random().Next();
    }
    
    public float GetGeneratedInt()
    {
        return generatedInt;
    }

}