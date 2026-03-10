//HintName: G.Models.AgentWorkflowRequestModelNodesDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentWorkflowRequestModelNodesDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AgentWorkflowRequestModelNodesDiscriminatorTypeJsonConverter))]
        public global::G.AgentWorkflowRequestModelNodesDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentWorkflowRequestModelNodesDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentWorkflowRequestModelNodesDiscriminator(
            global::G.AgentWorkflowRequestModelNodesDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentWorkflowRequestModelNodesDiscriminator" /> class.
        /// </summary>
        public AgentWorkflowRequestModelNodesDiscriminator()
        {
        }
    }
}