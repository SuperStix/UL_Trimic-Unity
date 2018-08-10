using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeManager : MonoBehaviour {

    public GameObject woman, vaginitis;
    public List<GameObject> Scenes;

    Vector2 firstPressPos;
    Vector2 secondPressPos;
    Vector2 currentSwipe;
    
    public bool canSwipe = false;

    //variables for Swipe
    public float minSwipeDistY = 0.5f;
    public float minSwipeDistX = -0.01f;
    public int swipe = 200; // swipe value
    private Vector2 startPos;

    void Update ()
    {
        if (Input.GetKey(KeyCode.Escape))
            Application.Quit();

        Swipe_v2();
	}

    //Swipe method
    void Swipe_v2()
    {

        //touch
        if (Input.touchCount > 0)

        {

            Touch touch = Input.touches[0];

            switch (touch.phase)

            {

                case TouchPhase.Began:

                    startPos = touch.position;

                    break;

                case TouchPhase.Ended:

                    //float swipeDistVertical = (new Vector3(0, touch.position.y, 0) - new Vector3(0, startPos.y, 0)).magnitude;
					//
                    //if (swipeDistVertical > minSwipeDistY)
					//
                    //{
					//
                    //    float swipeValue = Mathf.Sign(touch.position.y - startPos.y);
					//
                    //    if (swipeValue > 0) //up swipe
                    //    {
                    //        
                    //    }
					//
                    //    else if (swipeValue < 0)//down swipe
                    //    {
                    //        
                    //    }
					//
                    //}

                    float swipeDistHorizontal = (new Vector3(touch.position.x, 0, 0) - new Vector3(startPos.x, 0, 0)).magnitude;

                    if (swipeDistHorizontal > minSwipeDistX)

                    {

                        float swipeValue = touch.position.x - startPos.x;

                        if (swipeValue > swipe)//right swipe
                        {
                            Debug.Log(swipeValue);
                            Debug.Log("Right Swipe");
                            SwipeRight();
                        }
                            //MoveRight ();

                        else if (swipeValue < -swipe)//left swipe
                        {
                            Debug.Log(swipeValue);
                            Debug.Log("Left Swipe");
                            SwipeLeft();
                        }
                            //MoveLeft ();

                    }
                    break;
            }
        }
    }


    //Go to Next Page if the user swipe left
    void SwipeLeft()
    {
        SceneLeft();
    }
    //Go to Previous Page if the user swipe right
    void SwipeRight()
    {
        SceneRight();
    }

    //Scene method if swipe left
    void SceneLeft()
    {
        //Scene1
        if (Scenes[0].activeInHierarchy)
        {
            foreach (var page in Scenes)
                page.SetActive(false);

            Scenes[1].SetActive(true);
            woman.SetActive(true);
            vaginitis.SetActive(true);
        }
        //Scene2
        else if (Scenes[1].activeInHierarchy)
        {
            foreach (var page in Scenes)
                page.SetActive(false);

            Scenes[2].SetActive(true);
        }
        //Scene3
        else if (Scenes[2].activeInHierarchy)
        {
            foreach (var page in Scenes)
                page.SetActive(false);

            Scenes[3].SetActive(true);
        }
        //Scene4
        else if (Scenes[3].activeInHierarchy)
        {
            foreach (var page in Scenes)
                page.SetActive(false);

            Scenes[4].SetActive(true);
        }
        //Scene5
        else if (Scenes[4].activeInHierarchy)
        {
            foreach (var page in Scenes)
                page.SetActive(false);

            Scenes[5].SetActive(true);
        }
        //Scene6
        else if (Scenes[5].activeInHierarchy)
        {
            foreach (var page in Scenes)
                page.SetActive(false);

            Scenes[6].SetActive(true);
        }
        //Scene7
        else if (Scenes[6].activeInHierarchy)
        {
            foreach (var page in Scenes)
                page.SetActive(false);

            Scenes[7].SetActive(true);
        }
        //Scene8
        else if (Scenes[7].activeInHierarchy)
        {
            foreach (var page in Scenes)
                page.SetActive(false);

            Scenes[8].SetActive(true);
        }
        //Scene9
        else if (Scenes[8].activeInHierarchy)
        {
            foreach (var page in Scenes)
                page.SetActive(false);

            Scenes[9].SetActive(true);
        }
        //Scene10
        else if (Scenes[9].activeInHierarchy)
        {
            foreach (var page in Scenes)
                page.SetActive(false);

            Scenes[10].SetActive(true);
        }
        //Scene11
        else if (Scenes[10].activeInHierarchy)
        {
            foreach (var page in Scenes)
                page.SetActive(false);

            Scenes[11].SetActive(true);
        }
        //Scene12
        else if (Scenes[11].activeInHierarchy)
        {
            foreach (var page in Scenes)
                page.SetActive(false);

            Scenes[12].SetActive(true);
        }
        //Scene13
        else if (Scenes[12].activeInHierarchy)
        {
            foreach (var page in Scenes)
                page.SetActive(false);

            Scenes[13].SetActive(true);
        }
        //Scene14
        else if (Scenes[13].activeInHierarchy)
        {
            foreach (var page in Scenes)
                page.SetActive(false);

            Scenes[14].SetActive(true);
        }
        //Scene15
        else if (Scenes[14].activeInHierarchy)
        {
            foreach (var page in Scenes)
                page.SetActive(false);
            
            Scenes[0].SetActive(true);
        }
    }
    //Scene method if swipe right
    void SceneRight()
    {
        //Scene1
        if (Scenes[0].activeInHierarchy)
        {
            //foreach (var page in Scenes)
            //    page.SetActive(false);
            //
            //Scenes[1].SetActive(true);
        }
        //Scene2
        else if (Scenes[1].activeInHierarchy)
        {
            foreach (var page in Scenes)
                page.SetActive(false);

            Scenes[0].SetActive(true);
        }
        //Scene3
        else if (Scenes[2].activeInHierarchy)
        {
            foreach (var page in Scenes)
                page.SetActive(false);

            Scenes[1].SetActive(true);
            woman.SetActive(false);
            vaginitis.SetActive(false);
        }
        //Scene4
        else if (Scenes[3].activeInHierarchy)
        {
            foreach (var page in Scenes)
                page.SetActive(false);

            Scenes[2].SetActive(true);
        }
        //Scene5
        else if (Scenes[4].activeInHierarchy)
        {
            foreach (var page in Scenes)
                page.SetActive(false);

            Scenes[3].SetActive(true);
        }
        //Scene6
        else if (Scenes[5].activeInHierarchy)
        {
            foreach (var page in Scenes)
                page.SetActive(false);

            Scenes[4].SetActive(true);
        }
        //Scene7
        else if (Scenes[6].activeInHierarchy)
        {
            foreach (var page in Scenes)
                page.SetActive(false);

            Scenes[5].SetActive(true);
        }
        //Scene8
        else if (Scenes[7].activeInHierarchy)
        {
            foreach (var page in Scenes)
                page.SetActive(false);

            Scenes[6].SetActive(true);
        }
        //Scene9
        else if (Scenes[8].activeInHierarchy)
        {
            foreach (var page in Scenes)
                page.SetActive(false);

            Scenes[7].SetActive(true);
        }
        //Scene10
        else if (Scenes[9].activeInHierarchy)
        {
            foreach (var page in Scenes)
                page.SetActive(false);

            Scenes[8].SetActive(true);
        }
        //Scene11
        else if (Scenes[10].activeInHierarchy)
        {
            foreach (var page in Scenes)
                page.SetActive(false);

            Scenes[9].SetActive(true);
        }
        //Scene12
        else if (Scenes[11].activeInHierarchy)
        {
            foreach (var page in Scenes)
                page.SetActive(false);

            Scenes[10].SetActive(true);
        }
        //Scene13
        else if (Scenes[12].activeInHierarchy)
        {
            foreach (var page in Scenes)
                page.SetActive(false);

            Scenes[11].SetActive(true);
        }
        //Scene14
        else if (Scenes[13].activeInHierarchy)
        {
            foreach (var page in Scenes)
                page.SetActive(false);

            Scenes[12].SetActive(true);
        }
        //Scene15
        else if (Scenes[14].activeInHierarchy)
        {
            foreach (var page in Scenes)
                page.SetActive(false);
            
            Scenes[13].SetActive(true);
        }
    }
    
}


