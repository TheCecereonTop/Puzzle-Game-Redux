using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocks : MonoBehaviour {

	public bool Placed = false;
	public bool Active;

	public float minSpeed;
	public float maxSpeed;

	public int colorCode;


	public float randomSpeed;

	public ParticleSystem Boom;

	// Use this for initialization
	void Start () {
		Debug.Log (GameObject.Find("Arena").GetComponent<Matrix>().columnCounter1);
	}
	
	// Update is called once per frame
	void Update () {
		if (Active == true && Placed == false)
		{
			gameObject.GetComponent<Rigidbody2D> ().gravityScale = 0.5f;
		}
		if (Active == false && Placed == false)
		{
			randomSpeed = Random.Range (minSpeed, maxSpeed);
			gameObject.GetComponent<Rigidbody2D> ().AddForce (-transform.up * randomSpeed);
		}
		if (Placed == true) 
		{
			gameObject.GetComponent<Rigidbody2D> ().bodyType = RigidbodyType2D.Static;
		}
	}

	void OnTriggerEnter2D (Collider2D col)
	{

		if (col.gameObject.tag == "BottomBlock1" && Placed == false) 
		{
			//Debug.Log (GameObject.Find ("Arena").GetComponent<Matrix> ().blocksColumn1.Count);
			GameObject.Find("Arena").GetComponent<Matrix>().columnCounter1 += 1;
			//Debug.Log (GameObject.Find("Arena").GetComponent<Matrix>().columnCounter1);
			gameObject.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0.0f, 0.0f);
			gameObject.transform.position = GameObject.Find("Arena").GetComponent<Matrix>().firstColumn[GameObject.Find("Arena").GetComponent<Matrix>().columnCounter1].transform.position;
			gameObject.transform.rotation = GameObject.Find("Arena").GetComponent<Matrix>().firstColumn[GameObject.Find("Arena").GetComponent<Matrix>().columnCounter1].transform.rotation;
			col.gameObject.transform.position = GameObject.Find("Arena").GetComponent<Matrix>().firstColumn [GameObject.Find("Arena").GetComponent<Matrix>().columnCounter1].transform.position;
			Placed = true;
			GameObject.Find ("Arena").GetComponent<Matrix> ().blocksColumn1.Add (gameObject);
			Boom.Play();
			if (GameObject.Find("Arena").GetComponent<Matrix>().bottomBlock1Code == 0)
				GameObject.Find("Arena").GetComponent<Matrix>().bottomBlock1Code = colorCode;
			if (GameObject.Find("Arena").GetComponent<Matrix>().bottomBlock1Code != 0) 
			{
				if (GameObject.Find ("Arena").GetComponent<Matrix> ().bottomBlock1Code != colorCode) 
				{
					Debug.Log ("Ya Dun Goof'd");
					for (int i = 0; i < GameObject.Find ("Arena").GetComponent<Matrix> ().blocksColumn1.Count; i++)
					{
						Destroy (GameObject.Find ("Arena").GetComponent<Matrix> ().blocksColumn1 [i].gameObject);
						GameObject.Find("Arena").GetComponent<Matrix>().columnCounter1 =0;
						col.gameObject.transform.position = GameObject.Find("Arena").GetComponent<Matrix>().firstColumn [GameObject.Find("Arena").GetComponent<Matrix>().columnCounter1].transform.position;
						GameObject.Find ("Arena").GetComponent<Matrix> ().bottomBlock1Code = 0;
						GameObject.Find ("Arena").GetComponent<Matrix> ().HP -= GameObject.Find ("Arena").GetComponent<Matrix> ().column1Score;

					}
					GameObject.Find ("Arena").GetComponent<Matrix> ().blocksColumn1.Clear ();
					Debug.Log ("Column 1 destroyed, it's count is one " + GameObject.Find ("Arena").GetComponent<Matrix> ().blocksColumn1.Count);
				}
			}
				


		}
		if (col.gameObject.tag == "BottomBlock2" && Placed == false) 
		{
			//Debug.Log ("pass");
			gameObject.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0.0f, 0.0f);
			GameObject.Find("Arena").GetComponent<Matrix>().columnCounter2 += 1;
			//Debug.Log (GameObject.Find("Arena").GetComponent<Matrix>().columnCounter2);
			gameObject.transform.position = GameObject.Find("Arena").GetComponent<Matrix>().secondColumn[GameObject.Find("Arena").GetComponent<Matrix>().columnCounter2].transform.position;
			gameObject.transform.rotation = GameObject.Find("Arena").GetComponent<Matrix>().secondColumn[GameObject.Find("Arena").GetComponent<Matrix>().columnCounter2].transform.rotation;
			Placed = true;
			col.gameObject.transform.position = GameObject.Find("Arena").GetComponent<Matrix>().secondColumn [GameObject.Find("Arena").GetComponent<Matrix>().columnCounter2].transform.position;
			GameObject.Find ("Arena").GetComponent<Matrix> ().blocksColumn2.Add (gameObject);
			Boom.Play();
			if (GameObject.Find("Arena").GetComponent<Matrix>().bottomBlock2Code == 0)
				GameObject.Find("Arena").GetComponent<Matrix>().bottomBlock2Code = colorCode;
			if (GameObject.Find("Arena").GetComponent<Matrix>().bottomBlock2Code != 0) 
			{
				if (GameObject.Find ("Arena").GetComponent<Matrix> ().bottomBlock2Code != colorCode) 
				{
					Debug.Log ("Ya Dun Goof'd");
					for (int i = 0; i < GameObject.Find ("Arena").GetComponent<Matrix> ().blocksColumn2.Count; i++)
					{
						Destroy (GameObject.Find ("Arena").GetComponent<Matrix> ().blocksColumn2 [i].gameObject);
						GameObject.Find("Arena").GetComponent<Matrix>().columnCounter2 =0;
						col.gameObject.transform.position = GameObject.Find("Arena").GetComponent<Matrix>().secondColumn [GameObject.Find("Arena").GetComponent<Matrix>().columnCounter2].transform.position;
						GameObject.Find ("Arena").GetComponent<Matrix> ().bottomBlock2Code = 0;
						GameObject.Find ("Arena").GetComponent<Matrix> ().HP -= GameObject.Find ("Arena").GetComponent<Matrix> ().column2Score;
					}
					GameObject.Find ("Arena").GetComponent<Matrix> ().blocksColumn2.Clear ();
					Debug.Log ("Column 2 destroyed, it's count is one " + GameObject.Find ("Arena").GetComponent<Matrix> ().blocksColumn2.Count);
				}
			}

		}
		if (col.gameObject.tag == "BottomBlock3" && Placed == false) 
		{
			//Debug.Log ("pass");
			gameObject.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0.0f, 0.0f);
			GameObject.Find("Arena").GetComponent<Matrix>().columnCounter3 += 1;
			//Debug.Log (GameObject.Find("Arena").GetComponent<Matrix>().columnCounter3);
			gameObject.transform.position = GameObject.Find("Arena").GetComponent<Matrix>().thirdColumn[GameObject.Find("Arena").GetComponent<Matrix>().columnCounter3].transform.position;
			gameObject.transform.rotation = GameObject.Find("Arena").GetComponent<Matrix>().thirdColumn[GameObject.Find("Arena").GetComponent<Matrix>().columnCounter3].transform.rotation;
			Placed = true;
			col.gameObject.transform.position = GameObject.Find("Arena").GetComponent<Matrix>().thirdColumn [GameObject.Find("Arena").GetComponent<Matrix>().columnCounter3].transform.position;
			GameObject.Find ("Arena").GetComponent<Matrix> ().blocksColumn3.Add (gameObject);
			Boom.Play();
			if (GameObject.Find("Arena").GetComponent<Matrix>().bottomBlock3Code == 0)
				GameObject.Find("Arena").GetComponent<Matrix>().bottomBlock3Code = colorCode;
			if (GameObject.Find("Arena").GetComponent<Matrix>().bottomBlock3Code != 0) 
			{
				if (GameObject.Find ("Arena").GetComponent<Matrix> ().bottomBlock3Code != colorCode) 
				{
					Debug.Log ("Ya Dun Goof'd");
					for (int i = 0; i < GameObject.Find ("Arena").GetComponent<Matrix> ().blocksColumn3.Count; i++)
					{
						Destroy (GameObject.Find ("Arena").GetComponent<Matrix> ().blocksColumn3 [i].gameObject);
						GameObject.Find("Arena").GetComponent<Matrix>().columnCounter3 =0;
						col.gameObject.transform.position = GameObject.Find("Arena").GetComponent<Matrix>().thirdColumn [GameObject.Find("Arena").GetComponent<Matrix>().columnCounter3].transform.position;
						GameObject.Find ("Arena").GetComponent<Matrix> ().bottomBlock3Code = 0;
						GameObject.Find ("Arena").GetComponent<Matrix> ().HP -= GameObject.Find ("Arena").GetComponent<Matrix> ().column3Score;
					}
					GameObject.Find ("Arena").GetComponent<Matrix> ().blocksColumn3.Clear ();
					Debug.Log ("Column 3 destroyed, it's count is one " + GameObject.Find ("Arena").GetComponent<Matrix> ().blocksColumn3.Count);
				}
			}

		}
		if (col.gameObject.tag == "BottomBlock4" && Placed == false) 
		{
			//Debug.Log ("pass");
			gameObject.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0.0f, 0.0f);
			GameObject.Find("Arena").GetComponent<Matrix>().columnCounter4 += 1;
			//Debug.Log (GameObject.Find("Arena").GetComponent<Matrix>().columnCounter4);
			gameObject.transform.position = GameObject.Find("Arena").GetComponent<Matrix>().fourthColumn[GameObject.Find("Arena").GetComponent<Matrix>().columnCounter4].transform.position;
			gameObject.transform.rotation = GameObject.Find("Arena").GetComponent<Matrix>().fourthColumn[GameObject.Find("Arena").GetComponent<Matrix>().columnCounter4].transform.rotation;
			Placed = true;
			col.gameObject.transform.position = GameObject.Find("Arena").GetComponent<Matrix>().fourthColumn [GameObject.Find("Arena").GetComponent<Matrix>().columnCounter4].transform.position;
			GameObject.Find ("Arena").GetComponent<Matrix> ().blocksColumn4.Add (gameObject);
			Boom.Play();
			if (GameObject.Find("Arena").GetComponent<Matrix>().bottomBlock4Code == 0)
				GameObject.Find("Arena").GetComponent<Matrix>().bottomBlock4Code = colorCode;
			
			if (GameObject.Find("Arena").GetComponent<Matrix>().bottomBlock4Code != 0) 
			{
				if (GameObject.Find ("Arena").GetComponent<Matrix> ().bottomBlock4Code != colorCode) 
				{
					Debug.Log ("Ya Dun Goof'd");
					for (int i = 0; i < GameObject.Find ("Arena").GetComponent<Matrix> ().blocksColumn4.Count; i++)
					{
						Destroy (GameObject.Find ("Arena").GetComponent<Matrix> ().blocksColumn4 [i].gameObject);
						GameObject.Find("Arena").GetComponent<Matrix>().columnCounter4 =0;
						col.gameObject.transform.position = GameObject.Find("Arena").GetComponent<Matrix>().fourthColumn [GameObject.Find("Arena").GetComponent<Matrix>().columnCounter4].transform.position;
						GameObject.Find ("Arena").GetComponent<Matrix> ().bottomBlock4Code = 0;
						GameObject.Find ("Arena").GetComponent<Matrix> ().HP -= GameObject.Find ("Arena").GetComponent<Matrix> ().column4Score;

					}
					GameObject.Find ("Arena").GetComponent<Matrix> ().blocksColumn4.Clear ();
					Debug.Log ("Column 4 destroyed, it's count is one " + GameObject.Find ("Arena").GetComponent<Matrix> ().blocksColumn4.Count);
				}
			}

		}
		if (col.gameObject.tag == "BottomBlock5" && Placed == false) 
		{
			//Debug.Log ("pass");
			gameObject.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0.0f, 0.0f);
			GameObject.Find("Arena").GetComponent<Matrix>().columnCounter5 += 1;
			//Debug.Log (GameObject.Find("Arena").GetComponent<Matrix>().columnCounter5);
			gameObject.transform.position = GameObject.Find("Arena").GetComponent<Matrix>().fifthColumn[GameObject.Find("Arena").GetComponent<Matrix>().columnCounter5].transform.position;
			gameObject.transform.rotation = GameObject.Find("Arena").GetComponent<Matrix>().fifthColumn[GameObject.Find("Arena").GetComponent<Matrix>().columnCounter5].transform.rotation;
			Placed = true;
			col.gameObject.transform.position = GameObject.Find("Arena").GetComponent<Matrix>().fifthColumn [GameObject.Find("Arena").GetComponent<Matrix>().columnCounter5].transform.position;
			GameObject.Find ("Arena").GetComponent<Matrix> ().blocksColumn5.Add (gameObject);
			Boom.Play();
			if (GameObject.Find("Arena").GetComponent<Matrix>().bottomBlock5Code == 0)
				GameObject.Find("Arena").GetComponent<Matrix>().bottomBlock5Code = colorCode;
			if (GameObject.Find("Arena").GetComponent<Matrix>().bottomBlock5Code != 0) 
			{
				if (GameObject.Find ("Arena").GetComponent<Matrix> ().bottomBlock5Code != colorCode) 
				{
					Debug.Log ("Ya Dun Goof'd");
					for (int i = 0; i < GameObject.Find ("Arena").GetComponent<Matrix> ().blocksColumn5.Count; i++)
					{
						Destroy (GameObject.Find ("Arena").GetComponent<Matrix> ().blocksColumn5 [i].gameObject);
						GameObject.Find("Arena").GetComponent<Matrix>().columnCounter5 =0;
						col.gameObject.transform.position = GameObject.Find("Arena").GetComponent<Matrix>().fifthColumn [GameObject.Find("Arena").GetComponent<Matrix>().columnCounter5].transform.position;
						GameObject.Find ("Arena").GetComponent<Matrix> ().bottomBlock5Code = 0;
						GameObject.Find ("Arena").GetComponent<Matrix> ().HP -= GameObject.Find ("Arena").GetComponent<Matrix> ().column5Score;
					}
					GameObject.Find ("Arena").GetComponent<Matrix> ().blocksColumn5.Clear ();
					Debug.Log ("Column 5 destroyed, it's count is one " + GameObject.Find ("Arena").GetComponent<Matrix> ().blocksColumn5.Count);
				}
			}

		}
		if (col.gameObject.tag == "BottomBlock6" && Placed == false) 
		{
			//Debug.Log ("pass");
			gameObject.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0.0f, 0.0f);
			GameObject.Find("Arena").GetComponent<Matrix>().columnCounter6 += 1;
			//Debug.Log (GameObject.Find("Arena").GetComponent<Matrix>().columnCounter6);
			gameObject.transform.position = GameObject.Find("Arena").GetComponent<Matrix>().sixthColumn[GameObject.Find("Arena").GetComponent<Matrix>().columnCounter6].transform.position;
			gameObject.transform.rotation = GameObject.Find("Arena").GetComponent<Matrix>().sixthColumn[GameObject.Find("Arena").GetComponent<Matrix>().columnCounter6].transform.rotation;
			Placed = true;
			col.gameObject.transform.position = GameObject.Find("Arena").GetComponent<Matrix>().sixthColumn [GameObject.Find("Arena").GetComponent<Matrix>().columnCounter6].transform.position;
			GameObject.Find ("Arena").GetComponent<Matrix> ().blocksColumn6.Add (gameObject);
			Boom.Play();
			if (GameObject.Find("Arena").GetComponent<Matrix>().bottomBlock6Code == 0)
				GameObject.Find("Arena").GetComponent<Matrix>().bottomBlock6Code = colorCode;
			if (GameObject.Find("Arena").GetComponent<Matrix>().bottomBlock6Code != 0) 
			{
				if (GameObject.Find ("Arena").GetComponent<Matrix> ().bottomBlock6Code != colorCode) 
				{
					Debug.Log ("Ya Dun Goof'd");
					for (int i = 0; i < GameObject.Find ("Arena").GetComponent<Matrix> ().blocksColumn6.Count; i++)
					{
						Destroy (GameObject.Find ("Arena").GetComponent<Matrix> ().blocksColumn6 [i].gameObject);
						GameObject.Find("Arena").GetComponent<Matrix>().columnCounter6 =0;
						col.gameObject.transform.position = GameObject.Find("Arena").GetComponent<Matrix>().sixthColumn [GameObject.Find("Arena").GetComponent<Matrix>().columnCounter6].transform.position;
						GameObject.Find ("Arena").GetComponent<Matrix> ().bottomBlock6Code = 0;
						GameObject.Find ("Arena").GetComponent<Matrix> ().HP -= GameObject.Find ("Arena").GetComponent<Matrix> ().column6Score;
					}
					GameObject.Find ("Arena").GetComponent<Matrix> ().blocksColumn6.Clear ();
					Debug.Log ("Column 6 destroyed, it's count is one " + GameObject.Find ("Arena").GetComponent<Matrix> ().blocksColumn6.Count);
				}
			}
		}
		if (col.gameObject.tag == "BottomBlock7" && Placed == false) 
		{
			//Debug.Log ("pass");
			gameObject.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0.0f, 0.0f);
			GameObject.Find("Arena").GetComponent<Matrix>().columnCounter7 += 1;
			//Debug.Log (GameObject.Find("Arena").GetComponent<Matrix>().columnCounter7);
			gameObject.transform.position = GameObject.Find("Arena").GetComponent<Matrix>().seventhColumn[GameObject.Find("Arena").GetComponent<Matrix>().columnCounter7].transform.position;
			gameObject.transform.rotation = GameObject.Find("Arena").GetComponent<Matrix>().seventhColumn[GameObject.Find("Arena").GetComponent<Matrix>().columnCounter7].transform.rotation;
			Placed = true;
			col.gameObject.transform.position = GameObject.Find("Arena").GetComponent<Matrix>().seventhColumn [GameObject.Find("Arena").GetComponent<Matrix>().columnCounter7].transform.position;
			GameObject.Find ("Arena").GetComponent<Matrix> ().blocksColumn7.Add (gameObject);
			Boom.Play();
			if (GameObject.Find("Arena").GetComponent<Matrix>().bottomBlock7Code == 0)
				GameObject.Find("Arena").GetComponent<Matrix>().bottomBlock7Code = colorCode;
			if (GameObject.Find("Arena").GetComponent<Matrix>().bottomBlock7Code != 0) 
			{
				if (GameObject.Find ("Arena").GetComponent<Matrix> ().bottomBlock7Code != colorCode) 
				{
					Debug.Log ("Ya Dun Goof'd");
					for (int i = 0; i < GameObject.Find ("Arena").GetComponent<Matrix> ().blocksColumn7.Count; i++)
					{
						Destroy (GameObject.Find ("Arena").GetComponent<Matrix> ().blocksColumn7 [i].gameObject);
						GameObject.Find("Arena").GetComponent<Matrix>().columnCounter7 =0;
						col.gameObject.transform.position = GameObject.Find("Arena").GetComponent<Matrix>().seventhColumn [GameObject.Find("Arena").GetComponent<Matrix>().columnCounter7].transform.position;
						GameObject.Find ("Arena").GetComponent<Matrix> ().bottomBlock7Code = 0;
						GameObject.Find ("Arena").GetComponent<Matrix> ().HP -= GameObject.Find ("Arena").GetComponent<Matrix> ().column7Score;
					}
					GameObject.Find ("Arena").GetComponent<Matrix> ().blocksColumn7.Clear ();
					Debug.Log ("Column 7 destroyed, it's count is one " + GameObject.Find ("Arena").GetComponent<Matrix> ().blocksColumn7.Count);
				}
			}

		}
		if (col.gameObject.tag == "BottomBlock8" && Placed == false) 
		{
			//Debug.Log ("pass");
			gameObject.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0.0f, 0.0f);
			GameObject.Find("Arena").GetComponent<Matrix>().columnCounter8 += 1;
			//Debug.Log (GameObject.Find("Arena").GetComponent<Matrix>().columnCounter8);
			gameObject.transform.position = GameObject.Find("Arena").GetComponent<Matrix>().eigthColumn[GameObject.Find("Arena").GetComponent<Matrix>().columnCounter8].transform.position;
			gameObject.transform.rotation = GameObject.Find("Arena").GetComponent<Matrix>().eigthColumn[GameObject.Find("Arena").GetComponent<Matrix>().columnCounter8].transform.rotation;
			Placed = true;
			col.gameObject.transform.position = GameObject.Find("Arena").GetComponent<Matrix>().eigthColumn [GameObject.Find("Arena").GetComponent<Matrix>().columnCounter8].transform.position;
			GameObject.Find ("Arena").GetComponent<Matrix> ().blocksColumn8.Add (gameObject);
			Boom.Play();
			if (GameObject.Find("Arena").GetComponent<Matrix>().bottomBlock8Code == 0)
				GameObject.Find("Arena").GetComponent<Matrix>().bottomBlock8Code = colorCode;
			if (GameObject.Find("Arena").GetComponent<Matrix>().bottomBlock8Code != 0) 
			{
				if (GameObject.Find ("Arena").GetComponent<Matrix> ().bottomBlock8Code != colorCode) 
				{
					Debug.Log ("Ya Dun Goof'd");
					for (int i = 0; i < GameObject.Find ("Arena").GetComponent<Matrix> ().blocksColumn8.Count; i++)
					{
						Destroy (GameObject.Find ("Arena").GetComponent<Matrix> ().blocksColumn8 [i].gameObject);
						GameObject.Find("Arena").GetComponent<Matrix>().columnCounter8 =0;
						col.gameObject.transform.position = GameObject.Find("Arena").GetComponent<Matrix>().eigthColumn [GameObject.Find("Arena").GetComponent<Matrix>().columnCounter8].transform.position;
						GameObject.Find ("Arena").GetComponent<Matrix> ().bottomBlock8Code = 0;Debug.Log ("Column 9 destroyed, it's count is one " + GameObject.Find ("Arena").GetComponent<Matrix> ().blocksColumn9.Count);
						GameObject.Find ("Arena").GetComponent<Matrix> ().HP -= GameObject.Find ("Arena").GetComponent<Matrix> ().column8Score;
					}
					GameObject.Find ("Arena").GetComponent<Matrix> ().blocksColumn8.Clear ();
					Debug.Log ("Column 8 destroyed, it's count is one " + GameObject.Find ("Arena").GetComponent<Matrix> ().blocksColumn8.Count);
				}
			}

		}
		if (col.gameObject.tag == "BottomBlock9" && Placed == false) 
		{
			//Debug.Log ("pass");
			gameObject.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0.0f, 0.0f);
			GameObject.Find("Arena").GetComponent<Matrix>().columnCounter9 += 1;
			//Debug.Log (GameObject.Find("Arena").GetComponent<Matrix>().columnCounter9);
			gameObject.transform.position = GameObject.Find("Arena").GetComponent<Matrix>().ninethColumn[GameObject.Find("Arena").GetComponent<Matrix>().columnCounter9].transform.position;
			gameObject.transform.rotation = GameObject.Find("Arena").GetComponent<Matrix>().ninethColumn[GameObject.Find("Arena").GetComponent<Matrix>().columnCounter9].transform.rotation;
			Placed = true;
			col.gameObject.transform.position = GameObject.Find("Arena").GetComponent<Matrix>().ninethColumn [GameObject.Find("Arena").GetComponent<Matrix>().columnCounter9].transform.position;
			GameObject.Find ("Arena").GetComponent<Matrix> ().blocksColumn9.Add (gameObject);
			Boom.Play();
			if (GameObject.Find("Arena").GetComponent<Matrix>().bottomBlock9Code == 0)
				GameObject.Find("Arena").GetComponent<Matrix>().bottomBlock9Code = colorCode;
			if (GameObject.Find("Arena").GetComponent<Matrix>().bottomBlock9Code != 0) 
			{
				if (GameObject.Find ("Arena").GetComponent<Matrix> ().bottomBlock9Code != colorCode) 
				{
					Debug.Log ("Ya Dun Goof'd");
					for (int i = 0; i < GameObject.Find ("Arena").GetComponent<Matrix> ().blocksColumn9.Count; i++)
					{
						Destroy (GameObject.Find ("Arena").GetComponent<Matrix> ().blocksColumn9 [i].gameObject);
						GameObject.Find("Arena").GetComponent<Matrix>().columnCounter9 =0;
						col.gameObject.transform.position = GameObject.Find("Arena").GetComponent<Matrix>().ninethColumn [GameObject.Find("Arena").GetComponent<Matrix>().columnCounter9].transform.position;
						GameObject.Find ("Arena").GetComponent<Matrix> ().bottomBlock9Code = 0;
						GameObject.Find ("Arena").GetComponent<Matrix> ().HP -= GameObject.Find ("Arena").GetComponent<Matrix> ().column9Score;

					}
					GameObject.Find ("Arena").GetComponent<Matrix> ().blocksColumn9.Clear ();
					Debug.Log ("Column 9 destroyed, it's count is one " + GameObject.Find ("Arena").GetComponent<Matrix> ().blocksColumn9.Count);
				}
				
			}

		}
	}

	void OnCollisionEnter2D(Collision2D col)
	{

		if (col.gameObject.tag == "Bomb") {
			Destroy (col.gameObject);
			Destroy (gameObject);
		}
		if (col.gameObject.tag == "Bullet") {
			Active = true;
			gameObject.GetComponent<Rigidbody2D> ().AddForce (transform.up * 50);
		}

	}
		

}
