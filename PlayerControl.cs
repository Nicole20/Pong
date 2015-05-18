using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour
{
	public KeyCode moveUp, moveDown;

	public float speed = 10;

	void Update ()
	{
		Vector2 v = rigidbody2D.velocity;

		if(Input.GetKey(moveUp))
		{
			v.y = speed;
		}
		else if(Input.GetKey(moveDown))
		{
			v.y = -speed;
		}
		else
		{
			v.y = 0;
		}

		v.x = 0;

		rigidbody2D.velocity = v;
	}
}
