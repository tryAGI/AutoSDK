//HintName: G.Models.CustomConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bot_config")]
        public global::G.BotConfig? BotConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_config")]
        public global::G.ModelConfig? ModelConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomConfig" /> class.
        /// </summary>
        /// <param name="botConfig"></param>
        /// <param name="modelConfig"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomConfig(
            global::G.BotConfig? botConfig,
            global::G.ModelConfig? modelConfig)
        {
            this.BotConfig = botConfig;
            this.ModelConfig = modelConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomConfig" /> class.
        /// </summary>
        public CustomConfig()
        {
        }
    }
}