using UnityEngine;

public class Player : MonoBehaviour
{
    public float velocidade = 5f;

    void Start() {}
     
    void Update()
    {
        float movimentoHorizontal = 0f;
        if (Input.GetKey(KeyCode.RightArrow)) { movimentoHorizontal = 1f; }
        else if (Input.GetKey(KeyCode.LeftArrow)) { movimentoHorizontal = -1f; }
        else { movimentoHorizontal = 0f; }
        transform.position += new Vector3(movimentoHorizontal, 0f, 0f) * velocidade * Time.deltaTime;
    
        float movimentoVertical = 0f;
        if (Input.GetKey(KeyCode.UpArrow)) { movimentoVertical = 1f; }
        else if (Input.GetKey(KeyCode.DownArrow)) { movimentoVertical = -1f; }
        else { movimentoVertical = 0f; }
        transform.position += new Vector3(0f, movimentoVertical, 0f) * velocidade * Time.deltaTime;
    }
}
