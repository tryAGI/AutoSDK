//HintName: G.Models.NodeFinetuneConversationExample.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NodeFinetuneConversationExample
    {
        /// <summary>
        /// Unique identifier for the example
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The example transcript to finetune how the conversation should be.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transcript", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.FinetuneExampleUtterance> Transcript { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeFinetuneConversationExample" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the example
        /// </param>
        /// <param name="transcript">
        /// The example transcript to finetune how the conversation should be.
        /// </param>
        public NodeFinetuneConversationExample(
            string id,
            global::System.Collections.Generic.IList<global::G.FinetuneExampleUtterance> transcript)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Transcript = transcript ?? throw new global::System.ArgumentNullException(nameof(transcript));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeFinetuneConversationExample" /> class.
        /// </summary>
        public NodeFinetuneConversationExample()
        {
        }
    }
}