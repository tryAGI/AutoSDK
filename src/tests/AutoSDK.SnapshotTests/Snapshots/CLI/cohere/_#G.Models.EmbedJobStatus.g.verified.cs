//HintName: G.Models.EmbedJobStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the embed job
    /// </summary>
    public enum EmbedJobStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        Cancelling,
        /// <summary>
        /// 
        /// </summary>
        Complete,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Processing,
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
                EmbedJobStatus.Cancelled => "cancelled",
                EmbedJobStatus.Cancelling => "cancelling",
                EmbedJobStatus.Complete => "complete",
                EmbedJobStatus.Failed => "failed",
                EmbedJobStatus.Processing => "processing",
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
                "cancelled" => EmbedJobStatus.Cancelled,
                "cancelling" => EmbedJobStatus.Cancelling,
                "complete" => EmbedJobStatus.Complete,
                "failed" => EmbedJobStatus.Failed,
                "processing" => EmbedJobStatus.Processing,
                _ => null,
            };
        }
    }
}