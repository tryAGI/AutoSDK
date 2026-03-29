//HintName: G.Models.ApiDmActionsCreateId.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ApiDmActionsCreateId
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="delete_annotators")]
        DeleteAnnotators,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="delete_ground_truths")]
        DeleteGroundTruths,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="delete_reviewers")]
        DeleteReviewers,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="delete_tasks")]
        DeleteTasks,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="delete_tasks_annotations")]
        DeleteTasksAnnotations,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="delete_tasks_predictions")]
        DeleteTasksPredictions,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="delete_tasks_reviews")]
        DeleteTasksReviews,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="predictions_to_annotations")]
        PredictionsToAnnotations,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="remove_duplicates")]
        RemoveDuplicates,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="retrieve_tasks_predictions")]
        RetrieveTasksPredictions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApiDmActionsCreateIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiDmActionsCreateId value)
        {
            return value switch
            {
                ApiDmActionsCreateId.DeleteAnnotators => "delete_annotators",
                ApiDmActionsCreateId.DeleteGroundTruths => "delete_ground_truths",
                ApiDmActionsCreateId.DeleteReviewers => "delete_reviewers",
                ApiDmActionsCreateId.DeleteTasks => "delete_tasks",
                ApiDmActionsCreateId.DeleteTasksAnnotations => "delete_tasks_annotations",
                ApiDmActionsCreateId.DeleteTasksPredictions => "delete_tasks_predictions",
                ApiDmActionsCreateId.DeleteTasksReviews => "delete_tasks_reviews",
                ApiDmActionsCreateId.PredictionsToAnnotations => "predictions_to_annotations",
                ApiDmActionsCreateId.RemoveDuplicates => "remove_duplicates",
                ApiDmActionsCreateId.RetrieveTasksPredictions => "retrieve_tasks_predictions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiDmActionsCreateId? ToEnum(string value)
        {
            return value switch
            {
                "delete_annotators" => ApiDmActionsCreateId.DeleteAnnotators,
                "delete_ground_truths" => ApiDmActionsCreateId.DeleteGroundTruths,
                "delete_reviewers" => ApiDmActionsCreateId.DeleteReviewers,
                "delete_tasks" => ApiDmActionsCreateId.DeleteTasks,
                "delete_tasks_annotations" => ApiDmActionsCreateId.DeleteTasksAnnotations,
                "delete_tasks_predictions" => ApiDmActionsCreateId.DeleteTasksPredictions,
                "delete_tasks_reviews" => ApiDmActionsCreateId.DeleteTasksReviews,
                "predictions_to_annotations" => ApiDmActionsCreateId.PredictionsToAnnotations,
                "remove_duplicates" => ApiDmActionsCreateId.RemoveDuplicates,
                "retrieve_tasks_predictions" => ApiDmActionsCreateId.RetrieveTasksPredictions,
                _ => null,
            };
        }
    }
}