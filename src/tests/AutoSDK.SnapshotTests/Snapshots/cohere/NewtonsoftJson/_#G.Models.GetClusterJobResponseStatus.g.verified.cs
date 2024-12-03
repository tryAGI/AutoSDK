//HintName: G.Models.GetClusterJobResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetClusterJobResponseStatus
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
    public static class GetClusterJobResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetClusterJobResponseStatus value)
        {
            return value switch
            {
                GetClusterJobResponseStatus.Unknown => "unknown",
                GetClusterJobResponseStatus.Processing => "processing",
                GetClusterJobResponseStatus.Failed => "failed",
                GetClusterJobResponseStatus.Complete => "complete",
                GetClusterJobResponseStatus.Queued => "queued",
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
                "unknown" => GetClusterJobResponseStatus.Unknown,
                "processing" => GetClusterJobResponseStatus.Processing,
                "failed" => GetClusterJobResponseStatus.Failed,
                "complete" => GetClusterJobResponseStatus.Complete,
                "queued" => GetClusterJobResponseStatus.Queued,
                _ => null,
            };
        }
    }
}