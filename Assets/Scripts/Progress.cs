using System;
using UnityEngine;

public class Progress : MonoBehaviour
{
    public int Level;

    public static Progress Instance;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
           // Load();
        }
        else
            Destroy(gameObject);
    }
    public void SetLevel(int level)
    {
        Level = level;
        //Save();
    }

    private void Save()
    {
        ProgressData progressData = new ProgressData();
        progressData.Level = Level;

        string json = JsonUtility.ToJson(progressData);
        PlayerPrefs.SetString("Progress", json);
    }

    private void Load()
    {
        if (PlayerPrefs.HasKey("Progress"))
        {
            string json = PlayerPrefs.GetString("Progress");
            ProgressData progressData = JsonUtility.FromJson<ProgressData>(json);

            Level = progressData.Level;
        }
    }
}

[Serializable]
public class ProgressData
{
    public int Level;
}
