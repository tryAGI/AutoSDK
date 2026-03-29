//HintName: G.Models.TextEditorToolName.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The name of the tool, fixed to 'str_replace_editor'<br/>
    /// Default Value: str_replace_editor
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TextEditorToolName
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="str_replace_editor")]
        StrReplaceEditor,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextEditorToolNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextEditorToolName value)
        {
            return value switch
            {
                TextEditorToolName.StrReplaceEditor => "str_replace_editor",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextEditorToolName? ToEnum(string value)
        {
            return value switch
            {
                "str_replace_editor" => TextEditorToolName.StrReplaceEditor,
                _ => null,
            };
        }
    }
}