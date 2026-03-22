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
        AppPath,
        /// <summary>
        /// 
        /// </summary>
        ChildRunIds,
        /// <summary>
        /// 
        /// </summary>
        CompletionCost,
        /// <summary>
        /// 
        /// </summary>
        CompletionTokens,
        /// <summary>
        /// 
        /// </summary>
        DottedOrder,
        /// <summary>
        /// 
        /// </summary>
        EndTime,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        ErrorOrSignedUrl,
        /// <summary>
        /// 
        /// </summary>
        Events,
        /// <summary>
        /// 
        /// </summary>
        EventsOrSignedUrl,
        /// <summary>
        /// 
        /// </summary>
        Extra,
        /// <summary>
        /// 
        /// </summary>
        ExtraOrSignedUrl,
        /// <summary>
        /// 
        /// </summary>
        FeedbackStats,
        /// <summary>
        /// 
        /// </summary>
        FirstTokenTime,
        /// <summary>
        /// 
        /// </summary>
        Id,
        /// <summary>
        /// 
        /// </summary>
        InDataset,
        /// <summary>
        /// 
        /// </summary>
        Inputs,
        /// <summary>
        /// 
        /// </summary>
        InputsOrSignedUrl,
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
        LastQueuedAt,
        /// <summary>
        /// 
        /// </summary>
        Manifest,
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
        Name,
        /// <summary>
        /// 
        /// </summary>
        Outputs,
        /// <summary>
        /// 
        /// </summary>
        OutputsOrSignedUrl,
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
        ParentRunId,
        /// <summary>
        /// 
        /// </summary>
        ParentRunIds,
        /// <summary>
        /// 
        /// </summary>
        PriceModelId,
        /// <summary>
        /// 
        /// </summary>
        PromptCost,
        /// <summary>
        /// 
        /// </summary>
        PromptTokens,
        /// <summary>
        /// 
        /// </summary>
        ReferenceDatasetId,
        /// <summary>
        /// 
        /// </summary>
        ReferenceExampleId,
        /// <summary>
        /// 
        /// </summary>
        RunType,
        /// <summary>
        /// 
        /// </summary>
        S3Urls,
        /// <summary>
        /// 
        /// </summary>
        Serialized,
        /// <summary>
        /// 
        /// </summary>
        SerializedOrSignedUrl,
        /// <summary>
        /// 
        /// </summary>
        SessionId,
        /// <summary>
        /// 
        /// </summary>
        ShareToken,
        /// <summary>
        /// 
        /// </summary>
        StartTime,
        /// <summary>
        /// 
        /// </summary>
        Status,
        /// <summary>
        /// 
        /// </summary>
        Tags,
        /// <summary>
        /// 
        /// </summary>
        ThreadId,
        /// <summary>
        /// 
        /// </summary>
        TotalCost,
        /// <summary>
        /// 
        /// </summary>
        TotalTokens,
        /// <summary>
        /// 
        /// </summary>
        TraceFirstReceivedAt,
        /// <summary>
        /// 
        /// </summary>
        TraceId,
        /// <summary>
        /// 
        /// </summary>
        TraceTier,
        /// <summary>
        /// 
        /// </summary>
        TraceUpgrade,
        /// <summary>
        /// 
        /// </summary>
        TtlSeconds,
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
                RunSelect.AppPath => "app_path",
                RunSelect.ChildRunIds => "child_run_ids",
                RunSelect.CompletionCost => "completion_cost",
                RunSelect.CompletionTokens => "completion_tokens",
                RunSelect.DottedOrder => "dotted_order",
                RunSelect.EndTime => "end_time",
                RunSelect.Error => "error",
                RunSelect.ErrorOrSignedUrl => "error_or_signed_url",
                RunSelect.Events => "events",
                RunSelect.EventsOrSignedUrl => "events_or_signed_url",
                RunSelect.Extra => "extra",
                RunSelect.ExtraOrSignedUrl => "extra_or_signed_url",
                RunSelect.FeedbackStats => "feedback_stats",
                RunSelect.FirstTokenTime => "first_token_time",
                RunSelect.Id => "id",
                RunSelect.InDataset => "in_dataset",
                RunSelect.Inputs => "inputs",
                RunSelect.InputsOrSignedUrl => "inputs_or_signed_url",
                RunSelect.InputsPreview => "inputs_preview",
                RunSelect.InputsS3Urls => "inputs_s3_urls",
                RunSelect.LastQueuedAt => "last_queued_at",
                RunSelect.Manifest => "manifest",
                RunSelect.ManifestId => "manifest_id",
                RunSelect.ManifestS3Id => "manifest_s3_id",
                RunSelect.Name => "name",
                RunSelect.Outputs => "outputs",
                RunSelect.OutputsOrSignedUrl => "outputs_or_signed_url",
                RunSelect.OutputsPreview => "outputs_preview",
                RunSelect.OutputsS3Urls => "outputs_s3_urls",
                RunSelect.ParentRunId => "parent_run_id",
                RunSelect.ParentRunIds => "parent_run_ids",
                RunSelect.PriceModelId => "price_model_id",
                RunSelect.PromptCost => "prompt_cost",
                RunSelect.PromptTokens => "prompt_tokens",
                RunSelect.ReferenceDatasetId => "reference_dataset_id",
                RunSelect.ReferenceExampleId => "reference_example_id",
                RunSelect.RunType => "run_type",
                RunSelect.S3Urls => "s3_urls",
                RunSelect.Serialized => "serialized",
                RunSelect.SerializedOrSignedUrl => "serialized_or_signed_url",
                RunSelect.SessionId => "session_id",
                RunSelect.ShareToken => "share_token",
                RunSelect.StartTime => "start_time",
                RunSelect.Status => "status",
                RunSelect.Tags => "tags",
                RunSelect.ThreadId => "thread_id",
                RunSelect.TotalCost => "total_cost",
                RunSelect.TotalTokens => "total_tokens",
                RunSelect.TraceFirstReceivedAt => "trace_first_received_at",
                RunSelect.TraceId => "trace_id",
                RunSelect.TraceTier => "trace_tier",
                RunSelect.TraceUpgrade => "trace_upgrade",
                RunSelect.TtlSeconds => "ttl_seconds",
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
                "app_path" => RunSelect.AppPath,
                "child_run_ids" => RunSelect.ChildRunIds,
                "completion_cost" => RunSelect.CompletionCost,
                "completion_tokens" => RunSelect.CompletionTokens,
                "dotted_order" => RunSelect.DottedOrder,
                "end_time" => RunSelect.EndTime,
                "error" => RunSelect.Error,
                "error_or_signed_url" => RunSelect.ErrorOrSignedUrl,
                "events" => RunSelect.Events,
                "events_or_signed_url" => RunSelect.EventsOrSignedUrl,
                "extra" => RunSelect.Extra,
                "extra_or_signed_url" => RunSelect.ExtraOrSignedUrl,
                "feedback_stats" => RunSelect.FeedbackStats,
                "first_token_time" => RunSelect.FirstTokenTime,
                "id" => RunSelect.Id,
                "in_dataset" => RunSelect.InDataset,
                "inputs" => RunSelect.Inputs,
                "inputs_or_signed_url" => RunSelect.InputsOrSignedUrl,
                "inputs_preview" => RunSelect.InputsPreview,
                "inputs_s3_urls" => RunSelect.InputsS3Urls,
                "last_queued_at" => RunSelect.LastQueuedAt,
                "manifest" => RunSelect.Manifest,
                "manifest_id" => RunSelect.ManifestId,
                "manifest_s3_id" => RunSelect.ManifestS3Id,
                "name" => RunSelect.Name,
                "outputs" => RunSelect.Outputs,
                "outputs_or_signed_url" => RunSelect.OutputsOrSignedUrl,
                "outputs_preview" => RunSelect.OutputsPreview,
                "outputs_s3_urls" => RunSelect.OutputsS3Urls,
                "parent_run_id" => RunSelect.ParentRunId,
                "parent_run_ids" => RunSelect.ParentRunIds,
                "price_model_id" => RunSelect.PriceModelId,
                "prompt_cost" => RunSelect.PromptCost,
                "prompt_tokens" => RunSelect.PromptTokens,
                "reference_dataset_id" => RunSelect.ReferenceDatasetId,
                "reference_example_id" => RunSelect.ReferenceExampleId,
                "run_type" => RunSelect.RunType,
                "s3_urls" => RunSelect.S3Urls,
                "serialized" => RunSelect.Serialized,
                "serialized_or_signed_url" => RunSelect.SerializedOrSignedUrl,
                "session_id" => RunSelect.SessionId,
                "share_token" => RunSelect.ShareToken,
                "start_time" => RunSelect.StartTime,
                "status" => RunSelect.Status,
                "tags" => RunSelect.Tags,
                "thread_id" => RunSelect.ThreadId,
                "total_cost" => RunSelect.TotalCost,
                "total_tokens" => RunSelect.TotalTokens,
                "trace_first_received_at" => RunSelect.TraceFirstReceivedAt,
                "trace_id" => RunSelect.TraceId,
                "trace_tier" => RunSelect.TraceTier,
                "trace_upgrade" => RunSelect.TraceUpgrade,
                "ttl_seconds" => RunSelect.TtlSeconds,
                _ => null,
            };
        }
    }
}