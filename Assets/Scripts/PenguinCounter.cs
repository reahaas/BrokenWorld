using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenguinCounter : MonoBehaviour
{
    // This variable is update from out side of this class's code.
    // note that it is static so it belongs to the class and not an instance of that class.
    // That makes it easier to update the score from anywhere because we don't need to pass
    // GameScore reference around
    static public int count;
}
