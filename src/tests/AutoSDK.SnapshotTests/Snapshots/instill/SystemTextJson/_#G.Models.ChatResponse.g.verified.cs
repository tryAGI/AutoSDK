//HintName: G.Models.ChatResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// ChatResponse contains the chatbot response.
    /// </summary>
    public sealed partial class ChatResponse
    {
        /// <summary>
        /// Conversation responses.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputs")]
        public global::System.Collections.Generic.IList<object>? Outputs { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunks")]
        public global::System.Collections.Generic.IList<global::G.SimilarityChunk>? Chunks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatResponse" /> class.
        /// </summary>
        /// <param name="outputs">
        /// Conversation responses.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="chunks">
        /// Included only in responses
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ChatResponse(
            global::System.Collections.Generic.IList<object>? outputs,
            global::System.Collections.Generic.IList<global::G.SimilarityChunk>? chunks)
        {
            this.Outputs = outputs;
            this.Chunks = chunks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatResponse" /> class.
        /// </summary>
        public ChatResponse()
        {
        }
    }
}