using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RootSpawner : MonoBehaviour
{

    public int rootsCount = 1;
    public GameObject root;
    public GameObject spawnPivot;
    public float Horizontalrange = 5;
    public float Verticalrange = 5;
    private List<GameObject> spawnedRoots = new List<GameObject>();

    // Start is called before the first frame update
    void Start() {
        Vector3 pivot = spawnPivot.transform.position;
        for(int i = 0 ; i < rootsCount; ++i) {
            Vector3 pos = pivot + new Vector3(Random.Range( -1 * Horizontalrange, Horizontalrange), Random.Range(-1 * Verticalrange, 0), 0f);
            Instantiate(root, pos, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update() {
        
    }

}