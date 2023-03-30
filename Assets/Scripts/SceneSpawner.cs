using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSpawner : MonoBehaviour
{
    [SerializeField] private AudioSource buttonPushSound;
    [SerializeField] private AudioSource musicLoop;

    public void LoadGameScene() {
        musicLoop.Pause();
        buttonPushSound.Play();

        Invoke("DelayedLoading", 1.20f);
    }

    public void DelayedLoading() {
        SceneManager.LoadScene("Game");
    }
}
