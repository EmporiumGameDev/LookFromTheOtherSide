using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject _winWindow;

    public static GameManager instance = null; // Ёкземпл€р объекта

    // ћетод, выполн€емый при старте игры
    void Start()
    {
        // “еперь, провер€ем существование экземпл€ра
        if (instance == null)
        { // Ёкземпл€р менеджера был найден
            instance = this; // «адаем ссылку на экземпл€р объекта
        }
        else if (instance == this)
        { // Ёкземпл€р объекта уже существует на сцене
            Destroy(gameObject); // ”дал€ем объект
        }
    }
    public void Win()
    {
        _winWindow.SetActive(true);
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        Progress.Instance.SetLevel(currentSceneIndex);
    }
}
