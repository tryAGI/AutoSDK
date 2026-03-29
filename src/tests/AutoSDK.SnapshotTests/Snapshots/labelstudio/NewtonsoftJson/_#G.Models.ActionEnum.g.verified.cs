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
    [global::System.Runtime.Serialization.DataContract]
    public enum ActionEnum
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="accepted")]
        Accepted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="deleted_review")]
        DeletedReview,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fixed_and_accepted")]
        FixedAndAccepted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="imported")]
        Imported,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="prediction")]
        Prediction,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="propagated_annotation")]
        PropagatedAnnotation,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rejected")]
        Rejected,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="skipped")]
        Skipped,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="submitted")]
        Submitted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="updated")]
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