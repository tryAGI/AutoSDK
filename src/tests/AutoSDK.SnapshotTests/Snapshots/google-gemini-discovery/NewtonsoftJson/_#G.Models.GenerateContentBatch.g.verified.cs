//HintName: G.Models.GenerateContentBatch.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A resource representing a batch of `GenerateContent` requests.
    /// </summary>
    public sealed partial class GenerateContentBatch
    {
        /// <summary>
        /// Required. The name of the `Model` to use for generating the completion. Format: `models/{model}`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Output only. Identifier. Resource name of the batch. Format: `batches/{batch_id}`.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Required. The user-defined name of this batch.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("displayName")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Configures the input to the batch request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inputConfig")]
        public global::G.InputConfig? InputConfig { get; set; }

        /// <summary>
        /// The output of a batch request. This is returned in the `BatchGenerateContentResponse` or the `GenerateContentBatch.output` field.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output")]
        public global::G.GenerateContentBatchOutput? Output { get; set; }

        /// <summary>
        /// Output only. The time at which the batch was created.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createTime")]
        public string? CreateTime { get; set; }

        /// <summary>
        /// Output only. The time at which the batch processing completed.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("endTime")]
        public string? EndTime { get; set; }

        /// <summary>
        /// Output only. The time at which the batch was last updated.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updateTime")]
        public string? UpdateTime { get; set; }

        /// <summary>
        /// Stats about the batch.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("batchStats")]
        public global::G.BatchStats? BatchStats { get; set; }

        /// <summary>
        /// Output only. The state of the batch.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("state")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.GenerateContentBatchStateJsonConverter))]
        public global::G.GenerateContentBatchState? State { get; set; }

        /// <summary>
        /// Optional. The priority of the batch. Batches with a higher priority value will be processed before batches with a lower priority value. Negative values are allowed. Default is 0.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("priority")]
        public string? Priority { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateContentBatch" /> class.
        /// </summary>
        /// <param name="model">
        /// Required. The name of the `Model` to use for generating the completion. Format: `models/{model}`.
        /// </param>
        /// <param name="name">
        /// Output only. Identifier. Resource name of the batch. Format: `batches/{batch_id}`.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="displayName">
        /// Required. The user-defined name of this batch.
        /// </param>
        /// <param name="inputConfig">
        /// Configures the input to the batch request.
        /// </param>
        /// <param name="output">
        /// The output of a batch request. This is returned in the `BatchGenerateContentResponse` or the `GenerateContentBatch.output` field.
        /// </param>
        /// <param name="createTime">
        /// Output only. The time at which the batch was created.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="endTime">
        /// Output only. The time at which the batch processing completed.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="updateTime">
        /// Output only. The time at which the batch was last updated.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="batchStats">
        /// Stats about the batch.
        /// </param>
        /// <param name="state">
        /// Output only. The state of the batch.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="priority">
        /// Optional. The priority of the batch. Batches with a higher priority value will be processed before batches with a lower priority value. Negative values are allowed. Default is 0.
        /// </param>
        public GenerateContentBatch(
            string? model,
            string? name,
            string? displayName,
            global::G.InputConfig? inputConfig,
            global::G.GenerateContentBatchOutput? output,
            string? createTime,
            string? endTime,
            string? updateTime,
            global::G.BatchStats? batchStats,
            global::G.GenerateContentBatchState? state,
            string? priority)
        {
            this.Model = model;
            this.Name = name;
            this.DisplayName = displayName;
            this.InputConfig = inputConfig;
            this.Output = output;
            this.CreateTime = createTime;
            this.EndTime = endTime;
            this.UpdateTime = updateTime;
            this.BatchStats = batchStats;
            this.State = state;
            this.Priority = priority;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateContentBatch" /> class.
        /// </summary>
        public GenerateContentBatch()
        {
        }
    }
}