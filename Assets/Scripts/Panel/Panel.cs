using UnityEngine;

public class Panel: MonoBehaviour
{
    public void Open() => gameObject.SetActive(true);

    public void Close() => gameObject.SetActive(false);
}
