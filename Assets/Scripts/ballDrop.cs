using UnityEngine;
using System.Collections;

public class ballDrop : MonoBehaviour
{
		public Transform target;
		private float i = 0;	
		Vector3 v3 = Vector3.left;
		// Use this for initialization
		void Start ()
		{
		
		}
	
		// Update is called once per frame
		void Update ()
		{
				i = (i + 100 * Time.deltaTime);
				if (i > 200) {
						i = 0;
						v3 = (v3 == Vector3.right) ? Vector3.left : Vector3.right;
				}
				transform.Translate (v3 * 100 * Time.deltaTime);
		}
}
