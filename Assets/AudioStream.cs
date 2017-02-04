using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioStream : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine(DownloadAndPlay("http://stream.radioreklama.bg/radio1_low.ogg"));
	}

	// Update is called once per frame
	void Update () {

	}


	IEnumerator DownloadAndPlay(string url)
	{
	    WWW www = new WWW(url);
	    yield return www;

	    AudioSource audio = GetComponent<AudioSource>();
	    audio.clip = www.GetAudioClip(false, true);
	    audio.Play();
	}

}
