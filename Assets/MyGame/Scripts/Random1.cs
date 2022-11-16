
using UnityEngine;

public class Random1 : MonoBehaviour
{

    [SerializeField] float[] uZahl1 = new float[10];
    [SerializeField] float[] systemZahl1 = new float[10];

    [SerializeField] Color[] color = new Color[10];
    [SerializeField] Quaternion[] rotation = new Quaternion[10];
    void Start()
    {
        Random.seed = 42;
        
        
        for (int i = 0; i < uZahl1.Length; i++)
        {
            uZahl1[i] = UnityEngine.Random.Range(1f, 20f);
        }


        for (int i = 0; i < systemZahl1.Length; i++)
        {
            systemZahl1[i] = Random.value;
        }

        

        for (int i = 0; i < color.Length; i++)
        {
            color[i] = Random.ColorHSV();
        }


        for (int i = 0; i < rotation.Length; i++)
        {
            rotation[i] = Random.rotation;
        }


    }
}
