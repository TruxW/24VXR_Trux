using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//ItemClick
public class ItemClick : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            ScoreManager.scoreCount += 1;
        }
    }
    public static int clickCount = 0;

    private void OnMouseDown()
    {
        clickCount++;
        Transform moveLoc;
        GameObject tap = Instantiate(this.gameObject);
       // Destroy(tmp.GetComponent<ItemClick>());

        switch (clickCount)
        {
            case 1:
               // tmp.name = "Pan Item 1";
                moveLoc = GameObject.Find("Locl").transform;

               // tmp.Compute_DistanceTransform_EventTypes.position = moveLoc.position;
               // tmp.Compute_DistanceTransform_EventTypes.rotation = moveLoc.transform.rotation;
               // tmp.Compute_DistanceTransform_EventTypes.localScale = new Vector3(1f, 1f, 1f);
                break;
            case 2:
              //  tmp.name = "Pan Item 2";
                moveLoc = GameObject.Find("Loc2").transform;
               // tmp.transfom.position = moveLoc.position;
              //  tmp.Compute_DistanceTransform_EventTypes.rotation = moveLoc.transform.rotation;
               // tmp.Compute_DistanceTransform_EventTypes.localScale = new Vector3(0.5f, 0.5f, 0.5f);
                break;
            case 3:
               // tmp.name = "Pan Item 3";
                moveLoc = GameObject.Find("Loc3").transform;
              //  tmp.Compute_DistanceTransform_EventTypes.position = moveLoc.position;
               // tmp. transfom.localScale = new Vector3(0.5f, 0.5f, 0.5f);
                clickCount = 0;
                break;
        }
    }
}
