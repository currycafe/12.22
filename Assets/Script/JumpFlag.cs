using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpFlag : MonoBehaviour
{
	public string pushKey = "space";    // �L�[�FInspector�Ŏw��
	public string triggerName = "";     // trigger���FInspector�Ŏw��

	bool pushFlag = false;          // �L�[���������ςȂ����ǂ���

	void Update()
	{
		if (Input.GetKey(pushKey)) 
		{
			if (pushFlag == false)
			{
				pushFlag = true; 
								 
				Animator m_Animator = gameObject.GetComponent<Animator>();
				m_Animator.SetTrigger(triggerName);
			}
		}
		else
		{
			pushFlag = false;       
		}
	}
}
