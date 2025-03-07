// ===================================================
// Author: Adrián "Kadrius" Blanco
// Email: ablanco@invelon.com
// Date: #DATE#
// Project: #PROJECTNAME#
// ===================================================

using Fusion;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeCanvasColor : NetworkBehaviour
{
    public Image panel;

    [Rpc(RpcSources.All, RpcTargets.All)]
    public void RPC_ChangeCanvasColor(Color newColor)
    {
        panel.color = newColor;
    }

    public void ChangeColor()
    {
        Color newColor = new Color(Random.value, Random.value, Random.value);
        RPC_ChangeCanvasColor(newColor);
    }

}
