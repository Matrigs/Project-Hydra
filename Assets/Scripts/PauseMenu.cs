using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class PauseMenu : MonoBehaviour
{
	public Aiming aimScript;
	public Shooting shootScript;
	public PlayerMovement movementScript;

	public static bool GameIsPaused = false;

	public GameObject pauseMenuUI;
	//public GameObject FirstOptionToSelect;

	void Update() {
		if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.P)) {
			if (GameIsPaused) {
				Resume();
			}
			else {
				Pause();
			}
		}
	}

	public void Resume() {
		pauseMenuUI.SetActive(false);
		Time.timeScale = 1f;
		GameIsPaused = false;

		aimScript.enabled = true;
		shootScript.enabled = true;
		movementScript.enabled = true;
	}

	void Pause() {
		pauseMenuUI.SetActive(true);
		Time.timeScale = 0f;
		GameIsPaused = true;

		aimScript.enabled = false;
		shootScript.enabled = false;
		movementScript.enabled = false;
		//EventSystem.current.SetSelectedGameObject(FirstOptionToSelect);
	}
}
