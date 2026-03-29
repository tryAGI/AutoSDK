//HintName: G.Models.RelatedNodeInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RelatedNodeInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_type")]
        public global::G.AnyOf<global::G.ObjectType?, string, object>? NodeType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hash")]
        public string? Hash { get; set; }

        /// <summary>
        /// Default Value: RelatedNodeInfo
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("class_name")]
        public string? ClassName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RelatedNodeInfo" /> class.
        /// </summary>
        /// <param name="nodeId"></param>
        /// <param name="nodeType"></param>
        /// <param name="metadata"></param>
        /// <param name="hash"></param>
        /// <param name="className">
        /// Default Value: RelatedNodeInfo
        /// </param>
        public RelatedNodeInfo(
            string nodeId,
            global::G.AnyOf<global::G.ObjectType?, string, object>? nodeType,
            object? metadata,
            string? hash,
            string? className)
        {
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.NodeType = nodeType;
            this.Metadata = metadata;
            this.Hash = hash;
            this.ClassName = className;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RelatedNodeInfo" /> class.
        /// </summary>
        public RelatedNodeInfo()
        {
        }
    }
}