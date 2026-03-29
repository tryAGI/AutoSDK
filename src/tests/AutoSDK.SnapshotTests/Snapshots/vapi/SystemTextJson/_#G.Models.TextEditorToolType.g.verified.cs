//HintName: G.Models.TextEditorToolType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool. "textEditor" for Text Editor tool.
    /// </summary>
    public enum TextEditorToolType
    {
        /// <summary>
        /// 
        /// </summary>
        TextEditor,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextEditorToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextEditorToolType value)
        {
            return value switch
            {
                TextEditorToolType.TextEditor => "textEditor",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextEditorToolType? ToEnum(string value)
        {
            return value switch
            {
                "textEditor" => TextEditorToolType.TextEditor,
                _ => null,
            };
        }
    }
}