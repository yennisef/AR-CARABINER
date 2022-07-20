using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PindahScene : MonoBehaviour
{
    public void Play(string scene_name) {
        SceneManager.LoadScene(scene_name);
    }
}
