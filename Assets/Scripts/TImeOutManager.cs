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

    /*타임 아웃시 팝업 UI 등장
     stageNum은 해당 스테이지 숫자
     catCount는 찾은 고양이 수
     작성한 코드에 맞게 변경해주세요ㅋ
    */
    void ShowTimeOut()
    {
        timeOutPanel.SetActive(true);
        timeOut.text = /*stageNum +*/ "단계 타임 아웃!\n\n찾은 고양이 수: " /*+ catCount */ + " 마리";
        homeButton.gameObject.SetActive(true);
    }
}
