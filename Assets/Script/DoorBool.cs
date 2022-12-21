using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorBool : MonoBehaviour
{
	public string tagName; // タグ名：Inspectorで指定
	public string parameterName = "";   // パラメータ名：Inspectorで指定

	private void OnCollisionEnter(Collision collision) // 衝突したとき
	{
		bool Flag = true;
		// もし、衝突したものが目標のタグを持っていたら
		if (collision.gameObject.tag == tagName)
		{
			Flag = false;
		}
        // パラメータの値を変更
        Animator m_Animator = gameObject.GetComponent<Animator>();
        m_Animator.SetBool(parameterName, Flag);
    }
}