using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChangeBtnTxt : MonoBehaviour
{
    public TextMeshProUGUI[] newFile_BtnTxts;
    public void Update_BtnTxt()
	{
		for (int i = 0; i < 3; i++)
		{
			newFile_BtnTxts[i].text = QuestDataManager.questData[PlayerPrefs.GetInt("questNum" + i, 0)];
		}
	}
}
