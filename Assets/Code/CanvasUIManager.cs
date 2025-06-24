using TMPro;
using UnityEngine;

public class CanvasUIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textRef;

    private float timeInput;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeInput += Time.deltaTime;
        textRef.text = $"TIME: {timeInput.ToString("#.00")}s";
    }
}
