using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFloor : MonoBehaviour
{
	public float speedX = 1; // �X�s�[�hX�FInspector�Ŏw��
	public float speedY = 0; // �X�s�[�hY�FInspector�Ŏw��
	public float speedZ = 0; // �X�s�[�hZ�FInspector�Ŏw��
	public float second = 1; // ������b���FInspector�Ŏw��

	float time = 0f;

	private void FixedUpdate()  // �����ƁA��������
	{
		time += Time.deltaTime;
		float s = Mathf.Sin(time * 3.14f / second); // �ړ��ʂ����߂�
		this.transform.Translate(speedX * s / 50, speedY * s / 50, speedZ * s / 50);
	}
}
