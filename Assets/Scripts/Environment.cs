using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Environment : MonoBehaviour
{
    // Start is called before the first frame update
    public static Environment instance = null;
    // �����, ����������� ��� ������ ����
    void Start()
    {
        RotationManager.Instance.Obstacles.Clear(); 
        // ������, ��������� ������������� ����������
        if (instance == null)
        { // ��������� ��������� ��� ������
            instance = this; // ������ ������ �� ��������� �������
        }
        else if (instance == this)
        { // ��������� ������� ��� ���������� �� �����
            Destroy(gameObject); // ������� ������
        }
        RotationManager.Instance.Obstacles.Add(transform);
    }
}
