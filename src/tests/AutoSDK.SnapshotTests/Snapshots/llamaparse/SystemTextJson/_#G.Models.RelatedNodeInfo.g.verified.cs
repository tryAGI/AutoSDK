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
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::G.ObjectType?, string, object>))]
        public global::G.AnyOf<global::G.ObjectType?, string, object>? NodeType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hash")]
        public string? Hash { get; set; }

        /// <summary>
        /// Default Value: RelatedNodeInfo
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("class_name")]
        public string? ClassName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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