using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpFlag : MonoBehaviour
{
	public string pushKey = "space";    // キー：Inspectorで指定
	public string triggerName = "";     // trigger名：Inspectorで指定

	bool pushFlag = false;          // キーを押しっぱなしかどうか

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
