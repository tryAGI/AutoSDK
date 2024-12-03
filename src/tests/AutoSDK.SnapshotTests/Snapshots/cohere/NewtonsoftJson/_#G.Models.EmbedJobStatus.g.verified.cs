//HintName: G.Models.EmbedJobStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the embed job
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EmbedJobStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="processing")]
        Processing,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="complete")]
        Complete,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cancelling")]
        Cancelling,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cancelled")]
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="failed")]
        Failed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EmbedJobStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmbedJobStatus value)
        {
            return value switch
            {
                EmbedJobStatus.Processing => "processing",
                EmbedJobStatus.Complete => "complete",
                EmbedJobStatus.Cancelling => "cancelling",
                EmbedJobStatus.Cancelled => "cancelled",
                EmbedJobStatus.Failed => "failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmbedJobStatus? ToEnum(string value)
        {
            return value switch
            {
                "processing" => EmbedJobStatus.Processing,
                "complete" => EmbedJobStatus.Complete,
                "cancelling" => EmbedJobStatus.Cancelling,
                "cancelled" => EmbedJobStatus.Cancelled,
                "failed" => EmbedJobStatus.Failed,
                _ => null,
            };
        }
    }
}