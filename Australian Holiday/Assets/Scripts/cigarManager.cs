using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cigarManager : MonoBehaviour
{

	[SerializeField]
	private float time = 1.5f;

	public GameObject ciggie;


	void Start() {
		StartCoroutine(SpawnAnEnemy());
	}

	IEnumerator SpawnAnEnemy() {

		Vector2 spawn = GameObject.Find("Player").transform.position;
		spawn += Random.insideUnitCircle.normalized * 3;
		spawn.y = 0;

		Instantiate(ciggie, spawn, Quaternion.identity);
		yield return new WaitForSeconds(time);
		StartCoroutine(SpawnAnEnemy());

	}
}
