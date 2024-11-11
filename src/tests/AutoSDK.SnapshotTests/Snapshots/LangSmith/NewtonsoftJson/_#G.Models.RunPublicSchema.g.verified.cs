//HintName: G.Models.RunPublicSchema.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RunPublicSchema
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inputs")]
        public object? Inputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inputs_preview")]
        public string? InputsPreview { get; set; }

        /// <summary>
        /// Enum for run types.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("run_type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RunTypeEnum RunType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_time")]
        public global::System.DateTime? StartTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_time")]
        public global::System.DateTime? EndTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("extra")]
        public object? Extra { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Default Value: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("execution_order")]
        public int? ExecutionOrder { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("serialized")]
        public object? Serialized { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("outputs")]
        public object? Outputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("outputs_preview")]
        public string? OutputsPreview { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parent_run_id")]
        public global::System.Guid? ParentRunId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("manifest_id")]
        public global::System.Guid? ManifestId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("manifest_s3_id")]
        public global::System.Guid? ManifestS3Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("events")]
        public global::System.Collections.Generic.IList<object>? Events { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inputs_s3_urls")]
        public object? InputsS3Urls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("outputs_s3_urls")]
        public object? OutputsS3Urls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("s3_urls")]
        public object? S3Urls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("trace_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid TraceId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dotted_order", Required = global::Newtonsoft.Json.Required.Always)]
        public string DottedOrder { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public string Status { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("child_run_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? ChildRunIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("direct_child_run_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? DirectChildRunIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parent_run_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? ParentRunIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("feedback_stats")]
        public global::System.Collections.Generic.Dictionary<string, object>? FeedbackStats { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reference_example_id")]
        public global::System.Guid? ReferenceExampleId { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_tokens")]
        public int? TotalTokens { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_tokens")]
        public int? PromptTokens { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completion_tokens")]
        public int? CompletionTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_cost")]
        public string? TotalCost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_cost")]
        public string? PromptCost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completion_cost")]
        public string? CompletionCost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("price_model_id")]
        public global::System.Guid? PriceModelId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("first_token_time")]
        public global::System.DateTime? FirstTokenTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunPublicSchema" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="inputs"></param>
        /// <param name="inputsPreview"></param>
        /// <param name="runType">
        /// Enum for run types.
        /// </param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="extra"></param>
        /// <param name="error"></param>
        /// <param name="executionOrder">
        /// Default Value: 1
        /// </param>
        /// <param name="serialized"></param>
        /// <param name="outputs"></param>
        /// <param name="outputsPreview"></param>
        /// <param name="parentRunId"></param>
        /// <param name="manifestId"></param>
        /// <param name="manifestS3Id"></param>
        /// <param name="events"></param>
        /// <param name="tags"></param>
        /// <param name="inputsS3Urls"></param>
        /// <param name="outputsS3Urls"></param>
        /// <param name="s3Urls"></param>
        /// <param name="traceId"></param>
        /// <param name="dottedOrder"></param>
        /// <param name="id"></param>
        /// <param name="status"></param>
        /// <param name="childRunIds"></param>
        /// <param name="directChildRunIds"></param>
        /// <param name="parentRunIds"></param>
        /// <param name="feedbackStats"></param>
        /// <param name="referenceExampleId"></param>
        /// <param name="totalTokens">
        /// Default Value: 0
        /// </param>
        /// <param name="promptTokens">
        /// Default Value: 0
        /// </param>
        /// <param name="completionTokens">
        /// Default Value: 0
        /// </param>
        /// <param name="totalCost"></param>
        /// <param name="promptCost"></param>
        /// <param name="completionCost"></param>
        /// <param name="priceModelId"></param>
        /// <param name="firstTokenTime"></param>
        public RunPublicSchema(
            string name,
            global::G.RunTypeEnum runType,
            global::System.Guid traceId,
            string dottedOrder,
            global::System.Guid id,
            string status,
            object? inputs,
            string? inputsPreview,
            global::System.DateTime? startTime,
            global::System.DateTime? endTime,
            object? extra,
            string? error,
            int? executionOrder,
            object? serialized,
            object? outputs,
            string? outputsPreview,
            global::System.Guid? parentRunId,
            global::System.Guid? manifestId,
            global::System.Guid? manifestS3Id,
            global::System.Collections.Generic.IList<object>? events,
            global::System.Collections.Generic.IList<string>? tags,
            object? inputsS3Urls,
            object? outputsS3Urls,
            object? s3Urls,
            global::System.Collections.Generic.IList<global::System.Guid>? childRunIds,
            global::System.Collections.Generic.IList<global::System.Guid>? directChildRunIds,
            global::System.Collections.Generic.IList<global::System.Guid>? parentRunIds,
            global::System.Collections.Generic.Dictionary<string, object>? feedbackStats,
            global::System.Guid? referenceExampleId,
            int? totalTokens,
            int? promptTokens,
            int? completionTokens,
            string? totalCost,
            string? promptCost,
            string? completionCost,
            global::System.Guid? priceModelId,
            global::System.DateTime? firstTokenTime)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.RunType = runType;
            this.TraceId = traceId;
            this.DottedOrder = dottedOrder ?? throw new global::System.ArgumentNullException(nameof(dottedOrder));
            this.Id = id;
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.Inputs = inputs;
            this.InputsPreview = inputsPreview;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Extra = extra;
            this.Error = error;
            this.ExecutionOrder = executionOrder;
            this.Serialized = serialized;
            this.Outputs = outputs;
            this.OutputsPreview = outputsPreview;
            this.ParentRunId = parentRunId;
            this.ManifestId = manifestId;
            this.ManifestS3Id = manifestS3Id;
            this.Events = events;
            this.Tags = tags;
            this.InputsS3Urls = inputsS3Urls;
            this.OutputsS3Urls = outputsS3Urls;
            this.S3Urls = s3Urls;
            this.ChildRunIds = childRunIds;
            this.DirectChildRunIds = directChildRunIds;
            this.ParentRunIds = parentRunIds;
            this.FeedbackStats = feedbackStats;
            this.ReferenceExampleId = referenceExampleId;
            this.TotalTokens = totalTokens;
            this.PromptTokens = promptTokens;
            this.CompletionTokens = completionTokens;
            this.TotalCost = totalCost;
            this.PromptCost = promptCost;
            this.CompletionCost = completionCost;
            this.PriceModelId = priceModelId;
            this.FirstTokenTime = firstTokenTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunPublicSchema" /> class.
        /// </summary>
        public RunPublicSchema()
        {
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.RunPublicSchema? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.RunPublicSchema>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER     
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.RunPublicSchema?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.RunPublicSchema?>(serializer.Deserialize<global::G.RunPublicSchema>(jsonReader));
        }

    }
}