using System.Collections.Generic;
using UnityEngine;

namespace Dice
{
	public class Spawner : MonoBehaviour
	{
		[SerializeField] private List<GameObject> DicePrefabs = new List<GameObject>();
		[SerializeField] private int Min;
		[SerializeField] private int Max;

		public void Start()
		{
			var num = Random.Range(Min, Max);
			for (var i = 0; i < num; i++)
			{
				var pos = new Vector3(0.0f, i * 0.02f, 0.0f);
				Instantiate(DicePrefabs[Random.Range(0, DicePrefabs.Count)], pos, Quaternion.identity, transform);
			}
		}

		public void Update()
		{
			Debug.Log($"Dice: {transform.childCount}");
		}
	}
}