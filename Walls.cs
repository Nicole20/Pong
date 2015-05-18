using UnityEngine;
using System.Collections;

public class Walls : MonoBehaviour
{
	void OnTriggerEnter2D (Collider2D hitInfo)
	{
		if(hitInfo.name == "Ball")
		{
			string wallName = transform.name;
			GameScore.Score(wallName);
			hitInfo.gameObject.SendMessage("ResetBall");
		}
	}
}
