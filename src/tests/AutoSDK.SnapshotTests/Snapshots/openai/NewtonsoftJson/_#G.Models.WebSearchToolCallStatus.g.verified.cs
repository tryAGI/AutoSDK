//HintName: G.Models.WebSearchToolCallStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the web search tool call.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebSearchToolCallStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="in_progress")]
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="searching")]
        Searching,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="completed")]
        Completed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="failed")]
        Failed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebSearchToolCallStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebSearchToolCallStatus value)
        {
            return value switch
            {
                WebSearchToolCallStatus.InProgress => "in_progress",
                WebSearchToolCallStatus.Searching => "searching",
                WebSearchToolCallStatus.Completed => "completed",
                WebSearchToolCallStatus.Failed => "failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebSearchToolCallStatus? ToEnum(string value)
        {
            return value switch
            {
                "in_progress" => WebSearchToolCallStatus.InProgress,
                "searching" => WebSearchToolCallStatus.Searching,
                "completed" => WebSearchToolCallStatus.Completed,
                "failed" => WebSearchToolCallStatus.Failed,
                _ => null,
            };
        }
    }
}