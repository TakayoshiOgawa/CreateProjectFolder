﻿using System.IO;
using UnityEngine;
using UnityEditor;

namespace OG.Editor
{
    public static class CreateProjectFolder
    {
        // フォルダー名の一覧
        private static readonly string[] folders = new string[]
        {
            "Scenes",
            "Prefabs",
            "Scripts",
            "Animations",
            "Materials",
            "PhysicsMaterials",
            "Fonts",
            "Textures",
            "Audios",
            "Resources",
            "Editor",
            "Plugins",
        };

        [MenuItem("Tools/Create Project Folder")]
        private static void Excute()
        {
            // 作成先となるフォルダーのパスを取得
            var target = EditorUtility.OpenFolderPanel("Select Project Folder", Application.dataPath, "Project");

            // プロジェクト以下にフォルダを作成
            foreach (var folder in folders)
            {
                var path = target + "/" + folder;
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
            }

            // エディターの更新
            AssetDatabase.Refresh();
        }
    }
}
