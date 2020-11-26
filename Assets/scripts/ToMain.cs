using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ToMain : MonoBehaviour
{
    public void LoadMain()
    {
        SceneManager.LoadScene("Title"); // 타이틀 씬으로 이동
    }
}