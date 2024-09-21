//HintName: G.Models.RedactedApiKey.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A representation of an API key that does not contain the full key.
    /// </summary>
    public sealed partial class RedactedApiKey
    {
        /// <summary>
        /// A redacted text snippet of the API key. Contains the first 4 characters of the API key<br/>
        /// Example: vkpDja
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("redacted_api_key", Required = global::Newtonsoft.Json.Required.Always)]
        public string RedactedApiKey1 { get; set; } = default!;

        /// <summary>
        /// The time at which the key was created
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("creation_time", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreationTime { get; set; } = default!;

        /// <summary>
        /// A URL safe base64 encoded UUID<br/>
        /// Example: JRPVD7jWR1aTBYiJ0UFVOg==
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("api_key_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ApiKeyId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}