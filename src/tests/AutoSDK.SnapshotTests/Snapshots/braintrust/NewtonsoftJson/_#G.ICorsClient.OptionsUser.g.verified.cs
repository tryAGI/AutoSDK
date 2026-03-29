//HintName: G.ICorsClient.OptionsUser.g.cs
#nullable enable

namespace G
{
    public partial interface ICorsClient
    {
        /// <summary>
        /// Enable CORS (`/v1/user`)<br/>
        /// Enable CORS
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task OptionsUserAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}