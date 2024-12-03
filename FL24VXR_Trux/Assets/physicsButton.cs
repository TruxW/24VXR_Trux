using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

public class physicsButton : MonoBehaviour
{
    [SerializeField] private float threshold = 0.1f;
    [SerializeField] private float deadZone = 0.025f;

    private bool _isPressed;
    private Vector3 _startPos;
    private ConfigurableJoint _Joint;

    public UnityEvent onPressed, onReleaded;

    private void Start()
    {
        _startPos = transform.localPosition;
        _Joint = GetComponent<ConfigurableJoint>();

    }

    private void Update()
    {
        if (!_isPressed && GetValue() + threshold >= 1)
            Pressed();
        if (_isPressed && GetValue() - threshold <= 0)
            Released();
    }

    private float GetValue() 
    {
        var value = Vector3.Distance(a:_startPos, b:transform.localPosition) / _Joint.linearLimit.limit;

        if (Mathf.Abs(value) < deadZone)
            value = 0;

        return Mathf.Clamp(value, min:-1f, max:1f);
    
    
    }

    private void Pressed()
    {
        _isPressed = true;
        onPressed.Invoke();
        Debug.Log("Pressed");
    }

    private void Released()
    {
        _isPressed = false;
        onReleaded.Invoke();
        Debug.Log("Released");
    }
}
