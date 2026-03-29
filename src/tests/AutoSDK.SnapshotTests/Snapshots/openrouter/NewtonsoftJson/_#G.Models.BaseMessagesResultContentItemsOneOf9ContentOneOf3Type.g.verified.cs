//HintName: G.Models.BaseMessagesResultContentItemsOneOf9ContentOneOf3Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BaseMessagesResultContentItemsOneOf9ContentOneOf3Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text_editor_code_execution_str_replace_result")]
        TextEditorCodeExecutionStrReplaceResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseMessagesResultContentItemsOneOf9ContentOneOf3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseMessagesResultContentItemsOneOf9ContentOneOf3Type value)
        {
            return value switch
            {
                BaseMessagesResultContentItemsOneOf9ContentOneOf3Type.TextEditorCodeExecutionStrReplaceResult => "text_editor_code_execution_str_replace_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseMessagesResultContentItemsOneOf9ContentOneOf3Type? ToEnum(string value)
        {
            return value switch
            {
                "text_editor_code_execution_str_replace_result" => BaseMessagesResultContentItemsOneOf9ContentOneOf3Type.TextEditorCodeExecutionStrReplaceResult,
                _ => null,
            };
        }
    }
}