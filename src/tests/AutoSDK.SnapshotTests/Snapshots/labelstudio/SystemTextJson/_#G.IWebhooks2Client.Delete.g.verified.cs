//HintName: G.IWebhooks2Client.Delete.g.cs
#nullable enable

namespace G
{
    public partial interface IWebhooks2Client
    {
        /// <summary>
        /// Delete webhook info
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteAsync(
            int id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}