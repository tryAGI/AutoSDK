//HintName: G.Models.GetClusterJobResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetClusterJobResponseStatus
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
    public static class GetClusterJobResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetClusterJobResponseStatus value)
        {
            return value switch
            {
                GetClusterJobResponseStatus.Complete => "complete",
                GetClusterJobResponseStatus.Failed => "failed",
                GetClusterJobResponseStatus.Processing => "processing",
                GetClusterJobResponseStatus.Queued => "queued",
                GetClusterJobResponseStatus.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetClusterJobResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "complete" => GetClusterJobResponseStatus.Complete,
                "failed" => GetClusterJobResponseStatus.Failed,
                "processing" => GetClusterJobResponseStatus.Processing,
                "queued" => GetClusterJobResponseStatus.Queued,
                "unknown" => GetClusterJobResponseStatus.Unknown,
                _ => null,
            };
        }
    }
}