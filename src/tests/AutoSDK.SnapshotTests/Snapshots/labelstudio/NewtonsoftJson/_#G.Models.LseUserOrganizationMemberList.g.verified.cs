//HintName: G.Models.LseUserOrganizationMemberList.g.cs

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
    public sealed partial class LseUserOrganizationMemberList
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("active_organization")]
        public int? ActiveOrganization { get; set; }

        /// <summary>
        /// Allow sending newsletters to user
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allow_newsletters")]
        public bool? AllowNewsletters { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("avatar")]
        public string Avatar { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("contributed_to_projects")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<global::G.LseUserOrganizationMemberListContributedToProject>? ContributedToProjects { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_projects")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<global::G.LseUserOrganizationMemberListCreatedProject>? CreatedProjects { get; set; }

        /// <summary>
        /// Custom keyboard shortcuts configuration for the user interface
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("custom_hotkeys")]
        public object? CustomHotkeys { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("date_joined")]
        public global::System.DateTime? DateJoined { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("email")]
        public string? Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("first_name")]
        public string? FirstName { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Default Value: ?<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("initials")]
        public string Initials { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("last_activity")]
        public global::System.DateTime LastActivity { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_name")]
        public string? LastName { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("lse_fields")]
        public global::G.LseFields LseFields { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("pause")]
        public string Pause { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("phone")]
        public string? Phone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("username", Required = global::Newtonsoft.Json.Required.Always)]
        public string Username { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LseUserOrganizationMemberList" /> class.
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
        /// <param name="pause">
        /// Included only in responses
        /// </param>
        public LseUserOrganizationMemberList(
            string username,
            int? activeOrganization,
            bool? allowNewsletters,
            object? customHotkeys,
            global::System.DateTime? dateJoined,
            string? email,
            string? firstName,
            string? lastName,
            string? phone,
            string avatar = default!,
            int id = default!,
            string initials = default!,
            global::System.DateTime lastActivity = default!,
            global::G.LseFields lseFields = default!,
            string pause = default!)
        {
            this.ActiveOrganization = activeOrganization;
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
            this.Pause = pause;
            this.Phone = phone;
            this.Username = username ?? throw new global::System.ArgumentNullException(nameof(username));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LseUserOrganizationMemberList" /> class.
        /// </summary>
        public LseUserOrganizationMemberList()
        {
        }
    }
}