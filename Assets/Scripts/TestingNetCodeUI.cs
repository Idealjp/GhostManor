using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Unity.Netcode;
using UnityEngine.SceneManagement;

public class TestingNetCodeUI : MonoBehaviour
{
    //[SerializeField] private Button HostButton;
    //[SerializeField] private Button JoinButton;

    //private void Awake()
    //{
    //    
    //    HostButton.onClick.AddListener(() =>
    //    {
    //        NetworkManager.Singleton.StartHost();
    //        ToGame();
    //    });
        

    //    JoinButton.onClick.AddListener(() =>
    //    {
    //       NetworkManager.Singleton.StartClient();
    //      ToGame();
    //    });
    //}
    public void HostGame()
    {
        NetworkManager.Singleton.StartHost();
        //ToGame();
        //Hide();
    }

    public void JoinGame()
    {
        NetworkManager.Singleton.StartClient();
        //ToGame();
        //Hide();
    }

    private void Hide()
    {
        gameObject.SetActive(false);
    }

    //private void ToGame()
    //{
    //    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    //}
}
