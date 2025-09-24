using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class MapDataManager : MonoBehaviour
{
	// æ¿ ¿Ã∏ß
	public static Dictionary<int, string> MapSceneName = new Dictionary<int, string>
	{
		{ 0, "Map" }, // ¡ˆµµ º±≈√æ¿
		{ 1, "01-ShipLand" } // º∂∞±∆« ¿Â
	};
}
