using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
	public string tagName; 

	private void OnCollisionEnter(Collision collision) // �Փ˂����Ƃ�
	{
		if (collision.gameObject.tag == tagName)
		{
			// �������폜����
			Destroy(this.gameObject);
		}
	}
}
