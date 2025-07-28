using UnityEngine;

public static class ScoreManager
{
    public static int Score { get; private set; }

    public static void AddScore(int value) => Score += value;
    public static void Reset() => Score = 0;

    public static void Save() => PlayerPrefs.SetInt("HighScore", Score);
    public static int Load() => PlayerPrefs.GetInt("HighScore", 0);
}

