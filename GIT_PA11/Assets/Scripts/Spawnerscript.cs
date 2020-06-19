using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnerscript : MonoBehaviour
{
    public GameObject[] SpawnObject;
    float PositionY;
    public float spawnWait;
    public float spawnMostWait;
    public float spawnLeastWait;
    public int startWait;
    public bool stop;
    private int randEnemy;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawner());
    }

    // Update is called once per frame
    void Update()
    {

        spawnWait = Random.Range(spawnLeastWait, spawnMostWait);

    }

    //void SpawnObjects()
    //{
    //    PositionY = Random.Range(4, -4f);
    //    this.transform.position = new Vector3(transform.position.x, PositionY, transform.position.z);
    //    Instantiate(SpawnObject, transform.position, transform.rotation);
    //}

    IEnumerator Spawner()
    {
        yield return new WaitForSeconds(startWait);

        while(!stop)
        {
            randEnemy = Random.Range(0, 3);
            PositionY = Random.Range(4, -4f);
            this.transform.position = new Vector3(transform.position.x, PositionY, transform.position.z);
            Instantiate(SpawnObject[randEnemy], transform.position, transform.rotation);
            yield return new WaitForSeconds(spawnWait);
        }
    }
}
