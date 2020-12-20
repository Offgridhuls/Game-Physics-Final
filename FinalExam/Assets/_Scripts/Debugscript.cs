using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debugscript : MonoBehaviour
{
    public CubeBehaviour[] cubes;
    public BulletBehaviour[] spheres;
    // Start is called before the first frame update
    void Start()
    {
        spheres = FindObjectsOfType<BulletBehaviour>();
        cubes = FindObjectsOfType<CubeBehaviour>();
    }

    // Update is called once per frame
    void Update(BulletBehaviour s, CubeBehaviour y)
    {
        Debug.Log(s.transform.position);
    }
}
