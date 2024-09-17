//HintName: G.Models.GetTokenResponse.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// GetTokenResponse contains the requested token.
    /// </summary>
    public sealed partial class GetTokenResponse
    {
        /// <summary>
        /// The API token resource.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("token")]
        public global::G.AllOf<global::G.ApiToken>? Token { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}