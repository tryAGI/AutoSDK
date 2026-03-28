//HintName: G.Models.ContextLimitExceededEventVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ContextLimitExceededEventVariant2
    {
        /// <summary>
        /// The type of event.<br/>
        /// Default Value: context_limit_exceeded
        /// </summary>
        /// <default>"context_limit_exceeded"</default>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// The maximum number of tokens allowed by the model<br/>
        /// Example: 128000
        /// </summary>
        /// <example>128000</example>
        [global::Newtonsoft.Json.JsonProperty("context_limit")]
        public long? ContextLimit { get; set; }

        /// <summary>
        /// The actual number of tokens in the request<br/>
        /// Example: 140658
        /// </summary>
        /// <example>140658</example>
        [global::Newtonsoft.Json.JsonProperty("actual_tokens")]
        public long? ActualTokens { get; set; }

        /// <summary>
        /// Human-readable error message<br/>
        /// Example: Context limit exceeded: 140658 tokens used, 128000 limit
        /// </summary>
        /// <example>Context limit exceeded: 140658 tokens used, 128000 limit</example>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContextLimitExceededEventVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of event.<br/>
        /// Default Value: context_limit_exceeded
        /// </param>
        /// <param name="message">
        /// Human-readable error message<br/>
        /// Example: Context limit exceeded: 140658 tokens used, 128000 limit
        /// </param>
        /// <param name="contextLimit">
        /// The maximum number of tokens allowed by the model<br/>
        /// Example: 128000
        /// </param>
        /// <param name="actualTokens">
        /// The actual number of tokens in the request<br/>
        /// Example: 140658
        /// </param>
        public ContextLimitExceededEventVariant2(
            string type,
            string message,
            long? contextLimit,
            long? actualTokens)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.ContextLimit = contextLimit;
            this.ActualTokens = actualTokens;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContextLimitExceededEventVariant2" /> class.
        /// </summary>
        public ContextLimitExceededEventVariant2()
        {
        }
    }
}