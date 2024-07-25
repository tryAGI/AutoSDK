//HintName: G.Models.BodyParamsForRunSchemaSelect.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Enum for available run columns.
    /// </summary>
    public enum BodyParamsForRunSchemaSelect
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
    public static class BodyParamsForRunSchemaSelectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyParamsForRunSchemaSelect value)
        {
            return value switch
            {
                BodyParamsForRunSchemaSelect.Id => "id",
                BodyParamsForRunSchemaSelect.Name => "name",
                BodyParamsForRunSchemaSelect.RunType => "run_type",
                BodyParamsForRunSchemaSelect.StartTime => "start_time",
                BodyParamsForRunSchemaSelect.EndTime => "end_time",
                BodyParamsForRunSchemaSelect.Status => "status",
                BodyParamsForRunSchemaSelect.Error => "error",
                BodyParamsForRunSchemaSelect.Extra => "extra",
                BodyParamsForRunSchemaSelect.Events => "events",
                BodyParamsForRunSchemaSelect.Inputs => "inputs",
                BodyParamsForRunSchemaSelect.InputsS3Urls => "inputs_s3_urls",
                BodyParamsForRunSchemaSelect.InputsOrSignedUrl => "inputs_or_signed_url",
                BodyParamsForRunSchemaSelect.Outputs => "outputs",
                BodyParamsForRunSchemaSelect.OutputsS3Urls => "outputs_s3_urls",
                BodyParamsForRunSchemaSelect.OutputsOrSignedUrl => "outputs_or_signed_url",
                BodyParamsForRunSchemaSelect.S3Urls => "s3_urls",
                BodyParamsForRunSchemaSelect.ErrorOrSignedUrl => "error_or_signed_url",
                BodyParamsForRunSchemaSelect.ParentRunId => "parent_run_id",
                BodyParamsForRunSchemaSelect.ManifestId => "manifest_id",
                BodyParamsForRunSchemaSelect.ManifestS3Id => "manifest_s3_id",
                BodyParamsForRunSchemaSelect.SessionId => "session_id",
                BodyParamsForRunSchemaSelect.Serialized => "serialized",
                BodyParamsForRunSchemaSelect.ReferenceExampleId => "reference_example_id",
                BodyParamsForRunSchemaSelect.TotalTokens => "total_tokens",
                BodyParamsForRunSchemaSelect.PromptTokens => "prompt_tokens",
                BodyParamsForRunSchemaSelect.CompletionTokens => "completion_tokens",
                BodyParamsForRunSchemaSelect.TotalCost => "total_cost",
                BodyParamsForRunSchemaSelect.PromptCost => "prompt_cost",
                BodyParamsForRunSchemaSelect.CompletionCost => "completion_cost",
                BodyParamsForRunSchemaSelect.PriceModelId => "price_model_id",
                BodyParamsForRunSchemaSelect.FirstTokenTime => "first_token_time",
                BodyParamsForRunSchemaSelect.TraceId => "trace_id",
                BodyParamsForRunSchemaSelect.DottedOrder => "dotted_order",
                BodyParamsForRunSchemaSelect.LastQueuedAt => "last_queued_at",
                BodyParamsForRunSchemaSelect.FeedbackStats => "feedback_stats",
                BodyParamsForRunSchemaSelect.ChildRunIds => "child_run_ids",
                BodyParamsForRunSchemaSelect.ParentRunIds => "parent_run_ids",
                BodyParamsForRunSchemaSelect.Tags => "tags",
                BodyParamsForRunSchemaSelect.InDataset => "in_dataset",
                BodyParamsForRunSchemaSelect.AppPath => "app_path",
                BodyParamsForRunSchemaSelect.ShareToken => "share_token",
                BodyParamsForRunSchemaSelect.TraceTier => "trace_tier",
                BodyParamsForRunSchemaSelect.TraceFirstReceivedAt => "trace_first_received_at",
                BodyParamsForRunSchemaSelect.TtlSeconds => "ttl_seconds",
                BodyParamsForRunSchemaSelect.TraceUpgrade => "trace_upgrade",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyParamsForRunSchemaSelect? ToEnum(string value)
        {
            return value switch
            {
                "id" => BodyParamsForRunSchemaSelect.Id,
                "name" => BodyParamsForRunSchemaSelect.Name,
                "run_type" => BodyParamsForRunSchemaSelect.RunType,
                "start_time" => BodyParamsForRunSchemaSelect.StartTime,
                "end_time" => BodyParamsForRunSchemaSelect.EndTime,
                "status" => BodyParamsForRunSchemaSelect.Status,
                "error" => BodyParamsForRunSchemaSelect.Error,
                "extra" => BodyParamsForRunSchemaSelect.Extra,
                "events" => BodyParamsForRunSchemaSelect.Events,
                "inputs" => BodyParamsForRunSchemaSelect.Inputs,
                "inputs_s3_urls" => BodyParamsForRunSchemaSelect.InputsS3Urls,
                "inputs_or_signed_url" => BodyParamsForRunSchemaSelect.InputsOrSignedUrl,
                "outputs" => BodyParamsForRunSchemaSelect.Outputs,
                "outputs_s3_urls" => BodyParamsForRunSchemaSelect.OutputsS3Urls,
                "outputs_or_signed_url" => BodyParamsForRunSchemaSelect.OutputsOrSignedUrl,
                "s3_urls" => BodyParamsForRunSchemaSelect.S3Urls,
                "error_or_signed_url" => BodyParamsForRunSchemaSelect.ErrorOrSignedUrl,
                "parent_run_id" => BodyParamsForRunSchemaSelect.ParentRunId,
                "manifest_id" => BodyParamsForRunSchemaSelect.ManifestId,
                "manifest_s3_id" => BodyParamsForRunSchemaSelect.ManifestS3Id,
                "session_id" => BodyParamsForRunSchemaSelect.SessionId,
                "serialized" => BodyParamsForRunSchemaSelect.Serialized,
                "reference_example_id" => BodyParamsForRunSchemaSelect.ReferenceExampleId,
                "total_tokens" => BodyParamsForRunSchemaSelect.TotalTokens,
                "prompt_tokens" => BodyParamsForRunSchemaSelect.PromptTokens,
                "completion_tokens" => BodyParamsForRunSchemaSelect.CompletionTokens,
                "total_cost" => BodyParamsForRunSchemaSelect.TotalCost,
                "prompt_cost" => BodyParamsForRunSchemaSelect.PromptCost,
                "completion_cost" => BodyParamsForRunSchemaSelect.CompletionCost,
                "price_model_id" => BodyParamsForRunSchemaSelect.PriceModelId,
                "first_token_time" => BodyParamsForRunSchemaSelect.FirstTokenTime,
                "trace_id" => BodyParamsForRunSchemaSelect.TraceId,
                "dotted_order" => BodyParamsForRunSchemaSelect.DottedOrder,
                "last_queued_at" => BodyParamsForRunSchemaSelect.LastQueuedAt,
                "feedback_stats" => BodyParamsForRunSchemaSelect.FeedbackStats,
                "child_run_ids" => BodyParamsForRunSchemaSelect.ChildRunIds,
                "parent_run_ids" => BodyParamsForRunSchemaSelect.ParentRunIds,
                "tags" => BodyParamsForRunSchemaSelect.Tags,
                "in_dataset" => BodyParamsForRunSchemaSelect.InDataset,
                "app_path" => BodyParamsForRunSchemaSelect.AppPath,
                "share_token" => BodyParamsForRunSchemaSelect.ShareToken,
                "trace_tier" => BodyParamsForRunSchemaSelect.TraceTier,
                "trace_first_received_at" => BodyParamsForRunSchemaSelect.TraceFirstReceivedAt,
                "ttl_seconds" => BodyParamsForRunSchemaSelect.TtlSeconds,
                "trace_upgrade" => BodyParamsForRunSchemaSelect.TraceUpgrade,
                _ => null,
            };
        }
    }
}