//HintName: G.Models.TextEditorToolSubType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The sub type of tool.
    /// </summary>
    public enum TextEditorToolSubType
    {
        /// <summary>
        /// 
        /// </summary>
        TextEditor20241022,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextEditorToolSubTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextEditorToolSubType value)
        {
            return value switch
            {
                TextEditorToolSubType.TextEditor20241022 => "text_editor_20241022",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextEditorToolSubType? ToEnum(string value)
        {
            return value switch
            {
                "text_editor_20241022" => TextEditorToolSubType.TextEditor20241022,
                _ => null,
            };
        }
    }
}