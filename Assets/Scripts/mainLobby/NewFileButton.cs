using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class NewFileButton : MonoBehaviour
{
	public int btnIndex; // 0 1 2
    public Button btn;
    public TextMeshProUGUI btnTxt;
	private ChangeBtnTxt changeBtnTxt;

	void Start()
	{
		int currentSavedQuest = PlayerPrefs.GetInt("questNum" + btnIndex, 0);
		changeBtnTxt = FindObjectOfType<ChangeBtnTxt>();
		// ��ư�� ����� ���� ä���
		changeBtnTxt.Update_BtnTxt();
		btn.onClick.AddListener(ChangeBtnTxt);
	}

	public void ChangeBtnTxt()
	{
		int questNum = PlayerPrefs.GetInt("questNum" + btnIndex, 0);

		// ����� ����Ʈ �������� ���� �����ϱ�
		if (PlayerPrefs.GetInt("questNum" + btnIndex) > 0)
		{
			//Debug.Log($"���൵:{PlayerPrefs.GetInt("questNum" + btnIndex, 0)}, {btnIndex}��° ����");

			PlayerPrefs.SetInt("CurrentSlot", btnIndex);
			PlayerPrefs.Save();

			SceneManager.LoadScene("inGame"); // �ΰ��� ����
		}

		// �� ���� ����� ���ý�
		if (questNum == 0)
		{
			PlayerPrefs.SetInt("questNum" + btnIndex, 1); // ���൵ 1 ó��
		}

		int newQuest = PlayerPrefs.GetInt("questNum" + btnIndex);
		if (QuestDataManager.questData.ContainsKey(newQuest))
		{
			// ��ư ���� ����
			changeBtnTxt.Update_BtnTxt();
		}
		else
		{
			btnTxt.text = "�� �� ���� ����Ʈ";
		}
	}

	public void ResetBtnTxt()
	{
		for (int i = 0; i < 3; i++)
		{
			int newQuest = PlayerPrefs.GetInt("questNum" + i, 0);
			if (QuestDataManager.questData.ContainsKey(newQuest))
			{
				// ��ư ���� ����
				changeBtnTxt.Update_BtnTxt();
			}
			else
			{
				btnTxt.text = "�� �� ���� ����Ʈ";
			}
		}
	}

}
