//HintName: G.Models.TemplatesCreateAgentsFromTemplateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TemplatesCreateAgentsFromTemplateRequest
    {
        /// <summary>
        /// The tags to assign to the agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// The name of the agent, optional otherwise a random one will be assigned
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_name")]
        public string? AgentName { get; set; }

        /// <summary>
        /// Set an initial sequence of messages, if not provided, the agent will start with the default message sequence, if an empty array is provided, the agent will start with no messages
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("initial_message_sequence")]
        public global::System.Collections.Generic.IList<global::G.TemplatesCreateAgentsFromTemplateRequestInitialMessageSequenceItem>? InitialMessageSequence { get; set; }

        /// <summary>
        /// The memory variables to assign to the agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory_variables")]
        public global::System.Collections.Generic.Dictionary<string, string>? MemoryVariables { get; set; }

        /// <summary>
        /// The tool variables to assign to the agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_variables")]
        public global::System.Collections.Generic.Dictionary<string, string>? ToolVariables { get; set; }

        /// <summary>
        /// The identity ids to assign to the agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identity_ids")]
        public global::System.Collections.Generic.IList<string>? IdentityIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesCreateAgentsFromTemplateRequest" /> class.
        /// </summary>
        /// <param name="tags">
        /// The tags to assign to the agent
        /// </param>
        /// <param name="agentName">
        /// The name of the agent, optional otherwise a random one will be assigned
        /// </param>
        /// <param name="initialMessageSequence">
        /// Set an initial sequence of messages, if not provided, the agent will start with the default message sequence, if an empty array is provided, the agent will start with no messages
        /// </param>
        /// <param name="memoryVariables">
        /// The memory variables to assign to the agent
        /// </param>
        /// <param name="toolVariables">
        /// The tool variables to assign to the agent
        /// </param>
        /// <param name="identityIds">
        /// The identity ids to assign to the agent
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TemplatesCreateAgentsFromTemplateRequest(
            global::System.Collections.Generic.IList<string>? tags,
            string? agentName,
            global::System.Collections.Generic.IList<global::G.TemplatesCreateAgentsFromTemplateRequestInitialMessageSequenceItem>? initialMessageSequence,
            global::System.Collections.Generic.Dictionary<string, string>? memoryVariables,
            global::System.Collections.Generic.Dictionary<string, string>? toolVariables,
            global::System.Collections.Generic.IList<string>? identityIds)
        {
            this.Tags = tags;
            this.AgentName = agentName;
            this.InitialMessageSequence = initialMessageSequence;
            this.MemoryVariables = memoryVariables;
            this.ToolVariables = toolVariables;
            this.IdentityIds = identityIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesCreateAgentsFromTemplateRequest" /> class.
        /// </summary>
        public TemplatesCreateAgentsFromTemplateRequest()
        {
        }
    }
}