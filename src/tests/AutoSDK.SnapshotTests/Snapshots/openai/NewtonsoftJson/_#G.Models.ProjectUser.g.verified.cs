//HintName: G.Models.ProjectUser.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents an individual user in a project.
    /// </summary>
    public sealed partial class ProjectUser
    {
        /// <summary>
        /// The Unix timestamp (in seconds) of when the project was added.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("added_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTimeOffset AddedAt { get; set; } = default!;

        /// <summary>
        /// The email address of the user
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("email", Required = global::Newtonsoft.Json.Required.Always)]
        public string Email { get; set; } = default!;

        /// <summary>
        /// The identifier, which can be referenced in API endpoints
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The name of the user
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The object type, which is always `organization.project.user`
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.ProjectUserObject Object { get; set; }

        /// <summary>
        /// `owner` or `member`
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ProjectUserRole Role { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectUser" /> class.
        /// </summary>
        /// <param name="addedAt">
        /// The Unix timestamp (in seconds) of when the project was added.
        /// </param>
        /// <param name="email">
        /// The email address of the user
        /// </param>
        /// <param name="id">
        /// The identifier, which can be referenced in API endpoints
        /// </param>
        /// <param name="name">
        /// The name of the user
        /// </param>
        /// <param name="object">
        /// The object type, which is always `organization.project.user`
        /// </param>
        /// <param name="role">
        /// `owner` or `member`
        /// </param>
        public ProjectUser(
            global::System.DateTimeOffset addedAt,
            string email,
            string id,
            string name,
            global::G.ProjectUserRole role,
            global::G.ProjectUserObject @object)
        {
            this.AddedAt = addedAt;
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Role = role;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectUser" /> class.
        /// </summary>
        public ProjectUser()
        {
        }
    }
}