using UnityEngine;
using System.Collections;

public class Powerup : MonoBehaviour {

	AudioSource sound;

	// Use this for initialization
	void Start () {
		sound = gameObject.GetComponent<AudioSource>();
	}
	
	void OnTriggerEnter(Collider col) {
//		foreach (ContactPoint contact in collision.contacts) {
//			Debug.DrawRay(contact.point, contact.normal, Color.white);
//		}
		//if (collision.relativeVelocity.magnitude > 2){
			sound.Play();
			Debug.Log("PLAY");
			gameObject.GetComponent<MeshRenderer>().enabled = false;
			StartCoroutine("RemoveMe");
			
		//}
		//Destroy(gameObject);
		
	}
	
	IEnumerator RemoveMe(){
		yield return new WaitForSeconds(1f);
		Destroy(gameObject);
	}
	
}
