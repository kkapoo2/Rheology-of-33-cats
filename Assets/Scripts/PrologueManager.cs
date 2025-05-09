using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PrologueManager : MonoBehaviour
{
    //프롤로그 대사 팝업
    public GameObject prologuePanel;
    public Text prologue;
    public Button nextButton;
    public Button startButton;

    void Start()
    {
        prologuePanel.SetActive(true);
        startButton.gameObject.SetActive(false);
        nextButton.onClick.AddListener(NextPrologue);
        startButton.onClick.AddListener(StartGame);
    }


    void NextPrologue()
    {
        nextButton.gameObject.SetActive(false);
        startButton.gameObject.SetActive(true);

        prologue.text = "어느 날\n집에 돌아와 보니\n고양이가 한 마리도 안보인다!\n다 어디로 간 걸까?";
    }

    void StartGame()
    {
        SceneManager.LoadScene("Stage 1");
    }

}
