using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCController : MonoBehaviour , Interactable
{
    [SerializeField] Dialog dialog;


    public void Interact()
    {
        StartCoroutine(DialogManager.Instance.ShowDialog(dialog));
    }

    public void LookTowards(Vector3 targerPos)
    {
        var xdiff = Mathf.Floor(targerPos.x) - Mathf.Floor(transform.position.x);
        var ydiff = Mathf.Floor(targerPos.y) - Mathf.Floor(transform.position.y);

        if (xdiff == 0 || ydiff == 0)
        {

        }
        else
            Debug.LogError("Cannot look diagonal!");
    }
}
