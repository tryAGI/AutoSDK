//HintName: G.Models.ApiDmViewsCreateRequestDataOrderingItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ApiDmViewsCreateRequestDataOrderingItem
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
    public static class ApiDmViewsCreateRequestDataOrderingItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiDmViewsCreateRequestDataOrderingItem value)
        {
            return value switch
            {
                ApiDmViewsCreateRequestDataOrderingItem.Tasks_agreement => "tasks:agreement",
                ApiDmViewsCreateRequestDataOrderingItem.Tasks_annotationsResults => "tasks:annotations_results",
                ApiDmViewsCreateRequestDataOrderingItem.Tasks_annotators => "tasks:annotators",
                ApiDmViewsCreateRequestDataOrderingItem.Tasks_cancelledAnnotations => "tasks:cancelled_annotations",
                ApiDmViewsCreateRequestDataOrderingItem.Tasks_comments => "tasks:comments",
                ApiDmViewsCreateRequestDataOrderingItem.Tasks_completedAt => "tasks:completed_at",
                ApiDmViewsCreateRequestDataOrderingItem.Tasks_createdAt => "tasks:created_at",
                ApiDmViewsCreateRequestDataOrderingItem.Tasks_fileUpload => "tasks:file_upload",
                ApiDmViewsCreateRequestDataOrderingItem.Tasks_groundTruth => "tasks:ground_truth",
                ApiDmViewsCreateRequestDataOrderingItem.Tasks_id => "tasks:id",
                ApiDmViewsCreateRequestDataOrderingItem.Tasks_innerId => "tasks:inner_id",
                ApiDmViewsCreateRequestDataOrderingItem.Tasks_predictionsModelVersions => "tasks:predictions_model_versions",
                ApiDmViewsCreateRequestDataOrderingItem.Tasks_predictionsResults => "tasks:predictions_results",
                ApiDmViewsCreateRequestDataOrderingItem.Tasks_predictionsScore => "tasks:predictions_score",
                ApiDmViewsCreateRequestDataOrderingItem.Tasks_reviewed => "tasks:reviewed",
                ApiDmViewsCreateRequestDataOrderingItem.Tasks_reviewers => "tasks:reviewers",
                ApiDmViewsCreateRequestDataOrderingItem.Tasks_reviewsAccepted => "tasks:reviews_accepted",
                ApiDmViewsCreateRequestDataOrderingItem.Tasks_reviewsRejected => "tasks:reviews_rejected",
                ApiDmViewsCreateRequestDataOrderingItem.Tasks_totalAnnotations => "tasks:total_annotations",
                ApiDmViewsCreateRequestDataOrderingItem.Tasks_totalPredictions => "tasks:total_predictions",
                ApiDmViewsCreateRequestDataOrderingItem.Tasks_unresolvedCommentCount => "tasks:unresolved_comment_count",
                ApiDmViewsCreateRequestDataOrderingItem.Tasks_updatedAt => "tasks:updated_at",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiDmViewsCreateRequestDataOrderingItem? ToEnum(string value)
        {
            return value switch
            {
                "tasks:agreement" => ApiDmViewsCreateRequestDataOrderingItem.Tasks_agreement,
                "tasks:annotations_results" => ApiDmViewsCreateRequestDataOrderingItem.Tasks_annotationsResults,
                "tasks:annotators" => ApiDmViewsCreateRequestDataOrderingItem.Tasks_annotators,
                "tasks:cancelled_annotations" => ApiDmViewsCreateRequestDataOrderingItem.Tasks_cancelledAnnotations,
                "tasks:comments" => ApiDmViewsCreateRequestDataOrderingItem.Tasks_comments,
                "tasks:completed_at" => ApiDmViewsCreateRequestDataOrderingItem.Tasks_completedAt,
                "tasks:created_at" => ApiDmViewsCreateRequestDataOrderingItem.Tasks_createdAt,
                "tasks:file_upload" => ApiDmViewsCreateRequestDataOrderingItem.Tasks_fileUpload,
                "tasks:ground_truth" => ApiDmViewsCreateRequestDataOrderingItem.Tasks_groundTruth,
                "tasks:id" => ApiDmViewsCreateRequestDataOrderingItem.Tasks_id,
                "tasks:inner_id" => ApiDmViewsCreateRequestDataOrderingItem.Tasks_innerId,
                "tasks:predictions_model_versions" => ApiDmViewsCreateRequestDataOrderingItem.Tasks_predictionsModelVersions,
                "tasks:predictions_results" => ApiDmViewsCreateRequestDataOrderingItem.Tasks_predictionsResults,
                "tasks:predictions_score" => ApiDmViewsCreateRequestDataOrderingItem.Tasks_predictionsScore,
                "tasks:reviewed" => ApiDmViewsCreateRequestDataOrderingItem.Tasks_reviewed,
                "tasks:reviewers" => ApiDmViewsCreateRequestDataOrderingItem.Tasks_reviewers,
                "tasks:reviews_accepted" => ApiDmViewsCreateRequestDataOrderingItem.Tasks_reviewsAccepted,
                "tasks:reviews_rejected" => ApiDmViewsCreateRequestDataOrderingItem.Tasks_reviewsRejected,
                "tasks:total_annotations" => ApiDmViewsCreateRequestDataOrderingItem.Tasks_totalAnnotations,
                "tasks:total_predictions" => ApiDmViewsCreateRequestDataOrderingItem.Tasks_totalPredictions,
                "tasks:unresolved_comment_count" => ApiDmViewsCreateRequestDataOrderingItem.Tasks_unresolvedCommentCount,
                "tasks:updated_at" => ApiDmViewsCreateRequestDataOrderingItem.Tasks_updatedAt,
                _ => null,
            };
        }
    }
}