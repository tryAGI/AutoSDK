//HintName: G.IGroupsClient.PatchGroupId.g.cs
#nullable enable

namespace G
{
    public partial interface IGroupsClient
    {
        /// <summary>
        /// Partially update group<br/>
        /// Partially update a group object. Specify the fields to update in the payload. Any object-type fields will be deep-merged with existing content. Currently we do not support removing fields or setting them to null.
        /// </summary>
        /// <param name="groupId">
        /// Group id
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Group> PatchGroupIdAsync(
            global::System.Guid groupId,

            global::G.PatchGroup request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Partially update group<br/>
        /// Partially update a group object. Specify the fields to update in the payload. Any object-type fields will be deep-merged with existing content. Currently we do not support removing fields or setting them to null.
        /// </summary>
        /// <param name="groupId">
        /// Group id
        /// </param>
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Group> PatchGroupIdAsync(
            global::System.Guid groupId,
            string? description = default,
            string? name = default,
            global::System.Collections.Generic.IList<global::System.Guid>? addMemberUsers = default,
            global::System.Collections.Generic.IList<global::System.Guid>? removeMemberUsers = default,
            global::System.Collections.Generic.IList<global::System.Guid>? addMemberGroups = default,
            global::System.Collections.Generic.IList<global::System.Guid>? removeMemberGroups = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}