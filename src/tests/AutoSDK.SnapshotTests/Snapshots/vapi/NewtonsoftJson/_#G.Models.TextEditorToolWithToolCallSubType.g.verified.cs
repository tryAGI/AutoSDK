//HintName: G.Models.TextEditorToolWithToolCallSubType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The sub type of tool.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TextEditorToolWithToolCallSubType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text_editor_20241022")]
        TextEditor20241022,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextEditorToolWithToolCallSubTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextEditorToolWithToolCallSubType value)
        {
            return value switch
            {
                TextEditorToolWithToolCallSubType.TextEditor20241022 => "text_editor_20241022",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextEditorToolWithToolCallSubType? ToEnum(string value)
        {
            return value switch
            {
                "text_editor_20241022" => TextEditorToolWithToolCallSubType.TextEditor20241022,
                _ => null,
            };
        }
    }
}