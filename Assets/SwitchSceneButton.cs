using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SwitchSceneButton : MonoBehaviour
{
    [HideInInspector]
    public int LevelToLoad;

    void Awake()
    {
        var btn = GetComponent<Button>();
        if (btn != null)
        {
            btn.onClick.AddListener(OnMouseDown);
        }
    }

    void OnMouseDown()
    {
        Application.LoadLevel(LevelToLoad);
    }
}