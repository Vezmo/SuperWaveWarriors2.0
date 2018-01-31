using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {

  public static SceneLoader Instance { get { return m_instance; } }
  static SceneLoader m_instance;

  public string SplashScreenSceneName;
  public string MainMenuSceneName;
  public string GameSceneName;

  private void Awake()
  {
    if (m_instance != null)
    {
      Destroy(gameObject);
      Debug.LogWarning("Tried to instantiate a SceneLoader but one was already existing");
      return;
    }

    m_instance = this;
  }

  IEnumerator LoadAsyncScene(string _sceneName)
  {
    AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(_sceneName, LoadSceneMode.Additive);

    while (!asyncLoad.isDone)
    {
      yield return null;
    }
  }

  IEnumerator UnloadAsyncScene(string _sceneName)
  {
    AsyncOperation asyncUnload = SceneManager.LoadSceneAsync(_sceneName);

    while (!asyncUnload.isDone)
    {
      yield return null;
    }
  }

  public void UnloadSplashScreenScene()
  {
    StartCoroutine(UnloadAsyncScene(SplashScreenSceneName));
  }

  public void LoadSplashScreenScene()
  {
    StartCoroutine(LoadAsyncScene(SplashScreenSceneName));
  }

  public void UnloadMainMenuScene()
  {
    StartCoroutine(UnloadAsyncScene(MainMenuSceneName));
  }

  public void LoadMainMenuScene()
  {
    StartCoroutine(LoadAsyncScene(MainMenuSceneName));
  }

  public void UnloadGameScene()
  {
    StartCoroutine(UnloadAsyncScene(GameSceneName));
  }

  public void LoadGameScene()
  {
    StartCoroutine(LoadAsyncScene(GameSceneName));

  }

  // Use this for initialization
  void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
