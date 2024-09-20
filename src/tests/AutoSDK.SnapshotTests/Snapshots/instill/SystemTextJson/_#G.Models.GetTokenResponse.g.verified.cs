//HintName: G.Models.GetTokenResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// GetTokenResponse contains the requested token.
    /// </summary>
    public sealed partial class GetTokenResponse
    {
        /// <summary>
        /// API tokens allow users to make requests to the Instill AI API.
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