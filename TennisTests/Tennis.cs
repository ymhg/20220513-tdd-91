using System.Collections.Generic;

namespace TennisTests;

public class Tennis
{
    private int _firstPlayerTimes;

    private readonly Dictionary<int, string> _scoreLookUp = new Dictionary<int, string>()
    {
        { 0, "Love" },
        { 1, "Fifteen" },
        { 2, "Thirty" },
        { 3, "Forty" },
    };

    private int _secondPlayerTimes;

    public string Score()
    {
        if (_firstPlayerTimes != _secondPlayerTimes)
        {
            return $"{_scoreLookUp[_firstPlayerTimes]} {_scoreLookUp[_secondPlayerTimes]}";
        }

        if (_firstPlayerTimes == 1)
        {
            return "Fifteen All";
        }

        return "Love All";
    }

    public void FirstPlayerScore()
    {
        _firstPlayerTimes++;
    }

    public void SecondPlayerScore()
    {
        _secondPlayerTimes++;
    }
}