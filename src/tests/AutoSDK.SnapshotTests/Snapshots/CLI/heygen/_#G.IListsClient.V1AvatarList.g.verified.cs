//HintName: G.IListsClient.V1AvatarList.g.cs
#nullable enable

namespace G
{
    public partial interface IListsClient
    {
        /// <summary>
        /// v1/avatar.list<br/>
        /// v1/avatar.list
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task V1AvatarListAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}