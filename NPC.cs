using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    //здоровье/уровень/скорость NPC
    public int health = 5;
    public int level = 1;
    public float speed = 1.2f;

   
    

    // Start is called before the first frame update
    void Start()
    {
        //Увеличение кол-во здоровья NPC в зависимости от его уровня
        health += level;
        print("Здоровье NPC " + health);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition; 
    }
}
