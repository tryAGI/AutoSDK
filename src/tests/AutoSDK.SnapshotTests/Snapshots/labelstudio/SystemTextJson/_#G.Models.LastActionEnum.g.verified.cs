//HintName: G.Models.LastActionEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// * `prediction` - Created from prediction<br/>
    /// * `propagated_annotation` - Created from another annotation<br/>
    /// * `imported` - Imported<br/>
    /// * `submitted` - Submitted<br/>
    /// * `updated` - Updated<br/>
    /// * `skipped` - Skipped<br/>
    /// * `accepted` - Accepted<br/>
    /// * `rejected` - Rejected<br/>
    /// * `fixed_and_accepted` - Fixed and accepted<br/>
    /// * `deleted_review` - Deleted review
    /// </summary>
    public enum LastActionEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Accepted,
        /// <summary>
        /// 
        /// </summary>
        DeletedReview,
        /// <summary>
        /// 
        /// </summary>
        FixedAndAccepted,
        /// <summary>
        /// 
        /// </summary>
        Imported,
        /// <summary>
        /// 
        /// </summary>
        Prediction,
        /// <summary>
        /// 
        /// </summary>
        PropagatedAnnotation,
        /// <summary>
        /// 
        /// </summary>
        Rejected,
        /// <summary>
        /// 
        /// </summary>
        Skipped,
        /// <summary>
        /// 
        /// </summary>
        Submitted,
        /// <summary>
        /// 
        /// </summary>
        Updated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LastActionEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LastActionEnum value)
        {
            return value switch
            {
                LastActionEnum.Accepted => "accepted",
                LastActionEnum.DeletedReview => "deleted_review",
                LastActionEnum.FixedAndAccepted => "fixed_and_accepted",
                LastActionEnum.Imported => "imported",
                LastActionEnum.Prediction => "prediction",
                LastActionEnum.PropagatedAnnotation => "propagated_annotation",
                LastActionEnum.Rejected => "rejected",
                LastActionEnum.Skipped => "skipped",
                LastActionEnum.Submitted => "submitted",
                LastActionEnum.Updated => "updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LastActionEnum? ToEnum(string value)
        {
            return value switch
            {
                "accepted" => LastActionEnum.Accepted,
                "deleted_review" => LastActionEnum.DeletedReview,
                "fixed_and_accepted" => LastActionEnum.FixedAndAccepted,
                "imported" => LastActionEnum.Imported,
                "prediction" => LastActionEnum.Prediction,
                "propagated_annotation" => LastActionEnum.PropagatedAnnotation,
                "rejected" => LastActionEnum.Rejected,
                "skipped" => LastActionEnum.Skipped,
                "submitted" => LastActionEnum.Submitted,
                "updated" => LastActionEnum.Updated,
                _ => null,
            };
        }
    }
}