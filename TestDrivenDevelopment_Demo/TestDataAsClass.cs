using System.Collections;
public class TestDataAsClass : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}