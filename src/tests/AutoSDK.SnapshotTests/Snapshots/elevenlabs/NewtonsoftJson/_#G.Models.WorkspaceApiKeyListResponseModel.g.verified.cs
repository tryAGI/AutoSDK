//HintName: G.Models.WorkspaceApiKeyListResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkspaceApiKeyListResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("api-keys", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.WorkspaceApiKeyResponseModel> ApiKeys { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceApiKeyListResponseModel" /> class.
        /// </summary>
        /// <param name="apiKeys"></param>
        public WorkspaceApiKeyListResponseModel(
            global::System.Collections.Generic.IList<global::G.WorkspaceApiKeyResponseModel> apiKeys)
        {
            this.ApiKeys = apiKeys ?? throw new global::System.ArgumentNullException(nameof(apiKeys));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceApiKeyListResponseModel" /> class.
        /// </summary>
        public WorkspaceApiKeyListResponseModel()
        {
        }
    }
}