//HintName: G.Models.ApiKeyUpdateParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Parameters for updating an API key.
    /// </summary>
    public sealed partial class ApiKeyUpdateParams
    {
        /// <summary>
        /// A name/description for the API key
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Optional expiration datetime
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expires_at")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeyUpdateParams" /> class.
        /// </summary>
        /// <param name="name">
        /// A name/description for the API key
        /// </param>
        /// <param name="expiresAt">
        /// Optional expiration datetime
        /// </param>
        public ApiKeyUpdateParams(
            string? name,
            global::System.DateTime? expiresAt)
        {
            this.Name = name;
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeyUpdateParams" /> class.
        /// </summary>
        public ApiKeyUpdateParams()
        {
        }
    }
}