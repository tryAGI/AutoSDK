//HintName: G.Models.TokenRestrictions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TokenRestrictions
    {
        /// <summary>
        /// This determines whether the token is enabled or disabled. Default is true, it's enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// This determines the allowed origins for this token. Validates the `Origin` header. Default is any origin.<br/>
        /// Only relevant for `public` tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowedOrigins")]
        public global::System.Collections.Generic.IList<string>? AllowedOrigins { get; set; }

        /// <summary>
        /// This determines which assistantIds can be used when creating a call. Default is any assistantId.<br/>
        /// Only relevant for `public` tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowedAssistantIds")]
        public global::System.Collections.Generic.IList<string>? AllowedAssistantIds { get; set; }

        /// <summary>
        /// This determines whether transient assistants can be used when creating a call. Default is true.<br/>
        /// If `allowedAssistantIds` is provided, this is automatically false.<br/>
        /// Only relevant for `public` tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowTransientAssistant")]
        public bool? AllowTransientAssistant { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenRestrictions" /> class.
        /// </summary>
        /// <param name="enabled">
        /// This determines whether the token is enabled or disabled. Default is true, it's enabled.
        /// </param>
        /// <param name="allowedOrigins">
        /// This determines the allowed origins for this token. Validates the `Origin` header. Default is any origin.<br/>
        /// Only relevant for `public` tokens.
        /// </param>
        /// <param name="allowedAssistantIds">
        /// This determines which assistantIds can be used when creating a call. Default is any assistantId.<br/>
        /// Only relevant for `public` tokens.
        /// </param>
        /// <param name="allowTransientAssistant">
        /// This determines whether transient assistants can be used when creating a call. Default is true.<br/>
        /// If `allowedAssistantIds` is provided, this is automatically false.<br/>
        /// Only relevant for `public` tokens.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TokenRestrictions(
            bool? enabled,
            global::System.Collections.Generic.IList<string>? allowedOrigins,
            global::System.Collections.Generic.IList<string>? allowedAssistantIds,
            bool? allowTransientAssistant)
        {
            this.Enabled = enabled;
            this.AllowedOrigins = allowedOrigins;
            this.AllowedAssistantIds = allowedAssistantIds;
            this.AllowTransientAssistant = allowTransientAssistant;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenRestrictions" /> class.
        /// </summary>
        public TokenRestrictions()
        {
        }
    }
}