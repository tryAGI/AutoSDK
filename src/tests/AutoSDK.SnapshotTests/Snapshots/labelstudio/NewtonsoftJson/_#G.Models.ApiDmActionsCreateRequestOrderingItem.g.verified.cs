//HintName: G.Models.ApiDmActionsCreateRequestOrderingItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ApiDmActionsCreateRequestOrderingItem
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