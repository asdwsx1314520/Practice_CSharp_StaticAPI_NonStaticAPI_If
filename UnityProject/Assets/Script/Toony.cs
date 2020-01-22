using UnityEngine;

public class Toony : Biological
{

    void Update()
    {
        if(_hp == 0)
        {
            anim.SetBool("Death", true);
            enabled = false;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            float rand = Random.Range(0, 2);

            if (rand == 1)
            {
                anim.SetTrigger("Attack");
            }
        }

        transform.rotation = new Quaternion(0, 0, 0, 0);
    }

    void Attack() 
    {
        Zombie zombie = GameObject.Find("Zombie").GetComponent<Zombie>();

        float valur = getAttack();

        zombie.damage(valur, "Zombie");
    }

}
