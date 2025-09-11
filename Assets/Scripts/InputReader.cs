using UnityEngine;

public class InputReader : MonoBehaviour
{
    private const int MOUSE_BUTTON = 0;
    public event System.Action OnButtonClicked;

    private void Update()
    {
        if (Input.GetMouseButtonDown(MOUSE_BUTTON))
        {
            OnButtonClicked?.Invoke();
        }
    }
}