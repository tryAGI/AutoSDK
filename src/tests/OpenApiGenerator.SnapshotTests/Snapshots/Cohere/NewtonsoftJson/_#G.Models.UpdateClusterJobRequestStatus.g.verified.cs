//HintName: G.Models.UpdateClusterJobRequestStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UpdateClusterJobRequestStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="unknown")]
        Unknown,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="processing")]
        Processing,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="failed")]
        Failed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="complete")]
        Complete,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="queued")]
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