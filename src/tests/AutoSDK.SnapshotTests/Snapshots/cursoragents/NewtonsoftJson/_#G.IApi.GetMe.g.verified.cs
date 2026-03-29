//HintName: G.IApi.GetMe.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// API key info<br/>
        /// Retrieve information about the API key being used for authentication
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetMeResponse> GetMeAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}