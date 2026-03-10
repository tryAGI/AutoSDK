//HintName: G.Models.WorkspaceCreateApiKeyResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkspaceCreateApiKeyResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("xi-api-key", Required = global::Newtonsoft.Json.Required.Always)]
        public string XiApiKey { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("key_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string KeyId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceCreateApiKeyResponseModel" /> class.
        /// </summary>
        /// <param name="xiApiKey"></param>
        /// <param name="keyId"></param>
        public WorkspaceCreateApiKeyResponseModel(
            string xiApiKey,
            string keyId)
        {
            this.XiApiKey = xiApiKey ?? throw new global::System.ArgumentNullException(nameof(xiApiKey));
            this.KeyId = keyId ?? throw new global::System.ArgumentNullException(nameof(keyId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceCreateApiKeyResponseModel" /> class.
        /// </summary>
        public WorkspaceCreateApiKeyResponseModel()
        {
        }
    }
}