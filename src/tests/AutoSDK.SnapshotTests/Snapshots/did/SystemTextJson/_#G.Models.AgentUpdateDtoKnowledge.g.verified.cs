//HintName: G.Models.AgentUpdateDtoKnowledge.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Knowledge Base used by the Agent to retrieve answers (RAG).<br/>
    /// Use the ID returned by the Create Knowledge endpoint.
    /// </summary>
    public sealed partial class AgentUpdateDtoKnowledge
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentUpdateDtoKnowledge" /> class.
        /// </summary>
        /// <param name="id"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentUpdateDtoKnowledge(
            string id)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentUpdateDtoKnowledge" /> class.
        /// </summary>
        public AgentUpdateDtoKnowledge()
        {
        }
    }
}