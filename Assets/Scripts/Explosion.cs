using UnityEngine;

public class Explosion : MonoBehaviour
{
    // Variables
    
    void Start()
    {
        Destroy(this.gameObject, 3f);
    }
}
