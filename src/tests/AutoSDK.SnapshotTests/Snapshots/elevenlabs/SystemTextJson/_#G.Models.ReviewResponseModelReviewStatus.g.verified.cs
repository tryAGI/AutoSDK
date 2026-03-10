//HintName: G.Models.ReviewResponseModelReviewStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReviewResponseModelReviewStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Approved,
        /// <summary>
        /// 
        /// </summary>
        EditsRequired,
        /// <summary>
        /// 
        /// </summary>
        Rejected,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReviewResponseModelReviewStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReviewResponseModelReviewStatus value)
        {
            return value switch
            {
                ReviewResponseModelReviewStatus.Approved => "approved",
                ReviewResponseModelReviewStatus.EditsRequired => "edits_required",
                ReviewResponseModelReviewStatus.Rejected => "rejected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReviewResponseModelReviewStatus? ToEnum(string value)
        {
            return value switch
            {
                "approved" => ReviewResponseModelReviewStatus.Approved,
                "edits_required" => ReviewResponseModelReviewStatus.EditsRequired,
                "rejected" => ReviewResponseModelReviewStatus.Rejected,
                _ => null,
            };
        }
    }
}