using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
	public string tagName; 

	private void OnCollisionEnter(Collision collision) // Õ“Ë‚µ‚½‚Æ‚«
	{
		if (collision.gameObject.tag == tagName)
		{
			// ©•ª‚ğíœ‚·‚é
			Destroy(this.gameObject);
		}
	}
}
