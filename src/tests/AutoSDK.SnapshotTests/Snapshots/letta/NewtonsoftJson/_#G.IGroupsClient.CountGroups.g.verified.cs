//HintName: G.IGroupsClient.CountGroups.g.cs
#nullable enable

namespace G
{
    public partial interface IGroupsClient
    {
        /// <summary>
        /// Count Groups<br/>
        /// Get the count of all groups associated with a given user.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<int> CountGroupsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}