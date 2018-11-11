using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class rotatePlane : MonoBehaviour {

    public Vector3 plane_angle_y, cube_scale;
    
    public Transform father_obj;
    public Transform location;

    public  Transform cube1;
    //public Vector3 original_angle;
    // Use this for initialization
    void Start()
    {
       
        Transform transform = this.transform;
        print(GetChild(father_obj, 1).name);//0:Cube2,1:Cube1
        cube1 = GetChild(father_obj, 1).transform;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            this.transform.Rotate(plane_angle_y);

        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {

            xyj_rotatePlane(1);

        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {

            xyj_rotatePlane(0);

        }
    }
    void xyj_rotatePlane(int mode)
    {
        print("hello xyj");
        
        float y = this.transform.rotation.y;
        Debug.Log("plane position y is" + y);
        if(mode == 1)
        {
            this.transform.DORotate(this.transform.localEulerAngles + plane_angle_y, 2);
            //TODO:获得当前plane上的xyjGameObject的scale
            //if (Mathf.Abs(this.transform.position.y))
            Debug.Log("Before if y is" + y);
            if (System.Math.Abs(y) < 0.5)
            {
                Debug.Log(this.transform.position.y);
                print(cube1.localScale.y);
                Debug.Log("cube1.localScale:" + cube1.localScale + "cube_scale" + cube_scale);
                cube1.DOScale(cube1.localScale + cube_scale, 2);
            }
            //this.transform.DOScale(this.transform.localScale + cube_scale, 2);
            //Debug.Log(this.transform.localEulerAngles);
        }
        else if(mode == 0)
        {
            this.transform.DORotate(this.transform.localEulerAngles - plane_angle_y, 2);
            Debug.Log( "the condition is " + (System.Math.Abs(y) < 0.5));
            if (System.Math.Abs(y-0.7f) < 0.1)
            {
                Debug.Log(this.transform.position.y);
                print(cube1.localScale.y);
                Debug.Log("cube1.localScale:" + cube1.localScale + "cube_scale" + cube_scale);
                Vector3 tmp = cube1.localScale - cube_scale;
                Debug.Log("tmp is " + tmp);
                cube1.transform.localScale = tmp;
                //cube1.DOScale(tmp, 2);
                
            }
            //Debug.Log(this.transform.localEulerAngles);
        }
        
    }
    private Transform GetChild(Transform tr, int index)
    {
        # asdfwrt
        return tr.GetChild(index);
        # adsfasdf
        # asdrt
    }
}
