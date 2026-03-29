//HintName: G.Models.Group.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A group is a collection of users which can be assigned an ACL<br/>
    /// Groups can consist of individual users, as well as a set of groups they inherit from
    /// </summary>
    public sealed partial class Group
    {
        /// <summary>
        /// Unique identifier for the group
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// Unique id for the organization that the group belongs under<br/>
        /// It is forbidden to change the org after creating a group
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("org_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid OrgId { get; set; } = default!;

        /// <summary>
        /// Identifies the user who created the group
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id")]
        public global::System.Guid? UserId { get; set; }

        /// <summary>
        /// Date of group creation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created")]
        public global::System.DateTime? Created { get; set; }

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
        /// Date of group deletion, or null if the group is still active
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deleted_at")]
        public global::System.DateTime? DeletedAt { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Group" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the group
        /// </param>
        /// <param name="orgId">
        /// Unique id for the organization that the group belongs under<br/>
        /// It is forbidden to change the org after creating a group
        /// </param>
        /// <param name="name">
        /// Name of the group
        /// </param>
        /// <param name="userId">
        /// Identifies the user who created the group
        /// </param>
        /// <param name="created">
        /// Date of group creation
        /// </param>
        /// <param name="description">
        /// Textual description of the group
        /// </param>
        /// <param name="deletedAt">
        /// Date of group deletion, or null if the group is still active
        /// </param>
        /// <param name="memberUsers">
        /// Ids of users which belong to this group
        /// </param>
        /// <param name="memberGroups">
        /// Ids of the groups this group inherits from<br/>
        /// An inheriting group has all the users contained in its member groups, as well as all of their inherited users
        /// </param>
        public Group(
            global::System.Guid id,
            global::System.Guid orgId,
            string name,
            global::System.Guid? userId,
            global::System.DateTime? created,
            string? description,
            global::System.DateTime? deletedAt,
            global::System.Collections.Generic.IList<global::System.Guid>? memberUsers,
            global::System.Collections.Generic.IList<global::System.Guid>? memberGroups)
        {
            this.Id = id;
            this.OrgId = orgId;
            this.UserId = userId;
            this.Created = created;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.DeletedAt = deletedAt;
            this.MemberUsers = memberUsers;
            this.MemberGroups = memberGroups;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Group" /> class.
        /// </summary>
        public Group()
        {
        }
    }
}