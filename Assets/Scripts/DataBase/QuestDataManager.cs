using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class QuestDataManager : MonoBehaviour
{
	public static Dictionary<int, string> questData = new Dictionary<int, string>
	{
		{ 0, "새 파일 만들기" },
		{ 1, "프롤로그: 사고" },
		{ 2, "프롤로그: 사고 (1페이지)" },
		{ 3, "프롤로그: 사고 (2페이지)" },
		{ 4, "프롤로그: 사고 (3페이지)" },
		{ 5, "프롤로그: 사고 (4페이지)" },
		{ 6, "프롤로그: 사고 (5페이지)" },
		{ 7, "1장: 일곱 개의 그림자" },
		{ 8, "1장: 일곱 개의 그림자 (1페이지)" },
		{ 9, "1장: 일곱 개의 그림자 (2페이지)" },
		{ 10, "1장: 일곱 개의 그림자 (3페이지)" },
		{ 11, "1장: 일곱 개의 그림자 (4페이지)" },
		{ 12, "1장: 일곱 개의 그림자 (5페이지)" },
		{ 13, "1장: 일곱 개의 그림자 (6페이지)" },
	};
}
