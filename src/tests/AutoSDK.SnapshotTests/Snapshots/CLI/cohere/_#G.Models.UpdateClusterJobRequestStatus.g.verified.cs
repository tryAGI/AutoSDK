//HintName: G.Models.UpdateClusterJobRequestStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateClusterJobRequestStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Unknown,
        /// <summary>
        /// 
        /// </summary>
        Processing,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Complete,
        /// <summary>
        /// 
        /// </summary>
        Queued,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateClusterJobRequestStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateClusterJobRequestStatus value)
        {
            return value switch
            {
                UpdateClusterJobRequestStatus.Unknown => "unknown",
                UpdateClusterJobRequestStatus.Processing => "processing",
                UpdateClusterJobRequestStatus.Failed => "failed",
                UpdateClusterJobRequestStatus.Complete => "complete",
                UpdateClusterJobRequestStatus.Queued => "queued",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateClusterJobRequestStatus? ToEnum(string value)
        {
            return value switch
            {
                "unknown" => UpdateClusterJobRequestStatus.Unknown,
                "processing" => UpdateClusterJobRequestStatus.Processing,
                "failed" => UpdateClusterJobRequestStatus.Failed,
                "complete" => UpdateClusterJobRequestStatus.Complete,
                "queued" => UpdateClusterJobRequestStatus.Queued,
                _ => null,
            };
        }
    }
}