using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragPNE : MonoBehaviour
{
    Camera cam;
    public GameObject pne;

    private GameObject[] pNew;


    
    static int ip = 0;
    static int iN = 0;
    static int ie = 0;

    int numPNE = 5;

    public Vector3 position;

    private Vector3 pNeutron = new Vector3(1110.6f, 787f, -850.5f);
    private Vector3 pProton = new Vector3(1112.4f, 834.2f, -850.5f);
    private Vector3 pElectron = new Vector3(1110.9f, 743f, -850.5f);
    //new Vector3(1112.4f,834.2f,-850.5f); -- proton
    // 1110.6f, 787f, -850.5f -- neutron
    // 1110.9f, 743f, -850.5f -- electron
    private void Start()
    {
        //Debug.Log("Starting");
        cam = GetComponent<Camera>();
        Debug.Log(GameObject.Find("proton").transform.position);
        pNew = new GameObject[numPNE];
    }

    private Vector3 screenPoint;
    private Vector3 offset;


    void OnMouseDown()
    {
        CastRay();

        Debug.Log("left click");
        screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);

        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
        Debug.Log("Input " + Camera.main.ScreenToWorldPoint(Input.mousePosition).x + "Ager Position " + position.x);


        if (Camera.main.ScreenToWorldPoint(Input.mousePosition).x <= (position.x + 5))                // check X coordinate
        {
            if(Camera.main.ScreenToWorldPoint(Input.mousePosition).y >= (position.y - 5))           // check Y coordinate
            {
                if (position.y == pProton.y && ip<numPNE)
                {
                    pNew[ip] = Instantiate(pne, position, Quaternion.identity);
                    pNew[ip].transform.parent = GameObject.Find("pne").transform;
                    ip++;
                    Debug.Log("i p " + ip);
                }

                else if (position.y == pNeutron.y && iN<numPNE)
                {
                    pNew[iN] = Instantiate(pne, position, Quaternion.identity);
                    pNew[iN].transform.parent = GameObject.Find("pne").transform;
                    iN++;
                    Debug.Log("i n " + iN);
                }
                else if (position.y == pElectron.y && ie<numPNE)
                {
                    pNew[ie] = Instantiate(pne, position, Quaternion.identity);
                    pNew[ie].transform.parent = GameObject.Find("pne").transform;
                    ie++;
                    Debug.Log("i " + ie);
                }
            }
            
        }
    }

    void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);

        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
        transform.position = curPosition;


    }

    void CastRay()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, Mathf.Infinity);
        if (hit.collider != null)
        {
            Debug.Log("Cast " + hit.collider.gameObject.name);
        }

    }
}
