using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class DataTableManager : MonoBehaviour
{
	public static DataTableManager Instance;
	public static bool isReady = false;
	private void Awake()
	{
		Instance = this;
	}
	string SHEET;
	public static string[] col;
	const string url = "https://docs.google.com/spreadsheets/d/1rClJsqpAgQdU9jgtRnhObDOfqzokdw9L_4whilssk2g/export?format=tsv&range=A1:B2";
	IEnumerator Start()
	{
		using (UnityWebRequest online_sheet = UnityWebRequest.Get(url))
		{
			yield return online_sheet.SendWebRequest();

			if (online_sheet.isDone)
			{
				SHEET = online_sheet.downloadHandler.text;
			}
		}
		Test();
	}
	void Test()
	{
		Debug.Log(SHEET);
		col = SHEET.Split("\n");
		string[] row1 = col[1].Split("\t");
		Debug.Log(row1[1]);
		isReady = true;
	}

}
