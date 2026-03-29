//HintName: G.Models.TextEditorToolWithToolCallName.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The name of the tool, fixed to 'str_replace_editor'<br/>
    /// Default Value: str_replace_editor
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TextEditorToolWithToolCallName
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
    public static class TextEditorToolWithToolCallNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextEditorToolWithToolCallName value)
        {
            return value switch
            {
                TextEditorToolWithToolCallName.StrReplaceEditor => "str_replace_editor",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextEditorToolWithToolCallName? ToEnum(string value)
        {
            return value switch
            {
                "str_replace_editor" => TextEditorToolWithToolCallName.StrReplaceEditor,
                _ => null,
            };
        }
    }
}