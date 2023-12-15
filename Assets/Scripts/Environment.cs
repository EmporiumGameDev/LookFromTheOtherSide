using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Environment : MonoBehaviour
{
    // Start is called before the first frame update
    public static Environment instance = null;
    // ћетод, выполн€емый при старте игры
    void Start()
    {
        RotationManager.Instance.Obstacles.Clear(); 
        // “еперь, провер€ем существование экземпл€ра
        if (instance == null)
        { // Ёкземпл€р менеджера был найден
            instance = this; // «адаем ссылку на экземпл€р объекта
        }
        else if (instance == this)
        { // Ёкземпл€р объекта уже существует на сцене
            Destroy(gameObject); // ”дал€ем объект
        }
        RotationManager.Instance.Obstacles.Add(transform);
    }
}
