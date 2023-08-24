using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeVisualization : MonoBehaviour
{
    private UnityEngine.UI.Toggle GetToggle;
    private UnityEngine.UI.Image buttonSprite;
    [SerializeField] UnityEngine.UI.Image plot;
    [SerializeField] Sprite sprite_basic;
    [SerializeField] Sprite sprite_click;

    [SerializeField] Sprite sprite_basic_btn;
    [SerializeField] Sprite sprite_click_btn;

    // Start is called before the first frame update
    void Start()
    {
        GetToggle = GetComponent<UnityEngine.UI.Toggle>();
        buttonSprite = GetComponent<UnityEngine.UI.Image>();
    }

    // Update is called once per frame
    public void ChangePlot()
    {
        if (GetToggle.isOn)
        {
            plot.sprite = sprite_click;
            buttonSprite.sprite = sprite_click_btn;
        }
        else
        {
            plot.sprite = sprite_basic;
            buttonSprite.sprite = sprite_basic_btn;
        }
    }
}
