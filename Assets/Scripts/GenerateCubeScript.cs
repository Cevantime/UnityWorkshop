using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateCubeScript : MonoBehaviour
{
    public GameObject cubePrefab;

    private int i = 0;

    public void GenerateCube()
    {
        Instantiate(cubePrefab, new Vector3((i++) * 3, 1, 1), Quaternion.identity);
    }
}
