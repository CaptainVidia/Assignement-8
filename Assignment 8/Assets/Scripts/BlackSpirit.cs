using UnityEngine;
using System.Collections;

public class BlackSpirit : Pickup
{
    bool hungryActivated = true;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            hungryActivated = !hungryActivated;
        }
    }

    public override IEnumerator MonsterEatAnything()
    {
        gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
        yield return new WaitForSeconds(1f);
        gameObject.GetComponent<MeshRenderer>().material.color = Color.black;
        yield return new WaitForSeconds(1f);
        gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
        yield return new WaitForSeconds(0.25f);
        gameObject.GetComponent<MeshRenderer>().material.color = Color.black;
        yield return new WaitForSeconds(0.25f);

        yield break;


    }
    public override bool IsActivated()
    {
        return hungryActivated;
    }
}
