using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnMaker_ByQuestNum : MonoBehaviour
{
	private void Start()
	{
		//int slot = PlayerPrefs.GetInt("CurrentSlot"); // �� ��° ����
		//int quessProgress = PlayerPrefs.GetInt("questNum" + slot); // ����Ʈ ���൵
		//Debug.Log($"{slot}��° ���� (���൵:{quessProgress}");
		MakeBtns_ByQuestProgress();
	}

	private void MakeBtns_ByQuestProgress()
	{
		Debug.Log( PlayerPrefs.GetInt( "questNum" + PlayerPrefs.GetInt("CurrentSlot") ) );
	}
}
