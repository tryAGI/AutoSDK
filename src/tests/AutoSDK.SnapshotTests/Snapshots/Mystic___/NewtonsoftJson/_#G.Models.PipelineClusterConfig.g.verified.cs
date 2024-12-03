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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_pool", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodePool { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineClusterConfig" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nodePool"></param>
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