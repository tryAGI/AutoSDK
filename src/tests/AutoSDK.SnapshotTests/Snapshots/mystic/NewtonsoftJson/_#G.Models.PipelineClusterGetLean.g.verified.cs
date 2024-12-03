//HintName: G.Models.PipelineClusterGetLean.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A lean representation of a cluster when returned from an API call
    /// </summary>
    public sealed partial class PipelineClusterGetLean
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
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        public string? Provider { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineClusterGetLean" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nodePool"></param>
        /// <param name="name"></param>
        /// <param name="provider"></param>
        public PipelineClusterGetLean(
            string id,
            string nodePool,
            string? name,
            string? provider)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.NodePool = nodePool ?? throw new global::System.ArgumentNullException(nameof(nodePool));
            this.Name = name;
            this.Provider = provider;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineClusterGetLean" /> class.
        /// </summary>
        public PipelineClusterGetLean()
        {
        }
    }
}