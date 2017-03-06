using UnityEngine;
using System.Collections;

[ExecuteInEditMode()]
[RequireComponent( typeof(MeshFilter))]
[RequireComponent( typeof(MeshRenderer))]
[RequireComponent( typeof(MeshCollider))]
public class TileMap : MonoBehaviour
{
		MeshRenderer meshRenderer;
		MeshFilter meshFilter; 
		MeshCollider meshCollider;


		// Use this for initialization
		void Start ()
		{
				meshRenderer = GetComponent<MeshRenderer> ();
				meshFilter = GetComponent<MeshFilter> (); 
				meshCollider = GetComponent<MeshCollider> ();
				BuildMesh ();

		}
	

		void BuildMesh ()
		{
				
				var mesh = new Mesh ();

				//Generate the mesh data 
				Vector3[] vertices = new Vector3[4];
				int[] triangles = new int[3 * 2];
				Vector3[] normals = new Vector3[4];
				Vector2[] uv = new Vector2[4];

				vertices [0] = new Vector3 (0, 0, 0);
				vertices [1] = new Vector3 (1, 0, 0);
				vertices [2] = new Vector3 (0, 0, -1);
				vertices [3] = new Vector3 (1, 0, -1);

				triangles [0] = 0;
				triangles [1] = 3;
				triangles [2] = 2;

				triangles [3] = 0;
				triangles [4] = 1;
				triangles [5] = 3;

				normals [0] = Vector3.up;
				normals [1] = Vector3.up;
				normals [2] = Vector3.up;
				normals [3] = Vector3.up;

				uv [0] = new Vector2 (0, 1);
				uv [1] = new Vector2 (1, 1);
				uv [2] = new Vector2 (0, 0);
				uv [3] = new Vector2 (1, 0);

				//Create a new Mesh and populate the data
				mesh.vertices = vertices; 
				mesh.triangles = triangles; 
				mesh.normals = normals; 
				mesh.uv = uv;

				//Assign mesh to filter/renderer/collider
				meshFilter.mesh = mesh;

		}
}
