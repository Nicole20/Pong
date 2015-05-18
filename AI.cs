using UnityEngine;
using System.Collections;

public class AI : MonoBehaviour
{
	public float speed = 10;
	public Rigidbody2D ball;
	
	void Update ()
	{
		Vector2 v = rigidbody2D.velocity;

		if(ball.position.y > 2)  //ball move up
		{
			v.y = speed;
		}
		else if(ball.position.y < -2)  //ball move down
		{
			v.y = -speed;
		}
		else
		{
			if(rigidbody2D.position.y > 1)
			{
				v.y = -speed;
			}
			else if(rigidbody2D.position.y < -1)
			{
				v.y = speed;
			}
			else
			{
				v.y = 0;
			}
		}
		v.x = 0;
		rigidbody2D.velocity = v;
	}
}
