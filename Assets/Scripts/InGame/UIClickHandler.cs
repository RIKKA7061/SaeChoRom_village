using UnityEngine;
using UnityEngine.EventSystems;

public class UIClickHandler : MonoBehaviour, IPointerClickHandler
{
	public string ObjectName = "이름 미정";
	public void OnPointerClick(PointerEventData eventData)
	{
		Debug.Log(ObjectName);
	}
}
