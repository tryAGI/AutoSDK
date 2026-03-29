//HintName: G.Models.ManagedIngestionStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Status of managed ingestion with partial Updates.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ManagedIngestionStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CANCELLED")]
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ERROR")]
        Error,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="IN_PROGRESS")]
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="NOT_STARTED")]
        NotStarted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PARTIAL_SUCCESS")]
        PartialSuccess,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="SUCCESS")]
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ManagedIngestionStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ManagedIngestionStatus value)
        {
            return value switch
            {
                ManagedIngestionStatus.Cancelled => "CANCELLED",
                ManagedIngestionStatus.Error => "ERROR",
                ManagedIngestionStatus.InProgress => "IN_PROGRESS",
                ManagedIngestionStatus.NotStarted => "NOT_STARTED",
                ManagedIngestionStatus.PartialSuccess => "PARTIAL_SUCCESS",
                ManagedIngestionStatus.Success => "SUCCESS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ManagedIngestionStatus? ToEnum(string value)
        {
            return value switch
            {
                "CANCELLED" => ManagedIngestionStatus.Cancelled,
                "ERROR" => ManagedIngestionStatus.Error,
                "IN_PROGRESS" => ManagedIngestionStatus.InProgress,
                "NOT_STARTED" => ManagedIngestionStatus.NotStarted,
                "PARTIAL_SUCCESS" => ManagedIngestionStatus.PartialSuccess,
                "SUCCESS" => ManagedIngestionStatus.Success,
                _ => null,
            };
        }
    }
}