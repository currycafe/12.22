using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkBool : MonoBehaviour
{
	public string parameterName = "";   // �p�����[�^���FInspector�Ŏw��

	void Update()
	{
		bool pushFlag = false;
		if (Input.GetKey(KeyCode.W))
		{
			pushFlag = true;
		}
		// �p�����[�^�̒l��ύX
		Animator m_Animator = gameObject.GetComponent<Animator>();
		m_Animator.SetBool(parameterName, pushFlag);
	}
}
