using UnityEngine;

//�÷��̾��� �þ߿� �°� ���� UI�� ������ �����ִ� ��ũ��Ʈ
public class BillBoard : MonoBehaviour
{
    //ī�޶� ���󰣴�.
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
