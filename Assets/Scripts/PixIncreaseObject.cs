using UnityEngine;

public class PixIncreaseObject : MonoBehaviour
{
    public void ActivateFloatingPix()
    {
        gameObject.SetActive(true);
        Debug.Log("Entrou aq");
        float localPositionX = Random.Range(1.0f, 500.0f);
        localPositionX = Mathf.Round(localPositionX * 100f) / 100f;
        Debug.Log(transform.position);
        transform.position = new Vector3(localPositionX, transform.position.y, transform.position.z);
        Debug.Log(transform.position);

    }

    private void Deactivate()
    {
        gameObject.SetActive(false);
    }
}
