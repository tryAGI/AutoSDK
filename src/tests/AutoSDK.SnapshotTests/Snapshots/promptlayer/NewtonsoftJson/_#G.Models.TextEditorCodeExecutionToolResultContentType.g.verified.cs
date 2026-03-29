//HintName: G.Models.TextEditorCodeExecutionToolResultContentType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: text_editor_code_execution_tool_result
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TextEditorCodeExecutionToolResultContentType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text_editor_code_execution_tool_result")]
        TextEditorCodeExecutionToolResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextEditorCodeExecutionToolResultContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextEditorCodeExecutionToolResultContentType value)
        {
            return value switch
            {
                TextEditorCodeExecutionToolResultContentType.TextEditorCodeExecutionToolResult => "text_editor_code_execution_tool_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextEditorCodeExecutionToolResultContentType? ToEnum(string value)
        {
            return value switch
            {
                "text_editor_code_execution_tool_result" => TextEditorCodeExecutionToolResultContentType.TextEditorCodeExecutionToolResult,
                _ => null,
            };
        }
    }
}