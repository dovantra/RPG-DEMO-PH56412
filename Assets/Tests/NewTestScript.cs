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


    [UnityTest]
    public IEnumerator StartGame_HidesCanvas()
    {
        // Tạo canvas giả
        var canvasGO = new GameObject("Canvas");
        canvasGO.SetActive(true);

        // Tạo UI Manager
        var uiManagerGO = new GameObject("UIMANAGER");
        var uiManager = uiManagerGO.AddComponent<UIMANAGER>();
        uiManager.canvasStartGame = canvasGO;

        // Gọi StartGame
        uiManager.StartGame();

        yield return null;

        Assert.IsFalse(canvasGO.activeSelf, "Canvas should be hidden after StartGame is called.");
    }

    [UnityTest]
    public IEnumerator PauseGame_TogglesTimeScale()
    {
        // Tạo UI Manager
        var uiManagerGO = new GameObject("UIMANAGER");
        var uiManager = uiManagerGO.AddComponent<UIMANAGER>();

        // Đặt thời gian ban đầu là 1
        Time.timeScale = 1f;

        // Gọi PauseGame → tạm dừng
        uiManager.PauseGame();
        yield return null;
        Assert.AreEqual(0f, Time.timeScale, "Time should be paused (0) after first PauseGame call.");

        // Gọi lần 2 → chạy lại
        uiManager.PauseGame();
        yield return null;
        Assert.AreEqual(1f, Time.timeScale, "Time should be resumed (1) after second PauseGame call.");
    }
}
