//HintName: G.Models.AgentKnowledge.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Knowledge documents base where the agent will look for answers
    /// </summary>
    public sealed partial class AgentKnowledge
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The provider of the knowledge base
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AgentKnowledgeProviderJsonConverter))]
        public global::G.AgentKnowledgeProvider? Provider { get; set; }

        /// <summary>
        /// List of messages to be showen as chat starter questions for the user to ask
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("starter_message")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<string>? StarterMessage { get; set; }

        /// <summary>
        /// Prompt based textual knowledge
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_knowledge")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? BaseKnowledge { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentKnowledge" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="provider">
        /// The provider of the knowledge base
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentKnowledge(
            string id,
            global::G.AgentKnowledgeProvider? provider)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Provider = provider;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentKnowledge" /> class.
        /// </summary>
        public AgentKnowledge()
        {
        }
    }
}