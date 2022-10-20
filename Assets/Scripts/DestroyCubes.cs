
using UnityEngine;

public class DestroyCubes : MonoBehaviour
{
    public static float distance;
    


    private void Start()
    {
        distance = -10f;
    }

   
    void Update()
    {
        if (ButtonUI.distanceDistance < 0)
        
            distance = ButtonUI.distanceDistance;
            
        
      

        if (gameObject.transform.position.z < distance)
            Destroy(gameObject);

    }
}
