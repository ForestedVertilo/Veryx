using UnityEngine;
using System.Collections;

public class DemoScript : MonoBehaviour {
    //name of the scene you want to load
    public string scene;
	public string nextScene;
	public Color loadToColor = Color.white;
	public static bool click = false;
	// Update is called once per frame
	void OnGUI () {
		if(click)
			{Initiate.Fade(scene,loadToColor,0.9f);	
			click = false;
			}
		if(script.cherryCount == 0)
			{Initiate.Fade(nextScene,loadToColor,0.9f);	
			click = false;
			}
		if(script.isLose == true)
			{Initiate.Fade("LoseScene",loadToColor,0.9f);	
			click = false;
			}
	}
	public void click_button(){
	click = true;
	}
}
