using UnityEngine;
using UnityEngine.UI;

public class ToogleBTN : MonoBehaviour
{
    private UnityEngine.UI.Toggle GetToggle;
    [SerializeField] GameObject gameObject;
    // Start is called before the first frame update
    void Start()
    {
        GetToggle = GetComponent<UnityEngine.UI.Toggle>();
    }

    public void getToggleState()
    {
        if (GetToggle.isOn)
        {
            gameObject.SetActive(true);
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}
