using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class QuestDataManager : MonoBehaviour
{
	public static Dictionary<int, string> questData = new Dictionary<int, string>
	{
		{ 0, "새 파일 만들기" },
		{ 1, "섬 갚판장" },
		{ 2, "마을 회관" }
	};

	void Start()
	{
		//PlayerPrefs.SetInt("questNum0", 0);
		//PlayerPrefs.Save();

		//Debug.Log(PlayerPrefs.GetInt("questNum0"));
	}
}
