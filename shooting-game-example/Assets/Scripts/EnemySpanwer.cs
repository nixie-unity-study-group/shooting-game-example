﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpanwer : MonoBehaviour {
	public float spawnInterval = 1f;
	public GameObject enemy;

	private float _nextSpawn;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > _nextSpawn) {
			_nextSpawn = Time.time + spawnInterval;
			Instantiate(enemy, new Vector2(Random.Range(-2.5f, 2.5f), transform.position.y + 5), Quaternion.identity);
		}
	}
}
