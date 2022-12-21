using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  // �V�[���؂�ւ��ɕK�v

// UI�{�^������Ăяo���A�V�[����؂芷���閽��
public class Button_SwitchSceneCmd : MonoBehaviour
{
	public string sceneName = "";  // �V�[�����FInspector�Ŏw��

	public void SwitchScene()
	{
		if (sceneName != "")  // �V�[����������΁A�؂芷����
		{
			SceneManager.LoadScene(sceneName);
		}
		else
		{   // �V�[�������Ȃ���΁A���̃V�[���֐؂芷����
			int nextIndex = SceneManager.GetActiveScene().buildIndex + 1;
			if (nextIndex < SceneManager.sceneCountInBuildSettings)
			{
				SceneManager.LoadScene(nextIndex);
			}
			else
			{   // ���̃V�[�����Ȃ���΁A�ŏ��̃V�[���ɐ؂芷����
				SceneManager.LoadScene(0);
			}
		}
	}
}
