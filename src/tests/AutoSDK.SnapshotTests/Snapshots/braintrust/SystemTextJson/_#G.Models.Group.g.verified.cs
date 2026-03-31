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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Unique id for the organization that the group belongs under<br/>
        /// It is forbidden to change the org after creating a group
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid OrgId { get; set; }

        /// <summary>
        /// Identifies the user who created the group
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public global::System.Guid? UserId { get; set; }

        /// <summary>
        /// Date of group creation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public global::System.DateTime? Created { get; set; }

        /// <summary>
        /// Name of the group
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Textual description of the group
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Date of group deletion, or null if the group is still active
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted_at")]
        public global::System.DateTime? DeletedAt { get; set; }

        /// <summary>
        /// Ids of users which belong to this group
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("member_users")]
        public global::System.Collections.Generic.IList<global::System.Guid>? MemberUsers { get; set; }

        /// <summary>
        /// Ids of the groups this group inherits from<br/>
        /// An inheriting group has all the users contained in its member groups, as well as all of their inherited users
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("member_groups")]
        public global::System.Collections.Generic.IList<global::System.Guid>? MemberGroups { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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