//HintName: G.Models.AgentOutputEventVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentOutputEventVariant2
    {
        /// <summary>
        /// The type of event.<br/>
        /// Default Value: agent_output
        /// </summary>
        /// <default>"agent_output"</default>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// The complete agent response content.<br/>
        /// Example: Hello! I can help you with your widget installation. Let me guide you through the process.
        /// </summary>
        /// <example>Hello! I can help you with your widget installation. Let me guide you through the process.</example>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public string Content { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentOutputEventVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of event.<br/>
        /// Default Value: agent_output
        /// </param>
        /// <param name="content">
        /// The complete agent response content.<br/>
        /// Example: Hello! I can help you with your widget installation. Let me guide you through the process.
        /// </param>
        public AgentOutputEventVariant2(
            string type,
            string content)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentOutputEventVariant2" /> class.
        /// </summary>
        public AgentOutputEventVariant2()
        {
        }
    }
}