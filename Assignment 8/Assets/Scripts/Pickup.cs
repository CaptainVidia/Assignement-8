using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Pickup : MonoBehaviour
{
    public GameObject eat;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
            StartCoroutine(Triggered());
    }

    public IEnumerator Triggered()
    {
        if (IsActivated())
        {
            StartCoroutine(MonsterEatAnything());

            yield return new WaitForSeconds(0.5f);

            StartCoroutine(MonsterEat());
        }

        yield break;
    }

    public abstract IEnumerator MonsterEatAnything();

    public IEnumerator MonsterEat()
    {
        eat.SetActive(true);

        yield return new WaitForSeconds(5f);

        eat.SetActive(false);

        yield break;
    }

    public virtual bool IsActivated()
    {
        return true;
    }
}
