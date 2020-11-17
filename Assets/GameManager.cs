using UnityEngine;

public class GameManager: MonoBehaviour
{
    [Header("龍龍")]
    public Transform dragon;
    [Header("少女")]
    public Transform girl;
    [Header("龍龍動畫元件")]
    public Animator anidragon;
    [Header("少女動畫元件")]
    public Animator anigirl;
    public void Dead()
    {
        print("麥擱怕阿QWQ");
        
            anigirl.SetBool("IsDead", true);
        anidragon.SetBool("死亡開關", true);
            
    }
    public void UnDead()
    {
        print("英雄給我起來");
        anigirl.SetBool("IsDead", false);
        anidragon.SetBool("死亡開關", false);
    }
        public void PlayAnimation(string anistepname)
    {
        
        anidragon.SetTrigger(anistepname);
        anigirl.SetTrigger(anistepname);
        
    }
   
        
    } 
