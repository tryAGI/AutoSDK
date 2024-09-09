//HintName: G.Models.ChatSearchResultConnector.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The connector used for fetching documents.
    /// </summary>
    public sealed partial class ChatSearchResultConnector
    {
        /// <summary>
        /// The identifier of the connector.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}