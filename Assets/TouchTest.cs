using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchTest : MonoBehaviour
{
    public GameObject marsPopup;
    public GameObject earthPopup;
    public GameObject mercuryPopup;
    public GameObject venusPopup;
    public GameObject jupiterPopup;
    public GameObject saturnPopup;
    public GameObject uranusPopup;
    public GameObject neptunePopup;
    public GameObject moonPopup;
    public GameObject sunPopup;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Pressed primary button.");

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100))
            {
                Debug.Log("hit");
                Debug.Log(hit.transform.name + " : " + hit.transform.tag);

                if (hit.transform.tag == "mars")
                {
                   Vector3 pos = hit.point;
                   pos.z += 0.25f;
                   pos.y += 0.25f;
                   Instantiate(marsPopup, pos, transform.rotation);
                }

                if (hit.transform.tag == "earth")
                {
                    Vector3 pos = hit.point;
                    pos.z += 0.25f;
                    pos.y += 0.25f;
                    Instantiate(earthPopup, pos, transform.rotation);
                }

                if (hit.transform.tag == "mercury")
                {
                    Vector3 pos = hit.point;
                    pos.z += 0.25f;
                    pos.y += 0.25f;
                    Instantiate(mercuryPopup, pos, transform.rotation);
                }

                if (hit.transform.tag == "venus")
                {
                    Vector3 pos = hit.point;
                    pos.z += 0.25f;
                    pos.y += 0.25f;
                    Instantiate(venusPopup, pos, transform.rotation);
                }

                if (hit.transform.tag == "jupiter")
                {
                    Vector3 pos = hit.point;
                    pos.z += 0.25f;
                    pos.y += 0.25f;
                    Instantiate(jupiterPopup, pos, transform.rotation);
                }

                if (hit.transform.tag == "saturn")
                {
                    Vector3 pos = hit.point;
                    pos.z += 0.25f;
                    pos.y += 0.25f;
                    Instantiate(saturnPopup, pos, transform.rotation);
                }

                if (hit.transform.tag == "uranus")
                {
                    Vector3 pos = hit.point;
                    pos.z += 0.25f;
                    pos.y += 0.25f;
                    Instantiate(uranusPopup, pos, transform.rotation);
                }

                if (hit.transform.tag == "neptune")
                {
                    Vector3 pos = hit.point;
                    pos.z += 0.25f;
                    pos.y += 0.25f;
                    Instantiate(neptunePopup, pos, transform.rotation);
                }

                if (hit.transform.tag == "moon")
                {
                    Vector3 pos = hit.point;
                    pos.z += 0.25f;
                    pos.y += 0.25f;
                    Instantiate(moonPopup, pos, transform.rotation);
                }

                if (hit.transform.tag == "sun")
                {
                    Vector3 pos = hit.point;
                    pos.z += 0.25f;
                    pos.y += 0.25f;
                    Instantiate(sunPopup, pos, transform.rotation);
                }

                if (hit.transform.tag == "marsInfo")
                {
                    Destroy(hit.transform.gameObject);
                }

                if (hit.transform.tag == "earthInfo")
                {
                    Destroy(hit.transform.gameObject);
                }

                if (hit.transform.tag == "mercuryInfo")
                {
                    Destroy(hit.transform.gameObject);
                }

                if (hit.transform.tag == "venusInfo")
                {
                    Destroy(hit.transform.gameObject);
                }

                if (hit.transform.tag == "jupiterInfo")
                {
                    Destroy(hit.transform.gameObject);
                }

                if (hit.transform.tag == "saturnInfo")
                {
                    Destroy(hit.transform.gameObject);
                }
                if (hit.transform.tag == "uranusInfo")
                {
                    Destroy(hit.transform.gameObject);
                }
                if (hit.transform.tag == "neptuneInfo")
                {
                    Destroy(hit.transform.gameObject);
                }
                if (hit.transform.tag == "moonInfo")
                {
                    Destroy(hit.transform.gameObject);
                }
                if (hit.transform.tag == "sunInfo")
                {
                    Destroy(hit.transform.gameObject);
                }
            }
        }
    }
}
