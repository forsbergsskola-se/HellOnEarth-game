using UnityEngine;
public class DeathCount : MonoBehaviour
{
    public int deaths = 0;
 
    public void IncreaseDeaths()
    {
        deaths += 1;
    }
}