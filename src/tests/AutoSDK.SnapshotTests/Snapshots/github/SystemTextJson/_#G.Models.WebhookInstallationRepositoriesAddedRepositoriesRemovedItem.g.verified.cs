//HintName: G.Models.WebhookInstallationRepositoriesAddedRepositoriesRemovedItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookInstallationRepositoriesAddedRepositoriesRemovedItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("full_name")]
        public string? FullName { get; set; }

        /// <summary>
        /// Unique identifier of the repository
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// The name of the repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        public string? NodeId { get; set; }

        /// <summary>
        /// Whether the repository is private or public.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private")]
        public bool? Private { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookInstallationRepositoriesAddedRepositoriesRemovedItem" /> class.
        /// </summary>
        /// <param name="fullName"></param>
        /// <param name="id">
        /// Unique identifier of the repository
        /// </param>
        /// <param name="name">
        /// The name of the repository.
        /// </param>
        /// <param name="nodeId"></param>
        /// <param name="private">
        /// Whether the repository is private or public.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookInstallationRepositoriesAddedRepositoriesRemovedItem(
            string? fullName,
            int? id,
            string? name,
            string? nodeId,
            bool? @private)
        {
            this.FullName = fullName;
            this.Id = id;
            this.Name = name;
            this.NodeId = nodeId;
            this.Private = @private;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookInstallationRepositoriesAddedRepositoriesRemovedItem" /> class.
        /// </summary>
        public WebhookInstallationRepositoriesAddedRepositoriesRemovedItem()
        {
        }
    }
}