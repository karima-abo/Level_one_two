using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
    public GameObject Column;
    

    
    void Start()
    {
        StartCoroutine(CreateColumn());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator CreateColumn()
    {
        yield return new WaitForSeconds(5);

        GameObject new_column = Instantiate(Column);

        new_column.transform.position = new Vector3(10, Random.Range(-2.85f, -5.8f), 0);

        StartCoroutine(CreateColumn());
    }
}
