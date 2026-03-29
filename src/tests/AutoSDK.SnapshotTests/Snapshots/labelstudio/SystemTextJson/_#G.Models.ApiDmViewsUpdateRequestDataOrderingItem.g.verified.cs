//HintName: G.Models.ApiDmViewsUpdateRequestDataOrderingItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ApiDmViewsUpdateRequestDataOrderingItem
    {
        /// <summary>
        /// 
        /// </summary>
        Tasks_agreement,
        /// <summary>
        /// 
        /// </summary>
        Tasks_annotationsResults,
        /// <summary>
        /// 
        /// </summary>
        Tasks_annotators,
        /// <summary>
        /// 
        /// </summary>
        Tasks_cancelledAnnotations,
        /// <summary>
        /// 
        /// </summary>
        Tasks_comments,
        /// <summary>
        /// 
        /// </summary>
        Tasks_completedAt,
        /// <summary>
        /// 
        /// </summary>
        Tasks_createdAt,
        /// <summary>
        /// 
        /// </summary>
        Tasks_fileUpload,
        /// <summary>
        /// 
        /// </summary>
        Tasks_groundTruth,
        /// <summary>
        /// 
        /// </summary>
        Tasks_id,
        /// <summary>
        /// 
        /// </summary>
        Tasks_innerId,
        /// <summary>
        /// 
        /// </summary>
        Tasks_predictionsModelVersions,
        /// <summary>
        /// 
        /// </summary>
        Tasks_predictionsResults,
        /// <summary>
        /// 
        /// </summary>
        Tasks_predictionsScore,
        /// <summary>
        /// 
        /// </summary>
        Tasks_reviewed,
        /// <summary>
        /// 
        /// </summary>
        Tasks_reviewers,
        /// <summary>
        /// 
        /// </summary>
        Tasks_reviewsAccepted,
        /// <summary>
        /// 
        /// </summary>
        Tasks_reviewsRejected,
        /// <summary>
        /// 
        /// </summary>
        Tasks_totalAnnotations,
        /// <summary>
        /// 
        /// </summary>
        Tasks_totalPredictions,
        /// <summary>
        /// 
        /// </summary>
        Tasks_unresolvedCommentCount,
        /// <summary>
        /// 
        /// </summary>
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