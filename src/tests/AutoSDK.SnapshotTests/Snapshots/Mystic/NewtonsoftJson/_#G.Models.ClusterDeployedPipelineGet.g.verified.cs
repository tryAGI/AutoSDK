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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pointers", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Pointers { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_pool", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodePool { get; set; } = default!;

        /// <summary>
        /// Base model for schemas.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("replicas", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PipelineScaling Replicas { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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