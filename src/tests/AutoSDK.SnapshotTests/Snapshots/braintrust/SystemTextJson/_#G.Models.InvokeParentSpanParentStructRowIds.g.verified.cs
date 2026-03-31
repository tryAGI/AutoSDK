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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The span_id of the row
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("span_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SpanId { get; set; }

        /// <summary>
        /// The root_span_id of the row
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("root_span_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RootSpanId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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