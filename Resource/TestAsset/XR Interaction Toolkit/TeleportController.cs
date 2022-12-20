using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;


public class TeleportController : MonoBehaviour
{
    public GameObject baseControllerGameObejct;
    public GameObject teleportationGameObejct;

    public InputActionReference teleportActivationReference;
    [Space]
    public UnityEvent onTeleportActivate;
    public UnityEvent onTeleportCancel;

    private void Start()
    {
        teleportActivationReference.action.performed += TeleportModeActivate;
        teleportActivationReference.action.canceled += TeleportModeCancel;
    }
    private void TeleportModeCancel(InputAction.CallbackContext obj) => Invoke("DeactivateTeleporter", .1f);

    void DeactivateTeleporter() => onTeleportCancel.Invoke();
    private void TeleportModeActivate(InputAction.CallbackContext obj) => onTeleportActivate.Invoke();
}
