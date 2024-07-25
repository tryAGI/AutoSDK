//HintName: G.Models.BodyParamsForRunSchemaSelect.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Enum for available run columns.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BodyParamsForRunSchemaSelect
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="id")]
        Id,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="name")]
        Name,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="run_type")]
        RunType,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="start_time")]
        StartTime,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="end_time")]
        EndTime,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="status")]
        Status,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error")]
        Error,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="extra")]
        Extra,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="events")]
        Events,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="inputs")]
        Inputs,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="inputs_s3_urls")]
        InputsS3Urls,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="inputs_or_signed_url")]
        InputsOrSignedUrl,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="outputs")]
        Outputs,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="outputs_s3_urls")]
        OutputsS3Urls,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="outputs_or_signed_url")]
        OutputsOrSignedUrl,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="s3_urls")]
        S3Urls,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error_or_signed_url")]
        ErrorOrSignedUrl,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="parent_run_id")]
        ParentRunId,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="manifest_id")]
        ManifestId,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="manifest_s3_id")]
        ManifestS3Id,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="session_id")]
        SessionId,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="serialized")]
        Serialized,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="reference_example_id")]
        ReferenceExampleId,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="total_tokens")]
        TotalTokens,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="prompt_tokens")]
        PromptTokens,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="completion_tokens")]
        CompletionTokens,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="total_cost")]
        TotalCost,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="prompt_cost")]
        PromptCost,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="completion_cost")]
        CompletionCost,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="price_model_id")]
        PriceModelId,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="first_token_time")]
        FirstTokenTime,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="trace_id")]
        TraceId,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="dotted_order")]
        DottedOrder,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="last_queued_at")]
        LastQueuedAt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="feedback_stats")]
        FeedbackStats,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="child_run_ids")]
        ChildRunIds,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="parent_run_ids")]
        ParentRunIds,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tags")]
        Tags,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="in_dataset")]
        InDataset,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="app_path")]
        AppPath,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="share_token")]
        ShareToken,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="trace_tier")]
        TraceTier,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="trace_first_received_at")]
        TraceFirstReceivedAt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ttl_seconds")]
        TtlSeconds,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="trace_upgrade")]
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