using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public float repeatRate = 2;
    private float timer = 0;
    public float height = 4;
    public GameObject prefabCoin;
    // Start is called before the first frame update
    void Update()
    {
        if (timer > repeatRate) {
            SpawnCoin(prefabCoin);
            timer = 0;
        }

        timer += Time.deltaTime;
    }
    private void SpawnCoin(GameObject coin) {
        GameObject newCoin = Instantiate(coin);
        newCoin.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
        Destroy(newCoin, 10f);

    }
}
