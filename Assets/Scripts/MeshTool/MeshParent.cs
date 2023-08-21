using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace MVoxelizer
{
    [ExecuteInEditMode]
    public class MeshParent : MonoBehaviour
    {
        [SerializeField] private List<MeshData> MeshDataList;

        public MeshVoxelizer meshVoxelizer;

        public void RebuildData()
        {
            GameObject obj = meshVoxelizer.GenerateResultAgain();


        }
    }
    [CustomEditor(typeof(MeshParent))]
    public class MeshParentEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();
            MeshParent meshParent = (MeshParent)target;

            if (GUILayout.Button("Rebuild Data"))
            {
                meshParent.RebuildData();
            }
        }
    }
}