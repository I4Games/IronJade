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
        transform.Translate(awayDir * speed * Time.deltaTime);
    }
}
