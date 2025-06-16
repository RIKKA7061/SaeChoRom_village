using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class NewFileButton : MonoBehaviour
{
	public int btnIndex; // 0 1 2
    public Button btn;
    public TextMeshProUGUI btnTxt;

	void Start()
	{
		int currentSavedQuest = PlayerPrefs.GetInt("questNum" + btnIndex, 0);
		//Debug.Log($"{btnIndex}버튼 : {currentSavedQuest}진행도");
		btnTxt.text = QuestDataManager.questData[currentSavedQuest];
		btn.onClick.AddListener(ChangeBtnTxt);
	}

	public void ChangeBtnTxt()
	{
		int questNum = PlayerPrefs.GetInt("questNum" + btnIndex, 0);

		// 저장된 퀘스트 지역부터 게임 시작하기
		if (PlayerPrefs.GetInt("questNum" + btnIndex) > 0)
		{
			//Debug.Log($"진행도:{PlayerPrefs.GetInt("questNum" + btnIndex, 0)}, {btnIndex}번째 파일");

			PlayerPrefs.SetInt("CurrentSlot", btnIndex);
			PlayerPrefs.Save();

			SceneManager.LoadScene("inGame"); // 인게임 돌입
		}

		// 새 파일 만들기 선택시
		if (questNum == 0)
		{
			PlayerPrefs.SetInt("questNum" + btnIndex, 1); // 진행도 1 처리
		}

		int newQuest = PlayerPrefs.GetInt("questNum" + btnIndex);
		if (QuestDataManager.questData.ContainsKey(newQuest))
		{
			btnTxt.text = QuestDataManager.questData[newQuest];
		}
		else
		{
			btnTxt.text = "알 수 없는 퀘스트";
		}
	}

	public void ResetBtnTxt()
	{
		for (int i = 0; i < 3; i++)
		{
			int newQuest = PlayerPrefs.GetInt("questNum" + i, 0);
			if (QuestDataManager.questData.ContainsKey(newQuest))
			{
				btnTxt.text = QuestDataManager.questData[newQuest];
			}
			else
			{
				btnTxt.text = "알 수 없는 퀘스트";
			}
		}
	}

}
