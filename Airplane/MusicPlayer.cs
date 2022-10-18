using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int numOfMusicPlayers = FindObjectsOfType<MusicPlayer>().Length;
        if (numOfMusicPlayers > 1)
        {
            //���Ұ� ������ 
            Destroy(gameObject);
        }
        else
        {
            //ó��
            DontDestroyOnLoad(gameObject);
        }

        
    }

}
