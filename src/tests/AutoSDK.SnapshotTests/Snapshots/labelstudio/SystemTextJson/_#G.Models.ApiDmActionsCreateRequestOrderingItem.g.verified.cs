//HintName: G.Models.ApiDmActionsCreateRequestOrderingItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ApiDmActionsCreateRequestOrderingItem
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
    public static class ApiDmActionsCreateRequestOrderingItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiDmActionsCreateRequestOrderingItem value)
        {
            return value switch
            {
                ApiDmActionsCreateRequestOrderingItem.Tasks_agreement => "tasks:agreement",
                ApiDmActionsCreateRequestOrderingItem.Tasks_annotationsResults => "tasks:annotations_results",
                ApiDmActionsCreateRequestOrderingItem.Tasks_annotators => "tasks:annotators",
                ApiDmActionsCreateRequestOrderingItem.Tasks_cancelledAnnotations => "tasks:cancelled_annotations",
                ApiDmActionsCreateRequestOrderingItem.Tasks_comments => "tasks:comments",
                ApiDmActionsCreateRequestOrderingItem.Tasks_completedAt => "tasks:completed_at",
                ApiDmActionsCreateRequestOrderingItem.Tasks_createdAt => "tasks:created_at",
                ApiDmActionsCreateRequestOrderingItem.Tasks_fileUpload => "tasks:file_upload",
                ApiDmActionsCreateRequestOrderingItem.Tasks_groundTruth => "tasks:ground_truth",
                ApiDmActionsCreateRequestOrderingItem.Tasks_id => "tasks:id",
                ApiDmActionsCreateRequestOrderingItem.Tasks_innerId => "tasks:inner_id",
                ApiDmActionsCreateRequestOrderingItem.Tasks_predictionsModelVersions => "tasks:predictions_model_versions",
                ApiDmActionsCreateRequestOrderingItem.Tasks_predictionsResults => "tasks:predictions_results",
                ApiDmActionsCreateRequestOrderingItem.Tasks_predictionsScore => "tasks:predictions_score",
                ApiDmActionsCreateRequestOrderingItem.Tasks_reviewed => "tasks:reviewed",
                ApiDmActionsCreateRequestOrderingItem.Tasks_reviewers => "tasks:reviewers",
                ApiDmActionsCreateRequestOrderingItem.Tasks_reviewsAccepted => "tasks:reviews_accepted",
                ApiDmActionsCreateRequestOrderingItem.Tasks_reviewsRejected => "tasks:reviews_rejected",
                ApiDmActionsCreateRequestOrderingItem.Tasks_totalAnnotations => "tasks:total_annotations",
                ApiDmActionsCreateRequestOrderingItem.Tasks_totalPredictions => "tasks:total_predictions",
                ApiDmActionsCreateRequestOrderingItem.Tasks_unresolvedCommentCount => "tasks:unresolved_comment_count",
                ApiDmActionsCreateRequestOrderingItem.Tasks_updatedAt => "tasks:updated_at",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiDmActionsCreateRequestOrderingItem? ToEnum(string value)
        {
            return value switch
            {
                "tasks:agreement" => ApiDmActionsCreateRequestOrderingItem.Tasks_agreement,
                "tasks:annotations_results" => ApiDmActionsCreateRequestOrderingItem.Tasks_annotationsResults,
                "tasks:annotators" => ApiDmActionsCreateRequestOrderingItem.Tasks_annotators,
                "tasks:cancelled_annotations" => ApiDmActionsCreateRequestOrderingItem.Tasks_cancelledAnnotations,
                "tasks:comments" => ApiDmActionsCreateRequestOrderingItem.Tasks_comments,
                "tasks:completed_at" => ApiDmActionsCreateRequestOrderingItem.Tasks_completedAt,
                "tasks:created_at" => ApiDmActionsCreateRequestOrderingItem.Tasks_createdAt,
                "tasks:file_upload" => ApiDmActionsCreateRequestOrderingItem.Tasks_fileUpload,
                "tasks:ground_truth" => ApiDmActionsCreateRequestOrderingItem.Tasks_groundTruth,
                "tasks:id" => ApiDmActionsCreateRequestOrderingItem.Tasks_id,
                "tasks:inner_id" => ApiDmActionsCreateRequestOrderingItem.Tasks_innerId,
                "tasks:predictions_model_versions" => ApiDmActionsCreateRequestOrderingItem.Tasks_predictionsModelVersions,
                "tasks:predictions_results" => ApiDmActionsCreateRequestOrderingItem.Tasks_predictionsResults,
                "tasks:predictions_score" => ApiDmActionsCreateRequestOrderingItem.Tasks_predictionsScore,
                "tasks:reviewed" => ApiDmActionsCreateRequestOrderingItem.Tasks_reviewed,
                "tasks:reviewers" => ApiDmActionsCreateRequestOrderingItem.Tasks_reviewers,
                "tasks:reviews_accepted" => ApiDmActionsCreateRequestOrderingItem.Tasks_reviewsAccepted,
                "tasks:reviews_rejected" => ApiDmActionsCreateRequestOrderingItem.Tasks_reviewsRejected,
                "tasks:total_annotations" => ApiDmActionsCreateRequestOrderingItem.Tasks_totalAnnotations,
                "tasks:total_predictions" => ApiDmActionsCreateRequestOrderingItem.Tasks_totalPredictions,
                "tasks:unresolved_comment_count" => ApiDmActionsCreateRequestOrderingItem.Tasks_unresolvedCommentCount,
                "tasks:updated_at" => ApiDmActionsCreateRequestOrderingItem.Tasks_updatedAt,
                _ => null,
            };
        }
    }
}