using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChangeBtnTxt : MonoBehaviour
{
    public TextMeshProUGUI[] newFile_BtnTxts;

	// 버튼 내용 바꾸기
    public void Update_BtnTxt()
	{
		for (int i = 0; i < 3; i++)
		{
			if (PlayerPrefs.GetInt("questNum" + i, 0) == 0)
			{
				newFile_BtnTxts[i].text = QuestDataManager.questData[PlayerPrefs.GetInt("questNum" + i, 0)];
			}
			else if (PlayerPrefs.GetInt("questNum" + i, 0) > 0)
			{
				newFile_BtnTxts[i].text = PlayerPrefs.GetInt("questNum" + i, 0).ToString() + ". " + QuestDataManager.questData[PlayerPrefs.GetInt("questNum" + i, 0)];
			}
		}
	}
}
