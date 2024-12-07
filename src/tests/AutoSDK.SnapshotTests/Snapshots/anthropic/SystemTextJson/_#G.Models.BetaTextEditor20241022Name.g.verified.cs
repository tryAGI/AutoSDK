//HintName: G.Models.BetaTextEditor20241022Name.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Name of the tool.<br/>
    /// This is how the tool will be called by the model and in tool_use blocks.
    /// </summary>
    public enum BetaTextEditor20241022Name
    {
        /// <summary>
        /// 
        /// </summary>
        StrReplaceEditor,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaTextEditor20241022NameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaTextEditor20241022Name value)
        {
            return value switch
            {
                BetaTextEditor20241022Name.StrReplaceEditor => "str_replace_editor",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaTextEditor20241022Name? ToEnum(string value)
        {
            return value switch
            {
                "str_replace_editor" => BetaTextEditor20241022Name.StrReplaceEditor,
                _ => null,
            };
        }
    }
}