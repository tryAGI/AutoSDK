//HintName: G.Models.WhoAmIUser.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// A ModelSerializer that takes additional arguments for<br/>
    /// "fields", "omit" and "expand" in order to<br/>
    /// control which fields are displayed, and whether to replace simple<br/>
    /// values with complex, nested serializations
    /// </summary>
    public sealed partial class WhoAmIUser
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active_organization")]
        public int? ActiveOrganization { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("active_organization_meta")]
        public string ActiveOrganizationMeta { get; set; } = default!;

        /// <summary>
        /// Allow sending newsletters to user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_newsletters")]
        public bool? AllowNewsletters { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar")]
        public string Avatar { get; set; } = default!;

        /// <summary>
        /// Custom keyboard shortcuts configuration for the user interface
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_hotkeys")]
        public object? CustomHotkeys { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date_joined")]
        public global::System.DateTime? DateJoined { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_name")]
        public string? FirstName { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Default Value: ?<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("initials")]
        public string Initials { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_activity")]
        public global::System.DateTime LastActivity { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_name")]
        public string? LastName { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("lse_fields")]
        public global::G.WhoAmILseFields LseFields { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("org_membership")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<global::G.OrganizationMembership> OrgMembership { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_membership")]
        public global::G.OrganizationMembership OrganizationMembership { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("pause")]
        public string Pause { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions")]
        public global::System.Collections.Generic.IList<string> Permissions { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone")]
        public string? Phone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Username { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WhoAmIUser" /> class.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="activeOrganization"></param>
        /// <param name="allowNewsletters">
        /// Allow sending newsletters to user
        /// </param>
        /// <param name="customHotkeys">
        /// Custom keyboard shortcuts configuration for the user interface
        /// </param>
        /// <param name="dateJoined"></param>
        /// <param name="email"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="phone"></param>
        /// <param name="activeOrganizationMeta">
        /// Included only in responses
        /// </param>
        /// <param name="avatar">
        /// Included only in responses
        /// </param>
        /// <param name="id">
        /// Included only in responses
        /// </param>
        /// <param name="initials">
        /// Default Value: ?<br/>
        /// Included only in responses
        /// </param>
        /// <param name="lastActivity">
        /// Included only in responses
        /// </param>
        /// <param name="lseFields">
        /// Included only in responses
        /// </param>
        /// <param name="organizationMembership">
        /// Included only in responses
        /// </param>
        /// <param name="pause">
        /// Included only in responses
        /// </param>
        /// <param name="permissions">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WhoAmIUser(
            string username,
            int? activeOrganization,
            bool? allowNewsletters,
            object? customHotkeys,
            global::System.DateTime? dateJoined,
            string? email,
            string? firstName,
            string? lastName,
            string? phone,
            string activeOrganizationMeta = default!,
            string avatar = default!,
            int id = default!,
            string initials = default!,
            global::System.DateTime lastActivity = default!,
            global::G.WhoAmILseFields lseFields = default!,
            global::G.OrganizationMembership organizationMembership = default!,
            string pause = default!,
            global::System.Collections.Generic.IList<string> permissions = default!)
        {
            this.ActiveOrganization = activeOrganization;
            this.ActiveOrganizationMeta = activeOrganizationMeta;
            this.AllowNewsletters = allowNewsletters;
            this.Avatar = avatar;
            this.CustomHotkeys = customHotkeys;
            this.DateJoined = dateJoined;
            this.Email = email;
            this.FirstName = firstName;
            this.Id = id;
            this.Initials = initials;
            this.LastActivity = lastActivity;
            this.LastName = lastName;
            this.LseFields = lseFields;
            this.OrganizationMembership = organizationMembership;
            this.Pause = pause;
            this.Permissions = permissions;
            this.Phone = phone;
            this.Username = username ?? throw new global::System.ArgumentNullException(nameof(username));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WhoAmIUser" /> class.
        /// </summary>
        public WhoAmIUser()
        {
        }
    }
}