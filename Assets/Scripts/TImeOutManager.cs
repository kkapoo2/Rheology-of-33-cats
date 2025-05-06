using UnityEngine;
using UnityEngine.UI;

public class TImeOutManager : MonoBehaviour
{
    public GameObject timeOutPanel;
    public Text timeOut;
    public Button homeButton;
    void Start()
    {
        timeOutPanel.SetActive(false);
        timeOut.text = "";
        homeButton.gameObject.SetActive(false);
    }

    void Update()
    {
        
    }

    /*Ÿ�� �ƿ��� �˾� UI ����
     stageNum�� �ش� �������� ����
     catCount�� ã�� ����� ��
     �ۼ��� �ڵ忡 �°� �������ּ��䤻
    */
    void ShowTimeOut()
    {
        timeOutPanel.SetActive(true);
        timeOut.text = /*stageNum +*/ "�ܰ� Ÿ�� �ƿ�!\n\nã�� ����� ��: " /*+ catCount */ + " ����";
        homeButton.gameObject.SetActive(true);
    }
}
