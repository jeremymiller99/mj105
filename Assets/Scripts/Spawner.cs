using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject[] prefab;
    [SerializeField] float spawnInterval = 0.5f;
    [SerializeField] float min;
    [SerializeField] float max;
    public GameManager gm;

    void Update()
    {
        //start spawning
        if(gm.playing){
            StartCoroutine(Spawn());
        }
    }
    IEnumerator Spawn(){
        while(true){
            var wanted = Random.Range(min, max);
            var position = new Vector3(wanted, transform.position.y);
            GameObject gameObject = Instantiate(prefab[Random.Range(0,prefab.Length)], position, Quaternion.identity);
            yield return new WaitForSeconds(spawnInterval);
        }
    }
}
