//HintName: G.Models.BaseMessagesResultContentItemsOneOf9ContentOneOf1Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BaseMessagesResultContentItemsOneOf9ContentOneOf1Type
    {
        /// <summary>
        /// 
        /// </summary>
        TextEditorCodeExecutionViewResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseMessagesResultContentItemsOneOf9ContentOneOf1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseMessagesResultContentItemsOneOf9ContentOneOf1Type value)
        {
            return value switch
            {
                BaseMessagesResultContentItemsOneOf9ContentOneOf1Type.TextEditorCodeExecutionViewResult => "text_editor_code_execution_view_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseMessagesResultContentItemsOneOf9ContentOneOf1Type? ToEnum(string value)
        {
            return value switch
            {
                "text_editor_code_execution_view_result" => BaseMessagesResultContentItemsOneOf9ContentOneOf1Type.TextEditorCodeExecutionViewResult,
                _ => null,
            };
        }
    }
}