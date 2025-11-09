using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowManager : MonoBehaviour
{
    public static ShowManager Instance;
	private void Awake()
	{
		Instance = this;
	}
	public static bool sexual = false;
	public static bool sad = false;
	public static bool angry = false;
	public static bool ohMan = false;
	public static bool gyoMan = false;
	public static bool greedy = false;
	public GameObject nextBtn;
	public static void ShowUpdate()
	{
		if (sexual && sad && angry && ohMan && gyoMan && greedy)
		{
			Instance.nextBtn.SetActive(true);
		}
	}
	public void Sexual()
	{
		sexual = true;
		ShowUpdate();
	}
	public void Sad()
	{
		sad = true;
		ShowUpdate();
	}
	public void Angry()
	{
		angry = true;
		ShowUpdate();
	}
	public void OhMan()
	{
		ohMan = true;
		ShowUpdate();
	}
	public void GyoMan()
	{
		gyoMan = true;
		ShowUpdate();
	}
	public void Greedy()
	{
		greedy = true;
		ShowUpdate();
	}
}
