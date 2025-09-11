using TMPro;
using UnityEngine;

public class CounterView : MonoBehaviour
{
    [SerializeField] private TMP_Text _counterText;
    private Counter _counter;

    public void SetCounter(Counter counter)
    {
        _counter = counter;
    }

    public void UpdateDisplay()
    {
        if (_counterText != null && _counter != null)
        {
            _counterText.text = "Счетчик: " + _counter.Count;
        }
    }
}