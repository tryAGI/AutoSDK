//HintName: G.Models.OrganizationRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Organization roles
    /// </summary>
    public sealed partial class OrganizationRole
    {
        /// <summary>
        /// The unique identifier of the role.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public long Id { get; set; } = default!;

        /// <summary>
        /// The name of the role.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// A short description about who this role is for or what permissions it grants.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// A list of permissions included in this role.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("permissions", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Permissions { get; set; } = default!;

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.NullableSimpleUser? Organization { get; set; } = default!;

        /// <summary>
        /// The date and time the role was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// The date and time the role was last updated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationRole" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the role.
        /// </param>
        /// <param name="name">
        /// The name of the role.
        /// </param>
        /// <param name="description">
        /// A short description about who this role is for or what permissions it grants.
        /// </param>
        /// <param name="permissions">
        /// A list of permissions included in this role.
        /// </param>
        /// <param name="organization">
        /// A GitHub user.
        /// </param>
        /// <param name="createdAt">
        /// The date and time the role was created.
        /// </param>
        /// <param name="updatedAt">
        /// The date and time the role was last updated.
        /// </param>
        public OrganizationRole(
            long id,
            string name,
            global::System.Collections.Generic.IList<string> permissions,
            global::G.NullableSimpleUser? organization,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? description)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Permissions = permissions ?? throw new global::System.ArgumentNullException(nameof(permissions));
            this.Organization = organization ?? throw new global::System.ArgumentNullException(nameof(organization));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationRole" /> class.
        /// </summary>
        public OrganizationRole()
        {
        }
    }
}