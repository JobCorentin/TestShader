using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public List<GameObject> list;
    // Start is called before the first frame update
    void Start()
    {
        SetFalseList();
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown("a"))
        {
            SetFalseList();
            list[0].gameObject.SetActive(true);
        }
        if (Input.GetKeyDown("z"))
        {
            SetFalseList();
            list[1].gameObject.SetActive(true);
        }
        if (Input.GetKeyDown("e"))
        {
            SetFalseList();
            list[2].gameObject.SetActive(true);
        }
    }

    void SetFalseList()
    {
        foreach (GameObject game in list)
        {
            game.SetActive(false);
        }
    }
}
