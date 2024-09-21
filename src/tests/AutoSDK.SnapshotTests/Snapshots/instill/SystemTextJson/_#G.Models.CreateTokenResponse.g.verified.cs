//HintName: G.Models.CreateTokenResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// CreateTokenResponse contains the created token.
    /// </summary>
    public sealed partial class CreateTokenResponse
    {
        /// <summary>
        /// The created API token resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        public global::G.ApiToken? Token { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}