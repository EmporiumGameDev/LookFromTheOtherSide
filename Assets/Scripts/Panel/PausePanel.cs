using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PausePanel : Panel
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            Open();
    }

    public override void Open()
    {
        base.Open();
        Time.timeScale = 0.0f;
    }

    public override void Close()
    {
        base.Close();
        Time.timeScale = 1.0f;
    }
}
