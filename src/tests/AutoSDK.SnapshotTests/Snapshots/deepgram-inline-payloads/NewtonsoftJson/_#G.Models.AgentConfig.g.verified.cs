//HintName: G.Models.AgentConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for the AI agent.
    /// </summary>
    public sealed partial class AgentConfig
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"AgentConfig"</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; } = "AgentConfig";

        /// <summary>
        /// The model to use.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// Agent instructions.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentConfig" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="model">
        /// The model to use.
        /// </param>
        /// <param name="instructions">
        /// Agent instructions.
        /// </param>
        public AgentConfig(
            string model,
            string? instructions,
            string type = "AgentConfig")
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Type = type;
            this.Instructions = instructions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentConfig" /> class.
        /// </summary>
        public AgentConfig()
        {
        }
    }
}