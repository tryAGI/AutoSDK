//HintName: G.Models.ApiToken.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiToken
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("token", Required = global::Newtonsoft.Json.Required.Always)]
        public string Token { get; set; } = default!;

        /// <summary>
        /// creation unix timestamp
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTimeOffset CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("token_id")]
        public string? TokenId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiToken" /> class.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="createdAt">
        /// creation unix timestamp
        /// </param>
        /// <param name="name"></param>
        /// <param name="tokenId"></param>
        public ApiToken(
            string token,
            global::System.DateTimeOffset createdAt,
            string name,
            string? tokenId)
        {
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
            this.CreatedAt = createdAt;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.TokenId = tokenId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiToken" /> class.
        /// </summary>
        public ApiToken()
        {
        }
    }
}