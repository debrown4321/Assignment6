using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RoomLoader : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1f;

    void OnTriggerEnter(Collider other)
    {
        StartCoroutine(LoadRoom(SceneManager.GetActiveScene().buildIndex + 1));

    }

    IEnumerator LoadRoom(int roomIndex)
    {
        transition.SetTrigger("Start");
        
        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(roomIndex);
    }
}
