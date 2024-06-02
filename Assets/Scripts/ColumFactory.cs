using System.Collections.Generic;
using UnityEngine;

public class ColumFactory : MonoBehaviour
{
    public GameObject SpawnPoint;
    public MoveColums ColumPrefab;
    public AudioSource Sound1;

    private Queue<MoveColums> Pool = new Queue<MoveColums>();


    public void Create()
    {
        if (Pool.Count > 0)
        {
            var colum = Pool.Dequeue();
            ColumSetup(colum);
        }
        else
        {
            SpawnColum();
        }
    }

    private void ReleaseColum(MoveColums colum)
    {
        colum.OnRelease -= ReleaseColum;
        colum.transform.position = SpawnPoint.transform.position;
        Pool.Enqueue(colum);
    }

    private void ColumSetup(MoveColums colum)
    {
        var y = Random.Range(-2f, 3f);

        colum.transform.position = new Vector3(SpawnPoint.transform.position.x, y, SpawnPoint.transform.position.z);
        colum.OnRelease += ReleaseColum;
        colum.SetTimer(10f);
    }


    public void SpawnColum()
    {
        var colum = Instantiate(ColumPrefab, SpawnPoint.transform.position, Quaternion.identity);
        colum.SetAudioSource(Sound1);
        ColumSetup(colum);
    }
}