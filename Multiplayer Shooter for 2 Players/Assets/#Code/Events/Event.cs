using System;
public class Event
{
    private event Action _action = delegate { };


    public void Invoke() => _action.Invoke();

    public void AddListener(Action listener)
    {
        _action -= listener;
        _action += listener;
    }
    public void RemoveListener(Action listener) => _action -= listener;
}

public class Event<T>
{
    private event Action<T> _action = delegate { };


    public void Invoke(T param) => _action.Invoke(param);

    public void AddListener(Action<T> listener)
    {
        _action -= listener;
        _action += listener;
    }
    public void RemoveListener(Action<T> listener) => _action -= listener;
}