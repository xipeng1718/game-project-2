using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wave3 : MonoBehaviour
{
	public GameObject enemyPrefab;
	public Transform spawnPoint;

	public float timeBetweenWaves = 5f;
	private float countdown = 2f;

	private int waveIndex = 0;

	void Update()
	{
		if (countdown <= 0f)
		{
			StartCoroutine(SpawnWave());
			countdown = timeBetweenWaves;
		}

		countdown -= Time.deltaTime;
	}

	IEnumerator SpawnWave()
	{
		waveIndex++;

		for (int i = 0; i < waveIndex; i++)
		{
			SpawnEnemy();
			yield return new WaitForSeconds(0.5f);
		}
	}

	void SpawnEnemy()
	{
		GameObject mMyClone = Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
		//Destroy(mMyClone, 10f);
	}
}
