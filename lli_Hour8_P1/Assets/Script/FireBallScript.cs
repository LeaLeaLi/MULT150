using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    { // Call version 1: No parameters
        int x = TakeDamageFromFireball();
        print("Player health: " + x);

        // Call version 2: One parameter
        int y = TakeDamageFromFireball(25);
        print("Player health: " + y);

        // Call version 3: Two parameters
        int z = TakeDamageFromFireball(30, 50);
        print("Player health: " + z);
    }

    // Version 1: No parameters
    int TakeDamageFromFireball()
    {
        int health = 100;
        int damage = 10;
        return health - damage;
    }

    // Version 2: One parameter
    int TakeDamageFromFireball(int damageAmount)
    {
        int health = 100;
        return health - damageAmount;
    }

    // Version 3: Two parameters
    int TakeDamageFromFireball(int damageAmount, int bonusDamage)
    {
        int health = 100;
        return health - damageAmount - bonusDamage;
    }
}
