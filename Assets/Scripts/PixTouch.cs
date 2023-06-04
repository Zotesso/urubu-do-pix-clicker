using TMPro;
using UnityEngine;

public class PixTouch : MonoBehaviour
{
    private Touch touch;
    
    [SerializeField] public int pixCount;
    [SerializeField] public TMP_Text pixDisplayText;


    void Update()
    {
        if (Input.touchCount > 0) {
            Debug.Log("cricou");
            touch = Input.GetTouch(0);

            pixCount = pixCount + 1;
            Debug.Log(pixCount);

            pixDisplayText.text = pixCount.ToString();
        }
    }
}
