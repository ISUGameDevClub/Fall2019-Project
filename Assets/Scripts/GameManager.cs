using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int roundNum;
    private bool hasLost;

    private List<Enemy> enemyManager;
    private List<Livestock> livestockManager;
    private List<Bullet> bulletManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public List<Enemy> getEnemyManager()
    {
        return enemyManager;
    }
    public void setEnemyManager(List<Enemy> newEnemyManager)
    {
        this.enemyManager = newEnemyManager;
    }

    public List<Livestock> getLivestockManager()
    {
        return livestockManager;
    }
    public void setLivestockManager(List<Livestock> newLivestockManager)
    {
        this.livestockManager = newLivestockManager;
    }

    public List<Bullet> getBulletManager()
    {
        return bulletManager;
    }
    public void setBulletManager(List<Bullet> newBulletManager)
    {
        this.bulletManager = newBulletManager;
    }

    public void checkIfLost()
    {

    }

    public void checkIfWonRound()
    {

    }

    public void wonRound()
    {

    }

    public void lostGame()
    {

    }

    public void incrementRound()
    {

    }

    public void restartGame()
    {

    }
}
