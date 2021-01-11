using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parallaxscript : MonoBehaviour
{
    public Transform[] backgrounds; //array of parrlaxable objects
    [SerializeField]  private float[] parallaxScales; //proportion of the camera movement
    public float smoothing = 1f; // how smooth the paralax is going to be
    private Transform cam; // reference to the main cameras transform
    private Vector3 previouseCamPos;
    

    private void Awake()
    {
        cam = Camera.main.transform;
    }

    // Start is called before the first frame update
    void Start()
    {
        previouseCamPos = cam.position;

        parallaxScales = new float[backgrounds.Length];

        for (int i = 0; i < backgrounds.Length; i++)
        {
            parallaxScales[i] = backgrounds[i].position.z * -1;

        }
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < backgrounds.Length; i++)
        {
            float parallax = (previouseCamPos.x - cam.position.x) * parallaxScales[i];

            float backgroundTargetPosX = backgrounds[i].position.x + parallax;

            Vector3 backgroundTargetPos = new Vector3(backgroundTargetPosX, backgrounds[i].position.y, backgrounds[i].position.z);

            backgrounds[i].position = Vector3.Lerp(backgrounds[i].position, backgroundTargetPos, smoothing * Time.deltaTime);
        }

        previouseCamPos = cam.position;
    }
}
