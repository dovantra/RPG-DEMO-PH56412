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


    [UnityTest] 
    public IEnumerator NewTestScriptPlayerJump()
    {
        GameObject player = new GameObject();
        Rigidbody rb = player.AddComponent<Rigidbody>();
        rb.useGravity = true;

        float jumpForce = 4f;

        // Lưu lại vị trí Y ban đầu
        float startY = player.transform.position.y;

        // Áp lực nhảy
        rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);

        // Đợi vài frame để vật lý xử lý (khoảng 0.5s)
        yield return new WaitForSeconds(0.5f);

        // Kiểm tra vị trí mới cao hơn vị trí ban đầu → nghĩa là đã nhảy
        Assert.Greater(player.transform.position.y, startY);

    }
}
