//HintName: G.Models.DatasetItemPublic.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DatasetItemPublic
    {
        /// <summary>
        /// Stable item identifier.<br/>
        /// On write, used as the upsert key.<br/>
        /// If omitted, a new ID is generated.<br/>
        /// Remains the same across dataset versions
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// Deprecated.<br/>
        /// Always equals 'id'.<br/>
        /// Retained for backward compatibility and will be removed in a future version<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_item_id")]
        public global::System.Guid? DatasetItemId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_id")]
        public global::System.Guid? TraceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("span_id")]
        public global::System.Guid? SpanId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.DatasetItemPublicSourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.DatasetItemPublicSource Source { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.JsonNode Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluators")]
        public global::System.Collections.Generic.IList<global::G.EvaluatorItemPublic>? Evaluators { get; set; }

        /// <summary>
        /// Default execution policy for items in this version<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution_policy")]
        public global::G.ExecutionPolicyPublic? ExecutionPolicy { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experiment_items")]
        public global::System.Collections.Generic.IList<global::G.ExperimentItemPublic>? ExperimentItems { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_summaries_by_experiment")]
        public global::System.Collections.Generic.Dictionary<string, global::G.ExperimentRunSummaryPublic>? RunSummariesByExperiment { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_id")]
        public global::System.Guid? DatasetId { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_updated_at")]
        public global::System.DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        public string? CreatedBy { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_updated_by")]
        public string? LastUpdatedBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetItemPublic" /> class.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="data"></param>
        /// <param name="id">
        /// Stable item identifier.<br/>
        /// On write, used as the upsert key.<br/>
        /// If omitted, a new ID is generated.<br/>
        /// Remains the same across dataset versions
        /// </param>
        /// <param name="datasetItemId">
        /// Deprecated.<br/>
        /// Always equals 'id'.<br/>
        /// Retained for backward compatibility and will be removed in a future version<br/>
        /// Included only in responses
        /// </param>
        /// <param name="traceId"></param>
        /// <param name="spanId"></param>
        /// <param name="description"></param>
        /// <param name="tags"></param>
        /// <param name="evaluators"></param>
        /// <param name="executionPolicy">
        /// Default execution policy for items in this version<br/>
        /// Included only in responses
        /// </param>
        /// <param name="experimentItems">
        /// Included only in responses
        /// </param>
        /// <param name="runSummariesByExperiment">
        /// Included only in responses
        /// </param>
        /// <param name="datasetId">
        /// Included only in responses
        /// </param>
        /// <param name="createdAt">
        /// Included only in responses
        /// </param>
        /// <param name="lastUpdatedAt">
        /// Included only in responses
        /// </param>
        /// <param name="createdBy">
        /// Included only in responses
        /// </param>
        /// <param name="lastUpdatedBy">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DatasetItemPublic(
            global::G.DatasetItemPublicSource source,
            global::G.JsonNode data,
            global::System.Guid? id,
            global::System.Guid? datasetItemId,
            global::System.Guid? traceId,
            global::System.Guid? spanId,
            string? description,
            global::System.Collections.Generic.IList<string>? tags,
            global::System.Collections.Generic.IList<global::G.EvaluatorItemPublic>? evaluators,
            global::G.ExecutionPolicyPublic? executionPolicy,
            global::System.Collections.Generic.IList<global::G.ExperimentItemPublic>? experimentItems,
            global::System.Collections.Generic.Dictionary<string, global::G.ExperimentRunSummaryPublic>? runSummariesByExperiment,
            global::System.Guid? datasetId,
            global::System.DateTime? createdAt,
            global::System.DateTime? lastUpdatedAt,
            string? createdBy,
            string? lastUpdatedBy)
        {
            this.Id = id;
            this.DatasetItemId = datasetItemId;
            this.TraceId = traceId;
            this.SpanId = spanId;
            this.Source = source;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Description = description;
            this.Tags = tags;
            this.Evaluators = evaluators;
            this.ExecutionPolicy = executionPolicy;
            this.ExperimentItems = experimentItems;
            this.RunSummariesByExperiment = runSummariesByExperiment;
            this.DatasetId = datasetId;
            this.CreatedAt = createdAt;
            this.LastUpdatedAt = lastUpdatedAt;
            this.CreatedBy = createdBy;
            this.LastUpdatedBy = lastUpdatedBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetItemPublic" /> class.
        /// </summary>
        public DatasetItemPublic()
        {
        }
    }
}