using UnityEngine;

public class PlayerCamera : MonoBehaviour
{

    [SerializeField] Camera camera;
    [SerializeField] Transform playerLocation;
    [SerializeField] Transform orientation;

    // Start is called once before the first execution of Update after the MonoBehaviour is created


    /* ok so my initial thought as to how i want the camera and interaction and stuff to work is that i want the camera to be locked to where the ther cursor is. Kind of like a first person game, the cursor 
     is locked to the center of the screen. that way i dont have to do like "if ur holding down the right mouse button then you can look around. Then i suppose we can use code like for the cue stick and the power
    and use the idea of change in location to change the rotation of the camera. I believe this is similar to in my time at portia, which is what i am referencing for the 3d parts of this game
    */
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
