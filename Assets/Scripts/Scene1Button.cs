using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scene1Button : MonoBehaviour
{
    [SerializeField]
    private Button scene1Button;
    void Start()
    {
        scene1Button.onClick.AddListener(ChangeToScene2);
    }

    private void ChangeToScene2()
    {
        ScenesChanger.Instance.LoadScene(ScenesChanger.Scene.Scene2);
    }
}
