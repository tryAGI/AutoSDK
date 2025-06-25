//HintName: G.Models.ToolChoiceTypesType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of hosted tool the model should to use. Learn more about<br/>
    /// [built-in tools](/docs/guides/tools).<br/>
    /// Allowed values are:<br/>
    /// - `file_search`<br/>
    /// - `web_search_preview`<br/>
    /// - `computer_use_preview`<br/>
    /// - `code_interpreter`<br/>
    /// - `mcp`<br/>
    /// - `image_generation`
    /// </summary>
    public enum ToolChoiceTypesType
    {
        /// <summary>
        /// 
        /// </summary>
        FileSearch,
        /// <summary>
        /// 
        /// </summary>
        WebSearchPreview,
        /// <summary>
        /// 
        /// </summary>
        ComputerUsePreview,
        /// <summary>
        /// 
        /// </summary>
        WebSearchPreview20250311,
        /// <summary>
        /// 
        /// </summary>
        ImageGeneration,
        /// <summary>
        /// 
        /// </summary>
        CodeInterpreter,
        /// <summary>
        /// 
        /// </summary>
        Mcp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolChoiceTypesTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolChoiceTypesType value)
        {
            return value switch
            {
                ToolChoiceTypesType.FileSearch => "file_search",
                ToolChoiceTypesType.WebSearchPreview => "web_search_preview",
                ToolChoiceTypesType.ComputerUsePreview => "computer_use_preview",
                ToolChoiceTypesType.WebSearchPreview20250311 => "web_search_preview_2025_03_11",
                ToolChoiceTypesType.ImageGeneration => "image_generation",
                ToolChoiceTypesType.CodeInterpreter => "code_interpreter",
                ToolChoiceTypesType.Mcp => "mcp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolChoiceTypesType? ToEnum(string value)
        {
            return value switch
            {
                "file_search" => ToolChoiceTypesType.FileSearch,
                "web_search_preview" => ToolChoiceTypesType.WebSearchPreview,
                "computer_use_preview" => ToolChoiceTypesType.ComputerUsePreview,
                "web_search_preview_2025_03_11" => ToolChoiceTypesType.WebSearchPreview20250311,
                "image_generation" => ToolChoiceTypesType.ImageGeneration,
                "code_interpreter" => ToolChoiceTypesType.CodeInterpreter,
                "mcp" => ToolChoiceTypesType.Mcp,
                _ => null,
            };
        }
    }
}