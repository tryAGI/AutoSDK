//HintName: G.Models.UpdateAPIKeyRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateAPIKeyRequest
    {
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
        /// Initializes a new instance of the <see cref="UpdateAPIKeyRequest" /> class.
        /// </summary>
        /// <param name="apiKeyName"></param>
        public UpdateAPIKeyRequest(
            string apiKeyName)
        {
            this.ApiKeyName = apiKeyName ?? throw new global::System.ArgumentNullException(nameof(apiKeyName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAPIKeyRequest" /> class.
        /// </summary>
        public UpdateAPIKeyRequest()
        {
        }
    }
}