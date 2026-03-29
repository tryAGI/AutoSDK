//HintName: G.Models.BaseMessagesResultContentItemsOneOf9ContentOneOf0Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BaseMessagesResultContentItemsOneOf9ContentOneOf0Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text_editor_code_execution_tool_result_error")]
        TextEditorCodeExecutionToolResultError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseMessagesResultContentItemsOneOf9ContentOneOf0TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseMessagesResultContentItemsOneOf9ContentOneOf0Type value)
        {
            return value switch
            {
                BaseMessagesResultContentItemsOneOf9ContentOneOf0Type.TextEditorCodeExecutionToolResultError => "text_editor_code_execution_tool_result_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseMessagesResultContentItemsOneOf9ContentOneOf0Type? ToEnum(string value)
        {
            return value switch
            {
                "text_editor_code_execution_tool_result_error" => BaseMessagesResultContentItemsOneOf9ContentOneOf0Type.TextEditorCodeExecutionToolResultError,
                _ => null,
            };
        }
    }
}