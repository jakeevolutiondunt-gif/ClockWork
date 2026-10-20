using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] private Button _btn;
    [SerializeField] private Image _buttonImage;
    [SerializeField] private Sprite _startSprite;
    [SerializeField] private Sprite _stopSprite;
    void Start()
    {
        _buttonImage.sprite = _startSprite;
    }

    void Update()
    {

    }

    public void Stop()
    {
        _buttonImage.sprite = _startSprite;
    }

    public void StartTimer()
    {
        _btn.interactable = false;
        _buttonImage.sprite = _stopSprite;
    }

    public void Counter()
    {

    }
}
