using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public GameObject clone;
	public GameObject[] Blocks;

	public float maxTime;
	public float minTime;

	//public float minScale;
	//public float maxScale;

	//public float minSpeed;
	//public float maxSpeed;

	private float time;
	private float spawnTime;


	//public float randomScale;

	public int maxBlocks;

	//public float randomSpeed;

	public float delta = 1.5f;
	public float speed = 1.0f;
	public Vector3 startPos;

	public bool Level1 = false;
	public bool Level2 = false;
	public bool Level3 = false;
	public bool Level4 = false;
	public bool Level5 = false;


	// Use this for initialization
	void Start () {
		Level1 = true;
		maxBlocks = 3;
		SetSpawnTime ();
		time = 0;
		startPos = transform.position;
	}

	void SetSpawnTime()
	{
		spawnTime = Random.Range (minTime, maxTime);
		//randomScale = Random.Range (minScale, maxScale);
		//randomSpeed = Random.Range (minSpeed, maxSpeed);
		//	Debug.Log ("Next Spawn Time Is " + spawnTime + "Seconds");
	}

	void FixedUpdate()
	{
		time += Time.deltaTime;
		if (time >= spawnTime) 
		{
			clone = Instantiate (Blocks[Random.Range(0,maxBlocks)], this.transform.position, this.transform.rotation);
			//clone.transform.localScale = new Vector3 (randomScale, randomScale, randomScale);
			//clone.GetComponent<Rigidbody2D> ().AddForce (-transform.up * randomSpeed);
			SetSpawnTime ();
			time = 0;
		}
	}


	// Update is called once per frame
	void Update () {

		Vector3 v = startPos;
		v.x += delta * Mathf.Sin (Time.time * speed);
		transform.position = v;

		if (Level1 == true && GameObject.Find ("Arena").GetComponent<Matrix> ().HP >= 100) 
		{
			maxBlocks = 4;
			Level1 = false;
			Level2 = true;
		}
		if (Level2 == true && GameObject.Find ("Arena").GetComponent<Matrix> ().HP >= 250) 
		{
			maxBlocks = 5;
			Level2 = false;
			Level3 = true;
		}
		if (Level3 == true && GameObject.Find ("Arena").GetComponent<Matrix> ().HP >= 550) 
		{
			maxBlocks =6;
			Level3 = false;
			Level4 = true;
		}
		if (Level4 == true && GameObject.Find ("Arena").GetComponent<Matrix> ().HP >= 1375) 
		{
			maxBlocks = 7;
			Level4 = false;
			Level5 = true;
		}

	}
}
