using NUnit.Framework;

namespace TennisTests;

public class Tests
{
    [SetUp]
    public void SetUp()
    {
        _tennis = new Tennis();
    }

    private Tennis _tennis;

    [Test]
    public void Love_All()
    {
        ScoreShouldBe("Love All");
    }

    [Test]
    public void Fifteen_Love()
    {
        GivenFirstPlayerScore(1);
        ScoreShouldBe("Fifteen Love");
    }

    [Test]
    public void Thirty_Love()
    {
        GivenFirstPlayerScore(2);
        ScoreShouldBe("Thirty Love");
    }

    [Test]
    public void Forty_Love()
    {
        GivenFirstPlayerScore(3);
        ScoreShouldBe("Forty Love");
    }

    [Test]
    public void Love_Fifteen()
    {
        GivenSecondPlayerScore(1);
        ScoreShouldBe("Love Fifteen");
    }

    [Test]
    public void Love_Thirty()
    {
        GivenSecondPlayerScore(2);
        ScoreShouldBe("Love Thirty");
    }

    [Test]
    public void Love_Forty()
    {
        GivenSecondPlayerScore(3);
        ScoreShouldBe("Love Forty");
    }

    [Test]
    public void Fifteen_All()
    {
        GivenFirstPlayerScore(1);
        GivenSecondPlayerScore(1);
        ScoreShouldBe("Fifteen All");
    }

    private void GivenSecondPlayerScore(int times)
    {
        for (int i = 0; i < times; i++)
        {
            _tennis.SecondPlayerScore();
        }
    }

    private void GivenFirstPlayerScore(int times)
    {
        for (int i = 0; i < times; i++)
        {
            _tennis.FirstPlayerScore();
        }
    }

    private void ScoreShouldBe(string expected)
    {
        Assert.AreEqual(expected, _tennis.Score());
    }
}