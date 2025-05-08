//HintName: G.Models.EvalRunOutputItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A schema representing an evaluation run output item.
    /// </summary>
    public sealed partial class EvalRunOutputItem
    {
        /// <summary>
        /// The type of the object. Always "eval.run.output_item".<br/>
        /// Default Value: eval.run.output_item
        /// </summary>
        /// <default>global::G.EvalRunOutputItemObject.EvalRunOutputItem</default>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.EvalRunOutputItemObject Object { get; set; } = global::G.EvalRunOutputItemObject.EvalRunOutputItem;

        /// <summary>
        /// Unique identifier for the evaluation run output item.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The identifier of the evaluation run associated with this output item.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("run_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string RunId { get; set; } = default!;

        /// <summary>
        /// The identifier of the evaluation group.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("eval_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string EvalId { get; set; } = default!;

        /// <summary>
        /// Unix timestamp (in seconds) when the evaluation run was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTimeOffset CreatedAt { get; set; } = default!;

        /// <summary>
        /// The status of the evaluation run.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public string Status { get; set; } = default!;

        /// <summary>
        /// The identifier for the data source item.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("datasource_item_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int DatasourceItemId { get; set; } = default!;

        /// <summary>
        /// Details of the input data source item.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("datasource_item", Required = global::Newtonsoft.Json.Required.Always)]
        public object DatasourceItem { get; set; } = default!;

        /// <summary>
        /// A list of results from the evaluation run.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("results", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<object> Results { get; set; } = default!;

        /// <summary>
        /// A sample containing the input and output of the evaluation run.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sample", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.EvalRunOutputItemSample Sample { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalRunOutputItem" /> class.
        /// </summary>
        /// <param name="object">
        /// The type of the object. Always "eval.run.output_item".<br/>
        /// Default Value: eval.run.output_item
        /// </param>
        /// <param name="id">
        /// Unique identifier for the evaluation run output item.
        /// </param>
        /// <param name="runId">
        /// The identifier of the evaluation run associated with this output item.
        /// </param>
        /// <param name="evalId">
        /// The identifier of the evaluation group.
        /// </param>
        /// <param name="createdAt">
        /// Unix timestamp (in seconds) when the evaluation run was created.
        /// </param>
        /// <param name="status">
        /// The status of the evaluation run.
        /// </param>
        /// <param name="datasourceItemId">
        /// The identifier for the data source item.
        /// </param>
        /// <param name="datasourceItem">
        /// Details of the input data source item.
        /// </param>
        /// <param name="results">
        /// A list of results from the evaluation run.
        /// </param>
        /// <param name="sample">
        /// A sample containing the input and output of the evaluation run.
        /// </param>
        public EvalRunOutputItem(
            string id,
            string runId,
            string evalId,
            global::System.DateTimeOffset createdAt,
            string status,
            int datasourceItemId,
            object datasourceItem,
            global::System.Collections.Generic.IList<object> results,
            global::G.EvalRunOutputItemSample sample,
            global::G.EvalRunOutputItemObject @object = global::G.EvalRunOutputItemObject.EvalRunOutputItem)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.RunId = runId ?? throw new global::System.ArgumentNullException(nameof(runId));
            this.EvalId = evalId ?? throw new global::System.ArgumentNullException(nameof(evalId));
            this.CreatedAt = createdAt;
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.DatasourceItemId = datasourceItemId;
            this.DatasourceItem = datasourceItem ?? throw new global::System.ArgumentNullException(nameof(datasourceItem));
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
            this.Sample = sample ?? throw new global::System.ArgumentNullException(nameof(sample));
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalRunOutputItem" /> class.
        /// </summary>
        public EvalRunOutputItem()
        {
        }
    }
}