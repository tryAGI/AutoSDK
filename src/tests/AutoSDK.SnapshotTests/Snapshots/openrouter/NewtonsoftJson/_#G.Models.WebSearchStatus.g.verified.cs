//HintName: G.Models.WebSearchStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebSearchStatus
    {
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebSearchStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebSearchStatus value)
        {
            return value switch
            {
                WebSearchStatus.Completed => "completed",
                WebSearchStatus.Failed => "failed",
                WebSearchStatus.InProgress => "in_progress",
                WebSearchStatus.Searching => "searching",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebSearchStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => WebSearchStatus.Completed,
                "failed" => WebSearchStatus.Failed,
                "in_progress" => WebSearchStatus.InProgress,
                "searching" => WebSearchStatus.Searching,
                _ => null,
            };
        }
    }
}