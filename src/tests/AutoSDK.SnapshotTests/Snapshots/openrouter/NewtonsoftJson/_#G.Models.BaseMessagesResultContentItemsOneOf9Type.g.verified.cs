//HintName: G.Models.BaseMessagesResultContentItemsOneOf9Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BaseMessagesResultContentItemsOneOf9Type
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
    public static class BaseMessagesResultContentItemsOneOf9TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseMessagesResultContentItemsOneOf9Type value)
        {
            return value switch
            {
                BaseMessagesResultContentItemsOneOf9Type.TextEditorCodeExecutionToolResult => "text_editor_code_execution_tool_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseMessagesResultContentItemsOneOf9Type? ToEnum(string value)
        {
            return value switch
            {
                "text_editor_code_execution_tool_result" => BaseMessagesResultContentItemsOneOf9Type.TextEditorCodeExecutionToolResult,
                _ => null,
            };
        }
    }
}