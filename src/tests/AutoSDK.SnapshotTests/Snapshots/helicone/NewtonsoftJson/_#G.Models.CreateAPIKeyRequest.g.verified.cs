//HintName: G.Models.CreateAPIKeyRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAPIKeyRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("key_permissions")]
        public global::G.CreateAPIKeyRequestKeyPermissions? KeyPermissions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("api_key_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string ApiKeyName { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAPIKeyRequest" /> class.
        /// </summary>
        /// <param name="apiKeyName"></param>
        /// <param name="keyPermissions"></param>
        public CreateAPIKeyRequest(
            string apiKeyName,
            global::G.CreateAPIKeyRequestKeyPermissions? keyPermissions)
        {
            this.KeyPermissions = keyPermissions;
            this.ApiKeyName = apiKeyName ?? throw new global::System.ArgumentNullException(nameof(apiKeyName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAPIKeyRequest" /> class.
        /// </summary>
        public CreateAPIKeyRequest()
        {
        }
    }
}