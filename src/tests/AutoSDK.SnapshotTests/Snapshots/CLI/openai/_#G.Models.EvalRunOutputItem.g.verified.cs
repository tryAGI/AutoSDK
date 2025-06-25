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
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EvalRunOutputItemObjectJsonConverter))]
        public global::G.EvalRunOutputItemObject Object { get; set; } = global::G.EvalRunOutputItemObject.EvalRunOutputItem;

        /// <summary>
        /// Unique identifier for the evaluation run output item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The identifier of the evaluation run associated with this output item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RunId { get; set; }

        /// <summary>
        /// The identifier of the evaluation group.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eval_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EvalId { get; set; }

        /// <summary>
        /// Unix timestamp (in seconds) when the evaluation run was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// The status of the evaluation run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// The identifier for the data source item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasource_item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DatasourceItemId { get; set; }

        /// <summary>
        /// Details of the input data source item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasource_item")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object DatasourceItem { get; set; }

        /// <summary>
        /// A list of results from the evaluation run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<object> Results { get; set; }

        /// <summary>
        /// A sample containing the input and output of the evaluation run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.EvalRunOutputItemSample Sample { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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