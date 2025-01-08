using NUnit.Framework.Constraints;
using UnityEngine;

public class GameManager : MonoSingletongeneric<GameManager>
{
    // with this the Game Manager becomes a singleton and any other scripts will have 
    // Access to the Gamemanager.Instance as Isntance is static 
}
