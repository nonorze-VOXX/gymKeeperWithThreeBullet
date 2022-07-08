using UnityEngine;
using System.Collections;

public class Missile : MonoBehaviour
{
    public int timeoutDestructor;

    // ...other code...
}


public class test : MonoBehaviour
{
    // Instantiate a Prefab with an attached Missile script
    public Missile projectile;

    void Update()
    {
        // Ctrl was pressed, launch a projectile
        if (Input.GetButtonDown("Fire1"))
        {
            // Instantiate the projectile at the position and rotation of this transform
            Missile clone = Instantiate(projectile, transform.position, transform.rotation);

            // Set the missiles timeout destructor to 5
            clone.timeoutDestructor = 5;
        }
    }
}