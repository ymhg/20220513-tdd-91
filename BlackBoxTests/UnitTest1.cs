using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace BlackBoxTests;

public class Tests
{
    private BlackBox _blackBox;

    [SetUp]
    public void SetUp()
    {
        _blackBox = new BlackBox();
    }

    [Test]
    public void SingleChar()
    {
        ShouldBe("a", "A");
    }

    [Test]
    public void MultiChar()
    {
        ShouldBe("abc", "A-Bb-Ccc");
        ShouldBe("1b3C", "1-Bb-333-Cccc");
    }

    private void ShouldBe(string input, string expected)
    {
        Assert.AreEqual(expected, _blackBox.Convert(input));
    }
}

public class BlackBox
{
    public string Convert(string input)
    {
        return string.Join('-', input.ToCharArray().Select(AppendChar));
    }

    private string AppendChar(char c, int index)
    {
        var list = new List<string>();
        for (var j = 0; j <= index; j++)
        {
            list.Add(GetLetter(c, j));
        }

        return string.Join("", list);
    }

    private string GetLetter(char c, int j)
    {
        return j == 0
            ? c.ToString().ToUpper()
            : c.ToString().ToLower();
    }
}