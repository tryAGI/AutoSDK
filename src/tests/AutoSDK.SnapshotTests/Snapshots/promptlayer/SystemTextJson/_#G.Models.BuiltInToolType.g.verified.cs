//HintName: G.Models.BuiltInToolType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BuiltInToolType
    {
        /// <summary>
        /// 
        /// </summary>
        ApplyPatch,
        /// <summary>
        /// 
        /// </summary>
        Bash,
        /// <summary>
        /// 
        /// </summary>
        CodeInterpreter,
        /// <summary>
        /// 
        /// </summary>
        FileSearch,
        /// <summary>
        /// 
        /// </summary>
        GoogleMaps,
        /// <summary>
        /// 
        /// </summary>
        ImageGeneration,
        /// <summary>
        /// 
        /// </summary>
        Mcp,
        /// <summary>
        /// 
        /// </summary>
        Shell,
        /// <summary>
        /// 
        /// </summary>
        TextEditor,
        /// <summary>
        /// 
        /// </summary>
        UrlContext,
        /// <summary>
        /// 
        /// </summary>
        WebSearch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuiltInToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuiltInToolType value)
        {
            return value switch
            {
                BuiltInToolType.ApplyPatch => "apply_patch",
                BuiltInToolType.Bash => "bash",
                BuiltInToolType.CodeInterpreter => "code_interpreter",
                BuiltInToolType.FileSearch => "file_search",
                BuiltInToolType.GoogleMaps => "google_maps",
                BuiltInToolType.ImageGeneration => "image_generation",
                BuiltInToolType.Mcp => "mcp",
                BuiltInToolType.Shell => "shell",
                BuiltInToolType.TextEditor => "text_editor",
                BuiltInToolType.UrlContext => "url_context",
                BuiltInToolType.WebSearch => "web_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuiltInToolType? ToEnum(string value)
        {
            return value switch
            {
                "apply_patch" => BuiltInToolType.ApplyPatch,
                "bash" => BuiltInToolType.Bash,
                "code_interpreter" => BuiltInToolType.CodeInterpreter,
                "file_search" => BuiltInToolType.FileSearch,
                "google_maps" => BuiltInToolType.GoogleMaps,
                "image_generation" => BuiltInToolType.ImageGeneration,
                "mcp" => BuiltInToolType.Mcp,
                "shell" => BuiltInToolType.Shell,
                "text_editor" => BuiltInToolType.TextEditor,
                "url_context" => BuiltInToolType.UrlContext,
                "web_search" => BuiltInToolType.WebSearch,
                _ => null,
            };
        }
    }
}