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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The example transcript to finetune how the conversation should be.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.FinetuneExampleUtterance> Transcript { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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