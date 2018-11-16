using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {
    public Spawner spawnscript;
    public float rotateSpeed;
    public Rotate rotatescript;

    void Update() {
        //rotate
        if (Input.GetKeyDown(KeyCode.Alpha1) && rotatescript.rotateSpeed == 0f)
        { rotatescript.rotateSpeed = 180f; }

        else if (Input.GetKeyDown(KeyCode.Alpha0) && rotatescript.rotateSpeed >= 1f)
        { rotatescript.rotateSpeed = 0f; }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        //{ spawnscript.SpawnObject(); }
		this.transform.Rotate(Vector3.forward, rotateSpeed * Time.deltaTime);
	}
}
