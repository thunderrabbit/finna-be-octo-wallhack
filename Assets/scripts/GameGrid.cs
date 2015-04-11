using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameGrid : MonoBehaviour {

	public float horizSpaceBetweenStartSquares = 1.5f;
	public float topY = 5f;
	public float bottomY = -5f;
	public float gridCenter = 0;

	public static GameGrid instance = null;              //Static instance of GameManager which allows it to be accessed by any other script.

	// Available Gems
	public GameObject[] gems;

	void Start () {
		spawnAt (gridCenter - horizSpaceBetweenStartSquares, topY);
		spawnAt (gridCenter, topY);
		spawnAt (gridCenter + horizSpaceBetweenStartSquares, topY);
	}
	
	void spawnAt(float x, float y) {
		int index = Random.Range(0, gems.Length);
		Instantiate(gems[index], new Vector2(x, y), Quaternion.identity);
	}

}
