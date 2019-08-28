using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking; 

public class Player_Flip : NetworkBehaviour
{
    [SyncVar(hook = "FacingCallBack")]
    public bool netFacingRight = true;

    [Command]
    public void CmdFlipSprite(bool facing)
    {
        netFacingRight = facing;
        if (netFacingRight)
        {
            Vector3 SpriteScale = transform.localScale;
            SpriteScale.x = 3.5f;
            transform.localScale = SpriteScale;
        }
        else
        {
            Vector3 SpriteScale = transform.localScale;
            SpriteScale.x = -3.5f;
            transform.localScale = SpriteScale;
        }
    }

    void FacingCallBack(bool facing)
    {
        netFacingRight = facing;
        if (netFacingRight)
        {
            Vector3 SpriteScale = transform.localScale;
            SpriteScale.x = 3.5f;
            transform.localScale = SpriteScale;
        }
        else
        {
            Vector3 SpriteScale = transform.localScale;
            SpriteScale.x = -3.5f;
            transform.localScale = SpriteScale;
        }
    }
}
