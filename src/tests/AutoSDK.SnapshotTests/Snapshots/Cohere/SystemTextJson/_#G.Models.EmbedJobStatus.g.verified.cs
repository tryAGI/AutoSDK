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
        Processing,
        /// <summary>
        /// 
        /// </summary>
        Complete,
        /// <summary>
        /// 
        /// </summary>
        Cancelling,
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
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