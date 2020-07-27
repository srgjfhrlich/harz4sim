using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MimonDoorScript : MonoBehaviour
{
    // Start is called before the first frame update
    Animator doorAnim;
    
    

    void Start()
    {
        doorAnim = this.transform.parent.GetComponent<Animator>();
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyUp(KeyCode.E))
        {
            doorAnim.SetBool("PressedE", true);
            StartCoroutine(TimerRoutine());
            

                
            
        }
    }

     IEnumerator TimerRoutine()
      {
        
          yield return new WaitForSeconds(0.75f);
        SceneManager.LoadScene("MimonsHaus");
    }
   

    private void OnTriggerExit(Collider other)
    {
        doorAnim.SetBool("PressedE", false);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
