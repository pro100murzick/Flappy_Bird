using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiperSpawner : MonoBehaviour
{

    [SerializeField] float timeToSpawn = 1f;
    [SerializeField] GameObject pipe1;
    [SerializeField] GameObject pipe2;
    [SerializeField] float height;

    private int pipeNum = 0;
    private Coroutine spawnPipesCoroutine;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    IEnumerator SpawnPipe()
    {
        while (true)
        {
            if (pipeNum == 0)
            {
                CreateAndMove(pipe1);
                yield return new WaitForSeconds(timeToSpawn);
            }
            else if (pipeNum == 1)
            {
                CreateAndMove(pipe2);
            }
            yield return new WaitForSeconds(timeToSpawn);
            pipeNum = 1 - pipeNum;
        }
    }

    public void StartSpawning()
    {
        spawnPipesCoroutine = StartCoroutine(SpawnPipe());
    }

    private void CreateAndMove(GameObject pipe)
    {
        GameObject newPipe = Instantiate(pipe);
        Vector3 randFactor = new Vector3(0, Random.Range(-height, height), 0);
        newPipe.transform.position = transform.position + randFactor;
        Destroy(newPipe, 5f);// Время до уничтожения объекта-трубы (5 сек)
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
