using System.Collections;
using TMPro;
using UnityEngine;

public class CounterView : MonoBehaviour
{
    [SerializeField] private TMP_Text _counterText;
    private Counter _counter = new Counter();
    private Coroutine _counterCoroutine = null;
    public bool isCounting = false;
    private float _waitTime = 0.5f;

    public void StartCounter()
    {
        if (_counterCoroutine == null)
        {
            isCounting = true;
            _counterCoroutine = StartCoroutine(UpdateCounter());
        }
    }

    public void StopCounter()
    {
        if (_counterCoroutine != null)
        {
            StopCoroutine(_counterCoroutine);
            _counterCoroutine = null;
            isCounting = false;
        }
    }

    private IEnumerator UpdateCounter()
    {
        while (enabled)
        {
            yield return new WaitForSeconds(_waitTime);
            if (_counterText != null)
            {
                _counter.Increment();
                _counterText.text = "Счетчик: " + _counter.Count;
            }
        }
    }
}