//HintName: G.Models.ApiDmViewsPartialUpdateRequestDataOrderingItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ApiDmViewsPartialUpdateRequestDataOrderingItem
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