using System.IO;
using UnityEditor;
using UnityEditor.ShortcutManagement;
using UnityEngine;

namespace Editor.EditorTools
{
    public static class ScriptCreator
    {
        private const string TemplatePath = "Assets/Editor/EditorTools/ScriptTemplate.cs.txt";

        // Ctrl + Alt + N
        [Shortcut("Tools/Create Default Mono Script", KeyCode.N, ShortcutModifiers.Action | ShortcutModifiers.Alt)] 
        public static void CreateDefaultUnityScript()
        {
            if (!File.Exists(TemplatePath))
            {
                Debug.LogError($"Template not found at: {TemplatePath}");
                return;
            }

            ProjectWindowUtil.CreateScriptAssetFromTemplateFile(TemplatePath, "NewBehaviourScript.cs");
        }
    }
}