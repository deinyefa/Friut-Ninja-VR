using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProduceSpawner : MonoBehaviour {

    public GameObject[] produce;

	void Start () {
        StartCoroutine(SpawnProduce());
	}

    IEnumerator SpawnProduce ()
    {
        while (true)
        {
            GameObject go = Instantiate(produce[Random.Range(0, produce.Length)]);
            Rigidbody rb = go.GetComponent<Rigidbody>();

            rb.velocity = new Vector3(0, 5f, 0.5f);
            rb.angularVelocity = new Vector3(Random.Range(5f, 15f), 0, 0);
            rb.useGravity = true;

            Vector3 pos = transform.position;
            pos.x += Random.Range(-1f, 1f);
            go.transform.position = pos;

            yield return new WaitForSeconds(1f);
        }
    }
}
