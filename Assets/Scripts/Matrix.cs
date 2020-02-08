using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Matrix : MonoBehaviour {

	public GameObject[] firstColumn;
	public GameObject[] secondColumn;
	public GameObject[] thirdColumn;
	public GameObject[] fourthColumn;
	public GameObject[] fifthColumn;
	public GameObject[] sixthColumn;
	public GameObject[] seventhColumn;
	public GameObject[] eigthColumn;
	public GameObject[] ninethColumn;

	public List<GameObject> blocksColumn1 = new List <GameObject>();
	public List<GameObject> blocksColumn2 = new List <GameObject>();
	public List<GameObject> blocksColumn3 = new List <GameObject>();
	public List<GameObject> blocksColumn4 = new List <GameObject>();
	public List<GameObject> blocksColumn5 = new List <GameObject>();
	public List<GameObject> blocksColumn6 = new List <GameObject>();
	public List<GameObject> blocksColumn7 = new List <GameObject>();
	public List<GameObject> blocksColumn8 = new List <GameObject>();
	public List<GameObject> blocksColumn9 = new List <GameObject>();


	//public GameObject bottomBlock1;
	//public GameObject bottomBlock2;
	//public GameObject bottomBlock3;
	//public GameObject bottomBlock4;
	//public GameObject bottomBlock5;
	//public GameObject bottomBlock6;
	//public GameObject bottomBlock7;
	//public GameObject bottomBlock8;
	//public GameObject bottomBlock9;

	public int columnCounter1 =0;
	public int columnCounter2 =0;
	public int columnCounter3 =0;
	public int columnCounter4 =0;
	public int columnCounter5 =0;
	public int columnCounter6 =0;
	public int columnCounter7 =0;
	public int columnCounter8 =0;
	public int columnCounter9 =0;

	public int bottomBlock1Code = 0;
	public int bottomBlock2Code = 0;
	public int bottomBlock3Code = 0;
	public int bottomBlock4Code = 0;
	public int bottomBlock5Code = 0;
	public int bottomBlock6Code = 0;
	public int bottomBlock7Code = 0;
	public int bottomBlock8Code = 0;
	public int bottomBlock9Code = 0;

	public float column1Score;
	public float column2Score;
	public float column3Score;
	public float column4Score;
	public float column5Score;
	public float column6Score;
	public float column7Score;
	public float column8Score;
	public float column9Score;

	public float HP = 50;

	public Text HPText;







	public GameObject[][] gameMatrix = new GameObject[9][];


	// Use this for initialization
	void Start () {
		gameMatrix [0] = firstColumn;
		gameMatrix [1] = secondColumn;
		gameMatrix [2] = thirdColumn;
		gameMatrix [3] = fourthColumn;
		gameMatrix [4] = fifthColumn;
		gameMatrix [5] = sixthColumn;
		gameMatrix [6] = seventhColumn;
		gameMatrix [7] = eigthColumn;
		gameMatrix [8] = ninethColumn;
	

	}
	
	// Update is called once per frame
	void Update () {

		HPText.text = HP.ToString();
		column1Score = Mathf.Pow(blocksColumn1.Count, 2);
		column2Score = Mathf.Pow(blocksColumn2.Count, 2);
		column3Score = Mathf.Pow(blocksColumn3.Count, 2);
		column4Score = Mathf.Pow(blocksColumn4.Count, 2);
		column5Score = Mathf.Pow(blocksColumn5.Count, 2);
		column6Score = Mathf.Pow(blocksColumn6.Count, 2);
		column7Score = Mathf.Pow(blocksColumn7.Count, 2);
		column8Score = Mathf.Pow(blocksColumn8.Count, 2);
		column9Score = Mathf.Pow(blocksColumn9.Count, 2);
	}


}
