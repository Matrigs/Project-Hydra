using UnityEngine;

public class GameManager : MonoBehaviour
{
	public GameObject gameOverMenu;

	void Start() {
		gameOverMenu.SetActive(false);
	}

	public void EndGame() {
		Debug.Log("GAME OVER");
		Restart();
	}

	void Restart() {
		gameOverMenu.SetActive(true);
	}
}
