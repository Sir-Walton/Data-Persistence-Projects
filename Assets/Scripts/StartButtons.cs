using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor;

public class StartButtons : MonoBehaviour
{
    private Button button;
    private MainManager mainManager;
    
    // Start is called before the first frame update

    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }
    public void Exit()
    {
        MainManager.Instance.SaveName();  
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
    public void NewNameSelected()
    {
        // add code here to handle when a color is selected
        MainManager.Instance.Name = Name;
    }



    void Start()
    {
        button = GetComponent<Button>();
        mainManager = GameObject.Find("Main Manager").GetComponent<MainManager>();


        button.onClick.AddListener(StartGame);
    }

   
    void StartGame()
    {
        Debug.Log(button.gameObject.name + " was clicked");
        mainManager.LoadScene(0);

    }
}
