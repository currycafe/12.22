using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollision : MonoBehaviour
{
	public string tagName; // �^�O���FInspector�Ŏw��
	public string hideObjectName;   // �����I�u�W�F�N�g���FInspector�Ŏw��

	private void OnCollisionEnter(Collision collision) // �Փ˂����Ƃ�
	{
		// �����A�Փ˂������̂��ڕW�̃^�O�������Ă�����
		if (collision.gameObject.tag == tagName)
		{
			// �����I�u�W�F�N�g��T���Č���������
			GameObject hideObject = GameObject.Find(hideObjectName);
			if (hideObject)
			{
				hideObject.SetActive(false); // ����
			}
		}
	}
}
