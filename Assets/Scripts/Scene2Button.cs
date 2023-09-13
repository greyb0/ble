using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scene2Button : MonoBehaviour
{
    [SerializeField]
    private Button scene2Button;
    void Start()
    {
        scene2Button.onClick.AddListener(ChangeToScene1);
    }

    private void ChangeToScene1()
    {
        ScenesChanger.Instance.LoadScene(ScenesChanger.Scene.Scene1);
    }
}