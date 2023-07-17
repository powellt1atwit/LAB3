using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    float x;
    float y;
    float z;
    Vector3 pos;
    public GameObject start;
    public GameObject end;
    public GameObject player;
    public GameObject plane;
    public TestPathFinder TPF;
    private ArrayList bfs;
    private ArrayList astar;
    private int numOfColumns;
    private int numOfRows;
    private float gridCellSize;
    float width;
    float height;
    private Vector3 origin;

    // Start is called before the first frame update
    void Start()
    {

        start = GameObject.FindGameObjectWithTag("Start");
        end = GameObject.FindGameObjectWithTag("End");
        player = GameObject.FindGameObjectWithTag("Player");
        plane = GameObject.FindGameObjectWithTag("Plane");
        origin = new Vector3(20.0F,0.0F,20.0F);

        
        y = origin.y;
        x = Random.Range(origin.x - 20, origin.x + 20);
        z = Random.Range(origin.z - 20, origin.z + 20);
        pos = new Vector3(x, y, z);
        start.transform.position = pos;
        player.transform.position = new Vector3(start.transform.position.x,(float)0.5,start.transform.position.z);
        x = Random.Range(origin.x - 20, origin.x + 20);
        z = Random.Range(origin.z - 20, origin.z + 20);
        pos = new Vector3(x, y, z);
        end.transform.position = pos;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    // void OnDrawGizmos()
    // {
    //     bfs = TPF.pathArray2;

    //     if (bfs == null)
    //         return;        

    //     if (bfs.Count > 1)
    //     {
    //         int index = 1;
    //         foreach (Node node in bfs)
    //         {
    //             if (index < bfs.Count)
    //             {
    //                 Node nextNode = (Node)bfs[index];
    //                 Debug.DrawLine(node.position, nextNode.position, Color.blue);

    //                 index++;
    //             }
    //         };
    //     }

        
    // }

    void OnDrawGizmos()
    {
        astar = TPF.pathArray3;

        if (astar == null)
            return;        

        if (astar.Count > 1)
        {
            int index = 1;
            foreach (Node node in astar)
            {
                if (index < astar.Count)
                {
                    Node nextNode = (Node)astar[index];
                    Debug.DrawLine(node.position, nextNode.position, Color.red);

                    index++;
                }
            };
        }

        
    }
    
}