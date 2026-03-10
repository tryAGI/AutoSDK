//HintName: G.Models.ConversationInitiationClientDataInternal.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationInitiationClientDataInternal
    {
        /// <summary>
        /// Example: {"agent":{"first_message":"Hello, how can I help you today?","language":"en","prompt":{"llm":"gemini-2.0-flash-001","prompt":"You are a helpful assistant that can answer questions about the topic of the conversation."}},"tts":{"similarity_boost":0.8,"speed":1.0,"stability":0.5,"voice_id":"cjVigY5qzO86Huf0OWal"},"turn":{"soft_timeout_config":{"message":"Hhmmmm...yeah."}}}
        /// </summary>
        /// <example>{"agent":{"first_message":"Hello, how can I help you today?","language":"en","prompt":{"llm":"gemini-2.0-flash-001","prompt":"You are a helpful assistant that can answer questions about the topic of the conversation."}},"tts":{"similarity_boost":0.8,"speed":1.0,"stability":0.5,"voice_id":"cjVigY5qzO86Huf0OWal"},"turn":{"soft_timeout_config":{"message":"Hhmmmm...yeah."}}}</example>
        [global::Newtonsoft.Json.JsonProperty("conversation_config_override")]
        public global::G.ConversationConfigClientOverrideOutput? ConversationConfigOverride { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("custom_llm_extra_body")]
        public object? CustomLlmExtraBody { get; set; }

        /// <summary>
        /// ID of the end user participating in this conversation (for agent owner's user identification)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// Information about the source of conversation initiation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_info")]
        public global::G.ConversationInitiationSourceInfo? SourceInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dynamic_variables")]
        public object? DynamicVariables { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationInitiationClientDataInternal" /> class.
        /// </summary>
        /// <param name="conversationConfigOverride">
        /// Example: {"agent":{"first_message":"Hello, how can I help you today?","language":"en","prompt":{"llm":"gemini-2.0-flash-001","prompt":"You are a helpful assistant that can answer questions about the topic of the conversation."}},"tts":{"similarity_boost":0.8,"speed":1.0,"stability":0.5,"voice_id":"cjVigY5qzO86Huf0OWal"},"turn":{"soft_timeout_config":{"message":"Hhmmmm...yeah."}}}
        /// </param>
        /// <param name="customLlmExtraBody"></param>
        /// <param name="userId">
        /// ID of the end user participating in this conversation (for agent owner's user identification)
        /// </param>
        /// <param name="sourceInfo">
        /// Information about the source of conversation initiation
        /// </param>
        /// <param name="dynamicVariables"></param>
        public ConversationInitiationClientDataInternal(
            global::G.ConversationConfigClientOverrideOutput? conversationConfigOverride,
            object? customLlmExtraBody,
            string? userId,
            global::G.ConversationInitiationSourceInfo? sourceInfo,
            object? dynamicVariables)
        {
            this.ConversationConfigOverride = conversationConfigOverride;
            this.CustomLlmExtraBody = customLlmExtraBody;
            this.UserId = userId;
            this.SourceInfo = sourceInfo;
            this.DynamicVariables = dynamicVariables;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationInitiationClientDataInternal" /> class.
        /// </summary>
        public ConversationInitiationClientDataInternal()
        {
        }
    }
}