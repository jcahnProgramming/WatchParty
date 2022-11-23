using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Save : MonoBehaviour
{
    [SerializeField] private string plex_token;
    [SerializeField] private string plex_url;
    [SerializeField] private string discord_token;
    [SerializeField] private float localVolume;
    [SerializeField] private Color localSavedColor;
    [SerializeField] private int is2DMode;

    public void GetSavedData()
    {
        if (PlayerPrefs.HasKey("PlayerSave"))
        {
            plex_token =  PlayerPrefs.GetString("plexToken");
            plex_url = PlayerPrefs.GetString("plexUrl");
            discord_token = PlayerPrefs.GetString("discordToken");
            localVolume = PlayerPrefs.GetFloat("localVolume");
            is2DMode = PlayerPrefs.GetInt("is2DMode");
            localSavedColor = new Color(Random.Range(1f, 255f),Random.Range(1f, 255f), Random.Range(1f, 255f), Random.Range(100f,255f));
        }
        else
        {
            plex_token = string.Empty;
            plex_url = string.Empty;
            discord_token = string.Empty;
            localVolume = 100f;
            localSavedColor = new Color(Random.Range(1f, 255f), Random.Range(1f, 255f), Random.Range(100f, 255f));
            //int is2DMode Guide
            // 1 = 2D Mode
            // 2 = 3D Mode
            is2DMode = 2;
        }
    }

    public void SaveData()
    {
        PlayerPrefs.SetString("plexToken", plex_token);
        PlayerPrefs.SetString("plexUrl", plex_url);
        PlayerPrefs.SetString("discordToken", discord_token);
        PlayerPrefs.SetFloat("localVolume", localVolume);
        PlayerPrefs.SetInt("is2DMode", is2DMode);
    }
}
