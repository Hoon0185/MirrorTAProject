using Mirror.Examples.Basic;
using UnityEngine;
using UnityEngine.UI;

//UI HPBar 체력을 나타내는 스크립트
public class HpBar : MonoBehaviour
{
    public static HpBar Instance;

    private void Awake()
    {
        Instance = this; 
    }

    [SerializeField] private Slider slider;

    //체력
    [SerializeField] public int MaxHp = 10;       //최대 체력
    [SerializeField] public int MinHP = 0;             //최소 체력
    [SerializeField] public int HpItem=2;            //HP Item 회복체력
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
