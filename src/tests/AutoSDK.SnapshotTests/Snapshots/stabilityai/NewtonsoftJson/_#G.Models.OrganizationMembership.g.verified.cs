//HintName: G.Models.OrganizationMembership.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrganizationMembership
    {
        /// <summary>
        /// Example: org-123456
        /// </summary>
        /// <example>org-123456</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::Newtonsoft.Json.JsonProperty("is_default", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsDefault { get; set; } = default!;

        /// <summary>
        /// Example: My Organization
        /// </summary>
        /// <example>My Organization</example>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Example: MEMBER
        /// </summary>
        /// <example>MEMBER</example>
        [global::Newtonsoft.Json.JsonProperty("role", Required = global::Newtonsoft.Json.Required.Always)]
        public string Role { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationMembership" /> class.
        /// </summary>
        /// <param name="id">
        /// Example: org-123456
        /// </param>
        /// <param name="isDefault">
        /// Example: false
        /// </param>
        /// <param name="name">
        /// Example: My Organization
        /// </param>
        /// <param name="role">
        /// Example: MEMBER
        /// </param>
        public OrganizationMembership(
            string id,
            bool isDefault,
            string name,
            string role)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.IsDefault = isDefault;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Role = role ?? throw new global::System.ArgumentNullException(nameof(role));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationMembership" /> class.
        /// </summary>
        public OrganizationMembership()
        {
        }
    }
}