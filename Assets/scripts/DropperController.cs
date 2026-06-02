using UnityEngine;

public class DropperController : MonoBehaviour
{
    public bool hasIndicator = false;

    public GameObject dropletPrefab;
    public Transform dropPoint;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<IndicatorBeaker>())
        {
            hasIndicator = true;

            Debug.Log("Dropper Filled!");
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ReleaseDrop();
        }
    }

    public void ReleaseDrop()
    {
        if (!hasIndicator)
            return;

        Instantiate(
            dropletPrefab,
            dropPoint.position,
            Quaternion.identity
        );
    }
}