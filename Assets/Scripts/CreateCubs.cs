using System.Collections;
using UnityEngine;

public class CreateCubs : MonoBehaviour
{
 public GameObject cube;
    private Coroutine spawn;
    public static int time = 10;

    private void Start()
    {
       spawn= StartCoroutine(CreateCube());
       
    }

    private void Update()
    {
        time = ButtonUI.timeTime;

        if (Input.GetKey(KeyCode.Q))
            StopCoroutine(spawn);
        

    }


    IEnumerator CreateCube()
    {
        while (true)
        {
            Instantiate(cube, new Vector3(Random.Range(-6.5f,6.5f), 0.2f, Random.Range(-1, 10)), Quaternion.identity);
            yield return  new WaitForSeconds(time);
        }

    }


}
