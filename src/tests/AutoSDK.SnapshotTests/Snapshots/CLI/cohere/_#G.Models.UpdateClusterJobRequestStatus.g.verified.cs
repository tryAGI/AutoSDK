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
        Complete,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Processing,
        /// <summary>
        /// 
        /// </summary>
        Queued,
        /// <summary>
        /// 
        /// </summary>
        Unknown,
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
                UpdateClusterJobRequestStatus.Complete => "complete",
                UpdateClusterJobRequestStatus.Failed => "failed",
                UpdateClusterJobRequestStatus.Processing => "processing",
                UpdateClusterJobRequestStatus.Queued => "queued",
                UpdateClusterJobRequestStatus.Unknown => "unknown",
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
                "complete" => UpdateClusterJobRequestStatus.Complete,
                "failed" => UpdateClusterJobRequestStatus.Failed,
                "processing" => UpdateClusterJobRequestStatus.Processing,
                "queued" => UpdateClusterJobRequestStatus.Queued,
                "unknown" => UpdateClusterJobRequestStatus.Unknown,
                _ => null,
            };
        }
    }
}