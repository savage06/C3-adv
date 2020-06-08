using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Door2;
    private Vector3 Doorpos;

    private MapManager mapmanager;
    public Vector3 fix;
    void Start()
    {
        Doorpos = Door2.transform.position;
        mapmanager= GameObject.Find("Mapmaneger").GetComponent<MapManager>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerEnter2D(Collider2D col){
        int isdoor = mapmanager.readDoor();
        if(isdoor == 1){
            col.transform.position = Doorpos + fix;
        }
    }

}
