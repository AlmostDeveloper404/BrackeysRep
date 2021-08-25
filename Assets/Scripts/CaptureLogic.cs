using UnityEngine;

public class CaptureLogic : MonoBehaviour
{
    CoinManager _coinManager;

    private void Start()
    {
        _coinManager = CoinManager.instance;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Coin>()!=null)
        {
            _coinManager.PickUpCoin(other.transform);

            Destroy(other.gameObject);
        }
    }
}
