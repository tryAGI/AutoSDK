//HintName: G.Models.CreateTextEditorToolDTOType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool. "textEditor" for Text Editor tool.
    /// </summary>
    public enum CreateTextEditorToolDTOType
    {
        /// <summary>
        /// 
        /// </summary>
        TextEditor,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTextEditorToolDTOTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextEditorToolDTOType value)
        {
            return value switch
            {
                CreateTextEditorToolDTOType.TextEditor => "textEditor",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextEditorToolDTOType? ToEnum(string value)
        {
            return value switch
            {
                "textEditor" => CreateTextEditorToolDTOType.TextEditor,
                _ => null,
            };
        }
    }
}