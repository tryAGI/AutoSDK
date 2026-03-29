//HintName: G.Models.ToolDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ToolDiscriminatorType
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
        Function,
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
    public static class ToolDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolDiscriminatorType value)
        {
            return value switch
            {
                ToolDiscriminatorType.ApplyPatch => "apply_patch",
                ToolDiscriminatorType.Bash => "bash",
                ToolDiscriminatorType.CodeInterpreter => "code_interpreter",
                ToolDiscriminatorType.FileSearch => "file_search",
                ToolDiscriminatorType.Function => "function",
                ToolDiscriminatorType.GoogleMaps => "google_maps",
                ToolDiscriminatorType.ImageGeneration => "image_generation",
                ToolDiscriminatorType.Mcp => "mcp",
                ToolDiscriminatorType.Shell => "shell",
                ToolDiscriminatorType.TextEditor => "text_editor",
                ToolDiscriminatorType.UrlContext => "url_context",
                ToolDiscriminatorType.WebSearch => "web_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "apply_patch" => ToolDiscriminatorType.ApplyPatch,
                "bash" => ToolDiscriminatorType.Bash,
                "code_interpreter" => ToolDiscriminatorType.CodeInterpreter,
                "file_search" => ToolDiscriminatorType.FileSearch,
                "function" => ToolDiscriminatorType.Function,
                "google_maps" => ToolDiscriminatorType.GoogleMaps,
                "image_generation" => ToolDiscriminatorType.ImageGeneration,
                "mcp" => ToolDiscriminatorType.Mcp,
                "shell" => ToolDiscriminatorType.Shell,
                "text_editor" => ToolDiscriminatorType.TextEditor,
                "url_context" => ToolDiscriminatorType.UrlContext,
                "web_search" => ToolDiscriminatorType.WebSearch,
                _ => null,
            };
        }
    }
}