//HintName: G.Models.ChecksCreateRequestStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The current status of the check run. Only GitHub Actions can set a status of `waiting`, `pending`, or `requested`.<br/>
    /// Default Value: queued
    /// </summary>
    public enum ChecksCreateRequestStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Queued,
        /// <summary>
        /// 
        /// </summary>
        Requested,
        /// <summary>
        /// 
        /// </summary>
        Waiting,
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
                ChecksCreateRequestStatus.Completed => "completed",
                ChecksCreateRequestStatus.InProgress => "in_progress",
                ChecksCreateRequestStatus.Pending => "pending",
                ChecksCreateRequestStatus.Queued => "queued",
                ChecksCreateRequestStatus.Requested => "requested",
                ChecksCreateRequestStatus.Waiting => "waiting",
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
                "completed" => ChecksCreateRequestStatus.Completed,
                "in_progress" => ChecksCreateRequestStatus.InProgress,
                "pending" => ChecksCreateRequestStatus.Pending,
                "queued" => ChecksCreateRequestStatus.Queued,
                "requested" => ChecksCreateRequestStatus.Requested,
                "waiting" => ChecksCreateRequestStatus.Waiting,
                _ => null,
            };
        }
    }
}