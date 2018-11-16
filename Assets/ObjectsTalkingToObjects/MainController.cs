using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour {

    // Use this for initialization
    public Rotate rotatescript;
    public Spawner spawnscript;
    public SimpleMove movescript;
    public GameObject cylindertoturninvis_obj;
    public MeshRenderer cylindertoturninvis_rend;
    public Camera camtocontrol;
    public Light light;
    public TextMesh textObj; 
        void Start () {
        textObj.text = "hello World";
        textObj.fontSize = 50;
	}

    // Update is called once per frame

    float textTimer = 0;
    void Update() {
        CamBackgroundControl();
        RotationControl();
        SpawnerControl;
        MoveControl();
        CylinderControl();
        MusicControl();
        
        //rotate cube control
        if (Input.GetKeyDown(KeyCode.Alpha1) && rotatescript.rotateSpeed == 0f)
        {
            rotatescript.rotateSpeed = 180f;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha1) && rotatescript.rotateSpeed >= 1f)
        {
            rotatescript.rotateSpeed = 0f;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2)) {
            // Spawner.spawnscript();
        }

        //movecontrol
        if (Input.GetKeyDown(KeyCode.Alpha3) && movescript.moveSpeed == 0f)
        {
            movescript.moveSpeed = 4f;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3) && movescript.moveSpeed >= 1f)
        {
            movescript.moveSpeed = 0f;
        } }

    //void CylinderControl()
        //{
           // if(Input.GetKeyDown(KeyCode.Alpha4)&& cylin)
       // }
        bool backgroundFlag = true;
        void CamBackgroundControl()
        {
            camtocontrol.backgroundColor = Color.magenta;
            if (Input.GetKeyDown(KeyCode.Alpha6) && backgroundFlag == false)
            { camtocontrol.backgroundColor = Color.magenta;
                backgroundFlag = true;
            }
            else if (Input.GetKeyDown(KeyCode.Alpha6) && backgroundFlag == true)
            {
                Color randColor = new Color() ;
                randColor.r = Random.Range(0, 1f);
                randColor.g = Random.Range(0, 1f);
                randColor.b = Random.Range(0, 1f);

                camtocontrol.backgroundColor = randColor;
                backgroundFlag = false;
            }
        }
        
    }



