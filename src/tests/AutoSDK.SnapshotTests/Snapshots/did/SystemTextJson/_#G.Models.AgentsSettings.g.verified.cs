//HintName: G.Models.AgentsSettings.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentsSettings
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_embed")]
        public double? NumEmbed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_origins")]
        public double? NumOrigins { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_ttl")]
        public double? SessionTtl { get; set; }

        /// <summary>
        /// OpenAI LLM models
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AgentsSettingsLlmModelJsonConverter))]
        public global::G.AgentsSettingsLlmModel? LlmModel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages_limit")]
        public double? MessagesLimit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsSettings" /> class.
        /// </summary>
        /// <param name="numEmbed"></param>
        /// <param name="numOrigins"></param>
        /// <param name="sessionTtl"></param>
        /// <param name="llmModel">
        /// OpenAI LLM models
        /// </param>
        /// <param name="messagesLimit"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentsSettings(
            double? numEmbed,
            double? numOrigins,
            double? sessionTtl,
            global::G.AgentsSettingsLlmModel? llmModel,
            double? messagesLimit)
        {
            this.NumEmbed = numEmbed;
            this.NumOrigins = numOrigins;
            this.SessionTtl = sessionTtl;
            this.LlmModel = llmModel;
            this.MessagesLimit = messagesLimit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsSettings" /> class.
        /// </summary>
        public AgentsSettings()
        {
        }
    }
}