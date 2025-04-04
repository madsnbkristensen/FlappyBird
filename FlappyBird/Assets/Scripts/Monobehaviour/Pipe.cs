using UnityEngine;

public class Pipe : MonoBehaviour
{
   public float speed = 1f;
   public float despawnX = -10f; // Set this to a value that's off-screen

   void FixedUpdate()
   {
    transform.Translate(Vector3.left * speed * Time.fixedDeltaTime);

    if (transform.position.x < despawnX)
      {
         Destroy(gameObject);
      }
   }
}
