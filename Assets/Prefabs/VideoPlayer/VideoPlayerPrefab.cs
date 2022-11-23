using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoPlayerPrefab : MonoBehaviour
{
    private VideoPlayer videoPlayer;

    private string videoURL;

    private void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();
    }

    public void PlayVideo()
    {
        if (videoURL != null)
        {
            videoPlayer.source = VideoSource.Url;
            videoPlayer.url = videoURL;
            videoPlayer.Play();
        }
        else
        {
            Debug.Log("Video URL is null.");
        }

    }

    public void SetVideoURL(string url)
    {
        videoURL = url;
    }
}
