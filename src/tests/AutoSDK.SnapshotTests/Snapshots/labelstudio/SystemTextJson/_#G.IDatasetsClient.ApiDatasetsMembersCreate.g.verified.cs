//HintName: G.IDatasetsClient.ApiDatasetsMembersCreate.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Add dataset member<br/>
        /// Add a member to a specific dataset.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DatasetMember> ApiDatasetsMembersCreateAsync(
            int id,

            global::G.DatasetMemberRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add dataset member<br/>
        /// Add a member to a specific dataset.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="user"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DatasetMember> ApiDatasetsMembersCreateAsync(
            int id,
            int user,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}