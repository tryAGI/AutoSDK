//HintName: G.Models.PropertiesOrganizationPeopleItems.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PropertiesOrganizationPeopleItems
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_role_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PropertiesOrganizationPeopleItemsOrganizationRoleTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PropertiesOrganizationPeopleItemsOrganizationRoleType OrganizationRoleType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesOrganizationPeopleItems" /> class.
        /// </summary>
        /// <param name="organizationRoleType"></param>
        /// <param name="userId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PropertiesOrganizationPeopleItems(
            global::G.PropertiesOrganizationPeopleItemsOrganizationRoleType organizationRoleType,
            string userId)
        {
            this.OrganizationRoleType = organizationRoleType;
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesOrganizationPeopleItems" /> class.
        /// </summary>
        public PropertiesOrganizationPeopleItems()
        {
        }
    }
}