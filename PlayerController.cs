using Assets.Scripts.Ability;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    #region Fields
    private new Rigidbody rigidbody;
    private List<Ability> abilities;
    #endregion

    #region Public properties
    public float moveSpeed = 10f;

    #endregion
    
    // Use this for initialization
    void Start()
    {
        this.rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");
        this.rigidbody.position += new Vector3(horizontalMovement * moveSpeed * Time.deltaTime, 0.0f, verticalMovement * moveSpeed * Time.deltaTime);
    }
}
