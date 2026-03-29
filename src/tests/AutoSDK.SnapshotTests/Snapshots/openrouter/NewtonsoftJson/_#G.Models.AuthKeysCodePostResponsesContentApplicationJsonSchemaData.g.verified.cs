//HintName: G.Models.AuthKeysCodePostResponsesContentApplicationJsonSchemaData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Auth code data
    /// </summary>
    public sealed partial class AuthKeysCodePostResponsesContentApplicationJsonSchemaData
    {
        /// <summary>
        /// The authorization code ID to use in the exchange request
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The application ID associated with this auth code
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("app_id", Required = global::Newtonsoft.Json.Required.Always)]
        public double AppId { get; set; } = default!;

        /// <summary>
        /// ISO 8601 timestamp of when the auth code was created
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthKeysCodePostResponsesContentApplicationJsonSchemaData" /> class.
        /// </summary>
        /// <param name="id">
        /// The authorization code ID to use in the exchange request
        /// </param>
        /// <param name="appId">
        /// The application ID associated with this auth code
        /// </param>
        /// <param name="createdAt">
        /// ISO 8601 timestamp of when the auth code was created
        /// </param>
        public AuthKeysCodePostResponsesContentApplicationJsonSchemaData(
            string id,
            double appId,
            string createdAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.AppId = appId;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthKeysCodePostResponsesContentApplicationJsonSchemaData" /> class.
        /// </summary>
        public AuthKeysCodePostResponsesContentApplicationJsonSchemaData()
        {
        }
    }
}