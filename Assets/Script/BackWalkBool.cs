using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackWalkBool : MonoBehaviour
{
	public string parameterName = "";   // パラメータ名：Inspectorで指定

	void Update()
	{
		bool pushFlag = false;
		if (Input.GetKey(KeyCode.S))
		{
			pushFlag = true;
		}

		// パラメータの値を変更
		Animator m_Animator = gameObject.GetComponent<Animator>();
		m_Animator.SetBool(parameterName, pushFlag);
	}
}
