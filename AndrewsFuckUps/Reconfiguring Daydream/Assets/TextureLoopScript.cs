using UnityEngine;
using System.Collections;

public class TextureLoopScript : MonoBehaviour {

	public float duration = 0.1f;
	public Texture[] textures;

	// Use this for initialization
	void Start () {
		StartCoroutine(DoTextureLoop());
	}

	public IEnumerator DoTextureLoop(){
		int i = 0;
		print ("here");
		while (true){
			gameObject.GetComponent<Renderer>().material.mainTexture = textures[i];
			i = (i+1)%textures.Length;
			yield return new WaitForSeconds(duration);
		}
	}
}