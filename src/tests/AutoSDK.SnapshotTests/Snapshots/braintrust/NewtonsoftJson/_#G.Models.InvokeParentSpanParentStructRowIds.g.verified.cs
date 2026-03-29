//HintName: G.Models.InvokeParentSpanParentStructRowIds.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Identifiers for the row to to log a subspan under
    /// </summary>
    public sealed partial class InvokeParentSpanParentStructRowIds
    {
        /// <summary>
        /// The id of the row
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The span_id of the row
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("span_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string SpanId { get; set; } = default!;

        /// <summary>
        /// The root_span_id of the row
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("root_span_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string RootSpanId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InvokeParentSpanParentStructRowIds" /> class.
        /// </summary>
        /// <param name="id">
        /// The id of the row
        /// </param>
        /// <param name="spanId">
        /// The span_id of the row
        /// </param>
        /// <param name="rootSpanId">
        /// The root_span_id of the row
        /// </param>
        public InvokeParentSpanParentStructRowIds(
            string id,
            string spanId,
            string rootSpanId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.SpanId = spanId ?? throw new global::System.ArgumentNullException(nameof(spanId));
            this.RootSpanId = rootSpanId ?? throw new global::System.ArgumentNullException(nameof(rootSpanId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvokeParentSpanParentStructRowIds" /> class.
        /// </summary>
        public InvokeParentSpanParentStructRowIds()
        {
        }
    }
}