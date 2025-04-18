using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class NewTestScript
{


    [Test]
    public void TESTGETCOIN()
    {
        var gg = new GetCoin();

        gg.AddCoin(2);
        Assert.AreEqual(2, gg.coin);
    }
    
    public IEnumerator NewTestScriptPlayerMove()
    {
        var go = new GameObject();
        float startX = go.transform.position.x;


        go.transform.Translate(-Vector3.right * 5f * Time.deltaTime);
        
        yield return new WaitForSeconds(1f);
     Assert.Greater(go.transform.position.x, startX);
    
    }
}
