using UnityEngine;
using System.Collections;

public class greenTrigger_21 : MonoBehaviour {
    private float rotateSpeed = 40;
    private int i;
    private Animation Run;

    public GameObject rotate;
    void Start()
    {
        Run = GetComponent<Animation>();
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if( i == 1){
         rotate.transform.Rotate(Vector3.up * Time.deltaTime * rotateSpeed);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            i = 1;
            startsound.Instance.playTri();
            Run.Play("greenTri0");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Run.Play("greenTri1");
        }
    }
}
