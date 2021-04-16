using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{

    public static MoveScript instance;

    #region
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        } else if (instance != this)
        {
            Destroy(gameObject);
        }
    }
    #endregion


    public float senzitivity = 0f;
    private float _xRotation = 0f;
    public Transform camera;
    public LayerMask layer;
    public int life;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Mouse X") * Time.deltaTime * senzitivity;
        float y = Input.GetAxis("Mouse Y") * Time.deltaTime * senzitivity;

        _xRotation -= y;
        _xRotation = Mathf.Clamp(_xRotation, -90, 70);
        transform.Rotate(Vector3.up * x);

        camera.localRotation = Quaternion.Euler(_xRotation, 0, 0);


        if(Input.GetMouseButtonDown(0))
        {
            
            Ray positiionsOfCam = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit ray;
            
            if (Physics.Raycast(positiionsOfCam, out ray))
            {
                
                if (ray.collider.gameObject.tag == "Plane")
                    transform.position = new Vector3(ray.point.x, ray.point.y+1.5f, ray.point.z);
            }
        }

    }

    public void TakeDamage()
    {
        life -= 1;
        Debug.Log("Mai ai " + life + " vieti ramase");
        if (life < 0)
        {
            GameManager.instance.Reset();
        }
    }


}
