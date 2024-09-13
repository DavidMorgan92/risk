#nullable enable

using UnityEngine;

public partial class Game : MonoBehaviour
{  
    public Continent[]? continents;

    public static Game GetInstance() => GameObject.FindWithTag("GameController").GetComponent<Game>();
}
