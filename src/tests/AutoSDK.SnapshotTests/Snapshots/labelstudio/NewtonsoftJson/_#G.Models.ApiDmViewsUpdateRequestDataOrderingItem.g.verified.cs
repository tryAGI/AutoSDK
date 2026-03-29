//HintName: G.Models.ApiDmViewsUpdateRequestDataOrderingItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ApiDmViewsUpdateRequestDataOrderingItem
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
    public static class ApiDmViewsUpdateRequestDataOrderingItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiDmViewsUpdateRequestDataOrderingItem value)
        {
            return value switch
            {
                ApiDmViewsUpdateRequestDataOrderingItem.Tasks_agreement => "tasks:agreement",
                ApiDmViewsUpdateRequestDataOrderingItem.Tasks_annotationsResults => "tasks:annotations_results",
                ApiDmViewsUpdateRequestDataOrderingItem.Tasks_annotators => "tasks:annotators",
                ApiDmViewsUpdateRequestDataOrderingItem.Tasks_cancelledAnnotations => "tasks:cancelled_annotations",
                ApiDmViewsUpdateRequestDataOrderingItem.Tasks_comments => "tasks:comments",
                ApiDmViewsUpdateRequestDataOrderingItem.Tasks_completedAt => "tasks:completed_at",
                ApiDmViewsUpdateRequestDataOrderingItem.Tasks_createdAt => "tasks:created_at",
                ApiDmViewsUpdateRequestDataOrderingItem.Tasks_fileUpload => "tasks:file_upload",
                ApiDmViewsUpdateRequestDataOrderingItem.Tasks_groundTruth => "tasks:ground_truth",
                ApiDmViewsUpdateRequestDataOrderingItem.Tasks_id => "tasks:id",
                ApiDmViewsUpdateRequestDataOrderingItem.Tasks_innerId => "tasks:inner_id",
                ApiDmViewsUpdateRequestDataOrderingItem.Tasks_predictionsModelVersions => "tasks:predictions_model_versions",
                ApiDmViewsUpdateRequestDataOrderingItem.Tasks_predictionsResults => "tasks:predictions_results",
                ApiDmViewsUpdateRequestDataOrderingItem.Tasks_predictionsScore => "tasks:predictions_score",
                ApiDmViewsUpdateRequestDataOrderingItem.Tasks_reviewed => "tasks:reviewed",
                ApiDmViewsUpdateRequestDataOrderingItem.Tasks_reviewers => "tasks:reviewers",
                ApiDmViewsUpdateRequestDataOrderingItem.Tasks_reviewsAccepted => "tasks:reviews_accepted",
                ApiDmViewsUpdateRequestDataOrderingItem.Tasks_reviewsRejected => "tasks:reviews_rejected",
                ApiDmViewsUpdateRequestDataOrderingItem.Tasks_totalAnnotations => "tasks:total_annotations",
                ApiDmViewsUpdateRequestDataOrderingItem.Tasks_totalPredictions => "tasks:total_predictions",
                ApiDmViewsUpdateRequestDataOrderingItem.Tasks_unresolvedCommentCount => "tasks:unresolved_comment_count",
                ApiDmViewsUpdateRequestDataOrderingItem.Tasks_updatedAt => "tasks:updated_at",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiDmViewsUpdateRequestDataOrderingItem? ToEnum(string value)
        {
            return value switch
            {
                "tasks:agreement" => ApiDmViewsUpdateRequestDataOrderingItem.Tasks_agreement,
                "tasks:annotations_results" => ApiDmViewsUpdateRequestDataOrderingItem.Tasks_annotationsResults,
                "tasks:annotators" => ApiDmViewsUpdateRequestDataOrderingItem.Tasks_annotators,
                "tasks:cancelled_annotations" => ApiDmViewsUpdateRequestDataOrderingItem.Tasks_cancelledAnnotations,
                "tasks:comments" => ApiDmViewsUpdateRequestDataOrderingItem.Tasks_comments,
                "tasks:completed_at" => ApiDmViewsUpdateRequestDataOrderingItem.Tasks_completedAt,
                "tasks:created_at" => ApiDmViewsUpdateRequestDataOrderingItem.Tasks_createdAt,
                "tasks:file_upload" => ApiDmViewsUpdateRequestDataOrderingItem.Tasks_fileUpload,
                "tasks:ground_truth" => ApiDmViewsUpdateRequestDataOrderingItem.Tasks_groundTruth,
                "tasks:id" => ApiDmViewsUpdateRequestDataOrderingItem.Tasks_id,
                "tasks:inner_id" => ApiDmViewsUpdateRequestDataOrderingItem.Tasks_innerId,
                "tasks:predictions_model_versions" => ApiDmViewsUpdateRequestDataOrderingItem.Tasks_predictionsModelVersions,
                "tasks:predictions_results" => ApiDmViewsUpdateRequestDataOrderingItem.Tasks_predictionsResults,
                "tasks:predictions_score" => ApiDmViewsUpdateRequestDataOrderingItem.Tasks_predictionsScore,
                "tasks:reviewed" => ApiDmViewsUpdateRequestDataOrderingItem.Tasks_reviewed,
                "tasks:reviewers" => ApiDmViewsUpdateRequestDataOrderingItem.Tasks_reviewers,
                "tasks:reviews_accepted" => ApiDmViewsUpdateRequestDataOrderingItem.Tasks_reviewsAccepted,
                "tasks:reviews_rejected" => ApiDmViewsUpdateRequestDataOrderingItem.Tasks_reviewsRejected,
                "tasks:total_annotations" => ApiDmViewsUpdateRequestDataOrderingItem.Tasks_totalAnnotations,
                "tasks:total_predictions" => ApiDmViewsUpdateRequestDataOrderingItem.Tasks_totalPredictions,
                "tasks:unresolved_comment_count" => ApiDmViewsUpdateRequestDataOrderingItem.Tasks_unresolvedCommentCount,
                "tasks:updated_at" => ApiDmViewsUpdateRequestDataOrderingItem.Tasks_updatedAt,
                _ => null,
            };
        }
    }
}