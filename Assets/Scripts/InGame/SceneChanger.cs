using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneChanger : MonoBehaviour
{
	public string SceneName;
    public void OnClick_ToTheTitle()
	{
		SceneManager.LoadScene(SceneName);
	}
}
