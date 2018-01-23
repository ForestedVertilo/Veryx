using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start_Game : MonoBehaviour {
    
    public string scene;
    public Color col; 
	public void ChangeScene()
    {

        Initiate.Fade(scene, col, 0.5f); 
	}
}
