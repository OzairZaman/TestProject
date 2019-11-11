using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Player : MonoBehaviour
{
    public float movementSpeed = 10f;

    private Rigidbody rigid;
    private Collider col;

    #region Internal
    void Reset()
    {
        col = GetComponent<Collider>();
        rigid = GetComponent<Rigidbody>();
        rigid.useGravity = true;

        col.material = Resources.Load<PhysicMaterial>("Physics/Slide");
    }

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float inputH = Input.GetAxis("Horizontal");
        float inputV = Input.GetAxis("Vertical");
        Move(new Vector3(inputH, 0f, inputV), movementSpeed);
    }
    #endregion

    #region External
    public void Move(Vector3 direction, float force)
    {
        //rigid.AddForce(direction * force);
    }
    #endregion
}
