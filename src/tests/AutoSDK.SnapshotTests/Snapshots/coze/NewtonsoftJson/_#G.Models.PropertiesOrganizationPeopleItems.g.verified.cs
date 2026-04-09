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
        [global::Newtonsoft.Json.JsonProperty("organization_role_type", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.PropertiesOrganizationPeopleItemsOrganizationRoleTypeJsonConverter))]
        public global::G.PropertiesOrganizationPeopleItemsOrganizationRoleType OrganizationRoleType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesOrganizationPeopleItems" /> class.
        /// </summary>
        /// <param name="organizationRoleType"></param>
        /// <param name="userId"></param>
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