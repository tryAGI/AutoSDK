//HintName: G.Models.ApiKeyCreateParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Parameters for creating an API key.
    /// </summary>
    public sealed partial class ApiKeyCreateParams
    {
        /// <summary>
        /// A name/description for the API key<br/>
        /// Default Value: API Key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The scope of the API key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        public global::System.Collections.Generic.IList<global::G.Scope>? Scope { get; set; }

        /// <summary>
        /// Optional expiration datetime
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeyCreateParams" /> class.
        /// </summary>
        /// <param name="name">
        /// A name/description for the API key<br/>
        /// Default Value: API Key
        /// </param>
        /// <param name="scope">
        /// The scope of the API key
        /// </param>
        /// <param name="expiresAt">
        /// Optional expiration datetime
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiKeyCreateParams(
            string? name,
            global::System.Collections.Generic.IList<global::G.Scope>? scope,
            global::System.DateTime? expiresAt)
        {
            this.Name = name;
            this.Scope = scope;
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeyCreateParams" /> class.
        /// </summary>
        public ApiKeyCreateParams()
        {
        }
    }
}