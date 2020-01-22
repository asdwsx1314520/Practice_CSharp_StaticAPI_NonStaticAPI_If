using UnityEngine;

public class Zombie : Biological
{

    void Update()
    {
        if (_hp == 0)
        {
            anim.SetBool("Death", true);
            enabled = false;
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            float rand = Random.Range(0, 2);

            if (rand == 1)
            {
                anim.SetTrigger("Attack");
            }
        }
    }

    void Attack()
    {
        Toony toony = GameObject.Find("Toony").GetComponent<Toony>();

        float valur = getAttack();

        toony.damage(valur, "Toony");
    }
}
