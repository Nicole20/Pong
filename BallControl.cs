using UnityEngine;
using System.Collections;

public class BallControl : MonoBehaviour
{
	int speed = 40;
	
	IEnumerator Start () 
	{
		yield return new WaitForSeconds(2f);
		GoBall();
	}

	void OnCollisionEnter2D (Collision2D colInfo)
	{
		if(colInfo.collider.tag == "Player")
		{
			Vector2 temp;

			temp.y = 2*rigidbody2D.velocity.y/3 + colInfo.collider.rigidbody2D.velocity.y/4;
			temp.x = rigidbody2D.velocity.x;

			if(temp.x > 0)
			{
				temp.x = temp.x + Mathf.Abs(colInfo.collider.rigidbody2D.velocity.y/6);
			}
			else
			{
				temp.x = temp.x - Mathf.Abs(colInfo.collider.rigidbody2D.velocity.y/6);
			}

			rigidbody2D.velocity = temp;
		}
	}

	IEnumerator ResetBall()
	{
		rigidbody2D.velocity = new Vector2 (0, 0);
		transform.position = new Vector2 (0, 0);

		yield return new WaitForSeconds(1f);

		GoBall ();
	}

	void GoBall()
	{
		int rand = Random.Range (0, 5);  //0 to 4
		
		if(rand == 0)
		{
			rigidbody2D.AddForce(new Vector2(speed, speed));
		}
		else if(rand == 1)
		{
			rigidbody2D.AddForce(new Vector2(-speed, speed));
		}
		else if(rand == 2)
		{
			rigidbody2D.AddForce(new Vector2(-speed, -speed));
		}
		else
		{
			rigidbody2D.AddForce(new Vector2(speed, -speed));
		}
	}
}
