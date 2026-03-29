//HintName: G.Models.CreateResourceClientKeyResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateResourceClientKeyResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("client_key", Required = global::Newtonsoft.Json.Required.Always)]
        public string ClientKey { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allowed_domains", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> AllowedDomains { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("resource_id")]
        public string? ResourceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateResourceClientKeyResponse" /> class.
        /// </summary>
        /// <param name="clientKey"></param>
        /// <param name="allowedDomains"></param>
        /// <param name="name"></param>
        /// <param name="resourceId"></param>
        /// <param name="createdAt"></param>
        public CreateResourceClientKeyResponse(
            string clientKey,
            global::System.Collections.Generic.IList<string> allowedDomains,
            string? name,
            string? resourceId,
            string? createdAt)
        {
            this.ClientKey = clientKey ?? throw new global::System.ArgumentNullException(nameof(clientKey));
            this.AllowedDomains = allowedDomains ?? throw new global::System.ArgumentNullException(nameof(allowedDomains));
            this.Name = name;
            this.ResourceId = resourceId;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateResourceClientKeyResponse" /> class.
        /// </summary>
        public CreateResourceClientKeyResponse()
        {
        }
    }
}