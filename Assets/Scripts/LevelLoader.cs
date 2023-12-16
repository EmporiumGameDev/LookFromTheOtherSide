using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public static LevelLoader Instance;
    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    public void Home() => SceneManager.LoadScene(0);

    public void LoadLevel() => SceneManager.LoadScene(Progress.Instance.Level + 1);

    public void ReloadLevel() => SceneManager.LoadScene(SceneManager.GetActiveScene().name);
}
