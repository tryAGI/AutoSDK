//HintName: G.Models.RunSelect.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Enum for available run columns.
    /// </summary>
    public enum RunSelect
    {
        /// <summary>
        /// 
        /// </summary>
        Id,
        /// <summary>
        /// 
        /// </summary>
        Name,
        /// <summary>
        /// 
        /// </summary>
        RunType,
        /// <summary>
        /// 
        /// </summary>
        StartTime,
        /// <summary>
        /// 
        /// </summary>
        EndTime,
        /// <summary>
        /// 
        /// </summary>
        Status,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Extra,
        /// <summary>
        /// 
        /// </summary>
        Events,
        /// <summary>
        /// 
        /// </summary>
        Inputs,
        /// <summary>
        /// 
        /// </summary>
        InputsPreview,
        /// <summary>
        /// 
        /// </summary>
        InputsS3Urls,
        /// <summary>
        /// 
        /// </summary>
        InputsOrSignedUrl,
        /// <summary>
        /// 
        /// </summary>
        Outputs,
        /// <summary>
        /// 
        /// </summary>
        OutputsPreview,
        /// <summary>
        /// 
        /// </summary>
        OutputsS3Urls,
        /// <summary>
        /// 
        /// </summary>
        OutputsOrSignedUrl,
        /// <summary>
        /// 
        /// </summary>
        S3Urls,
        /// <summary>
        /// 
        /// </summary>
        ErrorOrSignedUrl,
        /// <summary>
        /// 
        /// </summary>
        ParentRunId,
        /// <summary>
        /// 
        /// </summary>
        ManifestId,
        /// <summary>
        /// 
        /// </summary>
        ManifestS3Id,
        /// <summary>
        /// 
        /// </summary>
        SessionId,
        /// <summary>
        /// 
        /// </summary>
        Serialized,
        /// <summary>
        /// 
        /// </summary>
        ReferenceExampleId,
        /// <summary>
        /// 
        /// </summary>
        TotalTokens,
        /// <summary>
        /// 
        /// </summary>
        PromptTokens,
        /// <summary>
        /// 
        /// </summary>
        CompletionTokens,
        /// <summary>
        /// 
        /// </summary>
        TotalCost,
        /// <summary>
        /// 
        /// </summary>
        PromptCost,
        /// <summary>
        /// 
        /// </summary>
        CompletionCost,
        /// <summary>
        /// 
        /// </summary>
        PriceModelId,
        /// <summary>
        /// 
        /// </summary>
        FirstTokenTime,
        /// <summary>
        /// 
        /// </summary>
        TraceId,
        /// <summary>
        /// 
        /// </summary>
        DottedOrder,
        /// <summary>
        /// 
        /// </summary>
        LastQueuedAt,
        /// <summary>
        /// 
        /// </summary>
        FeedbackStats,
        /// <summary>
        /// 
        /// </summary>
        ChildRunIds,
        /// <summary>
        /// 
        /// </summary>
        ParentRunIds,
        /// <summary>
        /// 
        /// </summary>
        Tags,
        /// <summary>
        /// 
        /// </summary>
        InDataset,
        /// <summary>
        /// 
        /// </summary>
        AppPath,
        /// <summary>
        /// 
        /// </summary>
        ShareToken,
        /// <summary>
        /// 
        /// </summary>
        TraceTier,
        /// <summary>
        /// 
        /// </summary>
        TraceFirstReceivedAt,
        /// <summary>
        /// 
        /// </summary>
        TtlSeconds,
        /// <summary>
        /// 
        /// </summary>
        TraceUpgrade,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunSelectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunSelect value)
        {
            return value switch
            {
                RunSelect.Id => "id",
                RunSelect.Name => "name",
                RunSelect.RunType => "run_type",
                RunSelect.StartTime => "start_time",
                RunSelect.EndTime => "end_time",
                RunSelect.Status => "status",
                RunSelect.Error => "error",
                RunSelect.Extra => "extra",
                RunSelect.Events => "events",
                RunSelect.Inputs => "inputs",
                RunSelect.InputsPreview => "inputs_preview",
                RunSelect.InputsS3Urls => "inputs_s3_urls",
                RunSelect.InputsOrSignedUrl => "inputs_or_signed_url",
                RunSelect.Outputs => "outputs",
                RunSelect.OutputsPreview => "outputs_preview",
                RunSelect.OutputsS3Urls => "outputs_s3_urls",
                RunSelect.OutputsOrSignedUrl => "outputs_or_signed_url",
                RunSelect.S3Urls => "s3_urls",
                RunSelect.ErrorOrSignedUrl => "error_or_signed_url",
                RunSelect.ParentRunId => "parent_run_id",
                RunSelect.ManifestId => "manifest_id",
                RunSelect.ManifestS3Id => "manifest_s3_id",
                RunSelect.SessionId => "session_id",
                RunSelect.Serialized => "serialized",
                RunSelect.ReferenceExampleId => "reference_example_id",
                RunSelect.TotalTokens => "total_tokens",
                RunSelect.PromptTokens => "prompt_tokens",
                RunSelect.CompletionTokens => "completion_tokens",
                RunSelect.TotalCost => "total_cost",
                RunSelect.PromptCost => "prompt_cost",
                RunSelect.CompletionCost => "completion_cost",
                RunSelect.PriceModelId => "price_model_id",
                RunSelect.FirstTokenTime => "first_token_time",
                RunSelect.TraceId => "trace_id",
                RunSelect.DottedOrder => "dotted_order",
                RunSelect.LastQueuedAt => "last_queued_at",
                RunSelect.FeedbackStats => "feedback_stats",
                RunSelect.ChildRunIds => "child_run_ids",
                RunSelect.ParentRunIds => "parent_run_ids",
                RunSelect.Tags => "tags",
                RunSelect.InDataset => "in_dataset",
                RunSelect.AppPath => "app_path",
                RunSelect.ShareToken => "share_token",
                RunSelect.TraceTier => "trace_tier",
                RunSelect.TraceFirstReceivedAt => "trace_first_received_at",
                RunSelect.TtlSeconds => "ttl_seconds",
                RunSelect.TraceUpgrade => "trace_upgrade",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunSelect? ToEnum(string value)
        {
            return value switch
            {
                "id" => RunSelect.Id,
                "name" => RunSelect.Name,
                "run_type" => RunSelect.RunType,
                "start_time" => RunSelect.StartTime,
                "end_time" => RunSelect.EndTime,
                "status" => RunSelect.Status,
                "error" => RunSelect.Error,
                "extra" => RunSelect.Extra,
                "events" => RunSelect.Events,
                "inputs" => RunSelect.Inputs,
                "inputs_preview" => RunSelect.InputsPreview,
                "inputs_s3_urls" => RunSelect.InputsS3Urls,
                "inputs_or_signed_url" => RunSelect.InputsOrSignedUrl,
                "outputs" => RunSelect.Outputs,
                "outputs_preview" => RunSelect.OutputsPreview,
                "outputs_s3_urls" => RunSelect.OutputsS3Urls,
                "outputs_or_signed_url" => RunSelect.OutputsOrSignedUrl,
                "s3_urls" => RunSelect.S3Urls,
                "error_or_signed_url" => RunSelect.ErrorOrSignedUrl,
                "parent_run_id" => RunSelect.ParentRunId,
                "manifest_id" => RunSelect.ManifestId,
                "manifest_s3_id" => RunSelect.ManifestS3Id,
                "session_id" => RunSelect.SessionId,
                "serialized" => RunSelect.Serialized,
                "reference_example_id" => RunSelect.ReferenceExampleId,
                "total_tokens" => RunSelect.TotalTokens,
                "prompt_tokens" => RunSelect.PromptTokens,
                "completion_tokens" => RunSelect.CompletionTokens,
                "total_cost" => RunSelect.TotalCost,
                "prompt_cost" => RunSelect.PromptCost,
                "completion_cost" => RunSelect.CompletionCost,
                "price_model_id" => RunSelect.PriceModelId,
                "first_token_time" => RunSelect.FirstTokenTime,
                "trace_id" => RunSelect.TraceId,
                "dotted_order" => RunSelect.DottedOrder,
                "last_queued_at" => RunSelect.LastQueuedAt,
                "feedback_stats" => RunSelect.FeedbackStats,
                "child_run_ids" => RunSelect.ChildRunIds,
                "parent_run_ids" => RunSelect.ParentRunIds,
                "tags" => RunSelect.Tags,
                "in_dataset" => RunSelect.InDataset,
                "app_path" => RunSelect.AppPath,
                "share_token" => RunSelect.ShareToken,
                "trace_tier" => RunSelect.TraceTier,
                "trace_first_received_at" => RunSelect.TraceFirstReceivedAt,
                "ttl_seconds" => RunSelect.TtlSeconds,
                "trace_upgrade" => RunSelect.TraceUpgrade,
                _ => null,
            };
        }
    }
}