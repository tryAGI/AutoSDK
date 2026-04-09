//HintName: G.Models.UpdateSettingsResponseAgents.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateSettingsResponseAgents
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("num_embed")]
        public double? NumEmbed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("num_origins")]
        public double? NumOrigins { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("session_ttl")]
        public double? SessionTtl { get; set; }

        /// <summary>
        /// OpenAI LLM models
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("llm_model")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.UpdateSettingsResponseAgentsLlmModelJsonConverter))]
        public global::G.UpdateSettingsResponseAgentsLlmModel? LlmModel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("messages_limit")]
        public double? MessagesLimit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSettingsResponseAgents" /> class.
        /// </summary>
        /// <param name="numEmbed"></param>
        /// <param name="numOrigins"></param>
        /// <param name="sessionTtl"></param>
        /// <param name="llmModel">
        /// OpenAI LLM models
        /// </param>
        /// <param name="messagesLimit"></param>
        public UpdateSettingsResponseAgents(
            double? numEmbed,
            double? numOrigins,
            double? sessionTtl,
            global::G.UpdateSettingsResponseAgentsLlmModel? llmModel,
            double? messagesLimit)
        {
            this.NumEmbed = numEmbed;
            this.NumOrigins = numOrigins;
            this.SessionTtl = sessionTtl;
            this.LlmModel = llmModel;
            this.MessagesLimit = messagesLimit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSettingsResponseAgents" /> class.
        /// </summary>
        public UpdateSettingsResponseAgents()
        {
        }
    }
}