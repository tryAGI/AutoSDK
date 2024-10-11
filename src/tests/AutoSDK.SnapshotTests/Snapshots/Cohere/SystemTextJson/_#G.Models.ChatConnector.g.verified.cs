//HintName: G.Models.ChatConnector.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The connector used for fetching documents.
    /// </summary>
    public sealed partial class ChatConnector
    {
        /// <summary>
        /// The identifier of the connector.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// When specified, this user access token will be passed to the connector in the Authorization header instead of the Cohere generated one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_access_token")]
        public string? UserAccessToken { get; set; }

        /// <summary>
        /// Defaults to `false`.<br/>
        /// When `true`, the request will continue if this connector returned an error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("continue_on_failure")]
        public bool? ContinueOnFailure { get; set; }

        /// <summary>
        /// Provides the connector with different settings at request time. The key/value pairs of this object are specific to each connector.<br/>
        /// For example, the connector `web-search` supports the `site` option, which limits search results to the specified domain.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        public object? Options { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}