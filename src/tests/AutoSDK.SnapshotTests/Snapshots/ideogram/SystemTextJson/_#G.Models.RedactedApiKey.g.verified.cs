//HintName: G.Models.RedactedApiKey.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A representation of an API key that does not contain the full key.<br/>
    /// Example: {"creation_time":"2000-01-23T04:56:07.0000000\u002B00:00","redacted_api_key":"vkpDja","api_key_id":"JRPVD7jWR1aTBYiJ0UFVOg=="}
    /// </summary>
    public sealed partial class RedactedApiKey
    {
        /// <summary>
        /// A redacted text snippet of the API key. Contains the first 4 characters of the API key<br/>
        /// Example: vkpDja
        /// </summary>
        /// <example>vkpDja</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("redacted_api_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RedactedApiKey1 { get; set; }

        /// <summary>
        /// The time at which the key was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creation_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreationTime { get; set; }

        /// <summary>
        /// A URL safe base64 encoded UUID<br/>
        /// Example: JRPVD7jWR1aTBYiJ0UFVOg==
        /// </summary>
        /// <example>JRPVD7jWR1aTBYiJ0UFVOg==</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApiKeyId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RedactedApiKey" /> class.
        /// </summary>
        /// <param name="redactedApiKey1">
        /// A redacted text snippet of the API key. Contains the first 4 characters of the API key<br/>
        /// Example: vkpDja
        /// </param>
        /// <param name="creationTime">
        /// The time at which the key was created
        /// </param>
        /// <param name="apiKeyId">
        /// A URL safe base64 encoded UUID<br/>
        /// Example: JRPVD7jWR1aTBYiJ0UFVOg==
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RedactedApiKey(
            string redactedApiKey1,
            global::System.DateTime creationTime,
            string apiKeyId)
        {
            this.RedactedApiKey1 = redactedApiKey1 ?? throw new global::System.ArgumentNullException(nameof(redactedApiKey1));
            this.CreationTime = creationTime;
            this.ApiKeyId = apiKeyId ?? throw new global::System.ArgumentNullException(nameof(apiKeyId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RedactedApiKey" /> class.
        /// </summary>
        public RedactedApiKey()
        {
        }
    }
}