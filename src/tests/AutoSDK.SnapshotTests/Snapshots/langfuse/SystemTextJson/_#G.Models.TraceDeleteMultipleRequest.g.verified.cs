//HintName: G.Models.TraceDeleteMultipleRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TraceDeleteMultipleRequest
    {
        /// <summary>
        /// List of trace IDs to delete
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("traceIds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> TraceIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TraceDeleteMultipleRequest" /> class.
        /// </summary>
        /// <param name="traceIds">
        /// List of trace IDs to delete
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TraceDeleteMultipleRequest(
            global::System.Collections.Generic.IList<string> traceIds)
        {
            this.TraceIds = traceIds ?? throw new global::System.ArgumentNullException(nameof(traceIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TraceDeleteMultipleRequest" /> class.
        /// </summary>
        public TraceDeleteMultipleRequest()
        {
        }
    }
}