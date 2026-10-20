using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] private Button _btn;
    [SerializeField] private Image _buttonImage;
    [SerializeField] private Sprite _startSprite;
    [SerializeField] private Sprite _stopSprite;
    public Image timerImage;

    [SerializeField] private float duration = 10f;
    [SerializeField] private TextMeshProUGUI timerText;
    [SerializeField] private Button actionButton;

    private float timeLeft;
    private bool isRunning = false;

    void Start()
    {
        _buttonImage.sprite = _startSprite;
        if (timerImage != null)
        {
            timerImage.fillAmount = 1f;
        }
    }

    void Update()
    {
        if (isRunning)
        {
            timeLeft -= Time.deltaTime;
            timerImage.fillAmount = timeLeft / duration;
            if (timeLeft <= 0f)
            {
                timerImage.fillAmount = 0f;
                isRunning = false;
            }
        }
    }

    public void Stop()
    {
        _buttonImage.sprite = _startSprite;
    }

    public void StartTimer()
    {
        _btn.interactable = false;
        _buttonImage.sprite = _stopSprite;
        if (!isRunning)
        {
            timeLeft = duration;
            isRunning = true;
        }
    }
}
