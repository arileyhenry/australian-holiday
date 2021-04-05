using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deployCigars : MonoBehaviour
{

    public GameObject cigarPrefab;
    public float respawnTime = 1.0f;
    private Vector2 screenbounds;

    
    void Start()
    {
        screenbounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(cigarWave());
    }

    private void spawnCigar() {
        GameObject a = Instantiate(cigarPrefab) as GameObject;
        a.transform.position = new Vector2(screenbounds.x * -2, Random.Range(-screenbounds.y, screenbounds.y));
    }

    IEnumerator cigarWave() {
        while (true) {
            yield return new WaitForSeconds(respawnTime);
            spawnCigar();
        }
    }
}
