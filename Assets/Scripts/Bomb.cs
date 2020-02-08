using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour {


	public GameObject explosionHolder;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D col)
	{

		//bombBoom.Play ();

		if (GameObject.Find("Arena").GetComponent<Matrix>().blocksColumn1.Contains(col.gameObject))
			{
			Instantiate (explosionHolder, gameObject.transform.position, gameObject.transform.rotation);
			//bombBoom.Play ();

				for (int i = 0; i < GameObject.Find ("Arena").GetComponent<Matrix> ().blocksColumn1.Count; i++)
				{
					Destroy (GameObject.Find ("Arena").GetComponent<Matrix> ().blocksColumn1 [i].gameObject);
					GameObject.Find("Arena").GetComponent<Matrix>().columnCounter1 =0;
					col.gameObject.transform.position = GameObject.Find("Arena").GetComponent<Matrix>().firstColumn [GameObject.Find("Arena").GetComponent<Matrix>().columnCounter1].transform.position;
					GameObject.Find ("Arena").GetComponent<Matrix> ().bottomBlock1Code = 0;
					GameObject.Find ("Arena").GetComponent<Matrix> ().HP += GameObject.Find ("Arena").GetComponent<Matrix> ().column1Score-1;
				}

			GameObject.Find ("Arena").GetComponent<Matrix> ().blocksColumn1.Clear ();
			Debug.Log ("Column 1 destroyed, it's count is one " + GameObject.Find ("Arena").GetComponent<Matrix> ().blocksColumn1.Count);
			}

		if (GameObject.Find("Arena").GetComponent<Matrix>().blocksColumn2.Contains(col.gameObject))
		{
			Instantiate (explosionHolder, gameObject.transform.position, gameObject.transform.rotation);
			//bombBoom.Play ();
			for (int i = 0; i < GameObject.Find ("Arena").GetComponent<Matrix> ().blocksColumn2.Count; i++)
			{
				Destroy (GameObject.Find ("Arena").GetComponent<Matrix> ().blocksColumn2 [i].gameObject);
				GameObject.Find("Arena").GetComponent<Matrix>().columnCounter2 =0;
				col.gameObject.transform.position = GameObject.Find("Arena").GetComponent<Matrix>().secondColumn [GameObject.Find("Arena").GetComponent<Matrix>().columnCounter2].transform.position;
				GameObject.Find ("Arena").GetComponent<Matrix> ().bottomBlock2Code = 0;
				GameObject.Find ("Arena").GetComponent<Matrix> ().HP += GameObject.Find ("Arena").GetComponent<Matrix> ().column2Score-1;
			}

			GameObject.Find ("Arena").GetComponent<Matrix> ().blocksColumn2.Clear ();
			Debug.Log ("Column 2 destroyed, it's count is one " + GameObject.Find ("Arena").GetComponent<Matrix> ().blocksColumn2.Count);
		}

		if (GameObject.Find("Arena").GetComponent<Matrix>().blocksColumn3.Contains(col.gameObject))
		{
			Instantiate (explosionHolder, gameObject.transform.position, gameObject.transform.rotation);
			//bombBoom.Play ();
			for (int i = 0; i < GameObject.Find ("Arena").GetComponent<Matrix> ().blocksColumn3.Count; i++)
			{
				Destroy (GameObject.Find ("Arena").GetComponent<Matrix> ().blocksColumn3 [i].gameObject);
				GameObject.Find("Arena").GetComponent<Matrix>().columnCounter3 =0;
				col.gameObject.transform.position = GameObject.Find("Arena").GetComponent<Matrix>().thirdColumn [GameObject.Find("Arena").GetComponent<Matrix>().columnCounter3].transform.position;
				GameObject.Find ("Arena").GetComponent<Matrix> ().bottomBlock3Code = 0;
				GameObject.Find ("Arena").GetComponent<Matrix> ().HP += GameObject.Find ("Arena").GetComponent<Matrix> ().column3Score-1;
			}

			GameObject.Find ("Arena").GetComponent<Matrix> ().blocksColumn3.Clear ();
			Debug.Log ("Column 3 destroyed, it's count is one " + GameObject.Find ("Arena").GetComponent<Matrix> ().blocksColumn3.Count);
		}

		if (GameObject.Find("Arena").GetComponent<Matrix>().blocksColumn4.Contains(col.gameObject))
		{
			Instantiate (explosionHolder, gameObject.transform.position, gameObject.transform.rotation);
			//bombBoom.Play ();
			for (int i = 0; i < GameObject.Find ("Arena").GetComponent<Matrix> ().blocksColumn4.Count; i++)
			{
				Destroy (GameObject.Find ("Arena").GetComponent<Matrix> ().blocksColumn4 [i].gameObject);
				GameObject.Find("Arena").GetComponent<Matrix>().columnCounter4 =0;
				col.gameObject.transform.position = GameObject.Find("Arena").GetComponent<Matrix>().fourthColumn [GameObject.Find("Arena").GetComponent<Matrix>().columnCounter4].transform.position;
				GameObject.Find ("Arena").GetComponent<Matrix> ().bottomBlock4Code = 0;
				GameObject.Find ("Arena").GetComponent<Matrix> ().HP += GameObject.Find ("Arena").GetComponent<Matrix> ().column4Score-1;
			}

			GameObject.Find ("Arena").GetComponent<Matrix> ().blocksColumn4.Clear ();
			Debug.Log ("Column 4 destroyed, it's count is one " + GameObject.Find ("Arena").GetComponent<Matrix> ().blocksColumn4.Count);
		}

		if (GameObject.Find("Arena").GetComponent<Matrix>().blocksColumn5.Contains(col.gameObject))
		{
			Instantiate (explosionHolder, gameObject.transform.position, gameObject.transform.rotation);
			//bombBoom.Play ();
			for (int i = 0; i < GameObject.Find ("Arena").GetComponent<Matrix> ().blocksColumn5.Count; i++)
			{
				Destroy (GameObject.Find ("Arena").GetComponent<Matrix> ().blocksColumn5 [i].gameObject);
				GameObject.Find("Arena").GetComponent<Matrix>().columnCounter5 =0;
				col.gameObject.transform.position = GameObject.Find("Arena").GetComponent<Matrix>().fifthColumn [GameObject.Find("Arena").GetComponent<Matrix>().columnCounter5].transform.position;
				GameObject.Find ("Arena").GetComponent<Matrix> ().bottomBlock5Code = 0;
				GameObject.Find ("Arena").GetComponent<Matrix> ().HP += GameObject.Find ("Arena").GetComponent<Matrix> ().column5Score-1;
			}

			GameObject.Find ("Arena").GetComponent<Matrix> ().blocksColumn5.Clear ();
			Debug.Log ("Column 5 destroyed, it's count is one " + GameObject.Find ("Arena").GetComponent<Matrix> ().blocksColumn5.Count);
		}

		if (GameObject.Find("Arena").GetComponent<Matrix>().blocksColumn6.Contains(col.gameObject))
		{
			Instantiate (explosionHolder, gameObject.transform.position, gameObject.transform.rotation);
			//bombBoom.Play ();
			for (int i = 0; i < GameObject.Find ("Arena").GetComponent<Matrix> ().blocksColumn6.Count; i++)
			{
				Destroy (GameObject.Find ("Arena").GetComponent<Matrix> ().blocksColumn6 [i].gameObject);
				GameObject.Find("Arena").GetComponent<Matrix>().columnCounter6 =0;
				col.gameObject.transform.position = GameObject.Find("Arena").GetComponent<Matrix>().sixthColumn [GameObject.Find("Arena").GetComponent<Matrix>().columnCounter6].transform.position;
				GameObject.Find ("Arena").GetComponent<Matrix> ().bottomBlock6Code = 0;
				GameObject.Find ("Arena").GetComponent<Matrix> ().HP += GameObject.Find ("Arena").GetComponent<Matrix> ().column6Score-1;
			}

			GameObject.Find ("Arena").GetComponent<Matrix> ().blocksColumn6.Clear ();
			Debug.Log ("Column 6 destroyed, it's count is one " + GameObject.Find ("Arena").GetComponent<Matrix> ().blocksColumn6.Count);
		}

		if (GameObject.Find("Arena").GetComponent<Matrix>().blocksColumn7.Contains(col.gameObject))
		{
			Instantiate (explosionHolder, gameObject.transform.position, gameObject.transform.rotation);
		//	bombBoom.Play ();
			for (int i = 0; i < GameObject.Find ("Arena").GetComponent<Matrix> ().blocksColumn7.Count; i++)
			{
				Destroy (GameObject.Find ("Arena").GetComponent<Matrix> ().blocksColumn7 [i].gameObject);
				GameObject.Find("Arena").GetComponent<Matrix>().columnCounter7 =0;
				col.gameObject.transform.position = GameObject.Find("Arena").GetComponent<Matrix>().seventhColumn [GameObject.Find("Arena").GetComponent<Matrix>().columnCounter7].transform.position;
				GameObject.Find ("Arena").GetComponent<Matrix> ().bottomBlock7Code = 0;
				GameObject.Find ("Arena").GetComponent<Matrix> ().HP += GameObject.Find ("Arena").GetComponent<Matrix> ().column7Score-1;
			}

			GameObject.Find ("Arena").GetComponent<Matrix> ().blocksColumn7.Clear ();
			Debug.Log ("Column 7 destroyed, it's count is one " + GameObject.Find ("Arena").GetComponent<Matrix> ().blocksColumn7.Count);
		}

		if (GameObject.Find("Arena").GetComponent<Matrix>().blocksColumn8.Contains(col.gameObject))
		{
			Instantiate (explosionHolder, gameObject.transform.position, gameObject.transform.rotation);
			//bombBoom.Play ();
			for (int i = 0; i < GameObject.Find ("Arena").GetComponent<Matrix> ().blocksColumn8.Count; i++)
			{
				Destroy (GameObject.Find ("Arena").GetComponent<Matrix> ().blocksColumn8 [i].gameObject);
				GameObject.Find("Arena").GetComponent<Matrix>().columnCounter8 =0;
				col.gameObject.transform.position = GameObject.Find("Arena").GetComponent<Matrix>().eigthColumn [GameObject.Find("Arena").GetComponent<Matrix>().columnCounter8].transform.position;
				GameObject.Find ("Arena").GetComponent<Matrix> ().bottomBlock8Code = 0;
				GameObject.Find ("Arena").GetComponent<Matrix> ().HP += GameObject.Find ("Arena").GetComponent<Matrix> ().column8Score-1;
			}

			GameObject.Find ("Arena").GetComponent<Matrix> ().blocksColumn8.Clear ();
			Debug.Log ("Column 8 destroyed, it's count is one " + GameObject.Find ("Arena").GetComponent<Matrix> ().blocksColumn8.Count);
		}

		if (GameObject.Find("Arena").GetComponent<Matrix>().blocksColumn9.Contains(col.gameObject))
		{
			Instantiate (explosionHolder, gameObject.transform.position, gameObject.transform.rotation);
			//bombBoom.Play ();
			for (int i = 0; i < GameObject.Find ("Arena").GetComponent<Matrix> ().blocksColumn9.Count; i++)
			{
				Destroy (GameObject.Find ("Arena").GetComponent<Matrix> ().blocksColumn9 [i].gameObject);
				GameObject.Find("Arena").GetComponent<Matrix>().columnCounter9 =0;
				col.gameObject.transform.position = GameObject.Find("Arena").GetComponent<Matrix>().ninethColumn [GameObject.Find("Arena").GetComponent<Matrix>().columnCounter9].transform.position;
				GameObject.Find ("Arena").GetComponent<Matrix> ().bottomBlock9Code = 0;
				GameObject.Find ("Arena").GetComponent<Matrix> ().HP += GameObject.Find ("Arena").GetComponent<Matrix> ().column9Score-1;
			}

			GameObject.Find ("Arena").GetComponent<Matrix> ().blocksColumn9.Clear ();
			Debug.Log ("Column 9 destroyed, it's count is one " + GameObject.Find ("Arena").GetComponent<Matrix> ().blocksColumn9.Count);


		}

		Destroy (gameObject);
	}
}
