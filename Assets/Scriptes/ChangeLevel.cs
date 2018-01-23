using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeLevel : MonoBehaviour {

    public int  LoadSceneWithId = 1;
    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        if
        (otherCollider.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(LoadSceneWithId);
        }
    }
}

