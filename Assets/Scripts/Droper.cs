using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Droper : MonoBehaviour
{
  MeshRenderer meshRenderer;
  Rigidbody rigidBody;
  [SerializeField] float waitTime = 5.0f;
  void Start()
  {
    meshRenderer = GetComponent<MeshRenderer>();
    meshRenderer.enabled = false;

    rigidBody = GetComponent<Rigidbody>();
    rigidBody.useGravity = false;
  }
  // Update is called once per frame
  void Update()
  {
    if (Time.time > waitTime)
    {
      meshRenderer.enabled = true;
      rigidBody.useGravity = true;
    }
  }
}
