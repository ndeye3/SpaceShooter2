using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BGScroller1 : MonoBehaviour
{
	public float scrollSpeed = 0.1f;
	public float tileSize;

	private Vector2 startPosition;

	void Start ()
	{
		startPosition = transform.position;
	}

	void Update ()
	{
		float newPosition = Mathf.Repeat(Time.time * scrollSpeed, tileSize);
		transform.position = startPosition + Vector2.left * newPosition;
	}
}