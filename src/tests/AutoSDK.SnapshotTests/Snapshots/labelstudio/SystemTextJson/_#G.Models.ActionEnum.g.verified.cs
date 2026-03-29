//HintName: G.Models.ActionEnum.g.cs

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
    public enum ActionEnum
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
    public static class ActionEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActionEnum value)
        {
            return value switch
            {
                ActionEnum.Accepted => "accepted",
                ActionEnum.DeletedReview => "deleted_review",
                ActionEnum.FixedAndAccepted => "fixed_and_accepted",
                ActionEnum.Imported => "imported",
                ActionEnum.Prediction => "prediction",
                ActionEnum.PropagatedAnnotation => "propagated_annotation",
                ActionEnum.Rejected => "rejected",
                ActionEnum.Skipped => "skipped",
                ActionEnum.Submitted => "submitted",
                ActionEnum.Updated => "updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActionEnum? ToEnum(string value)
        {
            return value switch
            {
                "accepted" => ActionEnum.Accepted,
                "deleted_review" => ActionEnum.DeletedReview,
                "fixed_and_accepted" => ActionEnum.FixedAndAccepted,
                "imported" => ActionEnum.Imported,
                "prediction" => ActionEnum.Prediction,
                "propagated_annotation" => ActionEnum.PropagatedAnnotation,
                "rejected" => ActionEnum.Rejected,
                "skipped" => ActionEnum.Skipped,
                "submitted" => ActionEnum.Submitted,
                "updated" => ActionEnum.Updated,
                _ => null,
            };
        }
    }
}