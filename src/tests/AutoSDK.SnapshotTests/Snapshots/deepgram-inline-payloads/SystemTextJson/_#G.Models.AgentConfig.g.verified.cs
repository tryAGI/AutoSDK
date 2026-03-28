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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "AgentConfig";

        /// <summary>
        /// The model to use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Agent instructions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentConfig" /> class.
        /// </summary>
        /// <param name="model">
        /// The model to use.
        /// </param>
        /// <param name="instructions">
        /// Agent instructions.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentConfig(
            string model,
            string? instructions,
            string type = "AgentConfig")
        {
            this.Type = type;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
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