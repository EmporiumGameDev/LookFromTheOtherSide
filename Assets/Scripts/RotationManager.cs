using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

enum RotationSide
{
    Left = 1,
    Right = -1
}

public class RotationManager : MonoBehaviour
{
    public static RotationManager Instance;
    public UnityEvent<float> OnWorldRotated;
    
    [SerializeField] private List<Transform> _obstacles;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
            RotateWorld(RotationSide.Left);
        else if (Input.GetKeyDown(KeyCode.X))
            RotateWorld(RotationSide.Right);
    }

    private void RotateWorld(RotationSide side)
    {
        foreach (Transform obstacle in _obstacles)
            StartCoroutine(RotationProcess(obstacle, side));
    }

    private IEnumerator RotationProcess(Transform obstacle, RotationSide side, int rotationAngle = 90)
    {
        OnWorldRotated.Invoke(1f);

        for (int i = 0; i < rotationAngle; i += 1)
        {
            obstacle.RotateAround(transform.position, Vector3.up, 1 * (int)side);
            yield return null;
        }
    }
}
