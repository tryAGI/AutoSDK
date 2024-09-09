//HintName: G.Models.ChecksCreateRequestStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The current status of the check run. Only GitHub Actions can set a status of `waiting`, `pending`, or `requested`.<br/>
    /// Default Value: queued
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChecksCreateRequestStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="queued")]
        Queued,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="in_progress")]
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="completed")]
        Completed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="waiting")]
        Waiting,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="requested")]
        Requested,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pending")]
        Pending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChecksCreateRequestStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChecksCreateRequestStatus value)
        {
            return value switch
            {
                ChecksCreateRequestStatus.Queued => "queued",
                ChecksCreateRequestStatus.InProgress => "in_progress",
                ChecksCreateRequestStatus.Completed => "completed",
                ChecksCreateRequestStatus.Waiting => "waiting",
                ChecksCreateRequestStatus.Requested => "requested",
                ChecksCreateRequestStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChecksCreateRequestStatus? ToEnum(string value)
        {
            return value switch
            {
                "queued" => ChecksCreateRequestStatus.Queued,
                "in_progress" => ChecksCreateRequestStatus.InProgress,
                "completed" => ChecksCreateRequestStatus.Completed,
                "waiting" => ChecksCreateRequestStatus.Waiting,
                "requested" => ChecksCreateRequestStatus.Requested,
                "pending" => ChecksCreateRequestStatus.Pending,
                _ => null,
            };
        }
    }
}