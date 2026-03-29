//HintName: G.Models.DatasetItemWrite.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DatasetItemWrite
    {
        /// <summary>
        /// Stable item identifier.<br/>
        /// On write, used as the upsert key.<br/>
        /// If omitted, a new ID is generated.<br/>
        /// Remains the same across dataset versions
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("trace_id")]
        public global::System.Guid? TraceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("span_id")]
        public global::System.Guid? SpanId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.DatasetItemWriteSource Source { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.JsonNode Data { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("evaluators")]
        public global::System.Collections.Generic.IList<global::G.EvaluatorItemWrite>? Evaluators { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("execution_policy")]
        public global::G.ExecutionPolicyWrite? ExecutionPolicy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetItemWrite" /> class.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="data"></param>
        /// <param name="id">
        /// Stable item identifier.<br/>
        /// On write, used as the upsert key.<br/>
        /// If omitted, a new ID is generated.<br/>
        /// Remains the same across dataset versions
        /// </param>
        /// <param name="traceId"></param>
        /// <param name="spanId"></param>
        /// <param name="description"></param>
        /// <param name="tags"></param>
        /// <param name="evaluators"></param>
        /// <param name="executionPolicy"></param>
        public DatasetItemWrite(
            global::G.DatasetItemWriteSource source,
            global::G.JsonNode data,
            global::System.Guid? id,
            global::System.Guid? traceId,
            global::System.Guid? spanId,
            string? description,
            global::System.Collections.Generic.IList<string>? tags,
            global::System.Collections.Generic.IList<global::G.EvaluatorItemWrite>? evaluators,
            global::G.ExecutionPolicyWrite? executionPolicy)
        {
            this.Id = id;
            this.TraceId = traceId;
            this.SpanId = spanId;
            this.Source = source;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Description = description;
            this.Tags = tags;
            this.Evaluators = evaluators;
            this.ExecutionPolicy = executionPolicy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetItemWrite" /> class.
        /// </summary>
        public DatasetItemWrite()
        {
        }
    }
}