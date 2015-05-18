using UnityEngine;
using System.Collections;

public class GameSetup : MonoBehaviour
{
	public Camera mainCamera;
	public BoxCollider2D topWall, bottomWall, leftWall, rightWall;

	public Transform player1, player2;

	void Start ()
	{
		topWall.size = new Vector2 (mainCamera.ScreenToWorldPoint (new Vector3 (Screen.width * 2f, 0f, 0f)).x, 1f);
		topWall.center = new Vector2 (0f, mainCamera.ScreenToWorldPoint (new Vector3 (0f, Screen.height, 0f)).y + 0.5f);

		bottomWall.size = new Vector2 (mainCamera.ScreenToWorldPoint (new Vector3 (Screen.width * 2f, 0f, 0f)).x, 1f);
		bottomWall.center = new Vector2 (0f, mainCamera.ScreenToWorldPoint (new Vector3 (0f, 0f, 0f)).y - 0.5f);

		leftWall.size = new Vector2 (1f, mainCamera.ScreenToWorldPoint (new Vector3 (0f, Screen.height * 2f, 0f)).y);
		leftWall.center = new Vector2 (mainCamera.ScreenToWorldPoint (new Vector3 (0f, 0f, 0f)).x - 0.5f, 0f);

		rightWall.size = new Vector2 (1f, mainCamera.ScreenToWorldPoint (new Vector3 (0f, Screen.height * 2f, 0f)).y);
		rightWall.center = new Vector2 (mainCamera.ScreenToWorldPoint (new Vector3 (Screen.width, 0f, 0f)).x + 0.5f, 0f);

		player1.position = new Vector2(mainCamera.ScreenToWorldPoint (new Vector3 (75f, 0f, 0f)).x, 0);
		player2.position = new Vector2(mainCamera.ScreenToWorldPoint (new Vector3 (Screen.width - 75f, 0f, 0f)).x, 0);
	}
}
