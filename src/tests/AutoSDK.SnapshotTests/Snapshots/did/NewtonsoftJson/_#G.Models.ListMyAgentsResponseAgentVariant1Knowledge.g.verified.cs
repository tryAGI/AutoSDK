//HintName: G.Models.ListMyAgentsResponseAgentVariant1Knowledge.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Knowledge documents base where the agent will look for answers
    /// </summary>
    public sealed partial class ListMyAgentsResponseAgentVariant1Knowledge
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The provider of the knowledge base
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        public global::G.ListMyAgentsResponseAgentVariant1KnowledgeProvider? Provider { get; set; }

        /// <summary>
        /// List of messages to be showen as chat starter questions for the user to ask
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("starter_message")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<string>? StarterMessage { get; set; }

        /// <summary>
        /// Prompt based textual knowledge
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("base_knowledge")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? BaseKnowledge { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListMyAgentsResponseAgentVariant1Knowledge" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="provider">
        /// The provider of the knowledge base
        /// </param>
        public ListMyAgentsResponseAgentVariant1Knowledge(
            string id,
            global::G.ListMyAgentsResponseAgentVariant1KnowledgeProvider? provider)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Provider = provider;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListMyAgentsResponseAgentVariant1Knowledge" /> class.
        /// </summary>
        public ListMyAgentsResponseAgentVariant1Knowledge()
        {
        }
    }
}