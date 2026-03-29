//HintName: G.Models.ApiDmViewsPartialUpdateRequestDataOrderingItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ApiDmViewsPartialUpdateRequestDataOrderingItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tasks:agreement")]
        Tasks_agreement,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tasks:annotations_results")]
        Tasks_annotationsResults,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tasks:annotators")]
        Tasks_annotators,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tasks:cancelled_annotations")]
        Tasks_cancelledAnnotations,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tasks:comments")]
        Tasks_comments,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tasks:completed_at")]
        Tasks_completedAt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tasks:created_at")]
        Tasks_createdAt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tasks:file_upload")]
        Tasks_fileUpload,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tasks:ground_truth")]
        Tasks_groundTruth,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tasks:id")]
        Tasks_id,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tasks:inner_id")]
        Tasks_innerId,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tasks:predictions_model_versions")]
        Tasks_predictionsModelVersions,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tasks:predictions_results")]
        Tasks_predictionsResults,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tasks:predictions_score")]
        Tasks_predictionsScore,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tasks:reviewed")]
        Tasks_reviewed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tasks:reviewers")]
        Tasks_reviewers,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tasks:reviews_accepted")]
        Tasks_reviewsAccepted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tasks:reviews_rejected")]
        Tasks_reviewsRejected,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tasks:total_annotations")]
        Tasks_totalAnnotations,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tasks:total_predictions")]
        Tasks_totalPredictions,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tasks:unresolved_comment_count")]
        Tasks_unresolvedCommentCount,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tasks:updated_at")]
        Tasks_updatedAt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApiDmViewsPartialUpdateRequestDataOrderingItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiDmViewsPartialUpdateRequestDataOrderingItem value)
        {
            return value switch
            {
                ApiDmViewsPartialUpdateRequestDataOrderingItem.Tasks_agreement => "tasks:agreement",
                ApiDmViewsPartialUpdateRequestDataOrderingItem.Tasks_annotationsResults => "tasks:annotations_results",
                ApiDmViewsPartialUpdateRequestDataOrderingItem.Tasks_annotators => "tasks:annotators",
                ApiDmViewsPartialUpdateRequestDataOrderingItem.Tasks_cancelledAnnotations => "tasks:cancelled_annotations",
                ApiDmViewsPartialUpdateRequestDataOrderingItem.Tasks_comments => "tasks:comments",
                ApiDmViewsPartialUpdateRequestDataOrderingItem.Tasks_completedAt => "tasks:completed_at",
                ApiDmViewsPartialUpdateRequestDataOrderingItem.Tasks_createdAt => "tasks:created_at",
                ApiDmViewsPartialUpdateRequestDataOrderingItem.Tasks_fileUpload => "tasks:file_upload",
                ApiDmViewsPartialUpdateRequestDataOrderingItem.Tasks_groundTruth => "tasks:ground_truth",
                ApiDmViewsPartialUpdateRequestDataOrderingItem.Tasks_id => "tasks:id",
                ApiDmViewsPartialUpdateRequestDataOrderingItem.Tasks_innerId => "tasks:inner_id",
                ApiDmViewsPartialUpdateRequestDataOrderingItem.Tasks_predictionsModelVersions => "tasks:predictions_model_versions",
                ApiDmViewsPartialUpdateRequestDataOrderingItem.Tasks_predictionsResults => "tasks:predictions_results",
                ApiDmViewsPartialUpdateRequestDataOrderingItem.Tasks_predictionsScore => "tasks:predictions_score",
                ApiDmViewsPartialUpdateRequestDataOrderingItem.Tasks_reviewed => "tasks:reviewed",
                ApiDmViewsPartialUpdateRequestDataOrderingItem.Tasks_reviewers => "tasks:reviewers",
                ApiDmViewsPartialUpdateRequestDataOrderingItem.Tasks_reviewsAccepted => "tasks:reviews_accepted",
                ApiDmViewsPartialUpdateRequestDataOrderingItem.Tasks_reviewsRejected => "tasks:reviews_rejected",
                ApiDmViewsPartialUpdateRequestDataOrderingItem.Tasks_totalAnnotations => "tasks:total_annotations",
                ApiDmViewsPartialUpdateRequestDataOrderingItem.Tasks_totalPredictions => "tasks:total_predictions",
                ApiDmViewsPartialUpdateRequestDataOrderingItem.Tasks_unresolvedCommentCount => "tasks:unresolved_comment_count",
                ApiDmViewsPartialUpdateRequestDataOrderingItem.Tasks_updatedAt => "tasks:updated_at",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiDmViewsPartialUpdateRequestDataOrderingItem? ToEnum(string value)
        {
            return value switch
            {
                "tasks:agreement" => ApiDmViewsPartialUpdateRequestDataOrderingItem.Tasks_agreement,
                "tasks:annotations_results" => ApiDmViewsPartialUpdateRequestDataOrderingItem.Tasks_annotationsResults,
                "tasks:annotators" => ApiDmViewsPartialUpdateRequestDataOrderingItem.Tasks_annotators,
                "tasks:cancelled_annotations" => ApiDmViewsPartialUpdateRequestDataOrderingItem.Tasks_cancelledAnnotations,
                "tasks:comments" => ApiDmViewsPartialUpdateRequestDataOrderingItem.Tasks_comments,
                "tasks:completed_at" => ApiDmViewsPartialUpdateRequestDataOrderingItem.Tasks_completedAt,
                "tasks:created_at" => ApiDmViewsPartialUpdateRequestDataOrderingItem.Tasks_createdAt,
                "tasks:file_upload" => ApiDmViewsPartialUpdateRequestDataOrderingItem.Tasks_fileUpload,
                "tasks:ground_truth" => ApiDmViewsPartialUpdateRequestDataOrderingItem.Tasks_groundTruth,
                "tasks:id" => ApiDmViewsPartialUpdateRequestDataOrderingItem.Tasks_id,
                "tasks:inner_id" => ApiDmViewsPartialUpdateRequestDataOrderingItem.Tasks_innerId,
                "tasks:predictions_model_versions" => ApiDmViewsPartialUpdateRequestDataOrderingItem.Tasks_predictionsModelVersions,
                "tasks:predictions_results" => ApiDmViewsPartialUpdateRequestDataOrderingItem.Tasks_predictionsResults,
                "tasks:predictions_score" => ApiDmViewsPartialUpdateRequestDataOrderingItem.Tasks_predictionsScore,
                "tasks:reviewed" => ApiDmViewsPartialUpdateRequestDataOrderingItem.Tasks_reviewed,
                "tasks:reviewers" => ApiDmViewsPartialUpdateRequestDataOrderingItem.Tasks_reviewers,
                "tasks:reviews_accepted" => ApiDmViewsPartialUpdateRequestDataOrderingItem.Tasks_reviewsAccepted,
                "tasks:reviews_rejected" => ApiDmViewsPartialUpdateRequestDataOrderingItem.Tasks_reviewsRejected,
                "tasks:total_annotations" => ApiDmViewsPartialUpdateRequestDataOrderingItem.Tasks_totalAnnotations,
                "tasks:total_predictions" => ApiDmViewsPartialUpdateRequestDataOrderingItem.Tasks_totalPredictions,
                "tasks:unresolved_comment_count" => ApiDmViewsPartialUpdateRequestDataOrderingItem.Tasks_unresolvedCommentCount,
                "tasks:updated_at" => ApiDmViewsPartialUpdateRequestDataOrderingItem.Tasks_updatedAt,
                _ => null,
            };
        }
    }
}