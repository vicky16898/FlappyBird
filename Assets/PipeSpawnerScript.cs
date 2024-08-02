using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject pipeSystem;
    public float spwanRate = 3;
    public float timer = 0;
    public float heightOffset = 10;
    void Start()
    {
        SpwanPipeSystem();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spwanRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            SpwanPipeSystem();
            timer = 0;
        }
    } 
    
    private void SpwanPipeSystem()
    {
        float highPoint = transform.position.y + heightOffset;
        float lowPoint = transform.position.y - heightOffset;
        Debug.Log(transform.position.x);
        Instantiate(pipeSystem, new Vector3(transform.position.x, Random.Range(lowPoint, highPoint), 0), transform.rotation);
    }
}
