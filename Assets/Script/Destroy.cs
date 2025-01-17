using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
	public string tagName; 

	private void OnCollisionEnter(Collision collision) // 衝突したとき
	{
		if (collision.gameObject.tag == tagName)
		{
			// 自分を削除する
			Destroy(this.gameObject);
		}
	}
}
