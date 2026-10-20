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
    public Image secondTimer;

    [SerializeField] private float duration = 10f;
    [SerializeField] private float durationResourse = 3f;
    [SerializeField] private Button actionButton;
    private int cycle = 0;
    private int resourse = 0;
    public TextMeshProUGUI _text;
    public TextMeshProUGUI _secondTimerText;

    private float timeResourse;
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
        if (timeResourse < 1f)
        {
            timeResourse += Time.deltaTime;
            secondTimer.fillAmount = timeResourse / duration;
        }
        else
        {
            resourse += 1;
            _secondTimerText.text = "Количество ресурсов: " + resourse;
            secondTimer.fillAmount = 0f;
            timeResourse = 0f;
        }
        if (resourse < 5)
        {
            _btn.interactable = false;
            _buttonImage.sprite = _stopSprite;
        }
        else
        {
            _btn.interactable = true;
            _buttonImage.sprite = _startSprite;
        }
        if (isRunning)
        {
            if (timeLeft > 0f)
            {
                timeLeft -= Time.deltaTime;
                timerImage.fillAmount = timeLeft / duration;
            }
            else
            {
                isRunning = false;
                timerImage.fillAmount = 1;
                _btn.interactable = true;
                _buttonImage.sprite = _startSprite;
            }
        }
    }

    public void StartTimer()
    {
        resourse -= 5;
        cycle += 1;
        _text.text = "Количество запусков: " + cycle;
        _btn.interactable = false;
        _buttonImage.sprite = _stopSprite;
        if (!isRunning)
        {
            timeLeft = duration;
            isRunning = true;
        }
    }
}
