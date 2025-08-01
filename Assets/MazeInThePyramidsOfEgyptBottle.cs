using UnityEngine;

public class MazeInThePyramidsOfEgyptBottle : MonoBehaviour
{
    public GameObject UIInfoObj;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            MazeInThePyramidsOfEgyptManager.Instance.collectedBottles++;
            MazeInThePyramidsOfEgyptManager.Instance.UpdateUI();
            Destroy(gameObject);
        }
    }
}
