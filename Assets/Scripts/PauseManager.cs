using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class PauseManager : MonoBehaviour {
    
    Canvas canvas;
//	MouseLook desactivacionMouse;
    
    void Start()
    {
        canvas = GetComponent<Canvas>();
        canvas.enabled = false;
//		desactivacionMouse = GameObject.Find("FPSController").GetComponent<MouseLook> ();
    }
    
    void Update()
    {
		if (Input.GetKeyDown(KeyCode.Space))
        {
            Pause();
//			Cursor.visible = true;
//			Cursor.lockState = CursorLockMode.None;
//			desactivacionMouse.m_cursorIsLocked = false;
//			Cursor.lockState = CursorLockMode.None;
//			Cursor.visible = true;


        }
    }
    
    public void Pause()
    {
		Debug.Log ("Se esta ejecutando");
        canvas.enabled = !canvas.enabled;
		Time.timeScale = Time.timeScale == 0 ? 1 : 0;
    }
    
    public void Quit()
    {
        #if UNITY_EDITOR 
        EditorApplication.isPlaying = false;
        #else 
		Application.Quit();
        #endif
    }
}