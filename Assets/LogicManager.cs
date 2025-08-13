using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class LogicManager : MonoBehaviour
{
    public int playerscore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public AudioSource audioSource;
    public AudioClip pointSound;
    public AudioClip hitSound;
    public AudioClip dieSound;
    private void Start()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 60;
        audioSource = GetComponent<AudioSource>();
    }
    public void addscore(int scoreToAdd)
    {
        playerscore= playerscore + scoreToAdd;
        scoreText.text = playerscore.ToString();
        audioSource.PlayOneShot(pointSound);
    }
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
    public void QuitGame()
    {
        Application.Quit(); 
    }
    public void playHitSound()
    {
        audioSource.PlayOneShot(hitSound);
    }
    public void playDieSound()
    {
        audioSource.PlayOneShot(dieSound);
    }
}
