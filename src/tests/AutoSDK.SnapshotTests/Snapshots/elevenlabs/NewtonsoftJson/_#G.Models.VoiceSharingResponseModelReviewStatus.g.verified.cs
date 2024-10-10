//HintName: G.Models.VoiceSharingResponseModelReviewStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum VoiceSharingResponseModelReviewStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="not_requested")]
        NotRequested,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pending")]
        Pending,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="declined")]
        Declined,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="allowed")]
        Allowed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="allowed_with_changes")]
        AllowedWithChanges,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VoiceSharingResponseModelReviewStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoiceSharingResponseModelReviewStatus value)
        {
            return value switch
            {
                VoiceSharingResponseModelReviewStatus.NotRequested => "not_requested",
                VoiceSharingResponseModelReviewStatus.Pending => "pending",
                VoiceSharingResponseModelReviewStatus.Declined => "declined",
                VoiceSharingResponseModelReviewStatus.Allowed => "allowed",
                VoiceSharingResponseModelReviewStatus.AllowedWithChanges => "allowed_with_changes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoiceSharingResponseModelReviewStatus? ToEnum(string value)
        {
            return value switch
            {
                "not_requested" => VoiceSharingResponseModelReviewStatus.NotRequested,
                "pending" => VoiceSharingResponseModelReviewStatus.Pending,
                "declined" => VoiceSharingResponseModelReviewStatus.Declined,
                "allowed" => VoiceSharingResponseModelReviewStatus.Allowed,
                "allowed_with_changes" => VoiceSharingResponseModelReviewStatus.AllowedWithChanges,
                _ => null,
            };
        }
    }
}