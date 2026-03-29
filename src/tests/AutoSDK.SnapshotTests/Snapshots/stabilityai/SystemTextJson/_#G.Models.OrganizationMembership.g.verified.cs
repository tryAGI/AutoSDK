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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_default")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsDefault { get; set; }

        /// <summary>
        /// Example: My Organization
        /// </summary>
        /// <example>My Organization</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Example: MEMBER
        /// </summary>
        /// <example>MEMBER</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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