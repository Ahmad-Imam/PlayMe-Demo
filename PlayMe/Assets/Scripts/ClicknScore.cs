using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClicknScore : MonoBehaviour
{
    public int final;



    public Text scoreupdate;
    public static int score = 0;
    public static int fnlscr;
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {

        Ray rayOrigin = Camera.main.ScreenPointToRay(Input.mousePosition);
        //RaycastHit hitInfo;

        Vector3 pos = Input.mousePosition;
          Collider2D hitCollider = Physics2D.OverlapPoint(Camera.main.ScreenToWorldPoint(pos));
        

            //Countdown countdown = gameObject.GetComponent<Countdown>();
            //final = countdown.timer;
            scoreupdate.text = "Score is " + score;
        
            //if (countdown.timer < 0) Debug.Log("hahah");

            if (Countdown.timer > 0)
            {

            if (hitCollider != null && hitCollider.CompareTag("asd"))
            {
                score = score - 2;
                scoreupdate.text = "Score is " + score;
                // Debug.Log("This is player");
            }

            else if (hitCollider != null && hitCollider.CompareTag("dsa"))
            {

                score = score + 1;
                scoreupdate.text = "Score is " + score;
                //Debug.Log("This is player");
            }
            fnlscr = score;

        }
            else
            {

                Debug.Log(score);
            }
        }

    }

