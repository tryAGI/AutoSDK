//HintName: G.Models.ProcessingStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProcessingStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
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
        Processing,
        /// <summary>
        /// 
        /// </summary>
        Queued,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProcessingStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProcessingStatus value)
        {
            return value switch
            {
                ProcessingStatus.Cancelled => "cancelled",
                ProcessingStatus.Complete => "complete",
                ProcessingStatus.Error => "error",
                ProcessingStatus.Processing => "processing",
                ProcessingStatus.Queued => "queued",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProcessingStatus? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => ProcessingStatus.Cancelled,
                "complete" => ProcessingStatus.Complete,
                "error" => ProcessingStatus.Error,
                "processing" => ProcessingStatus.Processing,
                "queued" => ProcessingStatus.Queued,
                _ => null,
            };
        }
    }
}