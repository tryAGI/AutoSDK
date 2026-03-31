//HintName: G.Models.ServiceToken.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ServiceToken
    {
        /// <summary>
        /// Unique identifier for the service token
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Date of service token creation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public global::System.DateTime? Created { get; set; }

        /// <summary>
        /// Name of the service token
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preview_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PreviewName { get; set; }

        /// <summary>
        /// Unique identifier for the service token
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_account_id")]
        public global::System.Guid? ServiceAccountId { get; set; }

        /// <summary>
        /// The service account email (not routable)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_account_email")]
        public string? ServiceAccountEmail { get; set; }

        /// <summary>
        /// The service account name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_account_name")]
        public string? ServiceAccountName { get; set; }

        /// <summary>
        /// Unique identifier for the organization
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org_id")]
        public global::System.Guid? OrgId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceToken" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the service token
        /// </param>
        /// <param name="name">
        /// Name of the service token
        /// </param>
        /// <param name="previewName"></param>
        /// <param name="created">
        /// Date of service token creation
        /// </param>
        /// <param name="serviceAccountId">
        /// Unique identifier for the service token
        /// </param>
        /// <param name="serviceAccountEmail">
        /// The service account email (not routable)
        /// </param>
        /// <param name="serviceAccountName">
        /// The service account name
        /// </param>
        /// <param name="orgId">
        /// Unique identifier for the organization
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ServiceToken(
            global::System.Guid id,
            string name,
            string previewName,
            global::System.DateTime? created,
            global::System.Guid? serviceAccountId,
            string? serviceAccountEmail,
            string? serviceAccountName,
            global::System.Guid? orgId)
        {
            this.Id = id;
            this.Created = created;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.PreviewName = previewName ?? throw new global::System.ArgumentNullException(nameof(previewName));
            this.ServiceAccountId = serviceAccountId;
            this.ServiceAccountEmail = serviceAccountEmail;
            this.ServiceAccountName = serviceAccountName;
            this.OrgId = orgId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceToken" /> class.
        /// </summary>
        public ServiceToken()
        {
        }
    }
}