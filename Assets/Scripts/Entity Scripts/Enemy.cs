using UnityEngine;

public class Enemy : Entity
{

    private Transform targetFolderTransform;
    [SerializeField] private int pointsWorth = 1; //The number of points the player gets for killing this enemy.

    // Start is called before the first frame update
    void Start()
    {
        targetFolderTransform = GameObject.FindGameObjectWithTag("Enemies Folder").transform;
        transform.SetParent(targetFolderTransform, false);
    }

    // Update is called once per frame
    public override void Update()
    {
        GetHealthManager().CheckIfDead();
    }

    //New shows that I am overiding this method from superclass Entity. Maybe OVERRIDE?
    public override void Attack()
    {
        //Go crazy!
        //Get those cattle!
    }

    public override void Die()
    {
        //Destroy/deactivate enemy when dead.
        this.gameObject.SetActive(false);
        //Give player points from this enemy.
        GameManager.AddPoints(pointsWorth);

    }
}
