using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FleeingBird : Bird {
    protected Transform playerTransform;

    public override void Start(){
        base.Start();
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    public override void Behave(){
        Vector3 awayDir = (transform.position - playerTransform.position).normalized;
        transform.rotation = Quaternion.LookRotation(awayDir + Vector3.up * 0.3f, Vector3.up);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
