//HintName: G.Models.GetKnowledgeBaseDependentAgentsResponseModelAgentDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetKnowledgeBaseDependentAgentsResponseModelAgentDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GetKnowledgeBaseDependentAgentsResponseModelAgentDiscriminatorTypeJsonConverter))]
        public global::G.GetKnowledgeBaseDependentAgentsResponseModelAgentDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetKnowledgeBaseDependentAgentsResponseModelAgentDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetKnowledgeBaseDependentAgentsResponseModelAgentDiscriminator(
            global::G.GetKnowledgeBaseDependentAgentsResponseModelAgentDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetKnowledgeBaseDependentAgentsResponseModelAgentDiscriminator" /> class.
        /// </summary>
        public GetKnowledgeBaseDependentAgentsResponseModelAgentDiscriminator()
        {
        }
    }
}