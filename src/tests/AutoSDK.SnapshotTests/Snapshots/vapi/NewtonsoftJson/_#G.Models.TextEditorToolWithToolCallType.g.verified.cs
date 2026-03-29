//HintName: G.Models.TextEditorToolWithToolCallType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool. "textEditor" for Text Editor tool.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TextEditorToolWithToolCallType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="textEditor")]
        TextEditor,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextEditorToolWithToolCallTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextEditorToolWithToolCallType value)
        {
            return value switch
            {
                TextEditorToolWithToolCallType.TextEditor => "textEditor",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextEditorToolWithToolCallType? ToEnum(string value)
        {
            return value switch
            {
                "textEditor" => TextEditorToolWithToolCallType.TextEditor,
                _ => null,
            };
        }
    }
}