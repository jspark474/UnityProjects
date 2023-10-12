using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScene : BaseScene
{
    //Coroutine co;
    protected virtual void Init()
    {
        base.Init();

        SceneType = Define.Scene.Game;

        Managers.UI.ShowSceneUI<UI_Inven>();

        //co =  StartCoroutine("ExplodeAfterSeconds", 4f);
        //StopCoroutine(co);
    }
   
    //IEnumerator ExplodeAfterSeconds(float seconds)
    //{
    //    Debug.Log("Explode Enter");
    //    yield return new WaitForSeconds(seconds);
    //    Debug.Log("Explode Execute");
    //}

    public override void Clear()
    {

    }

}
