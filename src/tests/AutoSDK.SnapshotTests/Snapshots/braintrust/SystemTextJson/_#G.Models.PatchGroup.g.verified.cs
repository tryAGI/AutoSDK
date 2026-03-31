//HintName: G.Models.PatchGroup.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchGroup
    {
        /// <summary>
        /// Textual description of the group
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Name of the group
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// A list of user IDs to add to the group
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("add_member_users")]
        public global::System.Collections.Generic.IList<global::System.Guid>? AddMemberUsers { get; set; }

        /// <summary>
        /// A list of user IDs to remove from the group
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remove_member_users")]
        public global::System.Collections.Generic.IList<global::System.Guid>? RemoveMemberUsers { get; set; }

        /// <summary>
        /// A list of group IDs to add to the group's inheriting-from set
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("add_member_groups")]
        public global::System.Collections.Generic.IList<global::System.Guid>? AddMemberGroups { get; set; }

        /// <summary>
        /// A list of group IDs to remove from the group's inheriting-from set
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remove_member_groups")]
        public global::System.Collections.Generic.IList<global::System.Guid>? RemoveMemberGroups { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchGroup" /> class.
        /// </summary>
        /// <param name="description">
        /// Textual description of the group
        /// </param>
        /// <param name="name">
        /// Name of the group
        /// </param>
        /// <param name="addMemberUsers">
        /// A list of user IDs to add to the group
        /// </param>
        /// <param name="removeMemberUsers">
        /// A list of user IDs to remove from the group
        /// </param>
        /// <param name="addMemberGroups">
        /// A list of group IDs to add to the group's inheriting-from set
        /// </param>
        /// <param name="removeMemberGroups">
        /// A list of group IDs to remove from the group's inheriting-from set
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchGroup(
            string? description,
            string? name,
            global::System.Collections.Generic.IList<global::System.Guid>? addMemberUsers,
            global::System.Collections.Generic.IList<global::System.Guid>? removeMemberUsers,
            global::System.Collections.Generic.IList<global::System.Guid>? addMemberGroups,
            global::System.Collections.Generic.IList<global::System.Guid>? removeMemberGroups)
        {
            this.Description = description;
            this.Name = name;
            this.AddMemberUsers = addMemberUsers;
            this.RemoveMemberUsers = removeMemberUsers;
            this.AddMemberGroups = addMemberGroups;
            this.RemoveMemberGroups = removeMemberGroups;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchGroup" /> class.
        /// </summary>
        public PatchGroup()
        {
        }
    }
}