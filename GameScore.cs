using UnityEngine;
using System.Collections;

public class GameScore : MonoBehaviour
{
	static int score1 = 0, score2 = 0;
	
	public GUISkin theSkin;

	public static void Score(string wall)
	{
		if(wall == "rightWall")
		{
			score1++;
		}
		else if(wall == "leftWall")
		{
			score2++;
		}
	}
	
	void OnGUI()
	{
		GUI.skin = theSkin;
		GUI.Label (new Rect (Screen.width / 2 - 150, 20, 100, 100), "" + score1);
		GUI.Label (new Rect (Screen.width / 2 + 150, 20, 100, 100), "" + score2);
	}
}
