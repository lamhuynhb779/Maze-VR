using UnityEngine;
using UnityEngine.Audio;
using System.Collections;

public class HitWall : MonoBehaviour
{
	// vars to Flash a colour when hit 
	public AudioSource ouchs;
	public Color NormalColour = Color.white;
	public Color FlashColour = Color.red;
	public float FlashDelay = 0.025f;
	public int TimesToFlash = 3;
	Renderer GameMesh;
	
	void Start()
	{

	}

	public void Flash()
	{
		
		StartCoroutine(OnCollisionEnter());
	}

	private IEnumerator OnCollisionEnter()
	{
			ouchs.Play();
			GameMesh = GetComponent<Renderer>();
			var renderer = GameMesh;
			if (renderer != null)
			{
				for (int i = 1; i <= TimesToFlash; i++)
				{
					renderer.material.color = FlashColour;
					yield return new WaitForSeconds(FlashDelay);
					renderer.material.color = NormalColour;
					yield return new WaitForSeconds(FlashDelay);
				}

			}
		
	}

}

