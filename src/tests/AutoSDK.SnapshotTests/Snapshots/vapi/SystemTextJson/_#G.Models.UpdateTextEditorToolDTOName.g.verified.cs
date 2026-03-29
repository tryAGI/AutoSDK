//HintName: G.Models.UpdateTextEditorToolDTOName.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The name of the tool, fixed to 'str_replace_editor'<br/>
    /// Default Value: str_replace_editor
    /// </summary>
    public enum UpdateTextEditorToolDTOName
    {
        /// <summary>
        /// 
        /// </summary>
        StrReplaceEditor,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateTextEditorToolDTONameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateTextEditorToolDTOName value)
        {
            return value switch
            {
                UpdateTextEditorToolDTOName.StrReplaceEditor => "str_replace_editor",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateTextEditorToolDTOName? ToEnum(string value)
        {
            return value switch
            {
                "str_replace_editor" => UpdateTextEditorToolDTOName.StrReplaceEditor,
                _ => null,
            };
        }
    }
}