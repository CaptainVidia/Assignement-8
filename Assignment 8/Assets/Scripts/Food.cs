using UnityEngine;
using System.Collections;

public class Food : Pickup
{

    bool activated = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            activated = false;
        }
    }

    public override IEnumerator MonsterEatAnything()
    {
        yield break;
    }

    public override bool IsActivated()
    {
        return activated;
    }
}
