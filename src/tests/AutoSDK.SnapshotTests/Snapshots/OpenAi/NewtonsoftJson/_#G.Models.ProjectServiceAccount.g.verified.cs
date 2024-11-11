//HintName: G.Models.ProjectServiceAccount.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents an individual service account in a project.
    /// </summary>
    public sealed partial class ProjectServiceAccount
    {
        /// <summary>
        /// The object type, which is always `organization.project.service_account`
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.ProjectServiceAccountObject Object { get; set; }

        /// <summary>
        /// The identifier, which can be referenced in API endpoints
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The name of the service account
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// `owner` or `member`
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ProjectServiceAccountRole Role { get; set; } = default!;

        /// <summary>
        /// The Unix timestamp (in seconds) of when the service account was created
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTimeOffset CreatedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectServiceAccount" /> class.
        /// </summary>
        /// <param name="object">
        /// The object type, which is always `organization.project.service_account`
        /// </param>
        /// <param name="id">
        /// The identifier, which can be referenced in API endpoints
        /// </param>
        /// <param name="name">
        /// The name of the service account
        /// </param>
        /// <param name="role">
        /// `owner` or `member`
        /// </param>
        /// <param name="createdAt">
        /// The Unix timestamp (in seconds) of when the service account was created
        /// </param>
        public ProjectServiceAccount(
            string id,
            string name,
            global::G.ProjectServiceAccountRole role,
            global::System.DateTimeOffset createdAt,
            global::G.ProjectServiceAccountObject @object)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Role = role;
            this.CreatedAt = createdAt;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectServiceAccount" /> class.
        /// </summary>
        public ProjectServiceAccount()
        {
        }
    }
}