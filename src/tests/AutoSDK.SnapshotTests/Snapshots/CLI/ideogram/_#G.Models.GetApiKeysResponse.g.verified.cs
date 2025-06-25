//HintName: G.Models.GetApiKeysResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetApiKeysResponse
    {
        /// <summary>
        /// The current API keys that are active. Only returns redacted keys.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_api_keys")]
        public global::System.Collections.Generic.IList<global::G.RedactedApiKey>? CurrentApiKeys { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetApiKeysResponse" /> class.
        /// </summary>
        /// <param name="currentApiKeys">
        /// The current API keys that are active. Only returns redacted keys.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetApiKeysResponse(
            global::System.Collections.Generic.IList<global::G.RedactedApiKey>? currentApiKeys)
        {
            this.CurrentApiKeys = currentApiKeys;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetApiKeysResponse" /> class.
        /// </summary>
        public GetApiKeysResponse()
        {
        }
    }
}