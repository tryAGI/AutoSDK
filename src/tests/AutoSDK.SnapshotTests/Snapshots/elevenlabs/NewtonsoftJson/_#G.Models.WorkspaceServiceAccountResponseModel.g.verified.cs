//HintName: G.Models.WorkspaceServiceAccountResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkspaceServiceAccountResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("service_account_user_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ServiceAccountUserId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at_unix")]
        public int? CreatedAtUnix { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("api-keys", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.WorkspaceApiKeyResponseModel> ApiKeys { get; set; } = default!;

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("default_sharing_groups")]
        public global::System.Collections.Generic.IList<global::G.DefaultSharingGroupResponseModel>? DefaultSharingGroups { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceServiceAccountResponseModel" /> class.
        /// </summary>
        /// <param name="serviceAccountUserId"></param>
        /// <param name="name"></param>
        /// <param name="apiKeys"></param>
        /// <param name="createdAtUnix"></param>
        /// <param name="defaultSharingGroups">
        /// Default Value: []
        /// </param>
        public WorkspaceServiceAccountResponseModel(
            string serviceAccountUserId,
            string name,
            global::System.Collections.Generic.IList<global::G.WorkspaceApiKeyResponseModel> apiKeys,
            int? createdAtUnix,
            global::System.Collections.Generic.IList<global::G.DefaultSharingGroupResponseModel>? defaultSharingGroups)
        {
            this.ServiceAccountUserId = serviceAccountUserId ?? throw new global::System.ArgumentNullException(nameof(serviceAccountUserId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CreatedAtUnix = createdAtUnix;
            this.ApiKeys = apiKeys ?? throw new global::System.ArgumentNullException(nameof(apiKeys));
            this.DefaultSharingGroups = defaultSharingGroups;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceServiceAccountResponseModel" /> class.
        /// </summary>
        public WorkspaceServiceAccountResponseModel()
        {
        }
    }
}