using TMPro;
using UnityEngine;

public class PixTouch : MonoBehaviour
{
    private Touch touch;
    
    [SerializeField] public int pixCount;
    [SerializeField] public TMP_Text pixDisplayText;
    [SerializeField] private GameObject[] pixFloatingList;


    void Update()
    {
        if (Input.touchCount > 0) {
            Debug.Log("cricou");
            touch = Input.GetTouch(0);

            pixCount = pixCount + 1;

            pixDisplayText.text = pixCount.ToString();
            Debug.Log(FindFloatingPix());
            pixFloatingList[FindFloatingPix()].GetComponent<PixIncreaseObject>().ActivateFloatingPix();
        }
    }

    private int FindFloatingPix()
    {
        for (int i = 0; i < pixFloatingList.Length; i++)
        {
            if (!pixFloatingList[i].activeInHierarchy)
            {
                Debug.Log("Entrou aq");
                return i;
            }
        }
        return 0;
    }
}
