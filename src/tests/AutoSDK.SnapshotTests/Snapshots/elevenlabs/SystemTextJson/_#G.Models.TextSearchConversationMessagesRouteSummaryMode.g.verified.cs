//HintName: G.Models.TextSearchConversationMessagesRouteSummaryMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Whether to include transcript summaries in the response.<br/>
    /// Default Value: exclude
    /// </summary>
    public enum TextSearchConversationMessagesRouteSummaryMode
    {
        /// <summary>
        /// 
        /// </summary>
        Exclude,
        /// <summary>
        /// 
        /// </summary>
        Include,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextSearchConversationMessagesRouteSummaryModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextSearchConversationMessagesRouteSummaryMode value)
        {
            return value switch
            {
                TextSearchConversationMessagesRouteSummaryMode.Exclude => "exclude",
                TextSearchConversationMessagesRouteSummaryMode.Include => "include",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextSearchConversationMessagesRouteSummaryMode? ToEnum(string value)
        {
            return value switch
            {
                "exclude" => TextSearchConversationMessagesRouteSummaryMode.Exclude,
                "include" => TextSearchConversationMessagesRouteSummaryMode.Include,
                _ => null,
            };
        }
    }
}