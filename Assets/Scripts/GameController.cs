using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private CounterView _counterView;
    [SerializeField] private InputReader _inputReader;
    private Counter _counter = new Counter();
    private Coroutine _counterCoroutine = null;
    private bool _isCounting = false;
    private readonly WaitForSeconds _waitTime = new WaitForSeconds(0.5f);

    private void Start()
    {
        _counterView.SetCounter(_counter);
        _inputReader.OnButtonClicked += HandleButtonClick;
    }

    private void HandleButtonClick()
    {
        if (_isCounting)
        {
            StopCounter();
        }
        else
        {
            StartCounter();
        }
    }

    private void StartCounter()
    {
        if (_counterCoroutine == null)
        {
            _isCounting = true;
            _counterCoroutine = StartCoroutine(UpdateCounter());
        }
    }

    private void StopCounter()
    {
        if (_counterCoroutine != null)
        {
            StopCoroutine(_counterCoroutine);
            _counterCoroutine = null;
            _isCounting = false;
        }
    }

    private IEnumerator UpdateCounter()
    {
        while (enabled)
        {
            yield return _waitTime;
            _counter.Increment();
            _counterView.UpdateDisplay();
        }
    }
}
