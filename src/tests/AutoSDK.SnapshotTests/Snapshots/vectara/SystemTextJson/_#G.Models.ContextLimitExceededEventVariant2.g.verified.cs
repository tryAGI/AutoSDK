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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "context_limit_exceeded";

        /// <summary>
        /// The maximum number of tokens allowed by the model<br/>
        /// Example: 128000
        /// </summary>
        /// <example>128000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_limit")]
        public long? ContextLimit { get; set; }

        /// <summary>
        /// The actual number of tokens in the request<br/>
        /// Example: 140658
        /// </summary>
        /// <example>140658</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("actual_tokens")]
        public long? ActualTokens { get; set; }

        /// <summary>
        /// Human-readable error message<br/>
        /// Example: Context limit exceeded: 140658 tokens used, 128000 limit
        /// </summary>
        /// <example>Context limit exceeded: 140658 tokens used, 128000 limit</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContextLimitExceededEventVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of event.<br/>
        /// Default Value: context_limit_exceeded
        /// </param>
        /// <param name="contextLimit">
        /// The maximum number of tokens allowed by the model<br/>
        /// Example: 128000
        /// </param>
        /// <param name="actualTokens">
        /// The actual number of tokens in the request<br/>
        /// Example: 140658
        /// </param>
        /// <param name="message">
        /// Human-readable error message<br/>
        /// Example: Context limit exceeded: 140658 tokens used, 128000 limit
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContextLimitExceededEventVariant2(
            string type,
            string message,
            long? contextLimit,
            long? actualTokens)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.ContextLimit = contextLimit;
            this.ActualTokens = actualTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContextLimitExceededEventVariant2" /> class.
        /// </summary>
        public ContextLimitExceededEventVariant2()
        {
        }
    }
}