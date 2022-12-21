using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorBool : MonoBehaviour
{
	public string tagName; // �^�O���FInspector�Ŏw��
	public string parameterName = "";   // �p�����[�^���FInspector�Ŏw��

	private void OnCollisionEnter(Collision collision) // �Փ˂����Ƃ�
	{
		bool Flag = true;
		// �����A�Փ˂������̂��ڕW�̃^�O�������Ă�����
		if (collision.gameObject.tag == tagName)
		{
			Flag = false;
		}
        // �p�����[�^�̒l��ύX
        Animator m_Animator = gameObject.GetComponent<Animator>();
        m_Animator.SetBool(parameterName, Flag);
    }
}