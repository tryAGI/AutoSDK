//HintName: G.Models.NodeFinetuneTransitionExample.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NodeFinetuneTransitionExample
    {
        /// <summary>
        /// Unique identifier for the example
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The example transcript to finetune how the node should transition.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.FinetuneExampleUtterance> Transcript { get; set; }

        /// <summary>
        /// Optional destination node ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("destination_node_id")]
        public string? DestinationNodeId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeFinetuneTransitionExample" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the example
        /// </param>
        /// <param name="transcript">
        /// The example transcript to finetune how the node should transition.
        /// </param>
        /// <param name="destinationNodeId">
        /// Optional destination node ID
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NodeFinetuneTransitionExample(
            string id,
            global::System.Collections.Generic.IList<global::G.FinetuneExampleUtterance> transcript,
            string? destinationNodeId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Transcript = transcript ?? throw new global::System.ArgumentNullException(nameof(transcript));
            this.DestinationNodeId = destinationNodeId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeFinetuneTransitionExample" /> class.
        /// </summary>
        public NodeFinetuneTransitionExample()
        {
        }
    }
}