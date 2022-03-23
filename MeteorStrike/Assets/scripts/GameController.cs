using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] int startWait;
    [SerializeField] int waveWait;
    [SerializeField] int spawnWait;

    [SerializeField] GameObject hazard;
    [SerializeField] Vector3 spawnValues;
    [SerializeField] int hazardCount;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnWaves());

    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);
        while (true)
        {
            for (int i = 0; i < hazardCount; i++)
            {
                Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate(hazard, spawnPosition, spawnRotation);
                yield return new WaitForSeconds(spawnWait);
            }
            yield return new WaitForSeconds(waveWait);
        }

    }
}

