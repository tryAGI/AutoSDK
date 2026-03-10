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
        [global::System.Text.Json.Serialization.JsonPropertyName("service_account_user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServiceAccountUserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at_unix")]
        public int? CreatedAtUnix { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api-keys")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.WorkspaceApiKeyResponseModel> ApiKeys { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_sharing_groups")]
        public global::System.Collections.Generic.IList<global::G.DefaultSharingGroupResponseModel>? DefaultSharingGroups { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceServiceAccountResponseModel" /> class.
        /// </summary>
        /// <param name="serviceAccountUserId"></param>
        /// <param name="name"></param>
        /// <param name="createdAtUnix"></param>
        /// <param name="apiKeys"></param>
        /// <param name="defaultSharingGroups">
        /// Default Value: []
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkspaceServiceAccountResponseModel(
            string serviceAccountUserId,
            string name,
            global::System.Collections.Generic.IList<global::G.WorkspaceApiKeyResponseModel> apiKeys,
            int? createdAtUnix,
            global::System.Collections.Generic.IList<global::G.DefaultSharingGroupResponseModel>? defaultSharingGroups)
        {
            this.ServiceAccountUserId = serviceAccountUserId ?? throw new global::System.ArgumentNullException(nameof(serviceAccountUserId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ApiKeys = apiKeys ?? throw new global::System.ArgumentNullException(nameof(apiKeys));
            this.CreatedAtUnix = createdAtUnix;
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