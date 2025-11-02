using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextChangeManager : MonoBehaviour
{
	public TextMeshProUGUI storyTxt;

	public int DoctorNum; 
    // 0:색욕, 1:슬픔, 2:분노, 3:오만, 4:교만, 5:탐욕

    public void TextChanger()
	{
		switch (DoctorNum)
		{
			case 0:
				storyTxt.text = "색욕: 인간의 감정과 욕망에 집착하며, 모든 것을 자신의 것으로 만들고 싶어한다.";
				break;
			case 1:
				storyTxt.text = "슬픔: 과거의 실패를 잊지 못하고, 계속 후회 속에서 살아간다.";
				break;
			case 2:
				storyTxt.text = "분노: 모든 것에 화를 내며, 이 감옥을 만든 자를 증오하고 있다.";
				break;
			case 3:
				storyTxt.text = "오만: 자신의 지식이 최고라고 믿으며, 다른 박사들을 무시한다.";
				break;
			case 4:
				storyTxt.text = "교만: 누구보다 자신이 우월하다고 생각하며, 다른 이들이 자신을 따르게 하려 한다.";
				break;
			case 5:
				storyTxt.text = "탐욕: 모든 기술과 지식을 독점하려 하며, 타임머신을 숨기려 한다.";
				break;
			default:
				break;
		}
	}
}
