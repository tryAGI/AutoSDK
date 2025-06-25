//HintName: G.Models.Agent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Agent
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("agentId")]
        public global::System.Guid AgentId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public global::System.DateTime Created { get; set; } = default!;

        /// <summary>
        /// A CallTemplate that can be used to create Ultravox calls with shared properties.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callTemplate")]
        public global::G.UltravoxV1CallTemplate? CallTemplate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Agent" /> class.
        /// </summary>
        /// <param name="agentId">
        /// Included only in responses
        /// </param>
        /// <param name="name"></param>
        /// <param name="created">
        /// Included only in responses
        /// </param>
        /// <param name="callTemplate">
        /// A CallTemplate that can be used to create Ultravox calls with shared properties.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Agent(
            string name,
            global::G.UltravoxV1CallTemplate? callTemplate,
            global::System.Guid agentId = default!,
            global::System.DateTime created = default!)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.AgentId = agentId;
            this.Created = created;
            this.CallTemplate = callTemplate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Agent" /> class.
        /// </summary>
        public Agent()
        {
        }
    }
}