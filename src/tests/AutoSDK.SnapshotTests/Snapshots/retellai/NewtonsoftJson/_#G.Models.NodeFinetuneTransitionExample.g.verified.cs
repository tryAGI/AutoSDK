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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The example transcript to finetune how the node should transition.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transcript", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.FinetuneExampleUtterance> Transcript { get; set; } = default!;

        /// <summary>
        /// Optional destination node ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("destination_node_id")]
        public string? DestinationNodeId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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