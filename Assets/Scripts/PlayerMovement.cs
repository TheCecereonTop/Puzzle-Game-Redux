using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Boundary1
{
	public float xMin, xMax, yMin, yMax;
}


public class PlayerMovement : MonoBehaviour {

	public float speed;

	public Boundary1 boundary;

	public GameObject bullet;
	public GameObject bomb;
	public Transform bulletSpawn;

	public Text pointsText;
	public float Points;

	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		var Movement = new Vector2 (moveHorizontal, moveVertical);
		var rigidbody = GetComponent<Rigidbody2D> ();
		rigidbody.velocity = Movement * speed;

		rigidbody.position = new Vector2(Mathf.Clamp (rigidbody.position.x, boundary.xMin, boundary.xMax),
			Mathf.Clamp (rigidbody.position.y, boundary.yMin, boundary.yMax));
	}

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space))
			Instantiate (bullet, bulletSpawn.position, bulletSpawn.rotation);
		if (Input.GetKeyDown (KeyCode.LeftAlt))
			Instantiate (bomb, bulletSpawn.position, bulletSpawn.rotation);
		//pointsText.text = Points.ToString();
		//Debug.Log ("Points: " + Points);
	}
}