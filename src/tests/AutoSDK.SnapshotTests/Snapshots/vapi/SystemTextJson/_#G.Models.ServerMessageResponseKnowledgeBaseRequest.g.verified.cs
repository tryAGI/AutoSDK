//HintName: G.Models.ServerMessageResponseKnowledgeBaseRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ServerMessageResponseKnowledgeBaseRequest
    {
        /// <summary>
        /// This is the list of documents that will be sent to the model alongside the `messages` to generate a response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documents")]
        public global::System.Collections.Generic.IList<global::G.KnowledgeBaseResponseDocument>? Documents { get; set; }

        /// <summary>
        /// This can be used to skip the model output generation and speak a custom message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public global::G.CustomMessage? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerMessageResponseKnowledgeBaseRequest" /> class.
        /// </summary>
        /// <param name="documents">
        /// This is the list of documents that will be sent to the model alongside the `messages` to generate a response.
        /// </param>
        /// <param name="message">
        /// This can be used to skip the model output generation and speak a custom message.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ServerMessageResponseKnowledgeBaseRequest(
            global::System.Collections.Generic.IList<global::G.KnowledgeBaseResponseDocument>? documents,
            global::G.CustomMessage? message)
        {
            this.Documents = documents;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerMessageResponseKnowledgeBaseRequest" /> class.
        /// </summary>
        public ServerMessageResponseKnowledgeBaseRequest()
        {
        }
    }
}