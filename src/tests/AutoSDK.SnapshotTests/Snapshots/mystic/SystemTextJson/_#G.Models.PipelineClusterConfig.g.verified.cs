//HintName: G.Models.PipelineClusterConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PipelineClusterConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_pool")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodePool { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineClusterConfig" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nodePool"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public PipelineClusterConfig(
            string id,
            string nodePool)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.NodePool = nodePool ?? throw new global::System.ArgumentNullException(nameof(nodePool));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineClusterConfig" /> class.
        /// </summary>
        public PipelineClusterConfig()
        {
        }
    }
}