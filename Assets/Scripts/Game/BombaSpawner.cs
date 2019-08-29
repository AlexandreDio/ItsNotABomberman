using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class BombaSpawner : NetworkBehaviour
{
    public GameObject bomb;
    public int firePower = 1;
    int numberOfBomb = 1;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        //if (!isLocalPlayer)
        //{
        //    //Destroy(this);
        //    return;
        //}
    }

    // Update is called once per frame
    void Update()
    {
        if (!isLocalPlayer)
        {
            return;
        }
        CmdSpawn();
    }

    [Command]
    void CmdSpawn()
    {
        if (Input.GetButtonDown("Jump") && numberOfBomb >= 1)
        {
            //Vector2 spawnPos = new Vector2(Mathf.Round(transform.position.x) / 2, Mathf.Round(transform.position.y) / 2);
            Vector2 spawnPos = new Vector2(Mathf.Round(player.transform.position.x), Mathf.Round(player.transform.position.y));
            var newBomb = Instantiate(bomb, spawnPos, Quaternion.identity) as GameObject;
            newBomb.GetComponent<Bomba2>().firePower = firePower;
            numberOfBomb--;
            Invoke("AddBomb", 1);

            NetworkServer.Spawn(newBomb);
        }
    }

    public void AddBomb()
    {
        numberOfBomb++;
    }
}
