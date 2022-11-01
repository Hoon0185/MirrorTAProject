using UnityEngine;

//플레이어의 시야에 맞게 같이 UI가 각도를 맞춰주는 스크립트
public class BillBoard : MonoBehaviour
{
    //카메라를 따라간다.
    private Transform Cam;

    // Start is called before the first frame update
    void Start()
    {
        Cam = Camera.main.transform;
    }

    private void LateUpdate()
    {
        transform.LookAt(transform.position + Cam.forward);
    }
}
