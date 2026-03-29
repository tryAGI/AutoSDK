//HintName: G.Models.ApiKeyResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response for API key creation
    /// </summary>
    public sealed partial class ApiKeyResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("publicKey", Required = global::Newtonsoft.Json.Required.Always)]
        public string PublicKey { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("secretKey", Required = global::Newtonsoft.Json.Required.Always)]
        public string SecretKey { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("displaySecretKey", Required = global::Newtonsoft.Json.Required.Always)]
        public string DisplaySecretKey { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("note")]
        public string? Note { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeyResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="createdAt"></param>
        /// <param name="publicKey"></param>
        /// <param name="secretKey"></param>
        /// <param name="displaySecretKey"></param>
        /// <param name="note"></param>
        public ApiKeyResponse(
            string id,
            global::System.DateTime createdAt,
            string publicKey,
            string secretKey,
            string displaySecretKey,
            string? note)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.PublicKey = publicKey ?? throw new global::System.ArgumentNullException(nameof(publicKey));
            this.SecretKey = secretKey ?? throw new global::System.ArgumentNullException(nameof(secretKey));
            this.DisplaySecretKey = displaySecretKey ?? throw new global::System.ArgumentNullException(nameof(displaySecretKey));
            this.Note = note;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeyResponse" /> class.
        /// </summary>
        public ApiKeyResponse()
        {
        }
    }
}