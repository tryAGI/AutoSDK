//HintName: G.Models.CallDetailsQueueStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Call progression status
    /// </summary>
    public enum CallDetailsQueueStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Allocated,
        /// <summary>
        /// 
        /// </summary>
        Complete,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        New,
        /// <summary>
        /// 
        /// </summary>
        Queued,
        /// <summary>
        /// 
        /// </summary>
        Started,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CallDetailsQueueStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CallDetailsQueueStatus value)
        {
            return value switch
            {
                CallDetailsQueueStatus.Allocated => "allocated",
                CallDetailsQueueStatus.Complete => "complete",
                CallDetailsQueueStatus.Error => "error",
                CallDetailsQueueStatus.New => "new",
                CallDetailsQueueStatus.Queued => "queued",
                CallDetailsQueueStatus.Started => "started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CallDetailsQueueStatus? ToEnum(string value)
        {
            return value switch
            {
                "allocated" => CallDetailsQueueStatus.Allocated,
                "complete" => CallDetailsQueueStatus.Complete,
                "error" => CallDetailsQueueStatus.Error,
                "new" => CallDetailsQueueStatus.New,
                "queued" => CallDetailsQueueStatus.Queued,
                "started" => CallDetailsQueueStatus.Started,
                _ => null,
            };
        }
    }
}