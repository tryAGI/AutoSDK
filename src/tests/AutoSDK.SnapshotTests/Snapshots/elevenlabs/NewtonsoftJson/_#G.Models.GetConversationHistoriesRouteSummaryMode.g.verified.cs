//HintName: G.Models.GetConversationHistoriesRouteSummaryMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Whether to include transcript summaries in the response.<br/>
    /// Default Value: exclude
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetConversationHistoriesRouteSummaryMode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="exclude")]
        Exclude,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="include")]
        Include,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetConversationHistoriesRouteSummaryModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConversationHistoriesRouteSummaryMode value)
        {
            return value switch
            {
                GetConversationHistoriesRouteSummaryMode.Exclude => "exclude",
                GetConversationHistoriesRouteSummaryMode.Include => "include",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConversationHistoriesRouteSummaryMode? ToEnum(string value)
        {
            return value switch
            {
                "exclude" => GetConversationHistoriesRouteSummaryMode.Exclude,
                "include" => GetConversationHistoriesRouteSummaryMode.Include,
                _ => null,
            };
        }
    }
}