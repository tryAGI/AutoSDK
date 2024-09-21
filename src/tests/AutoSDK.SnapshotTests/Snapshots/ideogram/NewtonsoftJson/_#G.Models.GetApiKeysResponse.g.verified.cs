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
        [global::Newtonsoft.Json.JsonProperty("current_api_keys")]
        public global::System.Collections.Generic.IList<global::G.RedactedApiKey>? CurrentApiKeys { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}