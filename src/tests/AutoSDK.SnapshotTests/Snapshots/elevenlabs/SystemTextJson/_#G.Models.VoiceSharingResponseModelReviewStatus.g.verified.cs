//HintName: G.Models.VoiceSharingResponseModelReviewStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The review status of the voice.
    /// </summary>
    public enum VoiceSharingResponseModelReviewStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Allowed,
        /// <summary>
        /// 
        /// </summary>
        AllowedWithChanges,
        /// <summary>
        /// 
        /// </summary>
        Declined,
        /// <summary>
        /// 
        /// </summary>
        NotRequested,
        /// <summary>
        /// 
        /// </summary>
        Pending,
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
                VoiceSharingResponseModelReviewStatus.Allowed => "allowed",
                VoiceSharingResponseModelReviewStatus.AllowedWithChanges => "allowed_with_changes",
                VoiceSharingResponseModelReviewStatus.Declined => "declined",
                VoiceSharingResponseModelReviewStatus.NotRequested => "not_requested",
                VoiceSharingResponseModelReviewStatus.Pending => "pending",
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
                "allowed" => VoiceSharingResponseModelReviewStatus.Allowed,
                "allowed_with_changes" => VoiceSharingResponseModelReviewStatus.AllowedWithChanges,
                "declined" => VoiceSharingResponseModelReviewStatus.Declined,
                "not_requested" => VoiceSharingResponseModelReviewStatus.NotRequested,
                "pending" => VoiceSharingResponseModelReviewStatus.Pending,
                _ => null,
            };
        }
    }
}