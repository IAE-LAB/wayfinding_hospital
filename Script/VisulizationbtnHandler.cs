using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Linq;

public class VisulizationbtnHandler : MonoBehaviour
{
    ToggleGroup yourToggleGroup;
    [SerializeField] GameObject comparison;
    [SerializeField] GameObject pattern;
    [SerializeField] GameObject range;

    private void Start()
    {
        yourToggleGroup = GetComponent<ToggleGroup>();
    }
    public void Example()
    {
        string name = yourToggleGroup.ActiveToggles().FirstOrDefault().gameObject.name;
        switch (name)
        {
            case "comparison_btn":
                comparison.SetActive(true);
                range.SetActive(false);
                pattern.SetActive(false);
                break;
            case "pattern_btn":
                comparison.SetActive(false);
                range.SetActive(false);
                pattern.SetActive(true);
                break;
            case "range_btn":
                comparison.SetActive(false);
                range.SetActive(true);
                pattern.SetActive(false);
                break;

        }
    }
}
