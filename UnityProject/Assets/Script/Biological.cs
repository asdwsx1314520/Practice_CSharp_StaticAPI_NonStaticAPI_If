using UnityEngine;

public class Biological : MonoBehaviour
{ 
    public Animator anim;
    private float attack;

    public AudioSource audio;
    public AudioClip audio_attack;

    private float hp = 100;
    public float _hp
    {
        get{ return hp;}
        set{
            if (value < 0)
                hp = 0;
            else
                hp = value;
        }
    }

    /// <summary>
    /// 得到攻擊力
    /// </summary>
    /// <returns></returns>
    public float getAttack()
    {
        attack = Random.Range(10, 21);

        audio.PlayOneShot(audio_attack);

        return attack;
    }

    /// <summary>
    /// 受傷
    /// </summary>
    /// <param name="hurt">受到的傷害</param>
    /// <param name="name">誰受傷害</param>
    public void damage(float hurt, string name)
    {
        _hp -= hurt;

        print(name + "剩下" + _hp + "低血");
    }

}
