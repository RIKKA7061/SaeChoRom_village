using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class QuestDataManager : MonoBehaviour
{
	public static Dictionary<int, string> questData = new Dictionary<int, string>
	{
		{ 0, "�� ���� �����" },
		{ 1, "�� ������" },
		{ 2, "���� ȸ��" }
	};

	void Start()
	{
		//PlayerPrefs.SetInt("questNum0", 0);
		//PlayerPrefs.Save();

		//Debug.Log(PlayerPrefs.GetInt("questNum0"));
	}
}
