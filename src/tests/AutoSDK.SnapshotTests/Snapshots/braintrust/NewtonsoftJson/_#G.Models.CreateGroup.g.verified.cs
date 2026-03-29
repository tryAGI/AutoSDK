//HintName: G.Models.CreateGroup.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateGroup
    {
        /// <summary>
        /// Name of the group
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Textual description of the group
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Ids of users which belong to this group
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("member_users")]
        public global::System.Collections.Generic.IList<global::System.Guid>? MemberUsers { get; set; }

        /// <summary>
        /// Ids of the groups this group inherits from<br/>
        /// An inheriting group has all the users contained in its member groups, as well as all of their inherited users
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("member_groups")]
        public global::System.Collections.Generic.IList<global::System.Guid>? MemberGroups { get; set; }

        /// <summary>
        /// For nearly all users, this parameter should be unnecessary. But in the rare case that your API key belongs to multiple organizations, you may specify the name of the organization the group belongs in.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("org_name")]
        public string? OrgName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGroup" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the group
        /// </param>
        /// <param name="description">
        /// Textual description of the group
        /// </param>
        /// <param name="memberUsers">
        /// Ids of users which belong to this group
        /// </param>
        /// <param name="memberGroups">
        /// Ids of the groups this group inherits from<br/>
        /// An inheriting group has all the users contained in its member groups, as well as all of their inherited users
        /// </param>
        /// <param name="orgName">
        /// For nearly all users, this parameter should be unnecessary. But in the rare case that your API key belongs to multiple organizations, you may specify the name of the organization the group belongs in.
        /// </param>
        public CreateGroup(
            string name,
            string? description,
            global::System.Collections.Generic.IList<global::System.Guid>? memberUsers,
            global::System.Collections.Generic.IList<global::System.Guid>? memberGroups,
            string? orgName)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.MemberUsers = memberUsers;
            this.MemberGroups = memberGroups;
            this.OrgName = orgName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGroup" /> class.
        /// </summary>
        public CreateGroup()
        {
        }
    }
}