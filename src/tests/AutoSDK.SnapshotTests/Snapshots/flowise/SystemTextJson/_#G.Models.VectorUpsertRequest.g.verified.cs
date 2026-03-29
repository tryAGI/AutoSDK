//HintName: G.Models.VectorUpsertRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VectorUpsertRequest
    {
        /// <summary>
        /// In cases when you have multiple vector store nodes, you can specify the node ID to store the vectors<br/>
        /// Example: node_1
        /// </summary>
        /// <example>node_1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("stopNodeId")]
        public string? StopNodeId { get; set; }

        /// <summary>
        /// The configuration to override the default vector upsert settings (optional)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overrideConfig")]
        public object? OverrideConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorUpsertRequest" /> class.
        /// </summary>
        /// <param name="stopNodeId">
        /// In cases when you have multiple vector store nodes, you can specify the node ID to store the vectors<br/>
        /// Example: node_1
        /// </param>
        /// <param name="overrideConfig">
        /// The configuration to override the default vector upsert settings (optional)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VectorUpsertRequest(
            string? stopNodeId,
            object? overrideConfig)
        {
            this.StopNodeId = stopNodeId;
            this.OverrideConfig = overrideConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorUpsertRequest" /> class.
        /// </summary>
        public VectorUpsertRequest()
        {
        }
    }
}