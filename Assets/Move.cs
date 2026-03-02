using UnityEngine;

public class Move : MonoBehaviour {

    public GameObject goal;
    public float speed = 1f;

    private Vector3 direction;
    void Start()
    {
        direction = goal.transform.position - transform.position;
    }
    private void Update()
    {
        direction = goal.transform.position - transform.position;
        transform.LookAt(goal.transform.position);
        if (direction.magnitude > 0.1f)
        {
            Vector3 velocity = direction.normalized * speed * Time.deltaTime;
            transform.position = transform.position + velocity;
        }
    }
}
