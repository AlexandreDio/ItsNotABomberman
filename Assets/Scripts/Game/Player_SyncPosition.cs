using UnityEngine;
using UnityEngine.Networking;

public class Player_SyncPosition : NetworkBehaviour
{
    //Cada vez que a variável bool netFacingRight é chamada, o método FacingCallback é chamado também.
    //Como o bool só muda quando o método CmdFlipSprite é chamado, ele garante que CmdFlipSprite realiza
    //a mudança no nosso servido e FacingCallback chama localmente.
    [SyncVar(hook = "FacingCallback")]
    public bool netFacingRight = true;

    [Command]
    public void CmdFlipSprite(bool facing)
    {
        netFacingRight = facing;
        if (netFacingRight)
        {
            Vector3 SpriteScale = transform.localScale;
            SpriteScale.x = 1;
            transform.localScale = SpriteScale;
        }
        else
        {
            Vector3 SpriteScale = transform.localScale;
            SpriteScale.x = -1;
            transform.localScale = SpriteScale;
        }
    }

    void FacingCallback(bool facing)
    {
        netFacingRight = facing;
        if (netFacingRight)
        {
            Vector3 SpriteScale = transform.localScale;
            SpriteScale.x = 1;
            transform.localScale = SpriteScale;
        }
        else
        {
            Vector3 SpriteScale = transform.localScale;
            SpriteScale.x = -1;
            transform.localScale = SpriteScale;
        }
    }
}
