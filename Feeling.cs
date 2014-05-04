using UnityEngine;
using System.Collections;


public class Feeling : MonoBehaviour
{
    public Feelings myFeeling = Feelings.Anger;
    public Door TempDoor;

    public Feeling()
    {
    }

    void Update()
    {

    }
    void OnTriggerEnter(Collider c)
    {
        for (int i = 0; i < GameObject.FindGameObjectsWithTag("Door").Length; i++) // On parcours l'ensemble des objets "Door"
        {
            GameObject doorGameObj = GameObject.FindGameObjectsWithTag("Door")[i];
            if (doorGameObj != null)
            {
                TempDoor = doorGameObj.GetComponent<Door>();
                if (TempDoor.myFeeling == this.myFeeling)
                    TempDoor.OpenTheDoor();
            }
        }
        Destroy(this.gameObject); // on supprime le Pickup
        PheelGameManager.SP.FoundFeeling(); // ajoute 1 au compteur
    }
}

