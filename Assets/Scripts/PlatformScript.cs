using UnityEngine;
using System.Collections;

public class PlatformScript : MonoBehaviour {

	public GameObject platform;
	public GameObject[] plats  = new GameObject[10];
	//private ArrayList plats;


	// Use this for initialization
	void Start () {
		float move = 0;
		//platform = Instantiate(Resources.Load("Prefabs/Platforms"), new Vector2(move,move), Quaternion.identity) as GameObject;


		//ArrayList plats = new ArrayList();
		//plats = new (ArrayList)ArrayList[10];

		for (int i = 0; i <= 9; i++) {

			//plats = new GameObject[10];

			GameObject clone = (GameObject)Instantiate (platform, new Vector3(move,move,0), Quaternion.identity);

			print ("plats[i] " + plats[i]);
			
			print ("adding plat " + i);
			print ("move " + move);

			plats[i] = clone;
			plats[i].transform.Translate(new Vector3(move,move,0));
			move++;





	
		}
	

	}

	//public Rigidbody2D platformPrefab;

	// Update is called once per frame
	void Update () {
	
		float move = .005f;
		for (int i = 0; i <= 9; i++) {
			plats[i].transform.Translate(new Vector3(move,0,0));
		}
	}
}
