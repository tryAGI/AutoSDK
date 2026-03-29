//HintName: G.Models.CallDetailsQueueStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Call progression status
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CallDetailsQueueStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="allocated")]
        Allocated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="complete")]
        Complete,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error")]
        Error,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="new")]
        New,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="queued")]
        Queued,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="started")]
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