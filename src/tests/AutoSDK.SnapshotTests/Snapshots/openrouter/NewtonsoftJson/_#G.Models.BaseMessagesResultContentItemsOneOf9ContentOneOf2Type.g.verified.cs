//HintName: G.Models.BaseMessagesResultContentItemsOneOf9ContentOneOf2Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BaseMessagesResultContentItemsOneOf9ContentOneOf2Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text_editor_code_execution_create_result")]
        TextEditorCodeExecutionCreateResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseMessagesResultContentItemsOneOf9ContentOneOf2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseMessagesResultContentItemsOneOf9ContentOneOf2Type value)
        {
            return value switch
            {
                BaseMessagesResultContentItemsOneOf9ContentOneOf2Type.TextEditorCodeExecutionCreateResult => "text_editor_code_execution_create_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseMessagesResultContentItemsOneOf9ContentOneOf2Type? ToEnum(string value)
        {
            return value switch
            {
                "text_editor_code_execution_create_result" => BaseMessagesResultContentItemsOneOf9ContentOneOf2Type.TextEditorCodeExecutionCreateResult,
                _ => null,
            };
        }
    }
}