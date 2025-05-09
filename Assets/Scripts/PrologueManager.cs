using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PrologueManager : MonoBehaviour
{
    //���ѷα� ��� �˾�
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

        prologue.text = "��� ��\n���� ���ƿ� ����\n����̰� �� ������ �Ⱥ��δ�!\n�� ���� �� �ɱ�?";
    }

    void StartGame()
    {
        SceneManager.LoadScene("Stage 1");
    }

}
