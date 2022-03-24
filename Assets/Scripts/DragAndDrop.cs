using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragAndDrop : MonoBehaviour
    //,IDragHandler,IEndDragHandler, IBeginDragHandler
{
    public float snapOffset = 10;
    public Vector2 AnswerPos;
    public int piece_no;
    public GameObject puzzle;

    private float startPosX;
    private float startPosY;
    private bool isHeld = false;

    AudioSource audioSource;
    public AudioClip wrongBGM;
    public AudioClip correctBGM;
    public AudioClip selectBGM;
    DragAndDrop drag;
    MixPuzzle mix;
    public bool isright;
    
    
    // Start is called before the first frame update
    void Awake()
    {
        AnswerPos = new Vector2(transform.position.x, transform.position.y-1);
        drag = this.GetComponent<DragAndDrop>();
        audioSource = GetComponent<AudioSource>();
    }
    void OnEnable()
    {
        mix = GameObject.FindGameObjectWithTag("Puzzle").GetComponent<MixPuzzle>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isHeld == true)
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            this.gameObject.transform.localPosition = new Vector3(mousePos.x,mousePos.y-1,0);
        }

    }

    private void OnMouseDown()
    {
        if (isright == false)
        {
            if (Input.GetMouseButtonDown(0))
            {
                audioSource.clip = selectBGM;
                audioSource.Play();
                Vector3 mousePos;
                mousePos = Input.mousePosition;
                mousePos = Camera.main.ScreenToWorldPoint(mousePos);
                isHeld = true;
            }
        }
        else
        {
            drag.enabled = false;
        }
       
        
    }
    private void OnMouseUp()
    {
        isHeld = false;
        //Debug.Log(Vector2.Distance(AnswerPos, transform.position));
        if(isright==false)
        {
            if (Vector2.Distance(AnswerPos, transform.position) < snapOffset)
            {
                audioSource.clip = correctBGM;
                audioSource.Play();
                this.gameObject.transform.localPosition = AnswerPos;
                mix.correctCnt++;
                drag.enabled = false;
                isHeld = true;
                isright = true;
                drag.enabled = false;


                //transform.SetParent(puzzle.transform);
                //transform.localPosition = Vector3.zero;
            }
            else
            {
                audioSource.clip = wrongBGM;
                audioSource.Play();

            }
        }
        
        
    }


}
