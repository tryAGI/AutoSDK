//HintName: G.Models.Role.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Role
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("display_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string DisplayName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization_id")]
        public global::System.Guid? OrganizationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("permissions", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Permissions { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("access_scope")]
        public global::G.AccessScope? AccessScope { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Role" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="displayName"></param>
        /// <param name="description"></param>
        /// <param name="organizationId"></param>
        /// <param name="permissions"></param>
        /// <param name="accessScope"></param>
        public Role(
            global::System.Guid id,
            string name,
            string displayName,
            string description,
            global::System.Collections.Generic.IList<string> permissions,
            global::System.Guid? organizationId,
            global::G.AccessScope? accessScope)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Permissions = permissions ?? throw new global::System.ArgumentNullException(nameof(permissions));
            this.OrganizationId = organizationId;
            this.AccessScope = accessScope;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Role" /> class.
        /// </summary>
        public Role()
        {
        }
    }
}