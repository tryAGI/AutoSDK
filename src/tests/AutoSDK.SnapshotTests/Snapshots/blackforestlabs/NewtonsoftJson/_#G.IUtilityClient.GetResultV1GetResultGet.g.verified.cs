//HintName: G.IUtilityClient.GetResultV1GetResultGet.g.cs
#nullable enable

namespace G
{
    public partial interface IUtilityClient
    {
        /// <summary>
        /// Get Result<br/>
        /// An endpoint for getting generation task result.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultResponse> GetResultV1GetResultGetAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}