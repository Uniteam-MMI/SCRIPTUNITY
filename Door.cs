using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour
{
    public bool opened;
    public static Door SD;
    public Feelings myFeeling = Feelings.Anger;
    void Update()
    {
        if (this.opened == true)
        {
            //ici faire monter la porte animation de la porte.
            Destroy(this.gameObject);
        }
    }

    public Door()
    {
        opened = false;
    }
    public void OpenTheDoor()
    {
        opened = true;
    }
}