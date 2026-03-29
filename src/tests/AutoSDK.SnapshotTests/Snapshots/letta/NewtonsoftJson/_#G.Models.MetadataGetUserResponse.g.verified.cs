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
        [global::Newtonsoft.Json.JsonProperty("email", Required = global::Newtonsoft.Json.Required.Always)]
        public string Email { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string OrganizationName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string OrganizationId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("current_project_name")]
        public string? CurrentProjectName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("current_project_id")]
        public string? CurrentProjectId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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