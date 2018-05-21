using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    public void ChooseDiffculty()
    {
        SceneManager.LoadScene("difficulty");
    }

    public void StartEasy()
    {
        SceneManager.LoadScene("level_1_easy");
    }

    public void StartMedium()
    {
        SceneManager.LoadScene("level_1_medium");
    }

    public void StartHard()
    {
        SceneManager.LoadScene("level_1_hard");
    }

    public void StartExtreme()
    {
        SceneManager.LoadScene("level_1_extreme");
    }

    public void Complete_Easy()
    {
        SceneManager.LoadScene("complete_easy");
    }

    public void Complete_Medium()
    {
        SceneManager.LoadScene("complete_medium");
    }

    public void Complete_Hard()
    {
        SceneManager.LoadScene("complete_hard");
    }

    public void Complete_Extreme()
    {
        SceneManager.LoadScene("complete_extreme");
    }

    public void BossEasy()
    {
        SceneManager.LoadScene("level_2_easy");
    }

    public void BossMedium()
    {
        SceneManager.LoadScene("level_2_medium");
    }

    public void BossHard()
    {
        SceneManager.LoadScene("level_2_hard");
    }

    public void BossExtreme()
    {
        SceneManager.LoadScene("level_2_extreme");
    }

    public void Menu()
    {
        SceneManager.LoadScene("menu");
    }

    public void Controls()
    {
        SceneManager.LoadScene("controls");
    }

    public void Finish()
    {
        SceneManager.LoadScene("finish");
    }
}