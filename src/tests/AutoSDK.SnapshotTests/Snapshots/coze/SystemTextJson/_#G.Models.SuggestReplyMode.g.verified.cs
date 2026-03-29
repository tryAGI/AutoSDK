//HintName: G.Models.SuggestReplyMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SuggestReplyMode
    {
        /// <summary>
        /// 
        /// </summary>
        Customized,
        /// <summary>
        /// 
        /// </summary>
        Disable,
        /// <summary>
        /// 
        /// </summary>
        Enable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SuggestReplyModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SuggestReplyMode value)
        {
            return value switch
            {
                SuggestReplyMode.Customized => "customized",
                SuggestReplyMode.Disable => "disable",
                SuggestReplyMode.Enable => "enable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SuggestReplyMode? ToEnum(string value)
        {
            return value switch
            {
                "customized" => SuggestReplyMode.Customized,
                "disable" => SuggestReplyMode.Disable,
                "enable" => SuggestReplyMode.Enable,
                _ => null,
            };
        }
    }
}