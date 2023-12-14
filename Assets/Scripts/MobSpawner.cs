using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] variants;
    [SerializeField] private Transform spawnArea;
    private float intensity = 3f;

    private bool isSpawning = true;
    private Vector3 spawnerSize;
    void Start()
    {
        StartCoroutine(SpawnEnemy());
        spawnerSize = new Vector3(
            spawnArea.localScale.x,
            0f,
            spawnArea.localScale.z
        );
        Debug.Log(spawnerSize);
        Debug.Log(spawnArea.transform.position);
    }

    private IEnumerator SpawnEnemy()
    {
        while (isSpawning)
        {
            yield return new WaitForSeconds(intensity);
            Vector3 random = new Vector3(
                Random.Range(-spawnerSize.x,
                    spawnerSize.x),
                0f,
                Random.Range(-spawnerSize.z, spawnerSize.z)
            );
            InstantiateEnemy(
                Random.Range(0,variants.Length),
                spawnArea.transform.position + random
                );
        }
    }

    private void InstantiateEnemy(int index, Vector3 position)
    {
        GameObject instantiated = Instantiate(
            variants[index],
            position, 
            Quaternion.Euler(0f, 180f, 0f)
            );
        Debug.Log("Spawning");
    }

    public void EndSpawn()
    {
        isSpawning = false;
    }
}
