using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnMaker_ByQuestNum : MonoBehaviour
{
	private void Start()
	{
		//int slot = PlayerPrefs.GetInt("CurrentSlot"); // 몇 번째 파일
		//int quessProgress = PlayerPrefs.GetInt("questNum" + slot); // 퀘스트 진행도
		//Debug.Log($"{slot}번째 파일 (진행도:{quessProgress}");
		MakeBtns_ByQuestProgress();
	}

	private void MakeBtns_ByQuestProgress()
	{
		Debug.Log( PlayerPrefs.GetInt( "questNum" + PlayerPrefs.GetInt("CurrentSlot") ) );
	}
}
