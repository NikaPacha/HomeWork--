using UnityEngine;

public class UserInputHandler : MonoBehaviour 
{
    private const int MouseButton = 0;
    public CounterView CounterView;

    public void Update()
    {
        if (Input.GetMouseButtonDown(MouseButton))
        {
            if (!CounterView.isCounting)
            {
                CounterView.StartCounter();
            }
            else
            {
                CounterView.StopCounter();
            }
        }
    }
}