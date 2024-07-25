//HintName: G.Models.RunSelect.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Enum for available run columns.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RunSelect
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
                RunSelect.InputsS3Urls => "inputs_s3_urls",
                RunSelect.InputsOrSignedUrl => "inputs_or_signed_url",
                RunSelect.Outputs => "outputs",
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
                "inputs_s3_urls" => RunSelect.InputsS3Urls,
                "inputs_or_signed_url" => RunSelect.InputsOrSignedUrl,
                "outputs" => RunSelect.Outputs,
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