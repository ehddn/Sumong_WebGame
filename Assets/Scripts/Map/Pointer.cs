using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pointer : MonoBehaviour
{

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator move(List<GameObject> wayPoint)
    {
        int i = 0;
        float degree = 100;

        while(i < wayPoint.Count - 1)
        {
            Vector2 now = new Vector2(transform.position.x, transform.position.y);
            Vector2 target = new Vector2(wayPoint[i + 1].transform.position.x, wayPoint[i + 1].transform.position.y);

            if (degree < (now - target).magnitude)
            {
                degree = 100;
                i++;
            }
            else
            {
                Vector3 dir = wayPoint[i + 1].transform.position - wayPoint[i].transform.position;
                dir = dir.normalized;
                transform.position = transform.position + dir * 2.5f * Time.deltaTime;
                transform.position = new Vector3(transform.position.x, transform.position.y, -5);

                degree = (now - target).magnitude;
            }
            yield return null;
        }

        Destroy(this.gameObject);
    }
}
