using System.Collections;
public class TestDataAsClass : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return new object[] { "Test string from IEnumerator data", -1,1 };
        yield return new object[] { "1", 1 };
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}