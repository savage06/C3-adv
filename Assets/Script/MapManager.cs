using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : MonoBehaviour
{
    // Start is called before the first frame update
    int Door = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void inDoor(int Doormode){
        Door = Doormode;
    }
    public int readDoor(){
        return Door;
    }
}
