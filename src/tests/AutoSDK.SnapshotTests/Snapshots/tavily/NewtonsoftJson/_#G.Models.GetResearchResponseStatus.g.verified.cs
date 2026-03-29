//HintName: G.Models.GetResearchResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Current status of the research task.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetResearchResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="in_progress")]
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pending")]
        Pending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetResearchResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetResearchResponseStatus value)
        {
            return value switch
            {
                GetResearchResponseStatus.InProgress => "in_progress",
                GetResearchResponseStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetResearchResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "in_progress" => GetResearchResponseStatus.InProgress,
                "pending" => GetResearchResponseStatus.Pending,
                _ => null,
            };
        }
    }
}