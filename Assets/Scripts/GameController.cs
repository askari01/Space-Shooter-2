using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{

	public GameObject hazard;
	public GameObject enemy;

	public Vector3 spawnValues;
	public int hazardCount;
	public float spawnWait;
	public float startWait;
	public float waveWait;

	public GUIText Score;
	private int score;

	public GameObject canvas;
	private bool restart;

	// Use this for initialization
	void Start ()
	{
		restart = false;
		score = 0;
		UpdateScore ();
		StartCoroutine (SpawnWaves ());
	}

	IEnumerator SpawnWaves ()
	{
		//Debug.Log ("hello");
		yield return new WaitForSeconds (startWait);
		while (true) {
			for (int i = 0; i < hazardCount; i++) {
				Vector3 spawnPosition = new Vector3 (Random.Range (-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
				Vector3 enemyPosition = new Vector3 (Random.Range (-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
				Quaternion spawnRotation = Quaternion.identity;
				Instantiate (hazard, spawnPosition, spawnRotation);
				Instantiate (enemy, enemyPosition, Quaternion.Euler(0f,-180,0f));
				yield return new WaitForSeconds (spawnWait);
			}
			yield return new WaitForSeconds (waveWait);

			if (restart){
				if (Input.GetKeyDown(KeyCode.R)) {
					restart = false;
					canvas.SetActive (false);
					int scene = UnityEngine.SceneManagement.SceneManager.GetActiveScene ().buildIndex;
					UnityEngine.SceneManagement.SceneManager.LoadScene (scene, LoadSceneMode.Single);

				} else {
					break;
				}
			}
		}
	}

	public void addScore (int newScore)
	{
		score += newScore;
		UpdateScore ();
	}
	// Update is called once per frame
	void UpdateScore ()
	{
		//Debug.Log (Score);
		Score.text = "Score: " + score;
	}
 
	public void GameOver (){
		canvas.SetActive (true);
		restart = true;
	}
}
