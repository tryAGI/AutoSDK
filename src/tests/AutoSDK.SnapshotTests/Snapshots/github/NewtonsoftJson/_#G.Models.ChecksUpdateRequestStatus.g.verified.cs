//HintName: G.Models.ChecksUpdateRequestStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The current status of the check run. Only GitHub Actions can set a status of `waiting`, `pending`, or `requested`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChecksUpdateRequestStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="completed")]
        Completed,
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
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="queued")]
        Queued,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="requested")]
        Requested,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="waiting")]
        Waiting,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChecksUpdateRequestStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChecksUpdateRequestStatus value)
        {
            return value switch
            {
                ChecksUpdateRequestStatus.Completed => "completed",
                ChecksUpdateRequestStatus.InProgress => "in_progress",
                ChecksUpdateRequestStatus.Pending => "pending",
                ChecksUpdateRequestStatus.Queued => "queued",
                ChecksUpdateRequestStatus.Requested => "requested",
                ChecksUpdateRequestStatus.Waiting => "waiting",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChecksUpdateRequestStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ChecksUpdateRequestStatus.Completed,
                "in_progress" => ChecksUpdateRequestStatus.InProgress,
                "pending" => ChecksUpdateRequestStatus.Pending,
                "queued" => ChecksUpdateRequestStatus.Queued,
                "requested" => ChecksUpdateRequestStatus.Requested,
                "waiting" => ChecksUpdateRequestStatus.Waiting,
                _ => null,
            };
        }
    }
}