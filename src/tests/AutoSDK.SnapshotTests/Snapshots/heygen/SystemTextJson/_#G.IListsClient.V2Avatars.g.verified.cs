//HintName: G.IListsClient.V2Avatars.g.cs
#nullable enable

namespace G
{
    public partial interface IListsClient
    {
        /// <summary>
        /// v2/avatars<br/>
        /// v2/avatars
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task V2AvatarsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}