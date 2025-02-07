//HintName: G.Models.ClusterDeployedPipelineGet.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Base model for schemas.
    /// </summary>
    public sealed partial class ClusterDeployedPipelineGet
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
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pointers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Pointers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_pool")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodePool { get; set; }

        /// <summary>
        /// Base model for schemas.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replicas")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PipelineScaling Replicas { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterDeployedPipelineGet" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="pointers"></param>
        /// <param name="nodePool"></param>
        /// <param name="replicas">
        /// Base model for schemas.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClusterDeployedPipelineGet(
            string id,
            string name,
            global::System.Collections.Generic.IList<string> pointers,
            string nodePool,
            global::G.PipelineScaling replicas)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Pointers = pointers ?? throw new global::System.ArgumentNullException(nameof(pointers));
            this.NodePool = nodePool ?? throw new global::System.ArgumentNullException(nameof(nodePool));
            this.Replicas = replicas ?? throw new global::System.ArgumentNullException(nameof(replicas));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterDeployedPipelineGet" /> class.
        /// </summary>
        public ClusterDeployedPipelineGet()
        {
        }
    }
}