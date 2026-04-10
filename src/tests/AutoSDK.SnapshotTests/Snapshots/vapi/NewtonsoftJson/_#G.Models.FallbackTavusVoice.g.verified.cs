//HintName: G.Models.FallbackTavusVoice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FallbackTavusVoice
    {
        /// <summary>
        /// This is the flag to toggle voice caching for the assistant.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("cachingEnabled")]
        public bool? CachingEnabled { get; set; }

        /// <summary>
        /// This is the voice provider that will be used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.FallbackTavusVoiceProviderJsonConverter))]
        public global::G.FallbackTavusVoiceProvider Provider { get; set; }

        /// <summary>
        /// This is the provider-specific ID that will be used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voiceId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<global::G.FallbackTavusVoiceVoiceId?, string> VoiceId { get; set; } = default!;

        /// <summary>
        /// This is the unique identifier for the persona that the replica will use in the conversation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("personaId")]
        public string? PersonaId { get; set; }

        /// <summary>
        /// This is the url that will receive webhooks with updates regarding the conversation state.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("callbackUrl")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// This is the name for the conversation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("conversationName")]
        public string? ConversationName { get; set; }

        /// <summary>
        /// This is the context that will be appended to any context provided in the persona, if one is provided.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("conversationalContext")]
        public string? ConversationalContext { get; set; }

        /// <summary>
        /// This is the custom greeting that the replica will give once a participant joines the conversation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("customGreeting")]
        public string? CustomGreeting { get; set; }

        /// <summary>
        /// These are optional properties used to customize the conversation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("properties")]
        public global::G.TavusConversationProperties? Properties { get; set; }

        /// <summary>
        /// This is the plan for chunking the model output before it is sent to the voice provider.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chunkPlan")]
        public global::G.ChunkPlan? ChunkPlan { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FallbackTavusVoice" /> class.
        /// </summary>
        /// <param name="voiceId">
        /// This is the provider-specific ID that will be used.
        /// </param>
        /// <param name="cachingEnabled">
        /// This is the flag to toggle voice caching for the assistant.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </param>
        /// <param name="provider">
        /// This is the voice provider that will be used.
        /// </param>
        /// <param name="personaId">
        /// This is the unique identifier for the persona that the replica will use in the conversation.
        /// </param>
        /// <param name="callbackUrl">
        /// This is the url that will receive webhooks with updates regarding the conversation state.
        /// </param>
        /// <param name="conversationName">
        /// This is the name for the conversation.
        /// </param>
        /// <param name="conversationalContext">
        /// This is the context that will be appended to any context provided in the persona, if one is provided.
        /// </param>
        /// <param name="customGreeting">
        /// This is the custom greeting that the replica will give once a participant joines the conversation.
        /// </param>
        /// <param name="properties">
        /// These are optional properties used to customize the conversation.
        /// </param>
        /// <param name="chunkPlan">
        /// This is the plan for chunking the model output before it is sent to the voice provider.
        /// </param>
        public FallbackTavusVoice(
            global::G.OneOf<global::G.FallbackTavusVoiceVoiceId?, string> voiceId,
            bool? cachingEnabled,
            global::G.FallbackTavusVoiceProvider provider,
            string? personaId,
            string? callbackUrl,
            string? conversationName,
            string? conversationalContext,
            string? customGreeting,
            global::G.TavusConversationProperties? properties,
            global::G.ChunkPlan? chunkPlan)
        {
            this.CachingEnabled = cachingEnabled;
            this.Provider = provider;
            this.VoiceId = voiceId;
            this.PersonaId = personaId;
            this.CallbackUrl = callbackUrl;
            this.ConversationName = conversationName;
            this.ConversationalContext = conversationalContext;
            this.CustomGreeting = customGreeting;
            this.Properties = properties;
            this.ChunkPlan = chunkPlan;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FallbackTavusVoice" /> class.
        /// </summary>
        public FallbackTavusVoice()
        {
        }
    }
}