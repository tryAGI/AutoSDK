//HintName: G.Models.MetadataGetUserResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MetadataGetUserResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrganizationName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrganizationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_project_name")]
        public string? CurrentProjectName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_project_id")]
        public string? CurrentProjectId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataGetUserResponse" /> class.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="name"></param>
        /// <param name="organizationName"></param>
        /// <param name="organizationId"></param>
        /// <param name="currentProjectName"></param>
        /// <param name="currentProjectId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MetadataGetUserResponse(
            string email,
            string name,
            string organizationName,
            string organizationId,
            string? currentProjectName,
            string? currentProjectId)
        {
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.OrganizationName = organizationName ?? throw new global::System.ArgumentNullException(nameof(organizationName));
            this.OrganizationId = organizationId ?? throw new global::System.ArgumentNullException(nameof(organizationId));
            this.CurrentProjectName = currentProjectName;
            this.CurrentProjectId = currentProjectId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataGetUserResponse" /> class.
        /// </summary>
        public MetadataGetUserResponse()
        {
        }
    }
}