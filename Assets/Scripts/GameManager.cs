using UnityEngine;

public class GameManager : MonoBehaviour
{
	public GameObject gameOverMenu;
	public GameObject pauseMenu;

	void Start() {
		gameOverMenu.SetActive(false);
		pauseMenu.SetActive(false);
	}

	public void EndGame() {
		Debug.Log("GAME OVER");
		Restart();
	}

	void Restart() {
		gameOverMenu.SetActive(true);
	}

	public void PauseGame() {
		Debug.Log("Paused");
		Pause();
	}

	void Pause() {
		pauseMenu.SetActive(true);
	}
}
