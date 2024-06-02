using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomEvent : MonoBehaviour
{
    public GameObject SpawnPoint;
    public GameObject ColumPrefab;
    

    private Queue<MoveColums> Pool = new Queue<MoveColums>();


    public void Create()
    {
        if (Pool.Count > 0)
        {
            var colum = Pool.Dequeue();
            ColumSetup(colum.gameObject);
        }
        else
        {
          //
        }
    }

    private void ColumSetup(GameObject colum)
    {
        var y = Random.Range(-2f, 3f);
        
      


        colum.transform.position = new Vector3(SpawnPoint.transform.position.x,y, SpawnPoint.transform.position.z);
    }

}
