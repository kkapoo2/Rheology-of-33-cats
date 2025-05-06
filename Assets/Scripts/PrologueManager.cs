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

    void Start()
    {
        prologuePanel.SetActive(true);

        nextButton.onClick.AddListener(NextPrologue);
    }


    void NextPrologue()
    {
        nextButton.gameObject.SetActive(false);
        prologue.text = "��� ��\n���� ���ƿ� ����\n����̰� �� ������ �Ⱥ��δ�!\n�� ���� �� �ɱ�?\n\nGAME START!!";

        Invoke("LoadNextScene", 7f); // 7�� �� �� ��ȯ    
    }

    void LoadNextScene()
    {
        SceneManager.LoadScene("Stage 1");
    }

}
