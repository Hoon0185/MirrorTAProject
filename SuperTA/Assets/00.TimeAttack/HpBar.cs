using Mirror.Examples.Basic;
using UnityEngine;
using UnityEngine.UI;

//UI HPBar ü���� ��Ÿ���� ��ũ��Ʈ
public class HpBar : MonoBehaviour
{
    public static HpBar Instance;

    private void Awake()
    {
        Instance = this; 
    }

    [SerializeField] private Slider slider;

    //ü��
    [SerializeField] public int MaxHp = 10;       //�ִ� ü��
    [SerializeField] public int MinHP = 0;             //�ּ� ü��
    [SerializeField] public int HpItem=2;            //HP Item ȸ��ü��
    [SerializeField] public int  CurHp;
    [SerializeField] public int HP;

    //public void SetValue(float value)
    //{
    //    slider.value = value;
    //}

    private void Start()
    {
        CurHp = MaxHp;
    }

    private void Update()
    {
        //CurHp = CurHp / MaxHp;

        UpdateHpSlider();
    }

    public void UpdateHpSlider()
    {
        if(CurHp<=MaxHp)
            slider.value = Mathf.Lerp(slider.value, CurHp, Time.deltaTime * 10);
    }



}
